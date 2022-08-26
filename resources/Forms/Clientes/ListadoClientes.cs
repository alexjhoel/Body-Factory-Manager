using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class ListadoClientes : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        string consulta;

        public string cedula;
        public ListadoClientes(string consulta = null, bool selector = false)
        {
            this.consulta = consulta;

            InitializeComponent();

            DialogResult = DialogResult.Cancel;
            if (this.consulta == null)
            {
                this.consulta = "SELECT nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cédula', fechaIngreso as 'Fecha de Ingreso' FROM Clientes";
            }




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
            

            listado = new Listado("Cédula", buttonDatos);
            this.Controls.Add(listado);
            listado.Dock = DockStyle.Fill;
            CargarListaClientes();



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

        private void PagarCuota(string cedula)
        {
            

            using (DatosMensualidad nuevaVentana = new DatosMensualidad(cedula, TipoPagoMensualidad.PagarCuotaDesdeClientes))
            {
                nuevaVentana.ShowDialog();
            }
        }

        
    }
}
