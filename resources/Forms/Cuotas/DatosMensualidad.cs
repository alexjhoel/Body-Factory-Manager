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
                            ingresoDTP.Value = DateTime.ParseExact("01/" + mes + "/" + anio, "dd/M/yyyy", CultureInfo.InvariantCulture);
                            vencimientoDTP.Value = DateTime.ParseExact("01/" + (int.Parse(mes) + 1) + "/" + anio, "dd/M/yyyy", CultureInfo.InvariantCulture);
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
                            MessageBox.Show("Selecciones una mensualiad activa");
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
                ActualizarTotal();

            EstablecerInterfaz();

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

        private void ActivarZonaMensualidad(bool estado)
        {
            cobroNUD.Enabled = estado;
            cobroCBX.Enabled = estado;
            descuentoNUD.Enabled = estado;
            descuentoCBX.Enabled = estado;
            ingresoDTP.Enabled = estado;
            totalTbx.Enabled = estado;
            if (!estado)
            {
                cobroNUD.Value = cobroNUD.Minimum;
                descuentoNUD.Value = descuentoNUD.Minimum;
                totalTbx.Text = "0";
            }
        }

        private void ObtenerDatosMensualidad(string cedulaCliente, string mes, string anio)
        {
            string consulta = "SELECT Mensualidades.cedulaCliente,Mensualidades.mes,Mensualidades.anio, valor, descuento, fechaIngreso, vencimiento, pagado, (valor - valor * (descuento / 100)) as total " +
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
                sql.Modificar(consulta, parametros);
                if (tipo == TipoPagoMensualidad.NuevoPago)
                {
                    consulta = " INSERT INTO Pagos (cedulaCliente, mesMensualidad, anioMensualidad, monto, fecha) VALUES(@cedulaCliente, @mes, @anio, @entregaPago, @fechaPago);";
                    consulta += " EXEC ComprobarMensualidades @c = @cedulaCliente";
                    sql.Modificar(consulta, parametros);
                    MessageBox.Show(this, "Pago adjuntado con exito", "Datos guardados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    /*
                    ObtenerDatosMensualidad(cedulaCliente, (mesCBX.SelectedIndex + 1).ToString(), anioNUD.Value.ToString());
                    
                    decimal sobrante = ((decimal)datosMensualidad.Rows[0]["total"]) - ((decimal)datosMensualidad.Rows[0]["pagado"]);
                    int i = 0;
                    if(sobrante < 0)
                    {
                        if(MessageBox.Show(this, "El pago excede el total de la mensualidad, ¿Quieres distribuirlo en las posteriores cuotas?", "Datos guardados con éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            while (sobrante < 0)
                            {

                                i++;
                                if (mesCBX.SelectedIndex + i + 1 == 13)
                                {
                                    parametros["mes"] = "1";
                                    parametros["anio"] = (anioNUD.Value + 1).ToString();
                                }
                                else parametros["mes"] = (mesCBX.SelectedIndex + i + 1).ToString();
                                //Pasarle datos de esta mensualidad siguiente a datosMensualidad
                                ObtenerDatosMensualidad(cedulaTBX.Text, (mesCBX.SelectedIndex + 1).ToString(), anioNUD.Value.ToString());
                                parametros["valor"] = (decimal)
                                if(datosMensualidad.Rows.Count != 0) {
                                    consulta = "INSERT INTO Mensualidades (cedulaCliente, mes, anio, valor, descuento, fechaIngreso, vencimiento) VALUES(@cedulaCliente, @mes, @anio, @valor, @descuento, @fechaIngreso, @vencimiento);";

                                } 
                            }
                        }
                    }
                    */

                }
                if (tipo == TipoPagoMensualidad.EditarMensualidad)
                {
                    consulta = "INSERT INTO Mensualidades (cedulaCliente, mes, anio, valor, descuento, fechaIngreso, vencimiento) VALUES(@cedulaCliente, @mes, @anio, @valor, @descuento, @fechaIngreso, @vencimiento);";

                    string texto = "Datos guardados";
                    for (int i = 1; i < (int)xMesesNUD.Value; i++)
                    {
                        if (i == 1) texto = "Se agregaron o modificaron las siguientes mensualidades: \n Mes " + parametros["mes"] + " del año " + parametros["anio"] + " a cobrar " + totalTbx.Text + " a vencer " + ((DateTime)parametros["vencimiento"]).ToString("dd/M/yyyy");

                        if (mesCBX.SelectedIndex + i + 1 == 13)
                        {
                            parametros["mes"] = "1";
                            parametros["anio"] = (anioNUD.Value + 1).ToString();
                        }
                        else parametros["mes"] = (mesCBX.SelectedIndex + i + 1).ToString();
                        parametros["fechaIngreso"] = ((DateTime)parametros["fechaIngreso"]).NextMonth();

                        if (sinVecimientoCBX.Checked) parametros["vencimiento"] = parametros["fechaIngreso"];
                        else { parametros["vencimiento"] = ((DateTime)parametros["vencimiento"]).NextMonth(); }


                        try
                        {
                            sql.Modificar(consulta, parametros);
                            texto += "\n Mes " + parametros["mes"] + " del año " + parametros["anio"] + " a cobrar " + totalTbx.Text + " vencimiento " + ((DateTime)parametros["vencimiento"]).ToString("dd/M/yyyy");
                        }

                        catch (SqlException exc)
                        {
                            if (exc.Number == 2627) { MessageBox.Show("La cuota del mes " + parametros["mes"] + " del año " + parametros["anio"] + " no se pudo crear, ya existe otra en su lugar, si desea modificarla edítala desde el listado", "Error de duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else MessageBox.Show("Ocurrió un error al agregar la cuota del mes " + parametros["mes"] + " del año " + parametros["anio"], "Error de base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        return;
                    }
                }
                
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
