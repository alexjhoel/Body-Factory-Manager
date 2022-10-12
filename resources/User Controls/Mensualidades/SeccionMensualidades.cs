using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionMensualidades : UserControl
    {
        SQL sql;
        string consulta;
        FiltroBusqeda filtro;
        SortOrder orden = SortOrder.None;
        string propiedadOrden;
        Comunicacion comunicacion = new Comunicacion();

        public string id;


        public SeccionMensualidades(bool selector = false, FiltroBusqeda filtro = null, Action<string> seleccionar = null)
        {
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            this.filtro = filtro;
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();

            //DialogResult = DialogResult.Cancel;





            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos("Listo", Body_Factory_Manager.Properties.Resources.check, seleccionar));
                buttonDatos.Add(new ListadoButtonDatos("Ver", Body_Factory_Manager.Properties.Resources.ver, this.Editar));

            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos("Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
                buttonDatos.Add(new ListadoButtonDatos("Avisar", Body_Factory_Manager.Properties.Resources.chat, this.Avisar));
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

            diasNUD.Value = 6;


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

        private void Avisar(string id)
        {
            try
            {
                DataTable datos = sql.Obtener("SELECT cedula, telefono FROM Mensualidades " +
                    "INNER JOIN Clientes " +
                    "ON Mensualidades.cedulaCliente = Clientes.cedula " +
                    "WHERE id = " + id);
                string telefono = datos.Rows[0]["telefono"].ToString();
                if (!String.IsNullOrEmpty(telefono))
                {
                    comunicacion.Chatear(telefono);
                    MessageBox.Show("Abriendo navegador web...");
                    return;
                }

                if (MessageBox.Show("El cliente no cuenta con un número de teléfono registrado, ¿Desea editar su información?", "Número no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (DatosCliente nuevaVentana = new DatosCliente(datos.Rows[0]["cedula"].ToString()))
                    {
                        nuevaVentana.ShowDialog();
                    }
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error al abrir el navegador, inténtelo de nuevo más tarde" + e.Message, "No se pudo realizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }
        }


        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
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
            consulta = "SELECT cedula as Cedula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', FullMensualidades.id, valor as 'Cuota($)', descuento as 'Descuento(%)', (CONVERT(DECIMAL(6,2),valor * (1 - descuento / 100))) as 'Total($)', ((valor * (1 - descuento / 100)) - pagado) as 'Deuda($)', vencimiento as Vencimiento " +
                "FROM(SELECT Mensualidades.id, pagado, valor, descuento, fechaCreado, vencimiento, cedulaCliente " +
                "FROM(SELECT Mensualidades.id, (ISNULL(SUM(monto), 0)) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id  " +
                "GROUP BY Mensualidades.id) AS PagosMensualidades " +
                "INNER JOIN Mensualidades ON PagosMensualidades.id = Mensualidades.id) as FullMensualidades " +
                "INNER JOIN Clientes on FullMensualidades.cedulaCliente = Clientes.cedula WHERE ";
            if (!pagasCBX.Checked)
            {
                consulta += "((valor * (1 - descuento / 100)) - pagado) > 0 AND ";
            }
            consulta += filtro.ObtenerWhereConsulta();
            if (orden != SortOrder.None) consulta += " ORDER BY " + propiedadOrden + (orden == SortOrder.Ascending ? " asc" : " desc");

            CargarListaMensualidades();
        }


        private void diasNUD_ValueChanged_1(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void pagasCBX_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void SeccionMensualidades_Load(object sender, EventArgs e)
        {

        }
    }
}
