using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class ListadoClientes : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        public ListadoClientes(DataTable tabla = null)
        {
            InitializeComponent();

            tablaDGV.RowTemplate.MinimumHeight = 30;

        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tablaDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell bc = tablaDGV[0, e.RowIndex] as DataGridViewButtonCell;
                Bitmap ico = new Bitmap(Properties.Resources.editar);
                e.Graphics.DrawImage(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3, 20, 20);

                e.Handled = true;
                return;
            }

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell bc = tablaDGV[0, e.RowIndex] as DataGridViewButtonCell;
                Bitmap ico = new Bitmap(Properties.Resources.eliminar);
                e.Graphics.DrawImage(ico, e.CellBounds.Left + 5, e.CellBounds.Top + 5, 20, 20);

                e.Handled = true;
                return;
            }
        }

        private void tablaDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 4) return;
            string cedula = ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString();
            string nombre = ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Nombre"].ToString();
            if (e.ColumnIndex == 4)
            {
                DatosCliente nuevaVentana = new DatosCliente(((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString());
                nuevaVentana.ShowDialog();
            }
            else if (e.ColumnIndex == 5 && ((DialogResult)MessageBox.Show(this, "¿Desea el eliminar el cliente " + nombre + " de cédula " + cedula + "? (Los datos no se recuperaran)", "BORRAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {

                sql.Modificar("DELETE FROM Clientes WHERE cedula= " + cedula);

            }
            CargarListaClientes();


        }

        private void CargarListaClientes()
        {
            tablaDGV.Columns.Clear();
            DataTable datos = sql.Obtener("SELECT nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cédula', fechaIngreso as 'Fecha de Ingreso' FROM Clientes");
            tablaDGV.DataSource = datos;
            using (DataGridViewButtonColumn editar = new DataGridViewButtonColumn())
            {
                editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                editar.Width = 30;
                editar.MinimumWidth = 30;
                tablaDGV.Columns.Add(editar);
            }

            using (DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn())
            {
                eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                eliminar.Width = 30;
                eliminar.MinimumWidth = 30;
                tablaDGV.Columns.Add(eliminar);
            }
        }
    }
}
