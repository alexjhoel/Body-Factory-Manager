using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class LoginPrincipal : UserControl
    {
        private SQL sql;
        private Email email = new Email(Properties.Settings.Default.CorreoRecover, Properties.Settings.Default.PasswordRecover);

        public DataTable datosUsuario;

        public string usuario = "";
        public LoginPrincipal()
        {
            InitializeComponent();

        }

        private void loginBTN_Click(object sender, EventArgs e) => Loguear();

        private void CrearUsuario()
        {
            sql.Modificar("INSERT INTO Usuarios (usuario, clave, correoElectronico, nombre, apellido) VALUES('admin', ENCRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "', 'admin'),'alexanderalmeida20@gmail.com', 'admin', 'admin')");
        }

        private void Loguear()
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"D:\Downloads\hihiha.wav");
            //simpleSound.Play();
            datosUsuario = ObtenerUsuario();
            if (datosUsuario.Rows.Count == 0) MessageBox.Show(this, "No existe el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!claveTBX.Text.Equals(datosUsuario.Rows[0]["clave"].ToString())) MessageBox.Show(this, "Clave incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ((Login)ParentForm).ConfirmarLogin(datosUsuario);
            }
        }

        private DataTable ObtenerUsuario()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@usuario", usuarioTBX.Text);
            datosUsuario = sql.Obtener("SELECT usuario, CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "', clave)) AS clave, correoElectronico FROM Usuarios WHERE usuario=@usuario", parametros);

            return datosUsuario;
        }

        private string EsconderCorreo(string input)
        {
            //Esconder correo electrónico con expresiones regulares
            string patron = @"(?<=[\w]{1})[\w-\._\+%]*(?=[\w]{1}@)";
            string resultado = Regex.Replace(input, patron, m => new string('*', m.Length));
            return resultado;
        }

        private void SetearInterfaz(bool estado)
        {
            claveTBX.Enabled = estado;
            usuarioTBX.Enabled = estado;
            loginBTN.Enabled = estado;
            recuperarContraseñaBTN.Enabled = estado;
            //this.ControlBox = estado;
        }

        private void LoginPrincipal_Enter(object sender, EventArgs e)
        {
            sql = ((Login)ParentForm).ObtenerSQL();
        }

        private void recuperarContraseñaBTN_Click(object sender, EventArgs e)
        {
            datosUsuario = ObtenerUsuario();
            if (datosUsuario.Rows.Count == 0)
            {
                MessageBox.Show(this, "No existe el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            email.Mensaje(Properties.Settings.Default.CorreoRecover, datosUsuario.Rows[0]["correoElectronico"].ToString(), "Recupera tu contraseña", "-Recuperación de contraseña-\n Usuario: " + datosUsuario.Rows[0]["Usuario"] +
                "\nContraeña:" + datosUsuario.Rows[0]["clave"] + "\n\nAtentamente,\n el equipo de Stardust Essentials");
            SetearInterfaz(false);
            if (email.Enviar())
            {
                MessageBox.Show(this, "Se ha enviado un correo a " + EsconderCorreo(datosUsuario.Rows[0]["correoElectronico"].ToString()) + " con su contraseña. Verifica la carpeta spam.", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Se produjo un error al enviar el correo, inténtelo más tarde", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetearInterfaz(true);
        }

        private void configuracionBTN_Click(object sender, EventArgs e)
        {
            ((Login)ParentForm).MostrarAjustes();
        }

        private void claveTBX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Loguear();
        }
    }
}
