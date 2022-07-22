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
    public partial class Clientes : UserControl
    {
        #region Objetos
        SQL sql;
        #endregion

        #region Valores
        #endregion

        public Clientes()
        {
            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);

            InitializeComponent();
        }

        #region Eventos
        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }



        private void buscarBTN_Click(object sender, EventArgs e) => BuscarClientes();

        private void buscarTBX_KeyPress(object sender, KeyPressEventArgs e) => BuscarClientes();


        private void buscarTBX_TextChange(object sender, EventArgs e)
        {
            if (buscarTBX.Text == "")
            {
                foreach (DataGridViewRow row in tablaDGV.Rows)
                {
                    row.SetVisible(true);


                }
            }
        }

        private void buscarTBX_Enter(object sender, EventArgs e)
        {

        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            DatosCliente nuevaVentana = new DatosCliente();
            nuevaVentana.ShowDialog();
            CargarListaClientes();
        }




        private void editarClienteBTN_Click(object sender, EventArgs e)
        {
            DatosCliente nuevaVentana = new DatosCliente(((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString());
            nuevaVentana.ShowDialog();
            CargarListaClientes();
        }

        private void tablaDGV_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void borrarClienteBTN_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index];
            DialogResult dialog = MessageBox.Show(this, "¿Desea elimnar el cliente " + fila["nombre"] + " de cédula " + fila["cédula"] + "?", "Borrar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@cedula", ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString());
                sql.Modificar("DELETE FROM Clientes WHERE cedula=@cedula", parametros);
            }

            CargarListaClientes();
        }
        #endregion

        #region Métodos y Funciones
        private void CargarListaClientes()
        {
            tablaDGV.Columns.Clear();
            DataTable data = sql.Obtener("SELECT cedula as Cédula, nombre as Nombre FROM Clientes", true);
            tablaDGV.DataSource = data;
        }

        private void BuscarClientes()
        {
            tablaDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in tablaDGV.Rows)
            {
                row.SetVisible(false);
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    //Comparación de texto no sensible a mayúsculas y minúsculas
                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().IndexOf(buscarTBX.Text, StringComparison.InvariantCultureIgnoreCase) >= 0) { row.SetVisible(true); }
                }

            }
        }
        #endregion




        
    }
}
