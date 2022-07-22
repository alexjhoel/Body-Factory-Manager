using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            connectionString = ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString;
            sql = new SQL(connectionString);
            InitializeComponent();

        }

        public SQL ObtenerSQL()
        {
            return sql;
        }

        public void ConfirmarLogin(DataTable datosUsuario = null)
        {
            this.datosUsuario = datosUsuario;
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
