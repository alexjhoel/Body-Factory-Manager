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
    public partial class SelectorIngresosClientes : Form
    {
        FiltroBusqeda filtro;
        Listado listado;
        string consulta;
        string idCliente;
        SQL sql = new SQL(Properties.Settings.Default.ConnectionString);

        public SelectorIngresosClientes(string idCliente)
        {

            this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            this.idCliente = idCliente;
            InitializeComponent();


            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            buttonDatos.Add(new ListadoButtonDatos(false, "Agregar", Body_Factory_Manager.Properties.Resources.agregarCliente, this.Agregar));
            buttonDatos.Add(new ListadoButtonDatos(true, "Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.Borrar));

            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>
            {
                new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha", "fecha")
            };

            listado = new Listado(new List<string> { "id" }, buttonDatos, 1, filtros, Filtrar, 1);

            listado.Dock = DockStyle.Fill;
            this.Controls.Add(listado);
            ActualizarConsulta();
        }

        private void ActualizarConsulta()
        {
            consulta = "SELECT id, fecha as Fecha, comentario as Comentario FROM IngresosClientes WHERE idCliente=" + idCliente;

            consulta += " AND " + filtro.ObtenerWhereConsulta();
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar(new List<string> { "id" });
        }

        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }



        private void SelectorIngresosClientes_Load(object sender, EventArgs e)
        {

        }

        private void Agregar(Dictionary<string, object> datos)
        {
            try
            {
                //DataTable datosIngreso = sql.Obtener("SELECT * FROM IngresosClientes WHERE id =" + datos["id"]);
                using (DatosIngreso nuevaVentana = new DatosIngreso())
                {
                    nuevaVentana.ShowDialog();
                    if (nuevaVentana.DialogResult == DialogResult.Yes)
                    {
                        Dictionary<string, object> parametros = new Dictionary<string, object>()
                    {
                        {"fecha", nuevaVentana.fecha },
                        { "comentario", nuevaVentana.comentario },
                        {"idCliente", idCliente }

                    };
                    sql.Modificar("INSERT INTO IngresosClientes (fecha, comentario, idCliente) VALUES (@fecha, @comentario, @idCliente)", parametros);

                    
                        ActualizarConsulta();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, razón: " + ex.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }


        }

        private void Editar(Dictionary<string, object> datos)
        {
            using (DatosCliente nuevaVentana = new DatosCliente(datos["id"].ToString()))
            {
                nuevaVentana.ShowDialog();
            }
            CargarListaClientes();
        }

        private void Borrar(Dictionary<string, object> datos)
        {
            if (string.IsNullOrEmpty(datos["id"].ToString()))
            {
                MessageBox.Show("Esta acción requiere seleccionar un item", "Ningún campo seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el dato?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                sql.Modificar("DELETE FROM IngresosClientes WHERE id= " + datos["id"].ToString());
                CargarListaClientes();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error, razón: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
