using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Login : Form
    {

        public DataTable datosUsuario;
        private SQL sql;
        public Login()
        {

            string connectionString;
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            InitializeComponent();
            using (Principal principal = new Principal())
            {
                this.Hide();
                principal.ShowDialog();
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
                Properties.Settings.Default.Usuario = datosUsuario.Rows[0]["id"].ToString();
                Properties.Settings.Default.Save();

                using (Principal principal = new Principal())
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
            connectionString = Properties.Settings.Default.ConnectionString;
            sql = new SQL(connectionString);
        }

        private void Login_Load(object sender, System.EventArgs e)
        {

        }
    }
}
