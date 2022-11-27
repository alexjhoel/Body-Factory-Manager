using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosMensualidad : Form
    {
        SQL sql = new SQL(Properties.Settings.Default.ConnectionString);

        DataTable datosMensualidad;
        DataTable descuentos;
        DataTable montos;

        string anteriorCedula;
        string anteriorMes;
        string anteriorAnio;

        TipoPagoMensualidad tipo;

        string cedulaCliente = null;
        string idPago;
        public DatosMensualidad(TipoPagoMensualidad tipo = TipoPagoMensualidad.PrimerPago, string cedulaCliente = null, string mes = null, string anio = null)
        {
            this.DialogResult = DialogResult.Cancel;
            InitializeComponent();
            this.tipo = tipo;
            if(tipo == TipoPagoMensualidad.EditarMensualidad)
            {
                
                this.Width = 384;
                try
                {
                    if (cedulaCliente != null && mes != null && anio != null)
                    {

                        anteriorCedula = cedulaCliente;
                        anteriorMes = mes;
                        anteriorAnio = anio;

                        cedulaTBX.Text = cedulaCliente;
                        CambiarCliente(cedulaCliente);
                        ObtenerDatosMensualidad(cedulaCliente, mes, anio);
                       
                        if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
                        {
                            cobroNUD.Value = (decimal) datosMensualidad.Rows[0]["valor"];
                            descuentoNUD.Value = (decimal)datosMensualidad.Rows[0]["descuento"];
                            mesCBX.SelectedIndex = int.Parse(datosMensualidad.Rows[0]["mes"].ToString()) - 1;
                            anioNUD.Value = int.Parse(datosMensualidad.Rows[0]["anio"].ToString());
                            if(datosMensualidad.Rows[0]["vencimiento"] == DBNull.Value)
                            {
                                vencimientoDTP.Enabled = false;
                                sinVecimientoCBX.Checked = true;
                            }
                            else
                            {
                                vencimientoDTP.Enabled = true;
                                vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[0]["vencimiento"];
                            }
                            ingresoDTP.Value = (DateTime)datosMensualidad.Rows[0]["fechaIngreso"];
                        }
                        else
                        {
                            datosMensualidad = null;
                            mesCBX.SelectedIndex = int.Parse(mes) - 1;
                            anioNUD.Value = int.Parse(anio);
                            ingresoDTP.Value = DateTime.ParseExact(DateTime.Today.Day + "/" + mes + "/" + anio, "dd/M/yyyy", CultureInfo.InvariantCulture);
                            vencimientoDTP.Value = DateTime.ParseExact(DateTime.Today.Day + "/" + (int.Parse(mes) + 1) + "/" + anio, "dd/M/yyyy", CultureInfo.InvariantCulture);
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
            else
            {
                this.Text = "Pagar Mensualidad";
                try
                {
                    if (cedulaCliente != null && mes != null && anio != null)
                    {

                        anteriorCedula = cedulaCliente;
                        anteriorMes = mes;
                        anteriorAnio = anio;
                        xMesesPNL.Visible = false;
                        cedulaTBX.Text = cedulaCliente;
                        CambiarCliente(cedulaCliente);
                        ObtenerDatosMensualidad(cedulaCliente, mes, anio);

                        if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
                        {
                            cobroNUD.Value = (decimal)datosMensualidad.Rows[0]["valor"];
                            descuentoNUD.Value = (decimal)datosMensualidad.Rows[0]["descuento"];
                            mesCBX.SelectedIndex = int.Parse(datosMensualidad.Rows[0]["mes"].ToString()) - 1;
                            anioNUD.Value = int.Parse(datosMensualidad.Rows[0]["anio"].ToString());
                            if (datosMensualidad.Rows[0]["vencimiento"] == DBNull.Value)
                            {
                                vencimientoDTP.Enabled = false;
                                sinVecimientoCBX.Checked = true;
                            }
                            else
                            {
                                vencimientoDTP.Enabled = true;
                                vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[0]["vencimiento"];
                            }
                            ingresoDTP.Value = (DateTime)datosMensualidad.Rows[0]["fechaIngreso"];
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una mensualiad activa");
                            this.Close();
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

            ActualizarTotal();

        }

        private void EstablecerInterfaz()
        {
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

        }
        

        private void ObtenerDatosMensualidad(string cedulaCliente, string mes, string anio)
        {
            string consulta = "SELECT Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio, valor, descuento, fechaIngreso, vencimiento, pagado, (valor - valor * (descuento / 100)) as total, CONVERT(DATE, CONCAT('01/', Mensualidades.mes, '/', Mensualidades.anio), 103) as mesAnio " +
                "FROM (SELECT Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio, ISNULL(SUM(monto),0) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos " +
                "ON Pagos.cedulaCliente = Mensualidades.cedulaCliente AND Mensualidades.mes = Pagos.mesMensualidad AND Mensualidades.anio = Pagos.anioMensualidad " +
                "WHERE Mensualidades.cedulaCliente = '" + cedulaCliente + "' AND Mensualidades.mes = '" + mes + "' AND Mensualidades.anio = '" + anio +
                "' GROUP BY Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio) as MensualidadesPagos " +
                "INNER JOIN Mensualidades " +
                "ON MensualidadesPagos.cedulaCliente = Mensualidades.cedulaCliente AND Mensualidades.mes = MensualidadesPagos.mes AND Mensualidades.anio = MensualidadesPagos.anio ";
            
            try
            {
                datosMensualidad = sql.Obtener(consulta);
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
            decimal total = cobroNUD.Value - cobroNUD.Value * (descuentoNUD.Value / 100);

            totalTbx.Text = total + "";


            if (entregaCBX.SelectedIndex == 0)
            {
                entregaNUD.Value = datosMensualidad != null && datosMensualidad.Rows.Count != 0 ? total - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString()) : total;


            }

            if (datosMensualidad == null || datosMensualidad.Rows.Count == 0)
            {
                deudaLBL.Text = (total - entregaNUD.Value).ToString();
                return;
            }
            deudaLBL.Text = (total - entregaNUD.Value - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString())) + "";

            




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
                    entregaNUD.Value = decimal.Parse(totalTbx.Text) - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString());

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
            if ((datosMensualidad != null && datosMensualidad.Rows.Count > 0 && entregaNUD.Value == decimal.Parse(totalTbx.Text) - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString()))
                || ((datosMensualidad == null || datosMensualidad.Rows.Count == 0) && entregaNUD.Value == decimal.Parse(totalTbx.Text)))
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

            if (entregaNUD.Value <= 0 && tipo == TipoPagoMensualidad.NuevoPago) { MessageBox.Show("La entrega para la cuota no puede ser 0", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


            string consulta = "";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("valor", cobroNUD.Value);
            parametros.Add("descuento", descuentoNUD.Value);
            parametros.Add("fechaIngreso", ingresoDTP.Value);
            if (sinVecimientoCBX.Checked) parametros.Add("vencimiento", DBNull.Value);
            else parametros.Add("vencimiento", vencimientoDTP.Value);
            parametros.Add("entregaPago", entregaNUD.Value);
            parametros.Add("fechaPago", pagoFechaDTP.Value);
            parametros.Add("mes", (mesCBX.SelectedIndex + 1).ToString());
            parametros.Add("anio", anioNUD.Value.ToString());
            parametros.Add("cedulaCliente", cedulaTBX.Text);
            if (datosMensualidad != null)
            {

                consulta = "UPDATE Mensualidades SET valor = @valor, " +
                    "descuento = @descuento, fechaIngreso = @fechaIngreso, vencimiento = @vencimiento, mes = @mes, anio = @anio WHERE cedulaCliente ='" + datosMensualidad.Rows[0]["cedulaCliente"] + "' AND mes = '" + datosMensualidad.Rows[0]["mes"] + "' AND anio =" + datosMensualidad.Rows[0]["anio"];
            }
            else
            {
                consulta = "INSERT INTO Mensualidades (cedulaCliente, mes, anio, valor, descuento, fechaIngreso, vencimiento) VALUES(@cedulaCliente, @mes, @anio, @valor, @descuento, @fechaIngreso, @vencimiento);";
            }
           




            try
            {

                //Mensualidades multiples
                if (tipo == TipoPagoMensualidad.NuevoPago)
                {
                    decimal totalActual = cobroNUD.Value - cobroNUD.Value * (descuentoNUD.Value / 100) - (decimal)datosMensualidad.Rows[0]["pagado"];
                    
                    if (entregaNUD.Value - totalActual > 0)
                    {
                        parametros["entregaPago"] = totalActual;
                        decimal sobrante = entregaNUD.Value  - totalActual;
                        DateTime mesAnio = ((DateTime)datosMensualidad.Rows[0]["mesAnio"]);

                        int i = 0;
                        while (sobrante > 0)
                        {

                            mesAnio = mesAnio.NextMonth();
                            string otraConsulta = "SELECT Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio, fechaIngreso, vencimiento, pagado, (valor - valor * (descuento / 100)) as total " +
                    "FROM (SELECT Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio, ISNULL(SUM(monto),0) AS pagado " +
                    "FROM Mensualidades " +
                    "LEFT JOIN Pagos " +
                    "ON Pagos.cedulaCliente = Mensualidades.cedulaCliente AND Mensualidades.mes = Pagos.mesMensualidad AND Mensualidades.anio = Pagos.anioMensualidad " +
                    "WHERE Mensualidades.cedulaCliente = '" + cedulaTBX.Text + "' AND Mensualidades.mes = '" + mesAnio.Month + "' AND Mensualidades.anio = '" + mesAnio.Year +
                    "' GROUP BY Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio) as MensualidadesPagos " +
                    "INNER JOIN Mensualidades " +
                    "ON MensualidadesPagos.cedulaCliente = Mensualidades.cedulaCliente AND Mensualidades.mes = MensualidadesPagos.mes AND Mensualidades.anio = MensualidadesPagos.anio ";
                            DataTable mensualidadSiguiente = sql.Obtener(otraConsulta);
                            parametros.Add("mes" + i, mesAnio.Month.ToString());
                            parametros.Add("anio" + i, mesAnio.Year.ToString());
                            if (mensualidadSiguiente.Rows.Count > 0)
                            {
                                parametros.Add("entregaPago" + i, Math.Min((decimal)mensualidadSiguiente.Rows[0]["total"] - (decimal)mensualidadSiguiente.Rows[0]["pagado"], sobrante));

                                consulta += " INSERT INTO Pagos (cedulaCliente, mesMensualidad, anioMensualidad, monto, fecha) VALUES(@cedulaCliente, @mes" + i + ", @anio" + i + ", @entregaPago" + i + ", @fechaPago);";
                            }
                            else
                            {
                                MessageBox.Show(this, "No se puede repartir el pago en la mensualidad del mes " + mesAnio.Month + " del año " + mesAnio.Year + " porque no existe, debe crearla antes", "No se puede adjuntar el pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            sobrante = sobrante - (decimal)parametros["entregaPago" + i];

                            i++;

                        }
                    }
                    consulta += " INSERT INTO Pagos (cedulaCliente, mesMensualidad, anioMensualidad, monto, fecha) VALUES(@cedulaCliente, @mes, @anio, @entregaPago, @fechaPago);";
                    consulta += " EXEC ComprobarMensualidades @c = @cedulaCliente";
                    sql.Modificar(consulta, parametros);
                    MessageBox.Show(this, "Pago adjuntado con exito", "Datos guardados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                if (tipo == TipoPagoMensualidad.EditarMensualidad)
                {
                    sql.Modificar(consulta, parametros);
                    consulta = "INSERT INTO Mensualidades (cedulaCliente, mes, anio, valor, fechaIngreso, vencimiento) VALUES(@cedulaCliente, @mes, @anio, @valor, @fechaIngreso, @vencimiento);";

                    string texto = "Datos guardados";
                    int mes = mesCBX.SelectedIndex + 2;
                    int anio = (int)anioNUD.Value;
                    for (int i = 1; i < (int)xMesesNUD.Value; i++)
                    {
                        if (i == 1) texto = "Se agregaron o modificaron las siguientes mensualidades: \n Mes " + parametros["mes"] + " del año " + parametros["anio"] + " a cobrar " + cobroNUD.Value + " a vencer " + (parametros["vencimiento"] != DBNull.Value ? ((DateTime)parametros["vencimiento"]).ToString("dd/M/yyyy") : ": Sin vecimiento");

                        
                        if (mes == 13)
                        {
                            anio++;
                            
                            mes = 1;
                        }
                        parametros["mes"] = mes.ToString();
                        parametros["anio"] = anio.ToString();
                        parametros["fechaIngreso"] = ((DateTime)parametros["fechaIngreso"]).NextMonth();

                        if (sinVecimientoCBX.Checked) parametros["vencimiento"] = parametros["fechaIngreso"];
                        else { parametros["vencimiento"] = ((DateTime)parametros["vencimiento"]).NextMonth(); }
                        mes++;


                        try
                        {
                            
                            sql.Modificar(consulta, parametros);
                            texto += "\n Mes " + parametros["mes"] + " del año " + parametros["anio"] + " a cobrar " + totalTbx.Text + " vencimiento " + (parametros["vencimiento"] != DBNull.Value ? ((DateTime)parametros["vencimiento"]).ToString("dd/M/yyyy") : ": Sin vecimiento");
                        }

                        catch (SqlException exc)
                        {
                            if (exc.Number == 2627) { texto += "La cuota del mes " + parametros["mes"] + " del año " + parametros["anio"] + " no se pudo crear, ya existe otra en su lugar, si desea modificarla edítala desde el listado"; }
                            else MessageBox.Show("La cuota del mes " + parametros["mes"] + " del año " + parametros["anio"] + " no se agregó " + exc.Message, "Error de base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sql.CerrarConexion();
                        }


                    }

                    if (MessageBox.Show(this, texto + "\n ¿Desea adjuntar un pago a la cuota?", "Datos guardados con éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ObtenerDatosMensualidad(cedulaTBX.Text, (mesCBX.SelectedIndex + 1).ToString(), anioNUD.Value.ToString());
                        xMesesPNL.Visible = false;
                        xMesesNUD.Value = 1;
                        this.Width = 589;
                        tipo = TipoPagoMensualidad.NuevoPago;
                        this.DialogResult = DialogResult.OK;
                        return;
                    }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    
                }





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
                    if (!SePuedeEstablecerMensualidad())
                    {
                        MessageBox.Show("Ya existe una mensualidad con el mismo mes y año de vigencia", "No se puede cambiar la cedula", MessageBoxButtons.OK);
                        cedulaTBX.Text = anteriorCedula;
                    }
                    nombreTBX.Text = datos.Rows[0]["nombre"].ToString() + " " + datos.Rows[0]["apellido"].ToString();
                    anteriorCedula = cedulaTBX.Text;
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
            vencimientoDTP.Enabled = !sinVecimientoCBX.Checked;
        }

        private void mesCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SePuedeEstablecerMensualidad())
            {
                MessageBox.Show("Ya existe una mensualidad con el mismo mes y año de vigencia", "No se puede el mes", MessageBoxButtons.OK);
                mesCBX.SelectedIndex = int.Parse(anteriorMes) - 1;
                return;
            }
            anteriorAnio = (mesCBX.SelectedIndex + 1).ToString();
        }

        private void anioNUD_ValueChanged(object sender, EventArgs e)
        {
            if (!SePuedeEstablecerMensualidad())
            {
                MessageBox.Show("Ya existe una mensualidad con el mismo mes y año de vigencia", "No se puede cambiar el año", MessageBoxButtons.OK);
                anioNUD.Value = int.Parse(anteriorAnio);
                return;
            }
            anteriorAnio = anioNUD.Value.ToString();
        }

        private bool SePuedeEstablecerMensualidad()
        {
            bool resultado = true;
            try
            {
                DataTable otraMensualidad = sql.Obtener("SELECT * FROM Mensualidades WHERE cedulaCliente = '" + cedulaTBX.Text + "' AND mes = '" + (mesCBX.SelectedIndex + 1) + "' AND anio = '" + anioNUD.Value + "'");
                resultado = otraMensualidad.Rows.Count == 0 || (datosMensualidad != null && datosMensualidad.Rows[0]["cedulaCliente"].ToString() == cedulaTBX.Text
                    && datosMensualidad.Rows[0]["mes"].ToString() == (mesCBX.SelectedIndex + 1).ToString()
                    && datosMensualidad.Rows[0]["anio"].ToString() == anioNUD.Value.ToString());

            }
            catch 
            {
                
            }
            return resultado;
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
