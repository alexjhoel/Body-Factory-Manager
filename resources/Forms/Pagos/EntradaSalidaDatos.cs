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
    public partial class EntradaSalidaDatos : Form
    {
        SQL sql;
        string id;
        public EntradaSalidaDatos(string id = null)
        {
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            InitializeComponent();
            entregaCBX.SelectedIndex = 0;
            this.id = id;
            if (id == null) return;
            DataTable data;
            if (id.StartsWith("A"))
            {
                data = sql.Obtener("SELECT * FROM EntradasSalidas WHERE idReal= '" + id + "'");
                entregaCBX.SelectedIndex = (decimal)data.Rows[0]["monto"] > 0 ? 1 : 0;
                
            }
            else
            {
                motivoTBX.ReadOnly = true;
                entregaCBX.SelectedIndex = 1;
                entregaCBX.Enabled = false;
                data = sql.Obtener("SELECT fecha, monto, CONCAT('Pago de cuota - ', nombre, ' ', apellido,  ' - ', cedula) AS motivo FROM Pagos INNER JOIN Clientes ON Pagos.idCliente = Clientes.id WHERE Pagos.id= " + id);
                entregaCBX.SelectedIndex = 1;
                
            }

            motivoTBX.Text = data.Rows[0]["motivo"].ToString();
            pagoFechaDTP.Value = (DateTime)data.Rows[0]["fecha"];
            entregaNUD.Value = Math.Abs((decimal)data.Rows[0]["monto"]);

        }

        private void EntradaSalidaDatos_Load(object sender, EventArgs e)
        {

        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametos = new Dictionary<string, object>();
            if(motivoTBX.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parametos.Add("motivo", motivoTBX.Text);
            parametos.Add("fecha", pagoFechaDTP.Value);

            if(entregaCBX.SelectedIndex == 0)
            {
                parametos.Add("monto", -entregaNUD.Value);
            }
            else
            {
                parametos.Add("monto", entregaNUD.Value);
            }

            try
            {
                if(id == null)
                {
                    sql.Modificar("INSERT INTO EntradasSalidas (motivo, fecha, monto) VALUES(@motivo, @fecha, @monto)", parametos);

                }
                else if (id.StartsWith("A"))
                {
                    sql.Modificar("UPDATE EntradasSalidas SET motivo = @motivo, fecha = @fecha, monto = @monto WHERE idReal='" + id + "'", parametos);

                }
                else
                {
                    sql.Modificar("UPDATE Pagos SET fecha = @fecha, monto = @monto WHERE id='" + id + "'", parametos);
                }



                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos, razon: " + ex.Message);
            }
            
        }

        private void entregaNUD_ValueChanged(object sender, EventArgs e)
        {
            if (entregaNUD.Value < 0)
            {
                entregaNUD.Value *= -1;
                entregaCBX.SelectedIndex = 0;
            }
        }

        private void descartarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
