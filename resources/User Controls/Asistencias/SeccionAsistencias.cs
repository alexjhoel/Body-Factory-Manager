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

        string consulta = "";
        FiltroBusqeda filtro;

        string idCliente;

        public SeccionAsistencias()
        {
            this.filtro = new FiltroBusqeda(TipoFiltro.FechaRango, "", "fecha");
            this.filtro.valor1 = DateTime.Now.ToString("MM-dd-yyyy");
            this.filtro.valor2 = DateTime.Now.ToString("MM-dd-yyyy");
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            mesCBX.SelectedIndex = 0;
            for (int i = 0; i < 6; i++)
            {
                calendarioDGV.Rows.Add();
                calendarioDGV.Rows[i].Height = calendarioDGV.Columns[0].Width;

            }


            transicion = new Transicion(1);
            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();

            buttonDatos.Add(new ListadoButtonDatos(true, "Editar", Body_Factory_Manager.Properties.Resources.editar, Editar));
            buttonDatos.Add(new ListadoButtonDatos(true, "Borrar", Body_Factory_Manager.Properties.Resources.eliminar, Borrar));

            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();

            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cedula", "cedulaCliente"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre completo", "CONCAT(nombre, ' ', apellido)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha", "fecha"));


            listado = new Listado(new List<string>() { "idCliente", "Fecha" }, buttonDatos, 0, filtros, this.Filtrar, 3);

            listadoPNL.Controls.Add(listado);



            listado.Location = new Point(0, 0);
            listado.Dock = DockStyle.Fill;
            ActualizarAsistencias(true);

            ActualizarConsulta();
            ActualizarCliente(idCliente);

        }

        private void ActualizarCliente(string idCliente)
        {
            this.idCliente = idCliente;
            
            if (idCliente == null) return;
            nombreTBX.Text = sql.Obtener("SELECT CONCAT(nombre, ' ', apellido) as nombre FROM Clientes WHERE id=" + idCliente).Rows[0]["nombre"].ToString();

        }

        private void ActualizarDisponibilidadBotones()
        {
            int i = 0;
            foreach (Control c in opcionesPNL.Controls)
            {
                c.Enabled = nombreTBX.Text != "No encontrado" && calendarioDGV.SelectedCells.Count != 0;
                i++;
            }
        }

        private void ActualizarConsulta()
        {
            //Actualiza la consulta para cargar los datos a mostrar de la tabla
            consulta = "SELECT idCliente, cedula as Cédula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', fecha as 'Fecha', observacion as 'Observación', IIF(falta=1, 'Sí', 'No') as Falta " +
                "FROM Asistencias INNER JOIN Clientes ON Asistencias.idCliente = Clientes.id";

            consulta += " WHERE " + filtro.ObtenerWhereConsulta();
            if (!faltaCBX.Checked) consulta += " AND falta=" + 0;
            CargarListaAsistencias();
        }

        private void CargarListaAsistencias()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar(new List<string>() { "idCliente" });
        }

        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }

        private void Editar(Dictionary<string, object> datos)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                { "idCliente", int.Parse(datos["idCliente"].ToString()) },
                { "fecha", datos["Fecha"] }
            };
            DataTable datosAsistencia = sql.Obtener("SELECT * FROM Asistencias WHERE idCliente =@idCliente AND fecha=@fecha", dict);
            using (DatosAsistencia nuevaVentana = new DatosAsistencia((bool)datosAsistencia.Rows[0]["falta"], datosAsistencia.Rows[0]["observacion"].ToString()))
            {
                nuevaVentana.ShowDialog();
                dict.Add("observacion", nuevaVentana.observacion);
                dict.Add("falta", nuevaVentana.faltaEstado);
                if(nuevaVentana.DialogResult == DialogResult.OK)
                {
                    sql.Modificar("UPDATE Asistencias SET observacion=@observacion, falta=@falta WHERE idCliente = @idCliente AND fecha=@fecha", dict);
                    CargarListaAsistencias();
                    return;
                }
                
            }
            
            
        }

        private void Borrar(Dictionary<string, object> datos)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar los datos de asistencia?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Asistencias WHERE idCliente= '" + datos["id"] + "' AND fecha='" + ((DateTime)datos["Fecha"]).ToString("MM-dd-yyyy") + "'");
            CargarListaAsistencias();
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
            parametros.Add("idCliente", int.TryParse(idCliente, out int id) ? id : -1);
            parametros.Add("mes", mesCBX.SelectedIndex + 1);
            parametros.Add("anio", anioNUD.Value);
            asistencias = sql.Obtener("SELECT idCliente, fecha, falta, observacion FROM Asistencias WHERE MONTH(fecha) = @mes AND YEAR(fecha) = @anio AND idCliente = @idCliente", parametros);

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
            using (SelectorClientes listado = new SelectorClientes())
            {
                listado.ShowDialog();
                if (listado.DialogResult == DialogResult.OK)
                {
                    ActualizarCliente(listado.id);
                    ActualizarAsistencias(true);
                    ActualizarDisponibilidadBotones();
                }
            }
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
                parametros.Add("idCliente", int.Parse(idCliente));
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
                            consulta = "INSERT INTO Asistencias (idCliente, fecha, falta, observacion) VALUES(@idCliente, @fecha, @falta, @observacion)";
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
                            consulta = "UPDATE Asistencias SET falta = @falta, observacion = @observacion WHERE idCliente = @idCliente AND fecha = @fecha";

                        }
                        else if (nuevaVentana.DialogResult == DialogResult.No)
                        {
                            consulta = "DELETE Asistencias WHERE fecha = @fecha AND idCliente = @idCliente";
                        }
                    }
                }

                if (consulta == String.Empty) return;
                sql.Modificar(consulta, parametros);
                ActualizarAsistencias(false);
                ActualizarConsulta();



            }
        }

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            if (calendarioDGV.SelectedCells.Count > 0 && calendarioDGV.SelectedCells[0].Tag != String.Empty)
            {
                string consulta = String.Empty;
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("idCliente", int.Parse(idCliente));
                parametros.Add("fecha", DateTime.ParseExact(calendarioDGV.SelectedCells[0].Value + "/" + (mesCBX.SelectedIndex + 1) + "/" + anioNUD.Value, "d/M/yyyy", CultureInfo.InvariantCulture));
                consulta = "DELETE Asistencias WHERE fecha = @fecha AND idCliente = @idCliente";
                sql.Modificar(consulta, parametros);
                ActualizarAsistencias(false);
                ActualizarConsulta();
            }




        }

        private void faltaCBX_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void faltaBTN_Click(object sender, EventArgs e)
        {
            if (calendarioDGV.SelectedCells.Count > 0 && calendarioDGV.SelectedCells[0].Value != String.Empty)
            {
                string consulta = String.Empty;
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("idCliente", int.Parse(idCliente));
                parametros.Add("fecha", DateTime.ParseExact(calendarioDGV.SelectedCells[0].Value + "/" + (mesCBX.SelectedIndex + 1) + "/" + anioNUD.Value, "d/M/yyyy", CultureInfo.InvariantCulture));
                if (calendarioDGV.SelectedCells[0].Tag == String.Empty)
                {
                    parametros.Add("falta", false);
                    consulta = "INSERT INTO Asistencias (idCliente, fecha, falta) VALUES(@idCliente, @fecha, @falta)";
                }
                else
                {
                    parametros.Add("falta", !(bool)sql.Obtener("SELECT * FROM Asistencias WHERE idCliente = @idCliente AND fecha = @fecha", parametros).Rows[0]["falta"]);
                    consulta = "UPDATE Asistencias SET falta = @falta WHERE idCliente = @idCliente AND fecha = @fecha";
                    
                }

                if (consulta == String.Empty) return;
                sql.Modificar(consulta, parametros);
                ActualizarAsistencias(false);
                ActualizarConsulta();



            }
        }
    }
}
