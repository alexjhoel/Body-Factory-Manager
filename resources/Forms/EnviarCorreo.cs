using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class EnviarCorreo : Form
    {
        Comunicacion email;
        public EnviarCorreo(string correo = "")
        {
            InitializeComponent();
            email = new Comunicacion(Properties.Settings.Default.CorreoRecover, Properties.Settings.Default.PasswordRecover);
            destinatario.Text = correo;
        }

        private void enviarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                email.Mensaje(Properties.Settings.Default.CorreoRecover, destinatario.Text, asuntoTBX.Text, mensajeTBX.Text);
                email.Enviar();
                MessageBox.Show("Email enviado con éxito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Ocurrió un error al enviar el correo, verifique los datos e intente nuevamente","Error al enviar email", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            
            
        }
    }
}
