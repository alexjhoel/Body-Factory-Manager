using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SelectorClientes : UserControl
    {
        SQL sql; 
        Action<string> retorno;



        public SelectorClientes(Action<string> retorno)
        {
            InitializeComponent();
            
            this.retorno = retorno;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SelectorClientes_Load(object sender, EventArgs e)
        {
            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        }



        private void cedulaTBX_TextChanged(object sender, EventArgs e)
        {
            if (cedulaTBX.Text.Length == 8)
            {
                DataTable datos = sql.Obtener("SELECT nombre,apellido FROM Clientes WHERE cedula=" + cedulaTBX.Text);
                if (datos.Rows.Count != 0)
                {
                    nombreTBX.Text = datos.Rows[0]["nombre"].ToString() + " " + datos.Rows[0]["apellido"].ToString();
                    retorno(cedulaTBX.Text);
                }
                return;
            }

            nombreTBX.Text = "N/A";
        }
    }
}
