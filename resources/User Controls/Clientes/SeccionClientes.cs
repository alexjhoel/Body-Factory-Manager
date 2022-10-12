using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionClientes : UserControl
    {
        SQL sql = new SQL(Properties.Settings.Default.ConnectionString);
        string consulta;
        FiltroBusqeda filtro;
        Comunicacion comunicacion = new Comunicacion();
        public string cedula;
        public string propiedadOrden;
        public SortOrder orden;

        public SeccionClientes(bool selector = false, FiltroBusqeda filtro = null, Action<string> seleccionar = null)
        {

            this.filtro = filtro;
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();


            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos("Listo", Body_Factory_Manager.Properties.Resources.check, seleccionar));
                buttonDatos.Add(new ListadoButtonDatos("Ver", Body_Factory_Manager.Properties.Resources.ver, this.Editar));
            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos("Nuevo", Body_Factory_Manager.Properties.Resources.person_add_FILL0_wght400_GRAD0_opsz48, this.Agregar));
                buttonDatos.Add(new ListadoButtonDatos("Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
                buttonDatos.Add(new ListadoButtonDatos("Pagar", Body_Factory_Manager.Properties.Resources.signo_de_dolar, this.PagarCuota));
                buttonDatos.Add(new ListadoButtonDatos("Chatear", Body_Factory_Manager.Properties.Resources.chat, this.Chatear));
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
            sql.Modificar("UPDATE Clientes SET esOculto = 1, esActivo = 0 WHERE cedula= " + cedula);
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar();
        }

        private void Editar(string cedula)
        {
            using (DatosCliente nuevaVentana = new DatosCliente(cedula))
            {
                nuevaVentana.ShowDialog();
            }
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
            consulta = "SELECT nombre as Nombre, apellido as Apellido, cedula as 'Cédula', telefono as 'Teléfono', fechaIngreso as 'Fecha de ingreso'  FROM Clientes ";
            if (orden != SortOrder.None) consulta += " ORDER BY " + propiedadOrden + (orden == SortOrder.Ascending ? " asc" : " desc");
            consulta += " WHERE esOculto = 0 AND " + filtro.ObtenerWhereConsulta();
            CargarListaClientes();
        }


        private void PagarCuota(string cedula)
        {


            using (DatosMensualidad nuevaVentana = new DatosMensualidad(cedula, TipoPagoMensualidad.PagarCuotaDesdeClientes))
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void Agregar(string cedula)
        {
            using (DatosCliente nuevaVentana = new DatosCliente())
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void Chatear(string cedula)
        {
            if (String.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("El cliente no tiene un número registrado", "No se pudo iniciar el chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                comunicacion.Chatear(sql.Obtener("SELECT * FROM Clientes WHERE cedula='" + cedula + "'").Rows[0]["telefono"].ToString());
                MessageBox.Show("Ventana abierta");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al abrir el navegador");
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        private void ListadoClientes_Load(object sender, System.EventArgs e)
        {

        }
    }
}
