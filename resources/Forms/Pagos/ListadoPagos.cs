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
    public partial class ListadoPagos : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        public ListadoPagos(DataTable tabla = null)
        {
            InitializeComponent();

            tablaDGV.RowTemplate.MinimumHeight = 30;

        }

        private void ListadoPagos_Load(object sender, EventArgs e)
        {
            CargarListaPagos();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tablaDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell bc = tablaDGV[0, e.RowIndex] as DataGridViewButtonCell;
                Bitmap ico = new Bitmap(Properties.Resources.editar);
                e.Graphics.DrawImage(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3, 20, 20);

                e.Handled = true;
                return;
            }

            if (e.ColumnIndex == 4)
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
            string id = ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["id"].ToString();
            //string nombre = ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Nombre"].ToString();
            if (e.ColumnIndex == 4)
            {
                //DatosCliente nuevaVentana = new DatosCliente(((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString());
                //nuevaVentana.ShowDialog();
            }
            else if (e.ColumnIndex == 5 /*&& ((DialogResult)MessageBox.Show(this, "¿Desea el eliminar el cliente " + nombre + " de cédula " + cedula + "? (Los datos no se recuperaran)", "BORRAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes*/)
            {

                sql.Modificar("DELETE FROM Pagos WHERE id= " + id);

            }
            CargarListaPagos();

        }

        private void CargarListaPagos()
        {
            tablaDGV.Columns.Clear();
            //DataTable datos = sql.Obtener("SELECT id, monto as 'Monto', descuento as 'Descuento', cedula as 'Cédula', fechaVigencia as 'Fecha de Vigencia', CONCAT( nombre, ' ' apellido, ' - ', cedula) as 'Cliente' FROM Clientes INNER JOIN Pagos ON Pagos.idCliente = Clientes.cedula");
            DataTable datos = sql.Obtener("SELECT id, monto as 'Monto', descuento as 'Descuento' FROM Pagos", true);
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
            tablaDGV.Columns[0].Visible = false;
        }

        private void tablaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
