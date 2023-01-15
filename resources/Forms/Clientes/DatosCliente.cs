using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosCliente : Form
    {

        SQL sql;
        public string id = null;
        DataTable data;
        public DatosCliente(string id = null, bool eliminable = true)
        {
            //http://api.textmebot.com/send.php?recipient=+598091056571&apikey=KdsSrQDjhoEN&text=This%20is%20a%20test
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.ConnectionString);

            usuarioLBL.Text = Properties.Settings.Default.Usuario;
            if (id != null)
            {

                this.id = id;
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                data = sql.Obtener("SELECT * FROM Clientes WHERE id=" + id);
                if (data.Rows.Count == 0) return;
                nombreTBX.Text = data.Rows[0]["nombre"].ToString();
                apellidoTBX.Text = data.Rows[0]["apellido"].ToString();
                try
                {
                    nacimientoDTP.Value = (DateTime)data.Rows[0]["fechaNacimiento"];// DateTime.ParseExact(data.Rows[0]["fechaNacimiento"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    ingresoDTP.Value = (DateTime)data.Rows[0]["fechaIngreso"];// DateTime.ParseExact(data.Rows[0]["fechaIngreso"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    nacimientoDTP.Value = DateTime.Now;
                    ingresoDTP.Value = DateTime.Now;
                }

                correoTBX.Text = data.Rows[0]["correo"].ToString();
                telefonoTBX.Text = data.Rows[0]["telefono"].ToString();
                telefono2TBX.Text = data.Rows[0]["telefono2"].ToString();
                cedulaTBX.Text = data.Rows[0]["cedula"].ToString();
                direccionTBX.Text = data.Rows[0]["direccion"].ToString();
                patologiasTbx.Text = data.Rows[0]["patologias"].ToString();
                observacionesTbx.Text = data.Rows[0]["observaciones"].ToString();
                grupoSanguineoCBX.SelectedIndex = 0;
                if (data.Rows[0]["grupoSanguineo"].ToString() != "NA")
                {
                    grupoSanguineoCBX.SelectedIndex = grupoSanguineoCBX.Items.IndexOf(data.Rows[0]["grupoSanguineo"].ToString());
                }

                if (data.Rows[0]["foto"] != DBNull.Value)
                {
                    byte[] imgData = ((byte[])data.Rows[0]["foto"]);

                    Image image = null;
                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {
                        ms.Write(imgData, 0, imgData.Length);
                        image = Image.FromStream(ms, true);


                    }

                    perfilPBX.Image = image;
                }


                estadoPNL.BackColor = !(bool)data.Rows[0]["esActivo"] ? Color.Red : Color.Green;
                darDeBajaBTN.Text = (bool)data.Rows[0]["esActivo"] ? "Dar de baja" : "Dar de alta";
                telefonoSaludTBX.Text = data.Rows[0]["telefonoSalud"].ToString();
                if (data.Rows[0]["idUsuario"] != DBNull.Value) usuarioLBL.Text = data.Rows[0]["idUsuario"].ToString();
                else usuarioLBL.Text = "Desconocido";
                

            }

            if (!eliminable)
            {
                borrarBTN.Visible = false;
                darDeBajaBTN.Visible = false;
                estadoLBL.Visible = false;
                estadoPNL.Visible = false;
            }


        }

        private void DatosCliente_Load(object sender, EventArgs e)
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

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> valores = new Dictionary<string, object>();
            if (cedulaTBX.Text.Trim() == String.Empty)
            {
                valores.Add("cedula", DBNull.Value);
            }
            else
            {
                if (int.TryParse(cedulaTBX.Text, out int c) && ValidarCedulas.ValidarCedula(cedulaTBX.Text))
                {
                    if ((c + "").Length < 8 && (c + "").Length != 0)
                    {
                        MessageBox.Show(this, "Ingrese una cédula válida", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    valores.Add("cedula", cedulaTBX.Text);
                }
                else
                {
                    MessageBox.Show(this, "Ingrese una cédula válida", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            if (String.IsNullOrEmpty(nombreTBX.Text) || String.IsNullOrEmpty(apellidoTBX.Text))
            {
                MessageBox.Show(this, "Ni el nombre ni el apellido pueden ser vacios", "Nombre y apellido vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DateTime hoy = DateTime.Now;
            
            valores.Add("nombre", nombreTBX.Text);
            valores.Add("apellido", apellidoTBX.Text);
            
            valores.Add("nacimiento", nacimientoDTP.Value);
            valores.Add("ingreso", ingresoDTP.Value);
            valores.Add("telefono", telefonoTBX.Text);
            valores.Add("telefono2", telefono2TBX.Text);
            valores.Add("correo", correoTBX.Text);
            valores.Add("direccion", direccionTBX.Text);
            valores.Add("patologias", patologiasTbx.Text);
            valores.Add("observaciones", observacionesTbx.Text);
            valores.Add("usuario", usuarioLBL.Text);
            valores.Add("adjudicado", hoy);
            valores.Add("salud", telefonoSaludTBX.Text);
            valores.Add("esActivo",estadoPNL.BackColor == Color.Green);

            valores.Add("vencimiento", DateTimeUtilities.NextMonth(hoy));
            if (grupoSanguineoCBX.SelectedIndex != 0)
            {
                valores.Add("grupoSanguineo", grupoSanguineoCBX.Text);
            }
            else
            {
                valores.Add("grupoSanguineo", "NA");
            }


            try
            {
                using (var ms = new MemoryStream())
                {

                    Image img = perfilPBX.Image;
                    img.Save(ms, img.RawFormat);

                    byte[] dataImg = ms.ToArray();
                    valores.Add("imagen", dataImg);
                }
            }
            catch
            {
                valores.Add("imagen", data.Rows[0]["foto"]);
            }

            
            if (id != null)
            {
                try
                {
                    if (sql.Obtener("SELECT * FROM Clientes WHERE cedula='" + cedulaTBX.Text + "' AND NOT id =" + id).Rows.Count > 0 && cedulaTBX.Text.Trim() != String.Empty)
                    {
                        MessageBox.Show(this, "Ya existe un cliente con dicha cedula", "Cédula repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    sql.Modificar("UPDATE Clientes SET cedula = @cedula, nombre = @nombre, apellido = @apellido, fechaNacimiento = @nacimiento, " +
                                        "fechaIngreso = @ingreso, telefono = @telefono, telefono2 = @telefono2, correo = @correo, foto = @imagen, patologias = @patologias, " +
                                        "observaciones = @observaciones, grupoSanguineo = @grupoSanguineo, direccion = @direccion, telefonoSalud = @salud, " +
                                        "esActivo=@esActivo, esOculto=0 WHERE id = " + id, valores);
                    this.Close();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error en la base de datos. Razón: \n" + ex.Message, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    sql.CerrarConexion();
                }
                
            }
            
            if (sql.Obtener("SELECT * FROM Clientes WHERE Cedula='" + cedulaTBX.Text+ "'").Rows.Count > 0)
            {
                MessageBox.Show(this, "Ya existe un cliente con dicha cedula", "Cédula repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
;                return;
            }

            

            try
            {
                string consulta = "INSERT INTO Clientes (nombre, apellido, cedula, fechaNacimiento, fechaIngreso," +
                " telefono, telefono2, correo, foto,patologias, observaciones, direccion, idUsuario, telefonoSalud, esActivo) VALUES(@nombre, @apellido," +
                " @cedula, @nacimiento, @ingreso, @telefono, @telefono2, @correo, @imagen, @patologias, @observaciones, @direccion," +
                " @usuario, @salud, 1); SELECT SCOPE_IDENTITY() AS id; INSERT INTO IngresosClientes (idCliente, fecha, comentario) VALUES(SCOPE_IDENTITY(),@ingreso,'Primer ingreso')";
                string id = sql.Obtener(consulta, valores).Rows[0]["id"].ToString();
                if (MessageBox.Show("Cliente agregado con éxito, ¿deseas adjudicarle una cuota?", "Datos guardados", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    this.id = id;
                    DialogResult = DialogResult.Yes;
                    this.Close();
                    return;
                } 

                
                this.Close();
                return;
            }
            catch (Exception res)
            {
                MessageBox.Show(this, "Error en la base de datos. Razón: \n" + res.Message.ToString(), "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }

        }

        private void descartarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviarMensajeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://wa.me/598" + telefonoTBX.Text);
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al abrir el navegador");
            }
            finally
            {
                MessageBox.Show("Ventana abierta|");
            }

        }

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            perfilPBX.Image = Properties.Resources.clientePortrait;
        }

        private void borrarBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que quiere eliminar este cliente?", "CONFIRMAR BORRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    sql.Modificar("DELETE FROM Clientes WHERE id = '" + id + "'");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error en la base de datos. Razón: \n" + ex.Message.ToString(), "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }
            
        }

        private void darDeBajaBTN_Click(object sender, EventArgs e)
        {
            if(darDeBajaBTN.Text == "Dar de alta")
            {
                if(MessageBox.Show("¿Desea dar de alta de servicio al cliente?", "Dar de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    darDeBajaBTN.Text = "Dar de baja";
                    estadoPNL.BackColor = Color.Green;
                }
            }
            else
            {
                if (MessageBox.Show("¿Desea dar baja de servicio al cliente?", "Baja de servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    darDeBajaBTN.Text = "Dar de alta";
                    estadoPNL.BackColor = Color.Red;
                }
            }
        }

        private void nombreTBX_TextChanged(object sender, EventArgs e)
        {
            Capitalizar(sender);
        }

        private void Capitalizar(object objeto)
        {
            Regex regex = new Regex(@"\b\w");

            TextBox textBox = (TextBox)objeto;

            int pos = textBox.SelectionStart;

            textBox.Text = regex.Replace(textBox.Text, (Match match) => match.ToString().ToUpper());

            textBox.SelectionStart = pos; nombreTBX.SelectionLength = 0;
        }

        private void apellidoTBX_TextChanged(object sender, EventArgs e)
        {
            Capitalizar(sender);
        }

        private void direccionTBX_TextChanged(object sender, EventArgs e)
        {
            Capitalizar(sender);
        }
    }
}
