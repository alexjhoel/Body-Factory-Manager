using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class LoginConfiguracion : UserControl
    {
        public LoginConfiguracion()
        {

            InitializeComponent();
        }

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        
        public SqlConnectionStringBuilder SqlConnectionStringBuilder { get; }

        private void guardarTbx_Click(object sender, EventArgs e)
        {

        }

        private void LoginConfiguracion_Enter(object sender, EventArgs e)
        {
            builder.ConnectionString = Properties.Settings.Default.ConnectionString;
            ipTbx.Text = builder.DataSource;
            usuarioTbx.Text = builder.UserID;
            claveTbx.Text = builder.Password;
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            builder.DataSource = ipTbx.Text;
            builder.UserID = usuarioTbx.Text;
            builder.Password = claveTbx.Text;

            Properties.Settings.Default.ConnectionString = builder.ConnectionString;
            Properties.Settings.Default.Save();
            
            ((Login)ParentForm).OcultarAjustes();
        }
    }
}
