using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionAsistencias : UserControl
    {
        SQL sql;
        DataTable asistencias;
        bool estado;
        Transicion transicion;
        int tiempoMouse;
        const int tiempoParaSubir = 50;
        public SeccionAsistencias()
        {
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            mesCBX.SelectedIndex = 0;
            for (int i = 0; i < 6; i++)
            {
                calendarioDGV.Rows.Add();
                calendarioDGV.Rows[i].Height = calendarioDGV.Columns[0].Width;

            }
            
            ActualizarAsistencias(true);
            transicion = new Transicion(1);
        }

        private void Assitencias_Load(object sender, EventArgs e)
        {

        }


        private void MenuAsistencias_SizeChanged(object sender, EventArgs e)
        {
            ActualizarTamanioCalendario();
        }


        private void ActualizarTamanioCalendario()
        {
            for (int i = 0; i < calendarioDGV.Rows.Count; i++)
            {
                calendarioDGV.Rows[i].Height = (calendarioDGV.Height - calendarioDGV.ColumnHeadersHeight) / 6;

            }

            for (int i = 0; i < calendarioDGV.Columns.Count; i++)
            {
                calendarioDGV.Columns[i].Width = calendarioDGV.Rows[0].Height;
            }
            calendarioDGV.Width = (calendarioDGV.Rows[0].Height + 1) * 7;

        }

        private void sigMesBTN_Click(object sender, EventArgs e)
        {
            if (mesCBX.SelectedIndex == 11)
            {
                anioNUD.Value++;
                mesCBX.SelectedIndex = 0;
            }
            else
            {
                mesCBX.SelectedIndex++;
            }
            ActualizarAsistencias(false);
        }

        private void antMesBTN_Click(object sender, EventArgs e)
        {
            if (mesCBX.SelectedIndex == 0)
            {
                anioNUD.Value--;
                mesCBX.SelectedIndex = 11;
            }
            else
            {
                mesCBX.SelectedIndex--;
            }
            ActualizarAsistencias(false);
        }

        private void mesCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarAsistencias(false);

        }

        private void anioNUD_ValueChanged(object sender, EventArgs e)
        {

            ActualizarAsistencias(false);

        }

        private void ActualizarAsistencias(bool selectHoy)
        {
            if (selectHoy)
            {
                mesCBX.SelectedIndex = DateTime.Now.Month - 1;
                anioNUD.Value = DateTime.Now.Year;
            }
            DataTable datos;
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("cedulaCliente", cedulaTBX.Text);
            parametros.Add("mes", mesCBX.SelectedIndex + 1);
            parametros.Add("anio", anioNUD.Value);
            asistencias = sql.Obtener("SELECT cedulaCliente, fecha, falta, observacion FROM Asistencias WHERE MONTH(fecha) = @mes AND YEAR(fecha) = @anio AND cedulaCliente = @cedulaCliente", parametros);

            for (int x = 0; x < calendarioDGV.Rows.Count; x++)
            {
                for (int y = 0; y < calendarioDGV.Columns.Count; y++)
                {
                    calendarioDGV.Rows[x].Cells[y].Tag = String.Empty;
                    calendarioDGV.Rows[x].Cells[y].Value = String.Empty;
                    calendarioDGV.Rows[x].Cells[y].Style.BackColor = Color.White;
                    calendarioDGV.Rows[x].Cells[y].Style.SelectionBackColor = Color.DarkGray;
                }
            }
            string fecha = "1/" + (mesCBX.SelectedIndex + 1) + "/" + anioNUD.Value;
            DateTime dia = DateTime.ParseExact(fecha, "d/M/yyyy", CultureInfo.InvariantCulture);

            int i = (int)dia.DayOfWeek;
            int indexAsistencias = 0;
            for (int j = 0; j < calendarioDGV.Rows.Count; j++)
            {
                for (; i < 7; i++)
                {
                    calendarioDGV.Rows[j].Cells[i].Value = dia.Day;
                    if (dia == DateTime.Today)
                    {
                        calendarioDGV.Rows[j].Cells[i].Style.SelectionBackColor = Color.DarkGray;
                        calendarioDGV.Rows[j].Cells[i].Style.BackColor = Color.DodgerBlue;
                        if (selectHoy){ calendarioDGV.Rows[j].Cells[i].Selected = true; }
                        
                    }
                    if (asistencias != null && indexAsistencias != asistencias.Rows.Count && ((DateTime)asistencias.Rows[indexAsistencias]["fecha"]).Day == dia.Day)
                    {
                        Color backColor = (bool)asistencias.Rows[indexAsistencias]["falta"] ? asistencias.Rows[indexAsistencias]["observacion"].ToString() != "" ? Color.Yellow : Color.Red : Color.Green;
                        calendarioDGV.Rows[j].Cells[i].Style.SelectionBackColor = backColor;
                        calendarioDGV.Rows[j].Cells[i].Tag = indexAsistencias;
                        calendarioDGV.Rows[j].Cells[i].Style.BackColor = backColor;
                        indexAsistencias++;
                    }

                    dia = dia.AddDays(1);

                    if (dia.Month != mesCBX.SelectedIndex + 1) return;

                }

                i = 0;

            }

        }

        private void UbicarFecha()
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

                        ActualizarAsistencias(true);
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


        private void timerTransicion_Tick(object sender, EventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
            if (estado && relativePoint.Y > this.Height - 80)
            {
                tiempoMouse++;
            }
            if (tiempoMouse >= tiempoParaSubir)
            {
                tiempoMouse = 0;
                transicion.Establecer(0, 80);
                estado = false;
            }
            if (!estado && relativePoint.Y < this.Height - 80)
            {
                tiempoMouse--;
                transicion.Establecer(80, 1);
                estado = true;
            }
            opcionesPNL.Height = (int)transicion.Avanzar();
            opcionesPNL.Location = new Point(0, this.Height + (int)transicion.Obtener() * (-1));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anotarBTN_Click(object sender, EventArgs e)
        {

            if (calendarioDGV.SelectedCells.Count > 0 && calendarioDGV.SelectedCells[0].Value != String.Empty)
            {
                string consulta = String.Empty;
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("cedulaCliente", cedulaTBX.Text);
                parametros.Add("fecha", DateTime.ParseExact(calendarioDGV.SelectedCells[0].Value + "/" + (mesCBX.SelectedIndex + 1) + "/" + anioNUD.Value, "d/M/yyyy", CultureInfo.InvariantCulture));
                if (calendarioDGV.SelectedCells[0].Tag == String.Empty)
                {
                    using (DatosAsistencia nuevaVentana = new DatosAsistencia(false, String.Empty))
                    {
                        nuevaVentana.ShowDialog();
                        if (nuevaVentana.DialogResult == DialogResult.OK)
                        {
                            parametros.Add("falta", nuevaVentana.faltaEstado);
                            parametros.Add("observacion", nuevaVentana.observacion);
                            consulta = "INSERT INTO Asistencias (cedulaCliente, fecha, falta, observacion) VALUES(@cedulaCliente, @fecha, @falta, @observacion)";
                        }
                    }
                }
                else
                {
                    DataRow fila = asistencias.Rows[(int)calendarioDGV.SelectedCells[0].Tag];
                    using (DatosAsistencia nuevaVentana = new DatosAsistencia((bool)fila["falta"], fila["observacion"].ToString()))
                    {
                        nuevaVentana.ShowDialog();
                        if (nuevaVentana.DialogResult == DialogResult.OK)
                        {
                            parametros.Add("falta", nuevaVentana.faltaEstado);
                            parametros.Add("observacion", nuevaVentana.observacion);
                            consulta = "UPDATE Asistencias SET falta = @falta, observacion = @observacion WHERE cedulaCliente = @cedulaCliente AND fecha = @fecha";

                        }
                        else if (nuevaVentana.DialogResult == DialogResult.No)
                        {
                            consulta = "DELETE Asistencias WHERE fecha = @fecha AND cedulaCliente = @cedulaCliente";
                        }
                    }
                }

                if (consulta == String.Empty) return;
                sql.Modificar(consulta, parametros);
                ActualizarAsistencias(false);



            }
        }

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            if (calendarioDGV.SelectedCells.Count > 0 && calendarioDGV.SelectedCells[0].Tag != String.Empty)
            {
                string consulta = String.Empty;
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("cedulaCliente", cedulaTBX.Text);
                parametros.Add("fecha", DateTime.ParseExact(calendarioDGV.SelectedCells[0].Value + "/" + (mesCBX.SelectedIndex + 1) + "/" + anioNUD.Value, "d/M/yyyy", CultureInfo.InvariantCulture));
                consulta = "DELETE Asistencias WHERE fecha = @fecha AND cedulaCliente = @cedulaCliente";
                sql.Modificar(consulta, parametros);
                ActualizarAsistencias(false);
            }




        }
    }
}
