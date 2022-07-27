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
        public Principal(DataTable datosUsuario)
        {
            InitializeComponent();
            menuTransicion.Establecer(40, 185, 0.05f);
            timerMenuPNL.Start();
            if (datosUsuario == null)
            {
                this.Close();
                return;
            }
            if (datosUsuario.Rows.Count == 0)
            {
                this.Close();
                return;
            }
            DataTable datosDeUsuario = datosUsuario;
            nombreUsuarioLBL.Text = datosDeUsuario.Rows[0]["usuario"].ToString();

            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);

            CambiarSección(new MenuClientes());
        }

        private void CambiarSección(UserControl userControl)
        {
            paginasPNL.Controls.Clear();
            paginasPNL.Controls.Add(userControl);
            userControl.Size = paginasPNL.Size;
            userControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        }

        #region Eventos
        private void timerMenuPNL_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("a");
            menuPNL.Width = (int)menuTransicion.Avanzar();
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
            CambiarSección(new MenuClientes());
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
            CambiarSección(new MenuPagos());
        }

        private void asistenciasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Asistencias());
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
            this.Close();
        }

        private void minimizarVentanaBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizarVentanaBTN_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        #endregion
    }
}
