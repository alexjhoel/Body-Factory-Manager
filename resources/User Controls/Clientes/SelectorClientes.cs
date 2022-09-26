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



        public SelectorClientes(Action<string> retorno, string cedulaCliente = null)
        {
            

            InitializeComponent();

            this.retorno = retorno;

            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);

            if (cedulaCliente != null)
            {
                cedulaTBX.Text = cedulaCliente;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SelectorClientes_Load(object sender, EventArgs e)
        {

        }

        public void Habilitar(bool estado)
        {
            if (estado) agregarBTN.Show(); else agregarBTN.Hide();
            cedulaTBX.ReadOnly = !estado;
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

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            using (ListadoClientes listado = new ListadoClientes(true))
            {
                listado.ShowDialog();
                if (listado.DialogResult == DialogResult.OK)
                {
                    cedulaTBX.Text = listado.cedula;
                }
            }
        }

        public void CambiarCliente(string cedula)
        {
            cedulaTBX.Text = cedula;
            DataTable datos = sql.Obtener("SELECT nombre,apellido FROM Clientes WHERE cedula=" + cedula);
            if (datos.Rows.Count != 0)
            {
                nombreTBX.Text = datos.Rows[0]["nombre"].ToString() + " " + datos.Rows[0]["apellido"].ToString();
            }
            return;
            

            nombreTBX.Text = "N/A";
        }
    }
}
