using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class ListadoClientes : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        string consulta;
        FiltroBusqeda filtro;

        public string cedula;
        public string propiedadOrden;
        public SortOrder orden;

        public ListadoClientes(bool selector = false, FiltroBusqeda filtro = null)
        {

            this.filtro = filtro;
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
                buttonDatos.Add(new ListadoButtonDatos("Pagar", Body_Factory_Manager.Properties.Resources.signo_de_dolar, this.PagarCuota));
                buttonDatos.Add(new ListadoButtonDatos("Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.Eliminar));
            }
            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();

            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre", "nombre"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Apellido", "apellido"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cédula", "cedula"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha de Ingreso", "fechaIngreso"));

            listado = new Listado("Cédula", buttonDatos, Ordenar, filtros, Filtrar);

            listado.Dock = DockStyle.Fill;

            this.Controls.Add(listado);
            ActualizarConsulta();
        }


        private void Eliminar(string cedula)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Clientes WHERE cedula= " + cedula);
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar();
        }

        private void Editar(string cedula)
        {
            using (DatosCliente nuevaVentana = new DatosCliente("", cedula))
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void Seleccionar(string cedula)
        {
            DialogResult = DialogResult.OK;
            this.cedula = cedula;
            this.Close();
        }

        private void Ordenar(string propiedadOrden, SortOrder orden)
        {
            this.propiedadOrden = propiedadOrden;
            this.orden = orden;
            ActualizarConsulta();
        }

        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }
        private void ActualizarConsulta()
        {
            consulta = "SELECT nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fechaIngreso as 'Fecha de ingreso'  FROM Clientes ";
            if (orden != SortOrder.None) consulta += " ORDER BY " + propiedadOrden + (orden == SortOrder.Ascending ? " asc" : " desc");
            consulta += " WHERE " + filtro.ObtenerWhereConsulta();
            CargarListaClientes();
        }


        private void PagarCuota(string cedula)
        {


            using (DatosMensualidad nuevaVentana = new DatosMensualidad(cedula, TipoPagoMensualidad.PagarCuotaDesdeClientes))
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void ListadoClientes_Load(object sender, System.EventArgs e)
        {

        }
    }
}
