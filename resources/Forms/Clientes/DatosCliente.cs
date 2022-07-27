using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Body_Factory_Manager
{
    public partial class DatosCliente : Form
    {
        
        SQL sql;
        System.Net.WebClient client = new System.Net.WebClient();
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
                nacimientoDP.Value = DateTime.ParseExact(data.Rows[0]["fechaNacimiento"].ToString(), "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                correoTBX.Text = data.Rows[0]["correo"].ToString();
                telefonoTBX.Text = data.Rows[0]["telefono"].ToString();
                cedulaTBX.Text = data.Rows[0]["cedula"].ToString();
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
            Dictionary<string, object> valores = new Dictionary<string, object>();
            valores.Add("@nombre", nombreTBX.Text);
            valores.Add("@apellido", apellidoTBX.Text);
            valores.Add("@cedula", cedulaTBX.Text);
            valores.Add("@nacimiento", nacimientoDP.Value.ToString("dd/mm/yyyy"));
            valores.Add("@telefono", telefonoTBX.Text);
            valores.Add("@correo", correoTBX.Text);
            using (var ms = new MemoryStream())
            {
                perfilPBX.Image.Save(ms, perfilPBX.Image.RawFormat);

                byte[] data = ms.ToArray();
                valores.Add("@imagen", data);
            }

            if (idCliente == null)
            {

                sql.Modificar("INSERT INTO Clientes (nombre, apellido, cedula, fechaNacimiento, telefono, correo, foto) VALUES(@nombre, @apellido, @cedula, @nacimiento, @telefono, @correo, @imagen)", valores);
            }
            else
            {
                sql.Modificar("UPDATE Clientes SET nombre = @nombre, apellido = @apellido, fechaNacimiento = @nacimiento, telefono = @telefono, correo = @correo, foto = @imagen WHERE cedula = @cedula", valores);
            }

            this.Close();
        }

        private void descartarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviarMensajeBTN_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://api.textmebot.com/send.php?recipient=+598091056571&apikey=KdsSrQDjhoEN&text=This%20is%20a%20test");
            try{
                client.UploadData("http://api.textmebot.com/send.php?recipient=+598" + telefonoTBX.Text + "&apikey=KdsSrQDjhoEN&text=HITLERNOHIZONADAMALO", "POST", Encoding.Default.GetBytes("{}"));
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al enviar el mensaje vía Whatsapp");
            }
            finally
            {
                MessageBox.Show("Mensaje enviado correctamente vía Whatsapp");
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
    }
}
