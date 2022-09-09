using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class ListadoMensualidades : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        string consulta;
        FiltroBusqeda filtro;
        SortOrder orden = SortOrder.None;
        string propiedadOrden;

        public string id;


        public ListadoMensualidades(bool selector = false, FiltroBusqeda filtro = null)
        {
            this.filtro = filtro;
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();

            DialogResult = DialogResult.Cancel;





            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos("Listo", Body_Factory_Manager.Properties.Resources.check, this.Seleccionar));
                buttonDatos.Add(new ListadoButtonDatos("Ver", Body_Factory_Manager.Properties.Resources.ver, this.Editar));

            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos("Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
                buttonDatos.Add(new ListadoButtonDatos("Pagar", Body_Factory_Manager.Properties.Resources.signo_de_dolar, this.PagarCuota));
                buttonDatos.Add(new ListadoButtonDatos("Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.Eliminar));
            }

            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre del cliente", "CONCAT(nombre, ' ', apellido)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cédula del cliente", "cedula"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de valores($)", "valor"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de deudas($)", "((valor * (1 - descuento / 100)) - pagado)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha de vencimiento", "fecha"));

            listado = new Listado("id", buttonDatos, Ordenar, filtros, Filtrar);
            this.Controls.Add(listado);
            listado.Location = new Point(0, 0);
            listado.Size = new Size(this.Size.Width, 420);
            listado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActualizarConsulta();



        }


        private void Eliminar(string id)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Mensualidades WHERE id= " + id);
            CargarListaMensualidades();
        }

        private void CargarListaMensualidades()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar("id", (int)diasNUD.Value);
        }

        private void Editar(string id)
        {
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(id, TipoPagoMensualidad.EditarMensualidad))
            {
                nuevaVentana.ShowDialog();

                ActualizarConsulta();
            }

        }

        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }
        private void Seleccionar(string id)
        {
            DialogResult = DialogResult.OK;
            this.id = id;
            this.Close();
        }

        private void Ordenar(string propiedadOrden, SortOrder orden)
        {
            this.propiedadOrden = propiedadOrden;
            this.orden = orden;
            CargarListaMensualidades();
        }
        private void PagarCuota(string id)
        {
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(id, TipoPagoMensualidad.PagarCuotaDesdeListado))
            {
                nuevaVentana.ShowDialog();
            }
        }
        private void ActualizarConsulta()
        {
            consulta = "SELECT cedula as Cedula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', FullMensualidades.id, valor as 'Cuota($)', descuento as 'Descuento(%)', (valor * (1 - descuento / 100)) as 'Total($)', ((valor * (1 - descuento / 100)) - pagado) as 'Deuda($)', vencimiento as Vencimiento " +
                "FROM(SELECT Mensualidades.id, pagado, valor, descuento, fechaCreado, vencimiento, cedulaCliente " +
                "FROM(SELECT Mensualidades.id, (ISNULL(SUM(monto), 0)) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id  " +
                "GROUP BY Mensualidades.id) AS PagosMensualidades " +
                "INNER JOIN Mensualidades ON PagosMensualidades.id = Mensualidades.id) as FullMensualidades " +
                "INNER JOIN Clientes on FullMensualidades.cedulaCliente = Clientes.cedula ";
            if (!pagasCBX.Checked)
            {
                consulta += " WHERE ((valor * (1 - descuento / 100)) - pagado) > 0 AND " + filtro.ObtenerWhereConsulta();

            }
            else
            {
                consulta += filtro.ObtenerWhereConsulta();
            }
            if (orden != SortOrder.None) consulta += " ORDER BY " + propiedadOrden + (orden == SortOrder.Ascending ? " asc" : " desc");

            CargarListaMensualidades();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void diasNUD_ValueChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void ListadoMensualidades_Load(object sender, EventArgs e)
        {

        }
    }
}
