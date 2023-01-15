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

        string anteriorMes;
        string anteriorAnio;

        TipoPagoMensualidad tipo;

        string idCliente = "";
        string idPago;
        public DatosMensualidad(TipoPagoMensualidad tipo = TipoPagoMensualidad.PrimerPago, string idCliente = null, string mes = null, string anio = null)
        {
            this.DialogResult = DialogResult.Cancel;
            InitializeComponent();
            EstablecerInterfaz();
            this.tipo = tipo;
            this.idCliente = idCliente;
            nombreTBX.Text = sql.Obtener("SELECT CONCAT(nombre, ' ', apellido) as nombre FROM Clientes WHERE id=" + idCliente).Rows[0]["nombre"].ToString();
            if (tipo == TipoPagoMensualidad.EditarMensualidad)
            {
                
                this.Width = 384;
                try
                {
                    if (idCliente != null && mes != null && anio != null)
                    {

                        anteriorMes = mes;
                        anteriorAnio = anio;

                        ObtenerDatosMensualidad(idCliente, mes, anio);

                        if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
                        {
                            //Mensualidad existente
                            cobroNUD.Value = (decimal)datosMensualidad.Rows[0]["valor"];
                            descuentoNUD.Value = (decimal)datosMensualidad.Rows[0]["descuento"];
                            mesCBX.SelectedIndex = int.Parse(datosMensualidad.Rows[0]["mes"].ToString()) - 1;
                            anioNUD.Value = int.Parse(datosMensualidad.Rows[0]["anio"].ToString());


                            if (datosMensualidad.Rows[0]["idPrefijada"] != DBNull.Value)
                            {
                                for (int i = 0; i < montos.Rows.Count; i++)
                                {
                                    if (montos.Rows[i]["id"].Equals(datosMensualidad.Rows[0]["idPrefijada"]))
                                    {
                                        cobroCBX.SelectedIndex = i + 1;
                                        break;
                                    } 
                                }
                            }

                            if (datosMensualidad.Rows[0]["idDescuento"] != DBNull.Value)
                            {
                                for (int i = 0; i < descuentos.Rows.Count; i++)
                                {
                                    if (descuentos.Rows[i]["id"].Equals(datosMensualidad.Rows[0]["idDescuento"]))
                                    {
                                        descuentoCBX.SelectedIndex = i + 2;
                                        break;
                                    }
                                }
                            }

                            if (datosMensualidad.Rows[0]["vencimiento"] == DBNull.Value)
                            {
                                vencimientoDTP.Enabled = false;
                            }
                            else
                            {
                                vencimientoDTP.Enabled = true;
                                vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[0]["vencimiento"];
                            }
                        }
                        else
                        {
                            //Mensualidad nueva
                            datosMensualidad = null;
                            mesCBX.SelectedIndex = int.Parse(mes) - 1;
                            anioNUD.Value = int.Parse(anio);
                            vencimientoDTP.Value = DateTime.ParseExact(DateTime.Today.Day + "/" + mes + "/" + anio, "d/M/yyyy", CultureInfo.InvariantCulture);
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
                    if (idCliente != null && mes != null && anio != null)
                    {
                        anteriorMes = mes;
                        anteriorAnio = anio;
                        xMesesPNL.Visible = false;
                        ObtenerDatosMensualidad(idCliente, mes, anio);

                        if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
                        {
                            cobroNUD.Value = (decimal)datosMensualidad.Rows[0]["valor"];
                            descuentoNUD.Value = (decimal)datosMensualidad.Rows[0]["descuento"];
                            mesCBX.SelectedIndex = int.Parse(datosMensualidad.Rows[0]["mes"].ToString()) - 1;
                            anioNUD.Value = int.Parse(datosMensualidad.Rows[0]["anio"].ToString());
                            if (datosMensualidad.Rows[0]["vencimiento"] == DBNull.Value)
                            {
                                vencimientoDTP.Enabled = false;
                            }
                            else
                            {
                                vencimientoDTP.Enabled = true;
                                vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[0]["vencimiento"];
                            }
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
                

            

            ActualizarTotal();

        }

        private void EstablecerInterfaz()
        {
            descuentos = sql.Obtener("SELECT id,nombre, porcentaje, CONCAT(nombre, ' -', porcentaje, '%') AS 'todo' FROM Descuentos");
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
        

        private void ObtenerDatosMensualidad(string idCliente, string mes, string anio)
        {
            string consulta = "SELECT Mensualidades.idCliente,Mensualidades.mes,Mensualidades.anio, valor, descuento, fechaIngreso, vencimiento, pagado, (valor - valor * (descuento / 100)) as total, CONVERT(DATE, CONCAT('01/', Mensualidades.mes, '/', Mensualidades.anio), 103) as mesAnio, idPrefijada, idDescuento " +
                "FROM (SELECT Mensualidades.idCliente,Mensualidades.mes,Mensualidades.anio, ISNULL(SUM(monto),0) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos " +
                "ON Pagos.idCliente = Mensualidades.idCliente AND Mensualidades.mes = Pagos.mesMensualidad AND Mensualidades.anio = Pagos.anioMensualidad " +
                "WHERE Mensualidades.idCliente = " + idCliente + " AND Mensualidades.mes = '" + mes + "' AND Mensualidades.anio = '" + anio +
                "' GROUP BY Mensualidades.idCliente,Mensualidades.mes,Mensualidades.anio) as MensualidadesPagos " +
                "INNER JOIN Mensualidades " +
                "ON MensualidadesPagos.idCliente = Mensualidades.idCliente AND Mensualidades.mes = MensualidadesPagos.mes AND Mensualidades.anio = MensualidadesPagos.anio ";
            
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

        private void ObtenerDatosCliente(string id)
        {
            idCliente = id;

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
            
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "valor", cobroNUD.Value },
                { "descuento", descuentoNUD.Value },
                { "fechaIngreso", DateTime.Today },
                { "vencimiento", vencimientoDTP.Value },
                { "entregaPago", entregaNUD.Value },
                { "fechaPago", pagoFechaDTP.Value },
                { "mes", (mesCBX.SelectedIndex + 1).ToString() },
                { "anio", anioNUD.Value.ToString() },
                { "idCliente", idCliente },
                { "idPrefijada", cobroCBX.SelectedIndex != 0 ? montos.Rows[cobroCBX.SelectedIndex - 1]["id"] : DBNull.Value},
                { "idDescuento", descuentoCBX.SelectedIndex > 1 ? descuentos.Rows[descuentoCBX.SelectedIndex - 2]["id"] : DBNull.Value}
            };


            string consulta;
            if (datosMensualidad != null)
            {

                consulta = "UPDATE Mensualidades SET valor = @valor, " +
                    "descuento = @descuento, fechaIngreso = @fechaIngreso, vencimiento = @vencimiento, mes = @mes, anio = @anio WHERE idCliente ='" + datosMensualidad.Rows[0]["idCliente"] + "' AND mes = '" + datosMensualidad.Rows[0]["mes"] + "' AND anio =" + datosMensualidad.Rows[0]["anio"];
            }
            else
            {
                consulta = "INSERT INTO Mensualidades (idCliente, mes, anio, valor, descuento, fechaIngreso, vencimiento, idPrefijada, idDescuento) VALUES(@idCliente, @mes, @anio, @valor, @descuento, @fechaIngreso, @vencimiento, @idPrefijada, @idDescuento);";
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
                            string otraConsulta = "SELECT Mensualidades.idCliente,Mensualidades.mes,Mensualidades.anio, fechaIngreso, vencimiento, pagado, (valor - valor * (descuento / 100)) as total " +
                    "FROM (SELECT Mensualidades.idCliente,Mensualidades.mes,Mensualidades.anio, ISNULL(SUM(monto),0) AS pagado " +
                    "FROM Mensualidades " +
                    "LEFT JOIN Pagos " +
                    "ON Pagos.idCliente = Mensualidades.idCliente AND Mensualidades.mes = Pagos.mesMensualidad AND Mensualidades.anio = Pagos.anioMensualidad " +
                    "WHERE Mensualidades.idCliente = '" + idCliente + "' AND Mensualidades.mes = '" + mesAnio.Month + "' AND Mensualidades.anio = '" + mesAnio.Year +
                    "' GROUP BY Mensualidades.idCliente,Mensualidades.mes,Mensualidades.anio) as MensualidadesPagos " +
                    "INNER JOIN Mensualidades " +
                    "ON MensualidadesPagos.idCliente = Mensualidades.idCliente AND Mensualidades.mes = MensualidadesPagos.mes AND Mensualidades.anio = MensualidadesPagos.anio ";
                            DataTable mensualidadSiguiente = sql.Obtener(otraConsulta);
                            parametros.Add("mes" + i, mesAnio.Month.ToString());
                            parametros.Add("anio" + i, mesAnio.Year.ToString());
                            if (mensualidadSiguiente.Rows.Count > 0)
                            {
                                parametros.Add("entregaPago" + i, Math.Min((decimal)mensualidadSiguiente.Rows[0]["total"] - (decimal)mensualidadSiguiente.Rows[0]["pagado"], sobrante));

                                consulta += " INSERT INTO Pagos (idCliente, mesMensualidad, anioMensualidad, monto, fecha) VALUES(@idCliente, @mes" + i + ", @anio" + i + ", @entregaPago" + i + ", @fechaPago);";
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
                    consulta += " INSERT INTO Pagos (idCliente, mesMensualidad, anioMensualidad, monto, fecha) VALUES(@idCliente, @mes, @anio, @entregaPago, @fechaPago);";
                    consulta += " EXEC ComprobarMensualidades @c = @idCliente";
                    sql.Modificar(consulta, parametros);
                    MessageBox.Show(this, "Pago adjuntado con exito", "Datos guardados con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                if (tipo == TipoPagoMensualidad.EditarMensualidad)
                {
                    consulta+= " EXEC ComprobarMensualidades @c = @idCliente";        
                    sql.Modificar(consulta, parametros);
                    consulta = "INSERT INTO Mensualidades (idCliente, mes, anio, valor, fechaIngreso, vencimiento, idPrefijada, idDescuento) VALUES(@idCliente, @mes, @anio, @valor, @fechaIngreso, @vencimiento, @idPrefijada, @idDescuento);";

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
                        
                        parametros["vencimiento"] = ((DateTime)parametros["vencimiento"]).NextMonth(); 
                        mes++;


                        try
                        {
                            
                            sql.Modificar(consulta, parametros);
                            texto += "\n Mes " + parametros["mes"] + " del año " + parametros["anio"] + " a cobrar " + totalTbx.Text + " vencimiento " + (parametros["vencimiento"] != DBNull.Value ? ((DateTime)parametros["vencimiento"]).ToString("dd/M/yyyy") : ": Sin vecimiento");
                        }

                        catch (SqlException exc)
                        {
                            if (exc.Number == 2627) { texto += "\nLa cuota del mes " + parametros["mes"] + " del año " + parametros["anio"] + " no se pudo crear, ya existe otra en su lugar, si desea modificarla edítala desde el listado"; }
                            else MessageBox.Show("La cuota del mes " + parametros["mes"] + " del año " + parametros["anio"] + " no se agregó " + exc.Message, "Error de base datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sql.CerrarConexion();
                        }


                    }


                    if (MessageBox.Show(texto + "\n ¿Desea adjuntar un pago a la cuota?", "Datos guardados con éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        ObtenerDatosMensualidad(idCliente, (mesCBX.SelectedIndex + 1).ToString(), anioNUD.Value.ToString());
                        xMesesPNL.Visible = false;
                        xMesesNUD.Value = 1;
                        this.Width = 589;
                        tipo = TipoPagoMensualidad.NuevoPago;
                        return;

                    }
                    
                    this.Close();
                    this.DialogResult = DialogResult.OK;



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


        private void verClienteCompleto_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = sql.Obtener("SELECT nombre,apellido FROM Clientes WHERE id=" + idCliente);
                if (datos.Rows.Count == 0)
                {
                    return;
                }
                using (DatosCliente nuevaVentana = new DatosCliente(idCliente, false))
                {
                    nuevaVentana.ShowDialog();
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
                DataTable otraMensualidad = sql.Obtener("SELECT * FROM Mensualidades WHERE idCliente = '" + idCliente + "' AND mes = '" + (mesCBX.SelectedIndex + 1) + "' AND anio = '" + anioNUD.Value + "'");
                resultado = otraMensualidad.Rows.Count == 0 || (datosMensualidad != null && datosMensualidad.Rows[0]["idCliente"].ToString() == idCliente
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
