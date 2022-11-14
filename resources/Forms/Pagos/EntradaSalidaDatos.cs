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
        public EntradaSalidaDatos()
        {
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            InitializeComponent();
            entregaCBX.SelectedIndex = 0;
        }

        private void EntradaSalidaDatos_Load(object sender, EventArgs e)
        {

        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametos = new Dictionary<string, object>();
            if(motivoTBX.Text.Trim() == String.Empty || responsableTBX.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parametos.Add("motivo", motivoTBX.Text);
            parametos.Add("fecha", pagoFechaDTP.Value);
            parametos.Add("responsable", responsableTBX.Text);

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
                sql.Modificar("INSERT INTO EntradasSalidas (motivo, fecha, responsable, monto) VALUES(@motivo, @fecha, @responsable, @monto)", parametos);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos, razon: " + ex.Message);
            }
            
        }

        private void entregaNUD_ValueChanged(object sender, EventArgs e)
        {
            if (entregaNUD.Value < 0) entregaNUD.Value *= -1;
            entregaCBX.SelectedIndex = 0;
        }

        private void descartarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
