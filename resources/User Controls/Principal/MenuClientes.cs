using System;
using System.Configuration;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class MenuClientes : UserControl
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        string usuario;
        public string valor1;
        public string valor2;
        public MenuClientes(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            using (DatosCliente nuevaVentana = new DatosCliente(usuario))
            {
                nuevaVentana.ShowDialog();
            }

        }

        private void listarBtn_Click(object sender, EventArgs e)
        {
            using (ListadoClientes nuevaVentana = new ListadoClientes())
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {

        }

    }
}
