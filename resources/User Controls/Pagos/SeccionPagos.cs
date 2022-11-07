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


        public SeccionPagos(bool selector = false, Action<string> seleccionar = null)
        {
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();

            //DialogResult = DialogResult.Cancel;





            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos("Listo", Body_Factory_Manager.Properties.Resources.check, seleccionar));
                buttonDatos.Add(new ListadoButtonDatos("Ver", Body_Factory_Manager.Properties.Resources.ver, this.EntradaSalida));

            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos("Nuevo pago", Body_Factory_Manager.Properties.Resources.signo_de_dolar, this.Agregar, 9f));

                buttonDatos.Add(new ListadoButtonDatos("E/S", Body_Factory_Manager.Properties.Resources.RightLeft, this.EntradaSalida));
                buttonDatos.Add(new ListadoButtonDatos("Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.EliminarPago));
            }

            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre del cliente", "CONCAT(nombre, ' ', apellido)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cédula del cliente", "cedula"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de montos($)", "monto"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha realizado", "fecha"));
            listado = new Listado("id", buttonDatos, Ordenar, filtros, Filtrar);
            this.Controls.Add(listado);
            listado.Size = new Size(this.Size.Width, 420);
            listado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActualizarConsulta();



        }


        private void EliminarPago(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Esta acción requiere seleccionar un pago", "Ningún pago seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el movimiento?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            if (id.StartsWith("A"))
            {
                sql.Modificar("DELETE FROM EntradasSalidas WHERE idReal= '" + id + "'");

            }
            else sql.Modificar("DELETE FROM Pagos WHERE id= " + id);
            CargarListaPagos();
        }

        private void CargarListaPagos()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar("id");
            totalLBL.Text = "$" + sql.Obtener("SELECT SUM(Todo.monto) as Total FROM " +
                "(SELECT monto FROM Pagos INNER JOIN Clientes ON Pagos.cedulaCliente = Clientes.cedula WHERE Clientes.esOculto = 0 AND " + 
                filtro.ObtenerWhereConsulta() + " UNION ALL SELECT monto FROM EntradasSalidas) as Todo").Rows[0]["Total"];
        }

        private void EntradaSalida(string id)
        {
            using (EntradaSalidaDatos nuevaVentana = new EntradaSalidaDatos())
            {
                nuevaVentana.ShowDialog();

                ActualizarConsulta();
            }

        }

        private void Ordenar(string propiedadOrden, SortOrder orden)
        {
            this.propiedadOrden = propiedadOrden;
            this.orden = orden;
            CargarListaPagos();
        }

        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }
        private void ActualizarConsulta()
        {
            consulta = "SELECT CONVERT(VARCHAR(17), id) as id, 'Pago de cuota' as 'Motivo', CONCAT(nombre, ' ', apellido,  ' - ', cedula) as 'Persona', monto as 'Importe($)', fecha as Fecha" +
                " FROM Pagos INNER JOIN Clientes ON Pagos.cedulaCliente = Clientes.cedula";
            consulta += " WHERE " + filtro.ObtenerWhereConsulta() + "AND Clientes.esOculto = 0 UNION ALL " +
                "SELECT idReal as id, motivo as 'Motivo', responsable as 'Persona', monto as 'Importe($)', fecha as 'Fecha' FROM EntradasSalidas";
            if (orden != SortOrder.None) consulta += " ORDER BY " + propiedadOrden + (orden == SortOrder.Ascending ? " asc" : " desc");

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

