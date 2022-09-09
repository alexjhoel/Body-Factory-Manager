using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Principal : Form
    {
        //Link de archivo (.mdf) de base de datos en la raiz del proyecto
        Transicion menuTransicion = new Transicion(0);
        List<BotonMenu> botonesMenu = new List<BotonMenu>();
        SQL sql;
        Point offset;
        string usuario;
        public Principal(DataTable datosUsuario)
        {
            InitializeComponent();
            menuTransicion.Establecer(40, 185, 0.05f);

            foreach (Control btn in menuPNL.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    botonesMenu.Add(new BotonMenu((Button)btn, false, ((Button)btn).Image));
                    btn.Click += BotonMenu_Click;
                    btn.MouseHover += BotonMenu_Hover;
                    btn.MouseLeave += BotonMenu_MouseLeave;
                    btn.Tag = botonesMenu.Count - 1;
                }

            }
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
            string usuario = datosDeUsuario.Rows[0]["id"].ToString();
            nombreUsuarioLBL.Text = usuario;
            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);

            CambiarSección(new MenuClientes(usuario));
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
            menuPNL.Width = (int)menuTransicion.Avanzar();
        }


        private void menuBTN_Click(object sender, EventArgs e)
        {
            if (menuPNL.Width == 185)
            {
                menuTransicion.Establecer(185, 50, 0.02f);
            }
            else if (menuPNL.Width == 50)
            {
                menuTransicion.Establecer(50, 185, 0.02f);
            }
        }

        private void clientesBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new MenuClientes(usuario));
        }

        private void inicioBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Incio());
        }

        private void rutinasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new MenuRutinas());
        }

        private void cuotasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new MenuPagos());
        }

        private void asistenciasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new MenuAsistencias());
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

        private void BotonMenu_Hover(object sender, EventArgs e)
        {
            BotonMenu botonMenu = botonesMenu[(int)((Button)sender).Tag];
            if (!botonMenu.clickeado)
            {
                botonMenu.transicion.Establecer(50, 25, 0.02f);
            }

        }

        private void BotonMenu_MouseLeave(object sender, EventArgs e)
        {
            BotonMenu botonMenu = botonesMenu[(int)((Button)sender).Tag];
            if (!botonMenu.clickeado)
            {
                botonMenu.transicion.Establecer(25, 50, 0.02f);
            }

        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            BotonMenu botonMenu = botonesMenu[(int)((Button)sender).Tag];

            foreach (BotonMenu btn in botonesMenu)
            {

                btn.Idle();
            }


            botonMenu.Clickeado();
        }


        #endregion

        private void inicioBTN_MouseLeave(object sender, EventArgs e)
        {

        }

        private void principalHover(object sender, EventArgs e)
        {

        }

        private void adminBTN_Click(object sender, EventArgs e)
        {
            AdminTools nueva = new AdminTools();
            nueva.ShowDialog();
        }


    }

    public class BotonMenu
    {
        public Image img;
        public Button button { private set; get; }
        public Transicion transicion { private set; get; }
        public bool clickeado { private set; get; }
        private Timer timer;

        public BotonMenu(Button button, bool clickeado, Image img)
        {
            this.clickeado = clickeado;
            transicion = new Transicion(1);
            transicion.Establecer(50, 50, 0.02f);
            this.button = button;
            timer = new Timer() { Interval = 1 };
            timer.Tick += Timer_Tick;
            timer.Start();
            this.img = img;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            button.Image = (Image)(new Bitmap(img, (int)transicion.Avanzar(), (int)transicion.Obtener()));
            button.BackColor = ColorUtilities.ColorFromHSV(0, (transicion.Obtener() - 25) / 25, 1);
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
        }

        public void Clickeado()
        {
            clickeado = true;
            transicion.Establecer(50, 25, 0.02f);
        }

        public void Idle()
        {
            if (clickeado)
            {
                transicion.Establecer(25, 50, 0.02f);
            }
            else
            {
                transicion.Establecer(50, 50, 0.00f);
            }

            clickeado = false;

        }



    }
}


