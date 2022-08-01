using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Pagos : UserControl
    {





        #region Objetos
        SQL sql;
        #endregion
        public Pagos()
        {
            sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
            InitializeComponent();
        }
        #region Valores
        #endregion



        #region Eventos
        private void Pagos_Load(object sender, EventArgs e)
        {
            CargarListaClientes();

        }


        /*
        private void buscarBTN_Click(object sender, EventArgs e) => BuscarClientes();

        private void buscarTBX_KeyPress(object sender, KeyPressEventArgs e) => BuscarClientes();
        */

        /*private void buscarTBX_TextChange(object sender, EventArgs e)
        {
            if (buscarTBX.Text == "")
            {
                foreach (DataGridViewRow row in tablaDGV.Rows)
                {
                    row.SetVisible(true);


                }
            }
        }
        */

        private void buscarTBX_Enter(object sender, EventArgs e)
        {

        }
        /*
        private void agregarBTN_Click(object sender, EventArgs e)
        {
            DatosCliente nuevaVentana = new DatosCliente();
            nuevaVentana.ShowDialog();
            CargarListaClientes();
        }
        */




        /*private void editarClienteBTN_Click(object sender, EventArgs e)
        {
            DatosCliente nuevaVentana = new DatosCliente(((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString());
            nuevaVentana.ShowDialog();
            CargarListaClientes();
        }
        */

        private void tablaDGV_SelectionChanged(object sender, EventArgs e)
        {

        }

        /*
        private void borrarClienteBTN_Click(object sender, EventArgs e)
        {
            DataRow fila = ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index];
            DialogResult dialog = MessageBox.Show(this, "¿Desea elimnar el cliente " + fila["nombre"] + " de cédula " + fila["cédula"] + "?", "Borrar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@cedula", ((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index]["Cédula"].ToString());
                sql.Modificar("DELETE FROM Cliente WHERE cedula=@cedula", parametros);
            }

            CargarListaClientes();
        }
        */

        #endregion

        #region Métodos y Funciones

        private void CargarListaClientes()
        {
            listaClientesDGV.Columns.Clear();
            string consulta = "SELECT nombre AS Nombre, apellido AS Apellido, cedula as Cédula FROM Clientes";
            using (DataTable data = sql.Obtener(consulta, true))
            {
                listaClientesDGV.DataSource = data;
            }
        }

        private void CargarListaPagos()
        {
            listaPagosDGV.Columns.Clear();
            string consulta = "SELECT Pagos.id, CONCAT(monto, 'U$') as 'Monto', fechaRealizado AS 'Fecha', valor AS 'Valor de la cuota' " +
                "FROM Pagos INNER JOIN Mensualidades ON Pagos.idMensualidad=Mensualidades.id " +
                "WHERE Pagos.idCliente=" + ((DataTable)listaClientesDGV.DataSource).Rows[listaClientesDGV.SelectedRows[0].Index]["Cédula"].ToString();
            Console.WriteLine(consulta);
            using (DataTable data = sql.Obtener(consulta, false))
            {
                listaPagosDGV.DataSource = data;

                listaPagosDGV.Columns["id"].Visible = false;
            }


        }

        /*private void BuscarClientes()
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
        */
        #endregion

        private void listaClientesDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (listaClientesDGV.Rows.Count > 0)
            {

            }
        }

        private void listaClientesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarListaPagos();
        }

        private void nuevoBTN_Click(object sender, EventArgs e)
        {
            string idCliente = ((DataTable)listaClientesDGV.DataSource).Rows[listaClientesDGV.SelectedRows[0].Index]["Cédula"].ToString();
            DatosPago nuevaVentana = new DatosPago(idCliente);
            nuevaVentana.ShowDialog();
        }
    }
}
