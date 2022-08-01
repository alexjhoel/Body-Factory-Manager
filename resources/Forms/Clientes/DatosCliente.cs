﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosCliente : Form
    {

        SQL sql;
        string idCliente = null;
        public DatosCliente(string id = null)
        {
            //http://api.textmebot.com/send.php?recipient=+598091056571&apikey=KdsSrQDjhoEN&text=This%20is%20a%20test
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString;
            sql = new SQL(connectionString);
            if (id != null)
            {
                idCliente = id;
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("Id", id);
                DataTable data = sql.Obtener("SELECT * FROM Clientes WHERE cedula=@Id", parametros);
                if (data.Rows.Count == 0) return;
                nombreTBX.Text = data.Rows[0]["nombre"].ToString();
                apellidoTBX.Text = data.Rows[0]["apellido"].ToString();
                nacimientoDTP.Value = DateTime.ParseExact(data.Rows[0]["fechaNacimiento"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                correoTBX.Text = data.Rows[0]["correo"].ToString();
                telefonoTBX.Text = data.Rows[0]["telefono"].ToString();
                cedulaTBX.Text = data.Rows[0]["cedula"].ToString();
                direccionTBX.Text = data.Rows[0]["direccion"].ToString();
                patologiasTbx.Text = data.Rows[0]["patologias"].ToString();
                observacionesTbx.Text = data.Rows[0]["observaciones"].ToString();
                grupoSanguineoCBX.SelectedIndex = 0;
                if (data.Rows[0]["grupoSanguineo"].ToString() != String.Empty)
                {

                    grupoSanguineoCBX.SelectedIndex = grupoSanguineoCBX.Items.IndexOf(data.Rows[0]["grupoSanguineo"].ToString());
                }
                    
                byte[] imgData = ((byte[])data.Rows[0]["foto"]);

                Image image = null;
                using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                {
                    ms.Write(imgData, 0, imgData.Length);
                    image = Image.FromStream(ms, true);
                }
                perfilPBX.Image = image;
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
            if (int.TryParse(cedulaTBX.Text, out int c)) {
                if ((c + "").Length < 8)
                {
                    MessageBox.Show(this, "Ingrese una cédula válida", "Cédula inválida", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else { return; }
            Dictionary<string, object> valores = new Dictionary<string, object>();
            valores.Add("@nombre", nombreTBX.Text);
            valores.Add("@apellido", apellidoTBX.Text);
            valores.Add("@cedula", cedulaTBX.Text);
            valores.Add("@nacimiento", nacimientoDTP.Value.ToString("dd/MM/yyyy"));
            valores.Add("@telefono", telefonoTBX.Text);
            valores.Add("@correo", correoTBX.Text);
            valores.Add("@direccion", direccionTBX.Text);
            valores.Add("@patologias", patologiasTbx.Text);
            valores.Add("@observaciones", observacionesTbx.Text);
            if (grupoSanguineoCBX.SelectedIndex != 0)
            {
                valores.Add("@grupoSanguineo", grupoSanguineoCBX.Text);
            }
            else
            {
                valores.Add("@grupoSanguineo", String.Empty);
            }

            using (var ms = new MemoryStream())
            {
                perfilPBX.Image.Save(ms, perfilPBX.Image.RawFormat);

                byte[] data = ms.ToArray();
                valores.Add("@imagen", data);
            }

            if (idCliente == null)
            {

                sql.Modificar("INSERT INTO Clientes (nombre, apellido, cedula, fechaNacimiento, telefono, correo, foto,patologias, observaciones) VALUES(@nombre, @apellido, @cedula, @nacimiento, @telefono, @correo, @imagen, @patologias, @observaciones)", valores);
            }
            else
            {
                sql.Modificar("UPDATE Clientes SET nombre = @nombre, apellido = @apellido, fechaNacimiento = @nacimiento, telefono = @telefono, correo = @correo, foto = @imagen, patologias = @patologias, observaciones = @observaciones, grupoSanguineo = @grupoSanguineo WHERE cedula = @cedula", valores);
            }

            this.Close();
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

        private void cedulaTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void direccionTBX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}