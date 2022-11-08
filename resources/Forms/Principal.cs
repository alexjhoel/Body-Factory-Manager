using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Principal : Form
    {
        //Link de archivo (.mdf) de base de datos en la raiz del proyecto
        Transicion menuTransicion = new Transicion(0);
        List<BotonMenu> botonesMenu = new List<BotonMenu>();
        Point offset;
        bool estadoMenu = false;
        bool quieto = true;
        int tiempoQuieto;
        SQL sql = new SQL(Properties.Settings.Default.ConnectionString);
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Principal()
        {
            InitializeComponent();

            menuTransicion.Establecer(185, 50, 0.05f);

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
            
            nombreUsuarioLBL.Text = Properties.Settings.Default.Usuario;
            DataTable data = sql.Obtener("SELECT * FROM Usuarios WHERE id= '" + Properties.Settings.Default.Usuario + "'");
            byte[] imgData = ((byte[])data.Rows[0]["foto"]);

            Image image = null;
            using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
            {
                ms.Write(imgData, 0, imgData.Length);
                image = Image.FromStream(ms, true);
            }

            perfilPBX.Image = image;
            CambiarSección(new Inicio(this.InicioSalida));
        }

        private void CambiarSección(UserControl userControl)
        {
            paginasPNL.Controls.Clear();
            paginasPNL.Controls.Add(userControl);
            userControl.SendToBack();
            userControl.Size = paginasPNL.Size;
            userControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        }

        #region Eventos
        private void timerMenuPNL_Tick(object sender, EventArgs e)
        {
            menuPNL.Width = (int)menuTransicion.Avanzar();
            if (estadoMenu) return;
            if (menuPNL.PointToClient(MousePosition).X < 50  && menuPNL.PointToClient(MousePosition).Y > 0 && quieto)
            {
                tiempoQuieto++;
                
            }
            if(tiempoQuieto == 60)
            {
                tiempoQuieto++;
                menuTransicion.Establecer(50, 185, 0.02f);
                quieto = false;
            }
            if ((menuPNL.PointToClient(MousePosition).X > 185 ||  menuPNL.PointToClient(MousePosition).Y < 0) && !quieto)
            {
                menuTransicion.Establecer(185, 50, 0.02f);
                quieto = true;
                tiempoQuieto = 0;
            }

        }


        private void menuBTN_Click(object sender, EventArgs e)
        {
            if (!quieto) return;
            if (estadoMenu)
            {
                menuTransicion.Establecer(185, 50, 0.02f);

            }
            else
            {
                menuTransicion.Establecer(50, 185, 0.02f);
            }
            estadoMenu = !estadoMenu;
        }

        private void clientesBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new SeccionClientes(PrimeraMensualidad));
        }

        private void PrimeraMensualidad(string cedula)
        {
            CambiarSección(new SeccionMensualidades(cedula));
        }


        private void inicioBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new Inicio(this.InicioSalida));
        }

        private void InicioSalida(TipoInicioSalida tipoSalida, string salida = "")
        {
            FiltroBusqeda filtro = new FiltroBusqeda(TipoFiltro.String, "", "cedula");
            filtro.valor1 = salida;
            switch (tipoSalida)
            {
                case TipoInicioSalida.Clientes:
                    ((Button)menuPNL.Controls[5]).PerformClick();
                    break;
                case TipoInicioSalida.Mensualidades:
                    ((Button)menuPNL.Controls[3]).PerformClick();
                    break;
                case TipoInicioSalida.Graficos:
                    ((Button)menuPNL.Controls[0]).PerformClick();
                    break;
            }
        }

        private void cuotasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new SeccionMensualidades());
        }

        private void asistenciasBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new SeccionAsistencias());
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
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MaximumSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None;
            }

            if (this.WindowState == FormWindowState.Normal) 
            {
                maximizarVentanaBTN.Image = Properties.Resources.maximizar1;
                this.WindowState = FormWindowState.Maximized;
                return;
            }
            maximizarVentanaBTN.Image = Properties.Resources.maximizar2;
            this.WindowState = FormWindowState.Normal;
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

        private void pagosBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new SeccionPagos());
        }

        private void configBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new SeccionConfiguracion());
        }

        private void graficosBTN_Click(object sender, EventArgs e)
        {
            CambiarSección(new SeccionGraficos());
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


