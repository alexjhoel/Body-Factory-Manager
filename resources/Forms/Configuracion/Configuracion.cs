using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = Properties.Settings.Default.ConnectionString;
            ipTbx.Text = builder.DataSource;
            usuarioTbx.Text = builder.UserID;
            claveTbx.Text = builder.Password;
        }

        public SqlConnectionStringBuilder SqlConnectionStringBuilder { get; }

        private void guardarTbx_Click(object sender, EventArgs e)
        {

        }
    }
}
