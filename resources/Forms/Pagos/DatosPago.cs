using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosPago : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        public DatosPago(string idCliente, string idPago = null)
        {
            
            InitializeComponent();
            string consulta = "SELECT fechaVigencia FROM Pagos WHERE fechaVigencia = (SELECT MAX(fechaVigencia) FROM Pagos)";
            DataTable fechaReciente = sql.Obtener(consulta);
            if(fechaReciente.Rows.Count > 0)
            {

            }
        }

        private void DatosPago_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void selectorClientes1_Load(object sender, EventArgs e)
        {

        }
    }
}
