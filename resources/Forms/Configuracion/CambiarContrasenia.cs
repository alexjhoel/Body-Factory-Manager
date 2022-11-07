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
    public partial class CambiarContrasenia : Form
    {
        SQL sql;
        public CambiarContrasenia()
        {
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            actualTBX.UseSystemPasswordChar = false;
            nuevaTBX.UseSystemPasswordChar = false;
            configrmarTBX.UseSystemPasswordChar = false;
            
        }


        private void cambiarContraseniaBTN_Click(object sender, EventArgs e)
        {
            DataTable datosUsuario = sql.Obtener("SELECT id, CONVERT(VARCHAR(MAX),DECRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "', contrasena)) AS contrasena FROM Usuarios WHERE id='" + Properties.Settings.Default.Usuario + "'");
            
                if (actualTBX.Text.Equals(datosUsuario.Rows[0]["contrasena"].ToString()) && nuevaTBX.Text == configrmarTBX.Text)
                {
                    try
                    {

                        sql.Modificar("UPDATE Usuarios SET contrasena= ENCRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "', '" + nuevaTBX.Text + "') WHERE id='" + Properties.Settings.Default.Usuario + "'");
                        MessageBox.Show("Contraseña cambiada correctamente");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        sql.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            

            
        }

        private void cancelarTBX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
