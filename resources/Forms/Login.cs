using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Security.Principal;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Login : Form
    {
        //Link de archivo (.mdf) de base de datos en la raiz del proyecto
        public DataTable datosUsuario;
        private SQL sql;
        public Login()
        {
            
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString;
            sql = new SQL(connectionString);
            InitializeComponent();
            /*Process proc = new Process();
            proc.StartInfo.FileName = @"d:\Downloads\SQL Stop.bat.lnk";
            proc.Start();*/
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                if (principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    
                }
            }
        }

        public SQL ObtenerSQL()
        {
            return sql;
        }

        public void ConfirmarLogin(DataTable datosUsuario = null)
        {
            this.datosUsuario = datosUsuario;
            if (datosUsuario != null)
            {
                using (Principal principal = new Principal(datosUsuario))
                {
                    this.Hide();
                    principal.ShowDialog();
                }
            }
            this.Close();


        }

        public void MostrarAjustes()
        {
            loginConfiguracion1.Show();
            loginPrincipal1.Hide();
        }

        public void OcultarAjustes()
        {
            loginConfiguracion1.Hide();
            loginPrincipal1.Show();
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString;
            sql = new SQL(connectionString);
        }
    }
}
