using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosPago : Form
    {
        private DataTable descuentos;
        private DataTable datosCuota;
        private SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        public DatosPago(string cedulaCliente, string idPago = null)
        {

            InitializeComponent();

            SelectorClientes selectorClientes;
            selectorClientes = new SelectorClientes(ObtenerDatosCliente, cedulaCliente);
            selectorClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            selectorClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            selectorClientes.Location = new System.Drawing.Point(-2, -2);
            selectorClientes.Margin = new System.Windows.Forms.Padding(0);
            selectorClientes.Size = new System.Drawing.Size(this.Width, 122);
            selectorClientes.TabIndex = 30;
            this.Controls.Add(selectorClientes);
            /*
            string consulta = "SELECT nombre, porcentaje, CONCAT(nombre,' -', porcentaje, '%') AS 'todo' FROM Descuentos WHERE esPersonalizado=0";
            descuentos = sql.Obtener(consulta);
            foreach (DataRow row in descuentos.Rows)
            {
                descuentosCBX.Items.Add(row["todo"]);
            }
            descuentosCBX.SelectedIndex = 0;
            Console.WriteLine(cedulaCliente);



            consulta = "SELECT fechaVigencia FROM Pagos WHERE fechaVigencia = (SELECT MAX(fechaVigencia) FROM Pagos)";
            DataTable fechaReciente = sql.Obtener(consulta);
            if (fechaReciente.Rows.Count > 0)
            {

            }
            */
        }



        private void ObtenerDatosCliente(string cedula)
        {
            string consulta = "SELECT Mensualidades.valor, Mensualidades.nombre, Clientes.cedula FROM Mensualidades INNER JOIN Clientes ON Clientes.idMensualidad = Mensualidades.id " +
                "WHERE Clientes.cedula='" + cedula + "'";
            datosCuota = sql.Obtener(consulta);
            /*
            if (datosCuota.Rows.Count > 0)
            {
                montoTBX.Text = datosCuota.Rows[0]["valor"].ToString();

                montosCBX.SelectedIndex = 0;
                return;
            }
            MessageBox.Show("Cliente sin cuota");
            */
        }

        private void DatosPago_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void entregaNUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void entregaCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void deudaLBL_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pagoFechaDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buscarBTN_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void totalTbx_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adjudDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vencimientoDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        /*
        private void DatosPago_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void selectorClientes1_Load(object sender, EventArgs e)
        {

        }

        private void descuentosCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void descuentoTBX_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                descuentosCBX.SelectedIndex = 1;
            }

            ActualizarTotal();


        }

        private void descuentosCBX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (descuentosCBX.SelectedIndex == 1) return;
            if (descuentosCBX.SelectedIndex == 0)
            {
                descuentoTBX.Text = "0";
                return;
            }
            descuentoTBX.Text = descuentos.Rows[descuentosCBX.SelectedIndex - 2]["porcentaje"].ToString();
        }

        private void montoTBX_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                montosCBX.SelectedIndex = 1;
            }
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            if (float.TryParse(montoTBX.Text, out float m) &&
                float.TryParse(descuentoTBX.Text, out float d))
            {
                Console.WriteLine(d + "");
                totalTbx.Text = (m - (m * (d / 100))) + "";
            }
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            if (datosCuota.Rows.Count > 0)
            {
                string cedulaCliente = datosCuota.Rows[0]["cedula"].ToString();
                string consulta = "INSERT INTO Pagos (monto, descuento, fechaVigencia, cedulaCliente) " +
                    "VALUES (" + montoTBX.Text + "," + descuentoTBX.Text + "," + validezDTP.Value.ToString("dd/mm/yyyy") + "," + cedulaCliente;
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }


        }

        private void montosCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (montosCBX.SelectedIndex == 0) montoTBX.Text = datosCuota.Rows[0]["Valor"].ToString();
        }
            */
    }
}
