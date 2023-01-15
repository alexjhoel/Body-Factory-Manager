using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionGraficos : UserControl
    {
        SQL sql;
        private Action[] establecerActions = new Action[6];
        private Action<int>[] cargarActions = new Action<int>[6];
        DateTime actualFecha = DateTime.Today;
        int zoom = 5;
        int actualValue;
        int selectedGraph;

        string idCliente;
        public SeccionGraficos()
        {
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            
            int select = 0;

            establecerActions[0] = EstablecerGraficoClientesNuevos;
            establecerActions[1] = EstablecerGraficoClientesEdades;
            establecerActions[2] = EstablecerGraficoIngresosTotales;
            establecerActions[3] = EstablecerGraficoGanancias;
            establecerActions[4] = EstablecerGraficoConcurrencia;
            establecerActions[5] = EstablecerGraficoConcurrenciaCliente;

            cargarActions[0] = CargarGraficoClientesNuevos;
            cargarActions[1] = CargarGraficoClientesEdades;
            cargarActions[2] = CargarGraficoIngresosTotales;
            cargarActions[3] = CargarGraficoGanancias;
            cargarActions[4] = CargarGraficoConcurrencia;
            cargarActions[5] = CargarGraficoConcurrenciaCliente;

            EstablecerGrafico(0);

            for (int i = 0; i < botonesPNL.Controls.Count; i++)
            {
                
            }
        }

        private void graficoDGV_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void EstablecerGrafico(int i)
        {
            actualFecha = DateTime.Now;

            selectedGraph = i;
            zoom = 5;
            establecerActions[i].Invoke();
            cargarActions[i].Invoke(0);
            if(intervalosCBX.Items.Count > 0) intervalosCBX.SelectedIndex = 0;

        }

        private void CargarGraficoConcurrencia(int cambio)
        {
            graficoDV.Series["Total"].Points.Clear();
            //graficoDV.Series.Add("Total");
            string consulta;

            /*if (intervalosCBX.SelectedIndex == 0)
            {
                actualFecha = actualFecha.AddDays(cambio * zoom / 2);
            }
            else */if (intervalosCBX.SelectedIndex == 1)
            {
                actualFecha = actualFecha.AddMonths(cambio);
            }
            else
            {
                actualFecha = actualFecha.AddYears(cambio);
            }

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            try
            {


                for (int i =  - zoom - 1; i < zoom; i++)
                {
                    /*if (intervalosCBX.SelectedIndex == 0)
                    {
                        DateTime actualFecha = this.actualFecha.AddDays(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT fecha as x, COUNT(*) as y FROM Asistencias" +
                        " WHERE fecha = @fechaActual AND falta=0 GROUP BY fecha";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = actualFecha.ToString("dd/MM/yyyy");
                        if (total.Rows.Count != 0)
                        {
                            
                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);
                    }
                    else */if (intervalosCBX.SelectedIndex == 0)
                    {
                        DateTime actualFecha = this.actualFecha.AddMonths(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT CONCAT(MONTH(fecha), ' ', YEAR(fecha)) as x, COUNT(*) as y FROM Asistencias" +
                        " WHERE MONTH(fecha) = MONTH(@fechaActual) AND YEAR(fecha) = YEAR(@fechaActual) AND falta=0 GROUP BY CONCAT(MONTH(fecha), ' ', YEAR(fecha))";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = DateTime.ParseExact("01/" + actualFecha.Month + "/" + actualFecha.Year, "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM yyyy");
                        
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);



                    }
                    else
                    {

                        DateTime actualFecha = this.actualFecha.AddYears(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT YEAR(fecha) as x, COUNT(*) as y FROM Asistencias" +
                        " WHERE YEAR(fecha) = YEAR(@fechaActual) AND falta=0 GROUP BY YEAR(fecha)";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = actualFecha.Year + "";
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);
                    }
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

        private void CargarGraficoConcurrenciaCliente(int cambio)
        {
            graficoDV.Series["Total"].Points.Clear();
            //graficoDV.Series.Add("Total");
            string consulta;

            if (intervalosCBX.SelectedIndex == 0)
            {
                actualFecha = actualFecha.AddMonths(cambio);
            }
            else
            {
                actualFecha = actualFecha.AddYears(cambio);
            }

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            try
            {


                for (int i =  - zoom - 1; i < zoom; i++)
                {

                    if (intervalosCBX.SelectedIndex == 0)
                    {
                        
                        DateTime actualFecha = this.actualFecha.AddMonths(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT CONCAT(MONTH(fecha), ' ', YEAR(fecha)) as x, COUNT(*) as y FROM Asistencias" +
                        " WHERE MONTH(fecha) = MONTH(@fechaActual) AND YEAR(fecha) = YEAR(@fechaActual) AND falta=0 AND idCliente = " + idCliente + " GROUP BY CONCAT(MONTH(fecha), ' ', YEAR(fecha))";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = DateTime.ParseExact("01/" + actualFecha.Month + "/" + actualFecha.Year, "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM yyyy");
                        
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);



                    }
                    else
                    {

                        DateTime actualFecha = this.actualFecha.AddYears(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT YEAR(fecha) as x, COUNT(*) as y FROM Asistencias" +
                        " WHERE YEAR(fecha) = YEAR(@fechaActual) AND falta=0 AND idCliente = " + idCliente + " GROUP BY YEAR(fecha)";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = actualFecha.Year + "";
                        
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);
                    }
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

        private void CargarGraficoIngresosTotales(int cambio)
        {
            graficoDV.Series["Total"].Points.Clear();
            //graficoDV.Series.Add("Total");
            string consulta;

            if (intervalosCBX.SelectedIndex == 0)
            {
                actualFecha = actualFecha.AddMonths(cambio);
            }
            else
            {
                actualFecha = actualFecha.AddYears(cambio);
            }

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            try
            {


                for (int i =  - zoom - 1; i < zoom; i++)
                {
                    
                    if (intervalosCBX.SelectedIndex == 0)
                    {
                        DateTime actualFecha = this.actualFecha.AddMonths(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT CONCAT(MONTH(fecha), ' ', YEAR(fecha)) as x, SUM(monto) as y FROM Pagos" +
                        " WHERE MONTH(fecha) = MONTH(@fechaActual) AND YEAR(fecha) = YEAR(@fechaActual) GROUP BY CONCAT(MONTH(fecha), ' ', YEAR(fecha))";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = DateTime.ParseExact("01/" + actualFecha.Month + "/" + actualFecha.Year, "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM yyyy");
                        
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);



                    }
                    else
                    {

                        DateTime actualFecha = this.actualFecha.AddYears(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT YEAR(fecha) as x, SUM(monto) as y FROM Pagos" +
                        " WHERE YEAR(fecha) = YEAR(@fechaActual) GROUP BY YEAR(fecha)";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = actualFecha.Year + "";
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);
                    }
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

        private void CargarGraficoGanancias(int cambio)
        {
            graficoDV.Series["Total"].Points.Clear();
            //graficoDV.Series.Add("Total");
            string consulta;

            if (intervalosCBX.SelectedIndex == 0)
            {
                actualFecha = actualFecha.AddMonths(cambio);
            }
            else
            {
                actualFecha = actualFecha.AddYears(cambio);
            }

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            try
            {


                for (int i = -zoom - 1; i < zoom; i++)
                {

                    if (intervalosCBX.SelectedIndex == 0)
                    {
                        DateTime actualFecha = this.actualFecha.AddMonths(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = " SELECT m.x, SUM(m.y) as y FROM(SELECT CONCAT(MONTH(fecha), ' ', YEAR(fecha)) as x, SUM(monto) as y FROM Pagos" +
                        " WHERE MONTH(fecha) = MONTH(@fechaActual) AND YEAR(fecha) = YEAR(@fechaActual) GROUP BY CONCAT(MONTH(fecha), ' ', YEAR(fecha)) " +
                        "UNION ALL SELECT CONCAT(MONTH(fecha), ' ', YEAR(fecha)) as x, SUM(monto) as y FROM EntradasSalidas " +
                        "WHERE MONTH(fecha) = MONTH(@fechaActual) AND YEAR(fecha) = YEAR(@fechaActual) GROUP BY CONCAT(MONTH(fecha), ' ', YEAR(fecha))) as m GROUP BY m.x";

                        
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = DateTime.ParseExact("01/" + actualFecha.Month + "/" + actualFecha.Year, "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM yyyy");
                        
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);



                    }
                    else
                    {

                        DateTime actualFecha = this.actualFecha.AddYears(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT m.x, SUM(m.y) as y FROM (SELECT YEAR(fecha) as x, SUM(monto) as y FROM Pagos" +
                        " WHERE YEAR(fecha) = YEAR(@fechaActual) GROUP BY YEAR(fecha) " +
                        "UNION ALL SELECT YEAR(fecha) as x, SUM(monto) as y FROM EntradasSalidas " +
                        " WHERE YEAR(fecha) = YEAR(@fechaActual) GROUP BY YEAR(fecha)) as m GROUP BY m.x"; 

                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = actualFecha.Year + "";
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);
                    }
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

        private void EstablecerGraficoConcurrencia()
        {
            graficoDV.ChartAreas[0].AxisX.Title = "";
            graficoDV.ChartAreas[0].AxisY.Title = "Concurrencia";

            intervalosCBX.Visible = true;

            intervalosCBX.Items.Clear();
            intervalosCBX.Items.Add("Por Meses");
            intervalosCBX.Items.Add("Por Años");



        }

        private void EstablecerGraficoIngresosTotales()
        {
            graficoDV.ChartAreas[0].AxisX.Title = "";
            graficoDV.ChartAreas[0].AxisY.Title = "Total($)";
            
            intervalosCBX.Visible = true;
            
            intervalosCBX.Items.Clear();
            intervalosCBX.Items.Add("Por Meses");
            intervalosCBX.Items.Add("Por Años");



        }

        private void EstablecerGraficoGanancias()
        {
            EstablecerGraficoIngresosTotales();



        }

        private void EstablecerGraficoConcurrenciaCliente()
        {
            graficoDV.ChartAreas[0].AxisX.Title = "";
            graficoDV.ChartAreas[0].AxisY.Title = "Concurrencia";

            intervalosCBX.Visible = true;

            intervalosCBX.Items.Clear();
            intervalosCBX.Items.Add("Por Meses");
            intervalosCBX.Items.Add("Por Años");



        }

        private void CargarGraficoClientesNuevos(int cambio)
        {
            graficoDV.Series["Total"].Points.Clear();
            //graficoDV.Series.Add("Total");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            string consulta;

            if (intervalosCBX.SelectedIndex == 0)
            {
                actualFecha = actualFecha.AddMonths(cambio);
            }
            else
            {
                actualFecha = actualFecha.AddYears(cambio);
            }
            try
            {


                for (int i = -zoom - 1; i < zoom; i++)
                {
                    if (intervalosCBX.SelectedIndex == 0)
                    {
                        DateTime actualFecha = this.actualFecha.AddMonths(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT CONCAT(MONTH(fechaIngreso), ' ', YEAR(fechaIngreso)) as x, COUNT(cedula) as y FROM Clientes" +
                        " WHERE MONTH(fechaIngreso) = MONTH(@fechaActual) AND YEAR(fechaIngreso) = YEAR(@fechaActual) GROUP BY CONCAT(MONTH(fechaIngreso), ' ', YEAR(fechaIngreso))";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = DateTime.ParseExact("01/" + actualFecha.Month + "/" + actualFecha.Year, "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM yyyy");
                        
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);

                        

                    }
                    else
                    {

                        DateTime actualFecha = this.actualFecha.AddYears(i);

                        parametros.Clear();
                        parametros.Add("fechaActual", actualFecha);
                        consulta = "SELECT YEAR(fechaIngreso) as x, COUNT(cedula) as y FROM Clientes" +
                        " WHERE YEAR(fechaIngreso) = YEAR(@fechaActual) GROUP BY YEAR(fechaIngreso)";
                        DataTable total = sql.Obtener(consulta, parametros);

                        string textFecha = actualFecha.Year + "";
                        if (total.Rows.Count != 0)
                        {

                            graficoDV.Series["Total"].Points.AddXY(textFecha,
                            total.Rows[0]["y"]);
                            continue;
                        }
                        graficoDV.Series["Total"].Points.AddXY(textFecha,
                            0);
                    }
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

        private void CargarGraficoClientesEdades(int cambio)
        {
            graficoDV.Series["Total"].Points.Clear();
            
            //graficoDV.Series.Add("Total");
            string consulta;

            actualValue += cambio;

            try
            {


                for (int edad = actualValue - zoom - 1; edad < actualValue + zoom; edad++)
                {
                    consulta = "Select floor((cast(convert(varchar(8), getdate(), 112) as int) - cast(convert(varchar(8), clientes.fechaNacimiento, 112) as int)) / 10000) as x," +
                        " COUNT(cedula) as y from Clientes " +
                        "WHERE floor((cast(convert(varchar(8), getdate(), 112) as int) - cast(convert(varchar(8), clientes.fechaNacimiento, 112) as int)) / 10000) = " + edad +  
                        " GROUP BY floor((cast(convert(varchar(8), getdate(), 112) as int) - cast(convert(varchar(8), clientes.fechaNacimiento, 112) as int)) / 10000)";
                    DataTable total = sql.Obtener(consulta);
                    if (total.Rows.Count != 0)
                    {

                        graficoDV.Series["Total"].Points.AddXY(edad,
                        total.Rows[0]["y"]);
                        continue;
                    }
                    graficoDV.Series["Total"].Points.AddXY(edad,
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

        private void EstablecerGraficoClientesNuevos()
        {
            graficoDV.ChartAreas[0].AxisX.Title = "";
            graficoDV.ChartAreas[0].AxisY.Title = "Cantidad";
            
            intervalosCBX.Visible = true;
            
            intervalosCBX.Items.Clear();
            intervalosCBX.Items.Add("Por Meses");
            intervalosCBX.Items.Add("Por Años");
            

           
        }

        private void EstablecerGraficoClientesEdades()
        {
            graficoDV.ChartAreas[0].AxisX.Title = "Edades";
            graficoDV.ChartAreas[0].AxisY.Title = "Cantidad";
            intervalosCBX.Visible = false;
            actualValue = 20;
            

            intervalosCBX.Items.Clear();



        }

        private void clientesNuevosBTN_Click(object sender, EventArgs e)
        {
                EstablecerGrafico(0);
                foreach (Control cont in botonesPNL.Controls)
                {
                    cont.BackColor = Color.Red;

                }
                ((Control)sender).BackColor = Color.White;
            
        }

        private void edadesBTN_Click(object sender, EventArgs e)
        {
            EstablecerGrafico(1);
            foreach (Control cont in botonesPNL.Controls)
            {
                cont.BackColor = Color.Red;

            }
                ((Control)sender).BackColor = Color.White;
        }

        private void ingresosTotalesBTN_Click(object sender, EventArgs e)
        {
            EstablecerGrafico(2);
            foreach (Control cont in botonesPNL.Controls)
            {
                cont.BackColor = Color.Red;

            }
                ((Control)sender).BackColor = Color.White;
        }

        private void concurrenciaBTN_Click(object sender, EventArgs e)
        {
            EstablecerGrafico(4);
            foreach (Control cont in botonesPNL.Controls)
            {
                cont.BackColor = Color.Red;

            }
                ((Control)sender).BackColor = Color.White;
        }

        private void concurrenciaClienteBTN_Click(object sender, EventArgs e)
        {
            using (SelectorClientes selectorClientes = new SelectorClientes())
            {
                if(selectorClientes.ShowDialog() == DialogResult.OK)
                {
                    idCliente = selectorClientes.id;
                    EstablecerGrafico(5);
                    foreach (Control cont in botonesPNL.Controls)
                    {
                        cont.BackColor = Color.Red;

                    }
                ((Control)sender).BackColor = Color.White;
                }
            }



                
        }

        private void avanzarBTN_Click(object sender, EventArgs e)
        {
            cargarActions[selectedGraph].Invoke(1);
        }

        private void retrocederBTN_Click(object sender, EventArgs e)
        {
            cargarActions[selectedGraph].Invoke(-1);
        }

        private void zoomMenosBTN_Click(object sender, EventArgs e)
        {
            zoom++;

            cargarActions[selectedGraph].Invoke(0);
        }

        private void zoomMasBTN_Click(object sender, EventArgs e)
        {

            zoom = Math.Max(1, zoom - 1);
            

            cargarActions[selectedGraph].Invoke(0);
        }

        private void intervalosCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarActions[selectedGraph].Invoke(0);
        }

        private void ganacniasBTN_Click(object sender, EventArgs e)
        {
            EstablecerGrafico(3);
            foreach (Control cont in botonesPNL.Controls)
            {
                cont.BackColor = Color.Red;

            }
                ((Control)sender).BackColor = Color.White;
        }
    }
}
