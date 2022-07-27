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
    public partial class MenuClientes : UserControl
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            using (DatosCliente nuevaVentana = new DatosCliente())
            {
                nuevaVentana.ShowDialog();
            }

        }

        private void listarBtn_Click(object sender, EventArgs e)
        {
            DataTable datos = sql.Obtener("SELECT nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cédula', fechaIngreso as 'Fecha de Ingreso' FROM Clientes"); 
            using (ListadoClientes nuevaVentana = new ListadoClientes(datos))
            {
                nuevaVentana.ShowDialog();
            }
        }
    }
}
