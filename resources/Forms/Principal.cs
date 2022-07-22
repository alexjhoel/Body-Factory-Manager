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
    public partial class Principal : Form
    {
        //Link de archivo (.mdf) de base de datos en la raiz del proyecto
        Transicion menuTransicion = new Transicion();
        SQL sql;
        Point offset;
        public Principal()
        {
            InitializeComponent();
            timedLogin.Start();
            menuTransicion.Establecer(40, 185, 0.05f);
            timerMenuPNL.Start();
        }

        private void CambiarSección(UserControl userControl)
        {
            paginasPNL.Controls.Clear();
            paginasPNL.Controls.Add(userControl);
            userControl.Size = paginasPNL.Size;
            userControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        }
        private void Login()
        {
            Login loginForm;
            loginForm = new Login();
            loginForm.ShowDialog();
            if (loginForm.datosUsuario == null)
            {
                this.Close();
                return;
            }
            if (loginForm.datosUsuario.Rows.Count == 0)
            {
                this.Close();
                return;
            }
            DataTable datosDeUsuario = loginForm.datosUsuario;
            nombreUsuarioLBL.Text = datosDeUsuario.Rows[0]["usuario"].ToString();

            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);

            CambiarSección(new Clientes());
        }

        private void timerMenuPNL_Tick(object sender, EventArgs e)
        {
            menuPNL.Width = (int)menuTransicion.Avanzar();
        }

        private void timedLogin_Tick(object sender, EventArgs e)
        {
            timedLogin.Stop();
            Login();

        }


        private void menuBTN_Click(object sender, EventArgs e)
        {
            if (menuPNL.Width == 185)
            {
                menuTransicion.Establecer(185, 40, 0.02f);
            }
            else if (menuPNL.Width == 40)
            {
                menuTransicion.Establecer(40, 185, 0.02f);
            }
        }

        private void clientesBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Clientes());
        }

        private void inicioBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Incio());
        }

        private void rutinasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Rutinas());
        }

        private void pagosBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Pagos());
        }

        private void asistenciasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Asistencias());
        }

        private void Principal_Enter(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void controlTBLPNL_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void controlTBLPNL_MouseDown(object sender, MouseEventArgs e)
        {
            offset = new Point(e.X, e.Y);
        }

        private void cerrarVentanaBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
