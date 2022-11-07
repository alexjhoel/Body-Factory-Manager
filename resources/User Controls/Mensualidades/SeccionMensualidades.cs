using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha de vencimiento", "vencimiento"));

            listado = new Listado("id", buttonDatos, Ordenar, filtros, Filtrar);
            this.pestaniasTCL.TabPages[0].Controls.Add(listado);
            listado.Location = new Point(0, 0);
            listado.Dock = DockStyle.Fill;

            diasNUD.Value = 6;

           


        }

        public SeccionMensualidades(string cedulaCliente)
        {
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            InitializeComponent();
            this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            cedulaTBX.Text = cedulaCliente;
            
            anioNUD.Value = DateTime.Now.Year;
            CargarListaMensualidades();
            tablaDGV.Rows[DateTime.Now.Month - 1].Selected = true;

        }


        private void Eliminar(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Esta acción requiere seleccionar una mensualidad", "Ningúna mensualidad seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Mensualidades WHERE id= " + id);
            CargarListaMensualidades();
        }

        private void CargarListaMensualidades()
        {
            //listado.datos = sql.Obtener(consulta);
            //listado.Recargar("id", (int)diasNUD.Value);

            tablaDGV.Rows.Clear();
            for (int i = 0; i < 12; i++)
            {

                tablaDGV.Rows.Add();
                tablaDGV.Rows[i].Cells[0].Value = DateTime.ParseExact("01/" + (i + 1) + "/2001", "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM"); 
                DataTable datos = sql.Obtener("SELECT fechaIngreso, pagado, valor, descuento, ISNULL(CONVERT(VARCHAR(MAX),vencimiento,103),'Sin vecimiento') as vencimiento     , CONVERT(DECIMAL(6, 2), valor * (1 - descuento / 100)) as total, ((valor * (1 - descuento / 100)) - pagado) as deuda, ISNULL(CONVERT(VARCHAR(10),ultimoPago,103),'Sin pagos') as ultimoPago " +
"FROM(SELECT Mensualidades.cedulaCliente, Mensualidades.mes, Mensualidades.anio, (ISNULL(SUM(monto), 0)) AS pagado, MAX(Pagos.fecha) as ultimoPago " +
"FROM Mensualidades LEFT JOIN Pagos ON Pagos.cedulaCliente = Mensualidades.cedulaCliente AND Pagos.mesMensualidad = Mensualidades.mes AND Pagos.anioMensualidad = Mensualidades.anio " +
"WHERE Mensualidades.cedulaCliente = '" + cedulaTBX.Text + "' AND Mensualidades.mes = " + (i + 1) + " AND Mensualidades.anio = " + anioNUD.Value +
" GROUP BY Mensualidades.cedulaCliente, Mensualidades.mes, Mensualidades.anio) AS PagosMensualidades " +
"INNER JOIN Mensualidades ON PagosMensualidades.cedulaCliente = Mensualidades.cedulaCliente AND PagosMensualidades.mes = Mensualidades.mes AND PagosMensualidades.anio = Mensualidades.anio");
                if (datos == null || datos.Rows.Count == 0) continue;
                tablaDGV.Rows[i].Cells[1].Value = datos.Rows[0]["fechaIngreso"];
                tablaDGV.Rows[i].Cells[2].Value = datos.Rows[0]["valor"];
                tablaDGV.Rows[i].Cells[3].Value = datos.Rows[0]["descuento"];
                tablaDGV.Rows[i].Cells[4].Value = datos.Rows[0]["total"];
                tablaDGV.Rows[i].Cells[5].Value = datos.Rows[0]["deuda"];
                tablaDGV.Rows[i].Cells[6].Value = datos.Rows[0]["vencimiento"];
                tablaDGV.Rows[i].Cells[7].Value = datos.Rows[0]["ultimoPago"];


            }
        }

        private void Editar(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Esta acción requiere seleccionar una mensualidad", "Ningúna mensualidad seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(TipoPagoMensualidad.EditarMensualidad, id))
            {
                nuevaVentana.ShowDialog();
                if(nuevaVentana.DialogResult == DialogResult.OK) ActualizarConsulta();
            }

        }

        private void Avisar(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Esta acción requiere seleccionar una mensualidad", "Ningúna mensualidad seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Esta acción requiere seleccionar una mensualidad", "Ningúna mensualidad seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(TipoPagoMensualidad.PagarCuotaDesdeListado, id))
            {
                nuevaVentana.ShowDialog();
                if (nuevaVentana.DialogResult == DialogResult.OK) ActualizarConsulta();
            }
        }


        private void ActualizarConsulta()
        {
            consulta = "SELECT cedula as Cedula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', FullMensualidades.id, valor as 'Cuota($)', descuento as 'Descuento(%)', (CONVERT(DECIMAL(6,2),valor * (1 - descuento / 100))) as 'Total($)', ((valor * (1 - descuento / 100)) - pagado) as 'Deuda($)',CONVERT(DATE, CONCAT(dia, '/', mes, '/', anio) ,103) as Ingreso, vencimiento as Vencimiento " +
                "FROM(SELECT Mensualidades.id, pagado, valor, descuento, dia, mes, anio, vencimiento, cedulaCliente " +
                "FROM(SELECT Mensualidades.id, (ISNULL(SUM(monto), 0)) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos ON Pagos.cedulaCliente = Mensualidades.cedulaCliente AND Pagos.mesMensualidad = Mensualidades.mes AND Pagos.anioMensualidad = Mensualidades.anio "  +
                "GROUP BY Mensualidades.id) AS PagosMensualidades " +
                "INNER JOIN Mensualidades ON PagosMensualidades.id = Mensualidades.id) as FullMensualidades " +
                "INNER JOIN Clientes on FullMensualidades.cedulaCliente = Clientes.cedula WHERE ";
            if (!pagasCBX.Checked)
            {
                consulta += "((valor * (1 - descuento / 100)) - pagado) > 0 AND ";
            }
            consulta += filtro.ObtenerWhereConsulta() + " AND Clientes.esOculto = 0";
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

        private void buscarClienteBTN_Click(object sender, EventArgs e)
        {
            FiltroBusqeda filtro = new FiltroBusqeda(TipoFiltro.String, "", "cedula");
            filtro.valor1 = this.cedulaTBX.Text.Trim();
            using (SelectorClientes listado = new SelectorClientes(filtro))
            {
                listado.ShowDialog();
                if (listado.DialogResult == DialogResult.OK)
                {
                    cedulaTBX.Text = listado.cedula;
                }
            }
        }

        private void cedulaTBX_TextChanged(object sender, EventArgs e)
        {
            if (cedulaTBX.Text.Length == 8)
            {
                try
                {
                    DataTable datos = sql.Obtener("SELECT nombre,apellido FROM Clientes WHERE cedula=" + cedulaTBX.Text);
                    if (datos.Rows.Count != 0)
                    {
                        nombreTBX.Text = datos.Rows[0]["nombre"].ToString() + " " + datos.Rows[0]["apellido"].ToString();

                        ActualizarConsulta();
                        anotarBTN.Enabled = true;
                        borrarBTN.Enabled = true;
                        return;
                    }
                }
                catch
                {

                }
                finally
                {
                    sql.CerrarConexion();
                }


            }

            nombreTBX.Text = "No encontrado";
            anotarBTN.Enabled = false;
            borrarBTN.Enabled = false;
        }

        private void anotarBTN_Click(object sender, EventArgs e)
        {
            if (tablaDGV.SelectedCells.Count == 0) return;
            using (DatosMensualidad datosMensualidad = new DatosMensualidad(TipoPagoMensualidad.EditarMensualidad, cedulaTBX.Text, (tablaDGV.SelectedCells[0].RowIndex + 1).ToString(), anioNUD.Value.ToString()))
            {
                datosMensualidad.ShowDialog();
            }
        }
    }
}
