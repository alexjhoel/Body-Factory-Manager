using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosMensualidad : Form
    {
        SQL sql = new SQL(Properties.Settings.Default.ConnectionString);

        DataTable datosMensualidad;
        DataTable descuentos;
        DataTable montos;
        TipoPagoMensualidad tipo;

        string cedulaCliente = null;
        string idPago;
        public DatosMensualidad(TipoPagoMensualidad tipo = TipoPagoMensualidad.PrimerPago, string cedulaCliente = null, string mes = null, string anio = null)
        {
            this.DialogResult = DialogResult.Cancel;
            InitializeComponent();

            if(tipo == TipoPagoMensualidad.EditarMensualidad)
            {
                try {
                if(cedulaCliente != null && mes != null && anio != null)
                    {
                        datosMensualidad = sql.Obtener("SELECT * FROM Mensualidades WHERE cedulaCliente='" + cedulaCliente + "' AND mes='" + mes + "' AND anio='" + anio + "'");
                        if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
                        {

                        }
                    }
                
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.CerrarConexion();
                }
            }



            EstablecerInterfaz();

        }

        private void EstablecerInterfaz()
        {

            string cedulaCliente = "";
            if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
            {
                cedulaCliente = datosMensualidad.Rows[0]["cedulaCliente"].ToString();
            }

            cedulaTBX.Text = cedulaCliente;

            descuentos = sql.Obtener("SELECT nombre, porcentaje, CONCAT(nombre, ' -', porcentaje, '%') AS 'todo' FROM Descuentos");
            foreach (DataRow row in descuentos.Rows)
            {
                descuentoCBX.Items.Add(row["todo"]);


            }

            montos = sql.Obtener("SELECT id, nombre, valor, CONCAT(nombre, ' - $' ,valor) AS 'todo' FROM Prefijadas");
            foreach (DataRow row in montos.Rows)
            {
                cobroCBX.Items.Add(row["todo"]);


            }

            descuentoCBX.SelectedIndex = 0;
            cobroCBX.SelectedIndex = 0;
            entregaCBX.SelectedIndex = 0;

            buscarClienteBTN.Visible = tipo == TipoPagoMensualidad.NuevoPago;
            if (tipo == TipoPagoMensualidad.NuevoPago)
            {
                ActivarZonaMensualidad(false);
            }
            if (tipo == TipoPagoMensualidad.PrimerPago || tipo == TipoPagoMensualidad.NuevaMensualidad)
            {
                entregaCBX.Items.Clear();
                entregaCBX.Items.Add("Entrega total");
                entregaCBX.Items.Add("Entrega parcial");
                entregaCBX.Items.Add("Paga después");
                buscarMensualidadBtn.Hide();
                vencimientoDTP.Value = DateTimeUtilities.NextMonth(DateTime.Now);
                totalTbx.Text = cobroNUD.Value + "";
            }

        }

        private void ActivarZonaMensualidad(bool estado)
        {
            cobroNUD.Enabled = estado;
            cobroCBX.Enabled = estado;
            descuentoNUD.Enabled = estado;
            descuentoCBX.Enabled = estado;
            adjudDTP.Enabled = estado;
            vencimientoDTP.Enabled = estado;
            totalTbx.Enabled = estado;
            if (!estado)
            {
                cobroNUD.Value = cobroNUD.Minimum;
                descuentoNUD.Value = descuentoNUD.Minimum;
                totalTbx.Text = "0";
            }
        }

        private void ObtenerDatosMensualidad(string id)
        {
            string consulta = "SELECT Mensualidades.id, valor, descuento, fechaCreado, vencimiento, cedulaCliente, pagado " +
                "FROM (SELECT Mensualidades.id as id, ISNULL(SUM(monto),0) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos " +
                "ON Pagos.idMensualidad = Mensualidades.id " +
                "WHERE Mensualidades.id = " + id +
                " GROUP BY Mensualidades.id) as MensualidadesPagos " +
                "INNER JOIN Mensualidades " +
                "ON MensualidadesPagos.id = Mensualidades.id ";
            try
            {
                datosMensualidad = sql.Obtener(consulta);
                Console.WriteLine(datosMensualidad.Rows[0]["valor"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }

        }

        private void ObtenerDatosCliente(string cedula)
        {
            cedulaCliente = cedula;

        }

        private void ActualizarTotal()
        {
            decimal total = cobroNUD.Value - (cobroNUD.Value * (descuentoNUD.Value / 100));
            if (tipo == TipoPagoMensualidad.PrimerPago)
            {


                totalTbx.Text = total + "";


                if (entregaCBX.SelectedIndex == 0)
                {

                    entregaNUD.Value = total;
                }

                deudaLBL.Text = (total - entregaNUD.Value) + "";
            }
            else
            {
                totalTbx.Text = total + "";


                if (entregaCBX.SelectedIndex == 0)
                {
                    entregaNUD.Value = datosMensualidad != null ? total - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString()) : total;


                }

                if (datosMensualidad == null)
                {
                    deudaLBL.Text = (total - entregaNUD.Value).ToString();
                    return;
                }
                deudaLBL.Text = (total - entregaNUD.Value - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString())) + "";

            }




        }

        private void ActivarPago(bool estado)
        {
            entregaNUD.Enabled = estado;
            pagoFechaDTP.Enabled = estado;
            deudaLBL.Enabled = estado;

        }

        private void descuentosCBX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (descuentoCBX.SelectedIndex == 1) return;
            if (descuentoCBX.SelectedIndex == 0)
            {
                descuentoNUD.Value = 0;
                return;
            }
            descuentoNUD.Value = decimal.Parse(descuentos.Rows[descuentoCBX.SelectedIndex - 2]["porcentaje"].ToString());
        }

        private void entregaCBX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (entregaCBX.SelectedIndex < 2)
            {

                if (entregaCBX.SelectedIndex == 0)
                {
                    if (tipo == TipoPagoMensualidad.PrimerPago)
                    {
                        entregaNUD.Value = decimal.Parse(totalTbx.Text);
                    }
                    else
                    {
                        entregaNUD.Value = decimal.Parse(totalTbx.Text) - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString());
                    }

                }
                ActivarPago(true);
            }

            if (entregaCBX.SelectedIndex == 2)
            {
                ActivarPago(false);
            }
            ActualizarTotal();
        }

        private void cobroCBX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cobroCBX.SelectedIndex != 0)
            {
                cobroNUD.Value = decimal.Parse(montos.Rows[cobroCBX.SelectedIndex - 1]["Valor"].ToString());

            }
        }

        private void cobroNUD_ValueChanged(object sender, EventArgs e)
        {
            if (montos == null) return;
            bool flag = true;
            foreach (DataRow m in montos.Rows)
            {
                if (cobroNUD.Value == decimal.Parse(m["valor"].ToString()))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                if (cobroNUD.Value == 0) descuentoCBX.SelectedIndex = 0; else descuentoCBX.SelectedIndex = 1;
            }

            ActualizarTotal();


        }

        private void descuentoNUD_ValueChanged(object sender, EventArgs e)
        {
            if (descuentos == null) return;
            bool flag = true;
            foreach (DataRow m in descuentos.Rows)
            {
                if (cobroNUD.Value == decimal.Parse(m["porcentaje"].ToString()))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                if (descuentoNUD.Value == 0) descuentoCBX.SelectedIndex = 0; else descuentoCBX.SelectedIndex = 1;
            }
            ActualizarTotal();
        }

        private void entregaNUD_ValueChanged(object sender, EventArgs e)
        {
            if ((datosMensualidad != null && tipo != TipoPagoMensualidad.PrimerPago && entregaNUD.Value == decimal.Parse(totalTbx.Text) - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString()))
                || (entregaNUD.Value == decimal.Parse(totalTbx.Text)))
            {
                entregaCBX.SelectedIndex = 0;
            }
            else
            {
                entregaCBX.SelectedIndex = 1;
            }


            ActualizarTotal();
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            string consulta = "";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("valor", cobroNUD.Value);
            parametros.Add("descuento", descuentoNUD.Value);
            parametros.Add("adjudicado", adjudDTP.Value);
            parametros.Add("vencimiento", vencimientoDTP.Value);
            parametros.Add("entregaPago", entregaNUD.Value);
            parametros.Add("fechaPago", pagoFechaDTP.Value);
            if (datosMensualidad != null)
            {
                parametros.Add("cedulaCliente", datosMensualidad.Rows[0]["cedulaCliente"]);
                parametros.Add("idMensualidad", datosMensualidad.Rows[0]["id"].ToString());
                consulta = "UPDATE Mensualidades SET valor = @valor, descuento = @descuento, fechaCreado = @adjudicado WHERE id =" + datosMensualidad.Rows[0]["id"].ToString();
            }
            if (tipo == TipoPagoMensualidad.PrimerPago)
            {
                consulta += "UPDATE Mensualidades SET valor = @valor, descuento = @descuento, fechaCreado = @adjudicado, vencimiento=@vencimiento WHERE id =" + datosMensualidad.Rows[1]["id"].ToString();
                if (entregaCBX.SelectedIndex < 2)
                {
                    consulta += " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) VALUES(@entregaPago, @fechaPago, @cedulaCliente, " + datosMensualidad.Rows[0]["id"].ToString() + ");";
                }

                try
                {
                    sql.Modificar(consulta, parametros);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show(this, "Datos guardados", "Datos guardados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ocurrió un error en la base de datos,no se guardaron los datos, razon: \n" + ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.CerrarConexion();
                }
                return;

            }

            if (tipo == TipoPagoMensualidad.NuevaMensualidad)
            {
                parametros.Add("cedulaCliente", cedulaCliente);
                consulta = "INSERT INTO Mensualidades (valor, descuento, fechaCreado, vencimiento, cedulaCliente) VALUES(@valor, @descuento, @adjudicado, @vencimiento, @cedulaCliente)";
                if (entregaCBX.SelectedIndex < 2)
                {
                    consulta += " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) VALUES(@entregaPago, @fechaPago, @cedulaCliente, SCOPE_IDENTITY());";
                }


            }


            if (tipo == TipoPagoMensualidad.PagarCuotaDesdeClientes || tipo == TipoPagoMensualidad.PagarCuotaDesdeListado)
            {
                consulta = " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) " +
                   "VALUES(@entregaPago, @fechaPago, @cedulaCliente, @idMensualidad);";

            }

            if (tipo == TipoPagoMensualidad.NuevoPago)
            {
                    consulta = " INSERT INTO Pagos (monto, fecha, cedulaCliente) " +
                   "VALUES(@entregaPago, @fechaPago, @cedulaCliente);";
                



            }
            /*
            if (false)
            {

                 consulta = " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) " +
                    "VALUES(@entregaPago, @fechaPago, @cedulaCliente, @idMensualidad);";
                consulta += "EXEC ComprobarMensualidades @c = @cedulaCliente";
                //Actualizar mensualidad
                sql.Modificar(consulta, parametros);
            }*/

            consulta += " EXEC ComprobarMensualidades @c = @cedulaCliente";
            try
            {
                sql.Modificar(consulta, parametros);

                MessageBox.Show(this, "Datos guardados", "Datos guardados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrió un error en la base de datos,no se guardaron los datos, razon: \n" + ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }

        }

        private void descartarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void buscarMensualidadBtn_Click(object sender, EventArgs e)
        {
            FiltroBusqeda filtro = null;
            if (cedulaCliente != null)
            {
                filtro = new FiltroBusqeda(TipoFiltro.String, "", "cedulaCliente");
            }
            using (SelectorMensualidad selector = new SelectorMensualidad(filtro))
            {
                selector.ShowDialog();
                if (selector.DialogResult == DialogResult.OK)
                {
                    ObtenerDatosMensualidad(selector.id);

                    cobroNUD.Value = (decimal)datosMensualidad.Rows[0]["valor"];
                    descuentoNUD.Value = (decimal)datosMensualidad.Rows[0]["descuento"];
                    adjudDTP.Value = (DateTime)datosMensualidad.Rows[0]["fechaCreado"];

                    vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[0]["vencimiento"];
                    ActualizarTotal();
                    ActivarZonaMensualidad(true);
                    CambiarCliente(datosMensualidad.Rows[0]["cedulaCliente"].ToString());
                }
            }


        }

        private void cedulaTBX_TextChanged(object sender, EventArgs e)
        {
            CambiarCliente(cedulaTBX.Text);
        }

        private void buscarClienteBTN_Click(object sender, EventArgs e)
        {
            FiltroBusqeda filtro = new FiltroBusqeda(TipoFiltro.String, "", "cedula");
            filtro.valor1 = cedulaTBX.Text;
            using (SelectorClientes listado = new SelectorClientes(filtro))
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
            try
            {
                cedulaTBX.Text = cedula;
                DataTable datos = sql.Obtener("SELECT nombre,apellido FROM Clientes WHERE cedula=" + cedula);
                if (datos.Rows.Count != 0)
                {
                    nombreTBX.Text = datos.Rows[0]["nombre"].ToString() + " " + datos.Rows[0]["apellido"].ToString();
                    return;
                }



                nombreTBX.Text = "N/A";
            }
            catch
            {

            }

            finally
            {
                sql.CerrarConexion();
            }

        }

        private void verClienteCompleto_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = sql.Obtener("SELECT nombre,apellido FROM Clientes WHERE cedula=" + cedulaTBX.Text);
                if (datos.Rows.Count == 0)
                {
                    return;
                }
                using (DatosCliente nuevaVentana = new DatosCliente(cedulaTBX.Text, false))
                {
                    nuevaVentana.ShowDialog();
                }

                CambiarCliente(cedulaTBX.Text);
            }
            catch
            {

            }

            finally
            {
                sql.CerrarConexion();
            }

        }

        private void HabilitarClientes(bool e)
        {
            selectorClientes.Enabled = e;
            verClienteCompleto.Enabled = true;
        }

        private void sinVecimientoCBX_CheckedChanged(object sender, EventArgs e)
        {
            vencimientoDTP.Enabled = sinVecimientoCBX.Checked;
        }
    }

    public enum TipoPagoMensualidad
    {
        PrimerPago,
        PagarCuotaDesdeClientes,
        PagarCuotaDesdeListado,
        EditarMensualidad,
        EditarPago,
        NuevaMensualidad,
        NuevoPago
    }
}
