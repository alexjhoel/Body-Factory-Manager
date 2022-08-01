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

        public SqlConnectionStringBuilder SqlConnectionStringBuilder { get; }

        private void guardarTbx_Click(object sender, EventArgs e)
        {

        }

        private void LoginConfiguracion_Enter(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString;
            ipTbx.Text = builder.DataSource;
            usuarioTbx.Text = builder.UserID;
            claveTbx.Text = builder.Password;
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ipTbx.Text;
            builder.UserID = usuarioTbx.Text;
            builder.Password = claveTbx.Text;
            builder.InitialCatalog = "StardustEssentials";
            builder.PersistSecurityInfo = true;
            builder.Pooling = false;
            //ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"]. = builder.ConnectionString;
            ((Login)ParentForm).OcultarAjustes();
        }
    }
}
