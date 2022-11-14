using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionPagos : UserControl
    {
        SQL sql;
        string consulta;
        FiltroBusqeda filtro;
        SortOrder orden = SortOrder.None;
        string propiedadOrden;
        public string id;
        bool incluirES = false;


        public SeccionPagos( FiltroBusqeda filtro = null, bool incluirES = true)
        {

            sql = new SQL(Properties.Settings.Default.ConnectionString);
            this.filtro = filtro;

            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();

            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            
                buttonDatos.Add(new ListadoButtonDatos(false, "E/S", Body_Factory_Manager.Properties.Resources.RightLeft, this.EntradaSalida));
                buttonDatos.Add(new ListadoButtonDatos(true, "Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.EliminarPago));
            

            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Responsable", "CONCAT(nombre, ' ', apellido)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de montos($)", "monto"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha realizado", "fecha"));
            listado = new Listado(new List<string>() { "id" }, buttonDatos, 1, filtros, Filtrar, 1);
            this.Controls.Add(listado);
            listado.Size = new Size(this.Size.Width, 420);
            listado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.incluirES = incluirES;
            ActualizarConsulta();
            


        }

        

        private void EliminarPago(Dictionary<string,object> datos)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el movimiento?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            if (datos["id"].ToString().StartsWith("A"))
            {
                sql.Modificar("DELETE FROM EntradasSalidas WHERE idReal= '" + datos["id"] + "'");

            }
            else sql.Modificar("DELETE FROM Pagos WHERE id= " + datos["id"]);
            CargarListaPagos();
        }

        private void CargarListaPagos()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar("id");
            string consultaParaTotal = "SELECT SUM(Todo.monto) as Total FROM " +
                "(SELECT monto FROM Pagos INNER JOIN Clientes ON Pagos.cedulaCliente = Clientes.cedula WHERE Clientes.esOculto = 0 AND " +
                filtro.ObtenerWhereConsulta();
            if (incluirES)
            {
                consultaParaTotal+= " UNION ALL SELECT monto FROM EntradasSalidas WHERE ";
                if (filtro.propiedad == "CONCAT(nombre, ' ', apellido)") consultaParaTotal += " responsable LIKE '%" + filtro.valor1 + "%'";
                else consultaParaTotal += filtro.ObtenerWhereConsulta();
            }
            consultaParaTotal+=") as Todo";
            totalLBL.Text = "$" + sql.Obtener(consultaParaTotal).Rows[0]["Total"];
        }

        private void EntradaSalida(Dictionary<string, object> datos)
        {
            using (EntradaSalidaDatos nuevaVentana = new EntradaSalidaDatos())
            {
                nuevaVentana.ShowDialog();

                ActualizarConsulta();
            }

        }


        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }
        private void ActualizarConsulta()
        {
            consulta = "SELECT CONVERT(VARCHAR(17), id) as id, 'Pago de cuota' as 'Motivo', CONCAT(nombre, ' ', apellido,  ' - ', cedula) as 'Responsable', monto as 'Importe($)', fecha as Fecha" +
                " FROM Pagos INNER JOIN Clientes ON Pagos.cedulaCliente = Clientes.cedula";
            consulta += " WHERE " + filtro.ObtenerWhereConsulta() + " AND Clientes.esOculto = 0 ";
            string esWhere = "1=1";
            if (filtro.propiedad == "CONCAT(nombre, ' ', apellido)") esWhere = " responsable LIKE '%" + filtro.valor1 + "%'";
            else esWhere = filtro.ObtenerWhereConsulta(); 
            if (incluirES) consulta += "UNION ALL " +
                "SELECT idReal as id, motivo as 'Motivo', responsable as 'Responsable', monto as 'Importe($)', fecha as 'Fecha' FROM EntradasSalidas WHERE " + esWhere;

            CargarListaPagos();
        }

        private void Agregar(string id)
        {
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(TipoPagoMensualidad.NuevoPago, null, null, null))
            {
                nuevaVentana.ShowDialog();

                ActualizarConsulta();
            }
        }

        private void ListadoPagos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeccionPagos_Load(object sender, EventArgs e)
        {

        }
    }
}

