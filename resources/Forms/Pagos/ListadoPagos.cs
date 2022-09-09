using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class ListadoPagos : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        string consulta;
        FiltroBusqeda filtro;
        SortOrder orden = SortOrder.None;
        string propiedadOrden;

        public string id;


        public ListadoPagos(bool selector = false)
        {
            this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();

            DialogResult = DialogResult.Cancel;





            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos("Listo", Body_Factory_Manager.Properties.Resources.check, this.Seleccionar));
                buttonDatos.Add(new ListadoButtonDatos("Ver", Body_Factory_Manager.Properties.Resources.ver, this.Editar));

            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos("Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
                buttonDatos.Add(new ListadoButtonDatos("Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.EliminarPago));
            }

            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre del cliente", "CONCAT(nombre, ' ', apellido)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cédula del cliente", "cedula"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de montos($)", "monto"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha realizado", "fecha"));
            listado = new Listado("id", buttonDatos, Ordenar, filtros, Filtrar);
            this.Controls.Add(listado);
            listado.Dock = DockStyle.Fill;
            ActualizarConsulta();



        }


        private void EliminarPago(string id)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Pagos WHERE id= " + id);
            CargarListaPagos();
        }

        private void CargarListaPagos()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar("id");
        }

        private void Editar(string id)
        {
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(id, TipoPagoMensualidad.EditarMensualidad))
            {
                nuevaVentana.ShowDialog();

                ActualizarConsulta();
            }

        }

        private void Seleccionar(string id)
        {
            DialogResult = DialogResult.OK;
            this.id = id;
            this.Close();
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
            consulta = "SELECT id, CONCAT(nombre, ' ', apellido) as 'Nombre del cliente', cedula as 'Cédula del cliente', monto as 'Monto($)', fecha as Fecha" +
                " FROM Pagos INNER JOIN Clientes ON Pagos.cedulaCliente = Clientes.cedula";
            consulta += " WHERE " + filtro.ObtenerWhereConsulta();
            if (orden != SortOrder.None) consulta += " ORDER BY " + propiedadOrden + (orden == SortOrder.Ascending ? " asc" : " desc");

            CargarListaPagos();
        }

        private void ListadoPagos_Load(object sender, EventArgs e)
        {

        }
    }
}
