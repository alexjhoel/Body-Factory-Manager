using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionConfiguracion : UserControl
    {
        SQL sql;
        /*Rango de edades Asistencias por meses Generos Ingresos por días*/
        Comunicacion comunicacion;
        public SeccionConfiguracion()
        {
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            comunicacion = new Comunicacion();
            CargarTodo();
        }

        private void CargarTodo()
        {
            
            try
            {
                
                CargarCuotas();
                CargarUsuarios();
                CargarDatosUsuario();
                CargarDescuentos();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Oucrrió un error, razón: " + e.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        private void GuardarTodo()
        {
            
            try
            {
                GuardarCuotas();
                GuardarDatosUsuario();
                GuardarUsuarios();
                GuardarDescuentos();

                MessageBox.Show("Todas las configuraciones se guardaron", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Oucrrió un error, razón: " + e.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }
            CargarTodo();
        }

        private void CargarDescuentos()
        {
            DataTable descuentos = sql.Obtener("SELECT * FROM Descuentos");

            descuentosDGV.Rows.Clear();
            for (int i = 0; i < descuentos.Rows.Count; i++)
            {
                descuentosDGV.Rows.Add();
                descuentosDGV.Rows[i].Tag = descuentos.Rows[i]["id"].ToString();
                descuentosDGV.Rows[i].Cells[0].Value = descuentos.Rows[i]["nombre"].ToString();
                descuentosDGV.Rows[i].Cells[1].Value = descuentos.Rows[i]["porcentaje"].ToString();
            }
        }

        private void GuardarDescuentos()
        {
            string consulta = "";

            for (int i = 0; i < descuentosDGV.Rows.Count; i++)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                foreach (DataGridViewCell cell in descuentosDGV.Rows[i].Cells)
                {
                    if (cell.Value == null) cell.Value = String.Empty;
                }
                parametros.Add("nombre", descuentosDGV.Rows[i].Cells[0].Value);
                parametros.Add("valor", descuentosDGV.Rows[i].Cells[1].Value.ToString());
                if (descuentosDGV.Rows[i].Tag != null)
                {
                    parametros.Add("id", descuentosDGV.Rows[i].Tag);

                    consulta = "UPDATE Descuentos SET nombre = @nombre, porcentaje = @valor WHERE id = @id;";
                    if (!descuentosDGV.Rows[i].Visible)
                    {
                        consulta = "DELETE FROM Descuentos WHERE id = @id;";

                    }


                }
                else
                {

                    consulta = "INSERT INTO Descuentos (nombre, porcentaje) VALUES (@nombre,@valor);";

                }


                sql.Modificar(consulta, parametros);
            }

        }
        private void CargarCuotas()
        {
            DataTable cuotas = sql.Obtener("SELECT * FROM Prefijadas");

            cuotasDGV.Rows.Clear();
            for (int i = 0; i < cuotas.Rows.Count; i++)
            {
                cuotasDGV.Rows.Add();
                cuotasDGV.Rows[i].Tag = cuotas.Rows[i]["id"].ToString();
                cuotasDGV.Rows[i].Cells[0].Value = cuotas.Rows[i]["nombre"].ToString();
                cuotasDGV.Rows[i].Cells[1].Value = cuotas.Rows[i]["valor"].ToString();
            }
        }

        private void GuardarCuotas()
        {
            string consulta = "";
            
            for (int i = 0; i < cuotasDGV.Rows.Count; i++)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                foreach (DataGridViewCell cell in cuotasDGV.Rows[i].Cells)
                {
                    if (cell.Value == null) cell.Value = String.Empty;
                }
                parametros.Add("nombre", cuotasDGV.Rows[i].Cells[0].Value);
                parametros.Add("valor", cuotasDGV.Rows[i].Cells[1].Value.ToString());
                if (cuotasDGV.Rows[i].Tag != null)
                {
                    parametros.Add("id", cuotasDGV.Rows[i].Tag);
                    
                    consulta = "UPDATE Prefijadas SET nombre = @nombre, valor = @valor WHERE id = @id;";
                    if (!cuotasDGV.Rows[i].Visible)
                    {
                        consulta = "DELETE FROM Prefijadas WHERE id = @id;";

                    }


                }
                else
                {
                    
                    consulta = "INSERT INTO Prefijadas (nombre, valor) VALUES (@nombre,@valor);";

                }


                sql.Modificar(consulta, parametros);
            }
            
        }

        private void CargarUsuarios()
        {
            DataTable datosUsuario = sql.Obtener("SELECT id, nombre, apellido, CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "', contrasena)) as contrasena, correoElectronico, privilegio FROM Usuarios WHERE NOT id = 'admin' AND NOT id = '" + Properties.Settings.Default.Usuario + "'");
            
            usuariosDGV.Rows.Clear();
            for (int i = 0; i < datosUsuario.Rows.Count; i++)
            {
                usuariosDGV.Rows.Add();
                
                usuariosDGV.Rows[i].Tag = usuariosDGV.Rows[i].Cells[0].Value = datosUsuario.Rows[i]["id"].ToString();
                usuariosDGV.Rows[i].Cells[0].Value = datosUsuario.Rows[i]["id"].ToString();
                usuariosDGV.Rows[i].Cells[1].Value = datosUsuario.Rows[i]["nombre"].ToString();
                usuariosDGV.Rows[i].Cells[2].Value = datosUsuario.Rows[i]["apellido"].ToString();
                usuariosDGV.Rows[i].Cells[3].Value = datosUsuario.Rows[i]["contrasena"].ToString();
                usuariosDGV.Rows[i].Cells[4].Value = datosUsuario.Rows[i]["correoElectronico"].ToString();
                ((DataGridViewComboBoxCell)usuariosDGV.Rows[i].Cells[5]).Value = datosUsuario.Rows[i]["privilegio"].ToString();
            }
        }

        private void GuardarUsuarios()
        {
            string consulta = "";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            for (int i = 0; i < usuariosDGV.Rows.Count; i++)
            {

                if (usuariosDGV.Rows[i].Cells[0].Value.ToString() == String.Empty)
                {
                    continue;
                }
                
                foreach(DataGridViewCell cell in usuariosDGV.Rows[i].Cells)
                {
                    if (cell == null) cell.Value = String.Empty;
                }

                if (usuariosDGV.Rows[i].Tag.ToString() != String.Empty)
                {
                    consulta += "UPDATE Usuarios SET id='" + usuariosDGV.Rows[i].Cells[0].Value.ToString() + "', ";
                    consulta += "nombre='" + usuariosDGV.Rows[i].Cells[1].Value.ToString() + "', ";
                    consulta += "apellido = '" + usuariosDGV.Rows[i].Cells[2].Value.ToString() + "', ";
                    consulta += "contrasena = ENCRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "','" + usuariosDGV.Rows[i].Cells[3].Value.ToString() + "'), ";
                    consulta += "correoElectronico='" + usuariosDGV.Rows[i].Cells[4].Value.ToString() + "', ";
                    consulta += "privilegio='" + usuariosDGV.Rows[i].Cells[5].Value.ToString() + "' ";
                    consulta += "WHERE id ='" + usuariosDGV.Rows[i].Tag + "';";
                    if (!usuariosDGV.Rows[i].Visible)
                    {
                        consulta += "DELETE FROM Usuarios WHERE id = '" + usuariosDGV.Rows[i].Tag.ToString() + "';";

                    }


                }
                else
                {
                    using (var ms = new MemoryStream())
                    {
                        perfilPBX.Image.Save(ms, Properties.Resources.clientePortrait.RawFormat);

                        byte[] data = ms.ToArray();
                        parametros.Add("@foto", data);
                    }

                    consulta += "INSERT INTO Usuarios (id,nombre, apellido, contrasena, correoElectronico, privilegio, foto) " +
                        "VALUES ('" + usuariosDGV.Rows[i].Cells[0].Value.ToString() + "', '" + usuariosDGV.Rows[i].Cells[1].Value.ToString() +
                        "', '" + usuariosDGV.Rows[i].Cells[2].Value.ToString() + "', " + "ENCRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "','" + usuariosDGV.Rows[i].Cells[3].Value.ToString() + "'), '" + usuariosDGV.Rows[i].Cells[4].Value.ToString() + "' , " +
                        "'" + usuariosDGV.Rows[i].Cells[5].Value.ToString() + "', @foto);";
                    if (!usuariosDGV.Rows[i].Visible)
                    {
                        consulta += "DELETE FROM Usuarios WHERE id = '" + usuariosDGV.Rows[i].Cells[0].Value.ToString() + "';";

                    }

                }
                


            }
            sql.Modificar(consulta,parametros);
        }

        private void CargarDatosUsuario()
        {
            DataTable datosUsuario = sql.Obtener("SELECT id, CONVERT(VARCHAR(MAX),DECRYPTBYPASSPHRASE('" + Properties.Settings.Default.Key + "', contrasena)) as contrasena, correoElectronico, nombre, apellido, foto, privilegio FROM Usuarios where id = '" + Properties.Settings.Default.Usuario + "'");
            usuarioTBX.Text = datosUsuario.Rows[0]["id"].ToString();
            nombreTBX.Text = datosUsuario.Rows[0]["nombre"].ToString();
            apellidoTBX.Text = datosUsuario.Rows[0]["apellido"].ToString();
            correoTBX.Text = datosUsuario.Rows[0]["correoElectronico"].ToString();
            adminPanel.Visible = datosUsuario.Rows[0]["privilegio"].ToString() == "Propietario" || datosUsuario.Rows[0]["privilegio"].ToString() == "SuperAdmin";
            cuotasPNL.Visible = datosUsuario.Rows[0]["privilegio"].ToString() == "Propietario" || datosUsuario.Rows[0]["privilegio"].ToString() == "SuperAdmin";
            descuentosPNL.Visible = datosUsuario.Rows[0]["privilegio"].ToString() == "Propietario" || datosUsuario.Rows[0]["privilegio"].ToString() == "SuperAdmin";
            superAdminPanel.Visible = datosUsuario.Rows[0]["privilegio"].ToString() == "SuperAdmin";
            tuPerfilLBL.Text = "Rango " + datosUsuario.Rows[0]["privilegio"].ToString();

            byte[] imgData = ((byte[])datosUsuario.Rows[0]["foto"]);

            Image image = null;
            using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
            {
                ms.Write(imgData, 0, imgData.Length);
                image = Image.FromStream(ms, true);
            }
            perfilPBX.Image = image;

        }

        private void GuardarDatosUsuario()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreTBX.Text);
            parametros.Add("apellido", apellidoTBX.Text);
            parametros.Add("correoElctronico", correoTBX.Text);
            using (var ms = new MemoryStream())
            {
                perfilPBX.Image.Save(ms, perfilPBX.Image.RawFormat);

                byte[] data = ms.ToArray();
                parametros.Add("@foto", data);
            }

            sql.Modificar("UPDATE Usuarios SET nombre = @nombre, apellido = @apellido, correoElectronico = @correoElctronico, foto = @foto WHERE id='" + Properties.Settings.Default.Usuario + "'", parametros);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void subirFotoBTN_Click(object sender, EventArgs e)
        {
            abrirFotoFD.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (abrirFotoFD.ShowDialog() == DialogResult.OK)
            {
                perfilPBX.Image = new Bitmap(abrirFotoFD.FileName);
            }
        }

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            perfilPBX.Image = Properties.Resources.clientePortrait;
        }

        private void cambiarContraseniaBTN_Click(object sender, EventArgs e)
        {
            using (CambiarContrasenia nuevaVentana = new CambiarContrasenia())
            {
                
                nuevaVentana.ShowDialog();
            }

                
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            GuardarTodo();
        }

        private void enviarConsultaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Modificar(consultaTbx.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }
            
        }

        private void recibirConsultaBTN_Click(object sender, EventArgs e)
        {
            try
            {
               resultadosConsultaDGV.DataSource = sql.Obtener(consultaTbx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        private void nombreTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void apellidoTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuariosDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void usuariosDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < usuariosDGV.Rows.Count; i++)
            {
                if(usuariosDGV.Rows[e.RowIndex].Cells[0].Value.ToString() == usuariosDGV.Rows[i].Cells[0].Value.ToString() && i != e.RowIndex)
                {
                    MessageBox.Show("Ya existe un usuario de nombre " + usuariosDGV.Rows[e.RowIndex].Cells[0].Value.ToString()+ "intente usar otro", "Usuario repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuariosDGV.Rows[e.RowIndex].Cells[0].Value = "";
                    break;
                }
            }
        }

        private void agregarUsuarioBTN_Click(object sender, EventArgs e)
        {
            usuariosDGV.Rows.Add();
            usuariosDGV.Rows[usuariosDGV.Rows.Count - 1].Tag = string.Empty;
            foreach (DataGridViewCell cell in usuariosDGV.Rows[usuariosDGV.Rows.Count - 1].Cells)
            {
                cell.Value = "";
                cell.ReadOnly = false;
            }
        }

        private void borrarUsuarioBTN_Click(object sender, EventArgs e)
        {
            usuariosDGV.Rows[usuariosDGV.SelectedRows[0].Index].Visible = false;
        }

        private void agregarCuotasBTN_Click(object sender, EventArgs e)
        {
            cuotasDGV.Rows.Add();
            cuotasDGV.Rows[cuotasDGV.Rows.Count - 1].Tag = null;
            foreach (DataGridViewCell cell in cuotasDGV.Rows[cuotasDGV.Rows.Count - 1].Cells)
            {
                cell.Value = 0;
                cell.ReadOnly = false;
            }
        }

        private void borrarCuotaBTN_Click(object sender, EventArgs e)
        {
            cuotasDGV.Rows[cuotasDGV.SelectedRows[0].Index].Visible = false;
        }

        private void cuotasDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (cuotasDGV.Rows[e.RowIndex].Cells[1].Value == null || !int.TryParse(cuotasDGV.Rows[e.RowIndex].Cells[1].Value.ToString(),out int n))
                {
                    cuotasDGV.Rows[e.RowIndex].Cells[1].Value = 0;
                }
            }
        }

        private void agregarDescuentoBTN_Click(object sender, EventArgs e)
        {
            descuentosDGV.Rows.Add();
            descuentosDGV.Rows[descuentosDGV.Rows.Count - 1].Tag = null;
            foreach (DataGridViewCell cell in descuentosDGV.Rows[descuentosDGV.Rows.Count - 1].Cells)
            {
                cell.Value = 0;
                cell.ReadOnly = false;
            }
        }

        private void descuentosDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (descuentosDGV.Rows[e.RowIndex].Cells[1].Value == null || !int.TryParse(descuentosDGV.Rows[e.RowIndex].Cells[1].Value.ToString(), out int n))
                {
                    descuentosDGV.Rows[e.RowIndex].Cells[1].Value = 0;
                }
            }
        }

        private void comprobarDisponibilidadBTN_Click(object sender, EventArgs e)
        {
            try
            {
                comunicacion.Chatear(numeroTBX.Text);
                MessageBox.Show("Ventana abierta"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo abrir el mensaje");
            }
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
