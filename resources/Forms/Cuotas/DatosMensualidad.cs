﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosMensualidad : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);

        DataTable datosMensualidad;
        DataTable descuentos;
        DataTable montos;
        TipoPagoMensualidad tipo;

        string cedulaCliente = null;
        public DatosMensualidad(string id = null, TipoPagoMensualidad tipo = TipoPagoMensualidad.PrimerPago)
        {
            InitializeComponent();

            this.tipo = tipo;
            string consulta = "";

            if (id != null)
            {

                switch (tipo)
                {
                    case TipoPagoMensualidad.NuevaMensualidad:
                        buscarMensualidadBtn.Hide();
                        break;
                    case TipoPagoMensualidad.PrimerPago:
                        pagoTituloLBL.Text = "Primer pago";
                        buscarMensualidadBtn.Hide();
                        try
                        {
                            datosMensualidad = sql.Obtener("SELECT * FROM Mensualidades WHERE cedulaCliente = " + id + " ORDER BY id ASC");

                            cobroNUD.Value = decimal.Parse(datosMensualidad.Rows[1]["valor"].ToString());
                            descuentoNUD.Value = decimal.Parse(datosMensualidad.Rows[1]["descuento"].ToString());
                            adjudDTP.Value = (DateTime)datosMensualidad.Rows[1]["fechaCreado"];
                            vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[1]["vencimiento"];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sql.CerrarConexion();
                        }
                        break;
                    case TipoPagoMensualidad.PagarCuotaDesdeClientes:
                        consulta = "SELECT TOP 1 Mensualidades.id as id " +
                       "FROM(SELECT idMensualidad, SUM(monto) AS suma FROM Pagos GROUP BY idMensualidad) as PagosMensualidades " +
                       "RIGHT JOIN Mensualidades ON PagosMensualidades.idMensualidad = Mensualidades.id " +
                       "WHERE(suma < (valor - (valor * (descuento / 100))) OR suma IS null) and cedulaCliente = '" + id + "' " +
                       "ORDER BY CONVERT(DateTime, vencimiento, 103) asc";

                        break;
                    case TipoPagoMensualidad.PagarCuotaDesdeListado:
                        consulta = "SELECT * FROM Mensualidades WHERE id = " + id;
                        break;
                    case TipoPagoMensualidad.EditarMensualidad:
                        consulta = "SELECT * FROM Mensualidades WHERE id= " + id;
                        this.Width = 390;
                        break;
                }

                try
                {
                    if (tipo != TipoPagoMensualidad.PrimerPago)
                    {
                        DataTable datos = sql.Obtener(consulta);
                        if (datos == null || datos.Rows.Count == 0)
                        {
                            if (MessageBox.Show("¿Este cliente no cuenta con mensualidades por pagar, desea crear una?", "Cliente sin mensualidades", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                Dictionary<string, object> dic = new Dictionary<string, object>();
                                dic.Add("vencimiento", DateTimeUtilities.NextMonth(DateTime.Now));
                                dic.Add("fechaCreado", DateTime.Now);
                                dic.Add("cedulaCliente", id);
                                sql.Modificar("INSERT INTO Mensualidades (vencimiento, fechaCreado, cedulaCliente) VALUES(@vencimiento,@fechaCreado,@cedulaCliente)", dic);
                                datos = sql.Obtener("SELECT * FROM Mensualidades WHERE cedulaCliente = " + id + " ORDER BY id DESC");
                                sql.CerrarConexion();
                            }
                            else
                            {
                                Load += (s, e) => Close();
                                return;
                            }
                        }
                        ObtenerDatosMensualidad(datos.Rows[0]["id"].ToString());
                        descuentoNUD.Value = decimal.Parse(datosMensualidad.Rows[0]["descuento"].ToString());
                        cobroNUD.Value = decimal.Parse(datosMensualidad.Rows[0]["valor"].ToString());
                        adjudDTP.Value = (DateTime)datosMensualidad.Rows[0]["fechaCreado"];
                        vencimientoDTP.Value = (DateTime)datosMensualidad.Rows[0]["vencimiento"];

                        totalTbx.Text = (cobroNUD.Value - cobroNUD.Value * (descuentoNUD.Value / 100)) + "";
                        if (tipo != TipoPagoMensualidad.EditarMensualidad)
                        {
                            entregaNUD.Value = cobroNUD.Value - cobroNUD.Value * (descuentoNUD.Value / 100) - decimal.Parse(datosMensualidad.Rows[0]["pagado"].ToString());
                            deudaLBL.Text = "0";
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
            if (tipo == TipoPagoMensualidad.PrimerPago)
            {
                entregaCBX.Items.Clear();
                entregaCBX.Items.Add("Entrega total");
                entregaCBX.Items.Add("Entrega parcial");
                entregaCBX.Items.Add("Paga después");
            }
            entregaCBX.SelectedIndex = 0;
        }

        private void EstablecerInterfaz()
        {
            string cedulaCliente = null;
            if (datosMensualidad != null && datosMensualidad.Rows.Count != 0)
            {
                cedulaCliente = datosMensualidad.Rows[0]["cedulaCliente"].ToString();
            }
            SelectorClientes selectorClientes;
            selectorClientes = new SelectorClientes(ObtenerDatosCliente, cedulaCliente);
            selectorClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            selectorClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            selectorClientes.Location = new System.Drawing.Point(-2, -2);
            selectorClientes.Margin = new System.Windows.Forms.Padding(0);
            selectorClientes.Size = new System.Drawing.Size(this.Width, 122);
            selectorClientes.TabIndex = 30;
            this.Controls.Add(selectorClientes);

            descuentos = sql.Obtener("SELECT nombre, porcentaje, CONCAT(nombre, ' -', porcentaje, '%') AS 'todo' FROM Descuentos");
            foreach (DataRow row in descuentos.Rows)
            {
                descuentosCBX.Items.Add(row["todo"]);


            }

            montos = sql.Obtener("SELECT id, nombre, valor, CONCAT(nombre, ' - $' ,valor) AS 'todo' FROM Prefijadas");
            foreach (DataRow row in montos.Rows)
            {
                cobroCBX.Items.Add(row["todo"]);


            }

            descuentosCBX.SelectedIndex = 0;
            cobroCBX.SelectedIndex = 0;
            entregaCBX.SelectedIndex = 0;

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
            if (descuentosCBX.SelectedIndex == 1) return;
            if (descuentosCBX.SelectedIndex == 0)
            {
                descuentoNUD.Value = 0;
                return;
            }
            descuentoNUD.Value = decimal.Parse(descuentos.Rows[descuentosCBX.SelectedIndex - 2]["porcentaje"].ToString());
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
                if (cobroNUD.Value == 0) descuentosCBX.SelectedIndex = 0; else descuentosCBX.SelectedIndex = 1;
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
                if (descuentoNUD.Value == 0) descuentosCBX.SelectedIndex = 0; else descuentosCBX.SelectedIndex = 1;
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
                parametros["cedulaCliente"] = cedulaCliente;
                consulta = "INSERT INTO Mensualidades (valor, descuento, fechaCreado, vencimiento, cedulaCliente) VALUES(@valor, @descuento, @adjudicado, @vencimiento, @cedulaCliente)";
                if (entregaCBX.SelectedIndex < 2)
                {
                    consulta += " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) VALUES(@entregaPago, @fechaPago, @cedulaCliente, SCOPE_IDENTITY());";
                }


            }


            if (tipo == TipoPagoMensualidad.PagarCuotaDesdeClientes)
            {
                consulta = " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) " +
                   "VALUES(@entregaPago, @fechaPago, @cedulaCliente, @idMensualidad);";

            }
            /*if (true)
            {

                 consulta = " INSERT INTO Pagos (monto, fecha, cedulaCliente, idMensualidad) " +
                    "VALUES(@entregaPago, @fechaPago, @cedulaCliente, @idMensualidad);";
                consulta += "EXEC ComprobarMensualidades @c = @cedulaCliente";
                //Actualizar mensualidad
                sql.Modificar(consulta, parametros);
            }
            */
            consulta += " EXEC ComprobarMensualidades @c = @cedulaCliente";
            try
            {
                sql.Modificar(consulta, parametros);

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

        }


    }

    public enum TipoPagoMensualidad
    {
        PrimerPago,
        PagarCuotaDesdeClientes,
        PagarCuotaDesdeListado,
        EditarMensualidad,
        NuevaMensualidad,
        NuevoPago
    }
}
