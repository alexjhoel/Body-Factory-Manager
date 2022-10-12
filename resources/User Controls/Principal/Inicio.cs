﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public enum TipoInicioSalida
    {
        Clientes,
        Mensualidades
    }
    public partial class Inicio : UserControl
    {
        SQL sql;
        bool horaPuntos;
        Comunicacion comunicacion = new Comunicacion();
        Action<TipoInicioSalida, string> salida;
        public Inicio(Action<TipoInicioSalida, string> salida)
        {
            InitializeComponent();
            this.salida = salida;
            sql = new SQL(Properties.Settings.Default.ConnectionString);

            CargarVencidas();
            CargarCumples();
            CargarGraficoIngresos();
            CargarGraficoClientes();
            fechaHoraLBL.Text = DateTime.Now.ToString("dddd");
        }

        private void CargarVencidas()
        {
            vencidasDGV.Columns.Clear();
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("hoy", DateTime.Now);
            string consulta = "SELECT FullMensualidades.id, cedula as Cedula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', vencimiento as Vencimiento " +
                "FROM(SELECT Mensualidades.id, pagado, valor, descuento, fechaCreado, vencimiento, cedulaCliente " +
                "FROM(SELECT Mensualidades.id, (ISNULL(SUM(monto), 0)) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id  " +
                "GROUP BY Mensualidades.id) AS PagosMensualidades " +
                "INNER JOIN Mensualidades ON PagosMensualidades.id = Mensualidades.id) as FullMensualidades " +
                "INNER JOIN Clientes on FullMensualidades.cedulaCliente = Clientes.cedula WHERE " +
                "((valor * (1 - descuento / 100)) - pagado) > 0 AND DATEDIFF(day, @hoy, vencimiento) < 5 " +
                "AND Clientes.esOculto = 0";

            vencidasDGV.DataSource = sql.Obtener(consulta, parametros);
            vencidasDGV.Columns[0].Visible = false;
        }

        private void CargarCumples()
        {
            cumplesDGV.Columns.Clear();
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("hoy", DateTime.Now);

            string consulta = "SELECT cedula as Cédula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', CONVERT(date, CONCAT(DAY(fechaNacimiento), '/', MONTH(fechaNacimiento), '/', YEAR(@hoy)), 103) as 'Cumpleaños'" +
                " FROM Clientes" +
                " WHERE DATEDIFF(day, @hoy, CONVERT(date, CONCAT(DAY(fechaNacimiento),'/',MONTH(fechaNacimiento),'/',YEAR(@hoy)), 103)) <= 5 " +
                "AND DATEDIFF(day, @hoy, CONVERT(date, CONCAT(DAY(fechaNacimiento),'/',MONTH(fechaNacimiento),'/',YEAR(@hoy)), 103)) >= -3;";
            cumplesDGV.DataSource = sql.Obtener(consulta, parametros);

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            if (horaPuntos) fechaHoraLBL.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'del' yyyy, HH:mm");
            else fechaHoraLBL.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'del' yyyy, HH mm");

            horaPuntos = !horaPuntos;
        }

        private void CargarGraficoIngresos()
        {
            try
            {

                for (int i = 0; i < 6; i++)
                {
                    int mes = DateTime.Now.Month - 5 + i;

                    DataTable total = sql.Obtener("SELECT MONTH(fecha) as Mes, SUM(monto) as Total FROM Pagos WHERE MONTH(fecha) = " + mes + "  GROUP BY MONTH(fecha)");

                    string mesString = DateTime.ParseExact("01/" + mes + "/2022", "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM");

                    mesString[0].ToString().ToUpper();

                    if (total.Rows.Count != 0)
                    {
                        ingresosCHT.Series["Total"].Points.AddXY(
                            mesString,
                        total.Rows[0]["Total"]);
                        continue;
                    }

                    ingresosCHT.Series["Total"].Points.AddXY(
                            mesString,
                        0);


                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error, al cargar el gráfico, inténtalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        private void CargarGraficoClientes()
        {
            try
            {

                for (int i = 0; i < 6; i++)
                {
                    int mes = DateTime.Now.Month - 5 + i;

                    DataTable total = sql.Obtener("SELECT MONTH(fechaIngreso) as Mes, COUNT(cedula) as Cantidad FROM Clientes WHERE MONTH(fechaIngreso) = " + mes + "  GROUP BY MONTH(fechaIngreso)");

                    string mesString = DateTime.ParseExact("01/" + mes + "/2022", "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM");

                    mesString[0].ToString().ToUpper();

                    if (total.Rows.Count != 0)
                    {
                        clientesNuevosCHT.Series["Total"].Points.AddXY(
                            mesString,
                        total.Rows[0]["Cantidad"]);
                        continue;
                    }

                    clientesNuevosCHT.Series["Total"].Points.AddXY(
                            mesString,
                        0);


                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error, al cargar el gráfico, inténtalo más tarde" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }
        }



        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void nuevoClienteBTN_Click(object sender, EventArgs e)
        {
            using (DatosCliente nuevaVentana = new DatosCliente())
            {
                nuevaVentana.ShowDialog();
            }

        }

        private void chatBTN_Click(object sender, EventArgs e)
        {
            using (SelectorClientes nuevaVentana = new SelectorClientes())
            {
                nuevaVentana.ShowDialog();
                if (nuevaVentana.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        comunicacion.Chatear(sql.Obtener("SELECT * FROM Clientes WHERE cedula =" + nuevaVentana.cedula).Rows[0]["telefono"].ToString());
                        MessageBox.Show("Abriendo ventana...");
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error, inténtalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.CerrarConexion();
                    }

                }
            }
        }

        private void asistenciaBTN_Click(object sender, EventArgs e)
        {

        }

        private void pagarCuotaBTN_Click(object sender, EventArgs e)
        {
            using (SelectorClientes nuevaVentana = new SelectorClientes())
            {
                nuevaVentana.ShowDialog();
                if (nuevaVentana.DialogResult == DialogResult.OK)
                {
                    using (DatosMensualidad datosMensualidad = new DatosMensualidad(nuevaVentana.cedula, TipoPagoMensualidad.PagarCuotaDesdeClientes))
                    {
                        datosMensualidad.ShowDialog();
                    }
                }
            }
        }

        private void verMasVencidasBTN_Click(object sender, EventArgs e)
        {
            salida(TipoInicioSalida.Mensualidades, ((DataTable)vencidasDGV.DataSource).Rows[vencidasDGV.SelectedRows[0].Index]["cedula"].ToString());
        }

        private void verMasCumplesBTN_Click(object sender, EventArgs e)
        {
            salida(TipoInicioSalida.Clientes, ((DataTable)vencidasDGV.DataSource).Rows[vencidasDGV.SelectedRows[0].Index]["cedula"].ToString());
        }
    }
}
