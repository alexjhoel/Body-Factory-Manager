using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Listado : UserControl
    {
        public DataTable datos;
        private int dias = -1;
        string identificador;
        Transicion transicion = new Transicion(1);
        bool estado;
        int indexToSelect = 0;
        string propiedadOrden;
        SortOrder orden = SortOrder.None;
        List<ListadoButtonDatos> buttonsDatos;

        List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();

        private Action<string, SortOrder> Ordenar;
        private Action<FiltroBusqeda> Filtrar;

        public Listado(string identificador, List<ListadoButtonDatos> buttonsDatos, Action<string, SortOrder> Ordenar, List<FiltroBusqeda> filtros, Action<FiltroBusqeda> Filtrar, int filtroDefault = 0)

        {
            this.filtros = filtros;
            this.identificador = identificador;
            InitializeComponent();
            tablaDGV.RowTemplate.MinimumHeight = 35;

            foreach (FiltroBusqeda filtro in filtros)
            {
                filtrosCbx.Items.Add(filtro.textoAMostrar);
            }
            this.buttonsDatos = buttonsDatos;
            foreach (ListadoButtonDatos data in buttonsDatos)
            {
                Button button = new Button();
                button.Image = new Bitmap(data.icon, new Size(30, 30));
                button.Text = data.texto;
                button.BackColor = System.Drawing.Color.Red;
                button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Bebas Neue", data.fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                button.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
                button.Margin = new System.Windows.Forms.Padding(5);
                button.Size = new System.Drawing.Size(opcionesFLP.Height - 6, opcionesFLP.Height - 6);
                button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                button.UseVisualStyleBackColor = false;
                button.Anchor = AnchorStyles.None;
                button.Click += delegate (object sender, EventArgs e)
                {
                    
                    if (tablaDGV.SelectedRows.Count >= 1)
                    {
                        data.onClick(((DataTable)tablaDGV.DataSource).Rows[tablaDGV.SelectedRows[0].Index][identificador].ToString());
                    }
                    else
                    {
                        data.onClick(String.Empty);
                    }
                };

                opcionesFLP.Controls.Add(button);

            }
            this.Ordenar = Ordenar;
            this.Filtrar = Filtrar;

            filtrosCbx.SelectedIndex = filtroDefault;
            ActualizarCambios();
            ActualizarBotonesDisponibles();


        }

        public void SetearButtons()
        {

        }
        public void EstablecerButtons()
        {

        }

        public void Recargar(string ocultar = null, int dias = -1)
        {

            if (tablaDGV.SelectedRows.Count > 0) indexToSelect = tablaDGV.SelectedRows[0].Index;

            tablaDGV.Columns.Clear();
            tablaDGV.DataSource = datos;
            /*foreach(DataGridViewColumn dc in tablaDGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            */
            //tablaDGV.Rows[index].Selected = true;

            if (ocultar != null)
            {
                tablaDGV.Columns[ocultar].Visible = false;
            }


            this.dias = dias;
            if(dias == -1) return;
            for (int i = 0; i < tablaDGV.Rows.Count; i++)
            {
                DateTime fecha = (DateTime)tablaDGV.Rows[i].Cells.GetCellValueFromColumnHeader("Vencimiento");
                if (DateTime.Now > fecha && double.Parse(datos.Rows[i]["Deuda($)"].ToString()) > 0)
                {
                    tablaDGV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;

                    continue;
                }
                if (fecha.Subtract(DateTime.Now).Days <= dias && double.Parse(datos.Rows[i]["Deuda($)"].ToString()) > 0)
                {
                    tablaDGV.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }

                tablaDGV.Rows[i].Selected = false;
            }


            
        }

        private void Listado_MouseMove(object sender, MouseEventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
        }

        private void timerTransicion_Tick(object sender, EventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
            if (estado && relativePoint.Y > this.Height - 80)
            {
                transicion.Establecer(0, 80);
                estado = false;
            }
            if (!estado && relativePoint.Y < this.Height - 80)
            {
                transicion.Establecer(80, 1);
                estado = true;
            }
            opcionesFLP.Height = (int)transicion.Avanzar();
            opcionesFLP.Location = new Point(0, this.Height + (int)transicion.Obtener() * (-1));
        }


        private void tablaDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dias == -1) return;
            DateTime fecha = (DateTime)tablaDGV.Rows[e.RowIndex].Cells.GetCellValueFromColumnHeader("Vencimiento");

            if (double.Parse(datos.Rows[e.RowIndex]["Deuda($)"].ToString()) > 0)
            {
                if (DateTime.Now > fecha)
                {
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;

                    return;
                }
                if (fecha.Subtract(DateTime.Now).Days <= dias)
                {
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }



        }

        private void tablaDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
            foreach (DataGridViewColumn dc in tablaDGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.Programmatic;
                dc.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            if (propiedadOrden != tablaDGV.Columns[e.ColumnIndex].Name || orden == SortOrder.None) orden = SortOrder.Descending;
            else if (orden == SortOrder.Descending) orden = SortOrder.Ascending;
            else if (orden == SortOrder.Ascending) orden = SortOrder.None;

            tablaDGV.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            propiedadOrden = tablaDGV.Columns[e.ColumnIndex].Name;
            Ordenar(propiedadOrden, orden);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FiltroBusqeda seleccionado = filtros[filtrosCbx.SelectedIndex - 1];
                FiltroBusqeda filtro = new FiltroBusqeda(seleccionado.tipo, "", seleccionado.propiedad);
                if (filtro.tipo == TipoFiltro.Fecha)
                {
                    filtro.valor1 = valor1DTP.Value.ToString("MM-dd-yyyy");
                }

                if (filtro.tipo == TipoFiltro.Numero)
                {
                    filtro.valor1 = valor1NUD.Value.ToString();
                }

                if (filtro.tipo == TipoFiltro.String)
                {
                    filtro.valor1 = valor1Tbx.Text;
                }

                if (filtro.tipo == TipoFiltro.NumeroRango)
                {
                    filtro.valor1 = valor1NUD.Value.ToString();
                    filtro.valor2 = valor2NUD.Value.ToString();
                }

                if (filtro.tipo == TipoFiltro.FechaRango)
                {
                    filtro.valor1 = valor1DTP.Value.ToString("MM-dd-yyyy");
                    filtro.valor2 = valor2DTP.Value.ToString("MM-dd-yyyy");
                }
                Filtrar(filtro);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            ActualizarBotonesDisponibles();
        }

        private void opcionesFLP_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ActualizarCambios() 
        {
            
            valor1Tbx.Clear();
            valor2Tbx.Clear();
            valor1NUD.Value = 0;
            valor2NUD.Value = 0;
            valor1DTP.Value = DateTime.Now;
            valor2DTP.Value = DateTime.Now;
            valor1Tbx.Hide();
            valor2Tbx.Hide();
            valor1NUD.Hide();
            valor2NUD.Hide();
            valor1DTP.Hide();
            valor2DTP.Hide();
            hastaLBL.Hide();

            if (filtrosCbx.SelectedIndex == 0)
            {
                Filtrar(new FiltroBusqeda(TipoFiltro.Nada));
                return;
            }

            if (filtros[filtrosCbx.SelectedIndex - 1].tipo == TipoFiltro.Fecha)
            {
                valor1DTP.Show();
                return;

            }

            if (filtros[filtrosCbx.SelectedIndex - 1].tipo == TipoFiltro.FechaRango)
            {
                valor1DTP.Show();
                valor2DTP.Show();
                hastaLBL.Show();
                return;
            }

            if (filtros[filtrosCbx.SelectedIndex - 1].tipo == TipoFiltro.Numero)
            {
                valor1NUD.Show();
                return;
            }

            if (filtros[filtrosCbx.SelectedIndex - 1].tipo == TipoFiltro.String)
            {
                valor1Tbx.Show();
                return;
            }

            if (filtros[filtrosCbx.SelectedIndex - 1].tipo == TipoFiltro.NumeroRango)
            {
                valor1NUD.Show();
                valor2NUD.Show();
                hastaLBL.Show();
                return;
            }
        }

        private void filtrosCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            ActualizarCambios();
        }


        private void ActualizarBotonesDisponibles()
        {
            if (tablaDGV.SelectedRows.Count == 0)
            {
                for (int i = 0; i < opcionesFLP.Controls.Count; i++)
                {
                    opcionesFLP.Controls[i].Enabled = !buttonsDatos[i].requiereSeleccion;
                }
            }
            else
            {
                foreach (Control c in opcionesFLP.Controls)
                {
                    c.Enabled = true;
                }
            }
            
        }

        private void tablaDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                tablaDGV.CurrentCell = tablaDGV.Rows[indexToSelect].Cells[1];
            }
            catch
            {
                tablaDGV.CurrentCell = null;
            }

            ActualizarBotonesDisponibles();
        }

        private void tablaDGV_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotonesDisponibles();
        }
    }

    public class ListadoButtonDatos
    {
        public ListadoButtonDatos(bool requiereSeleccion, string texto, Image icon, Action<string> onClick, float fontSize = 12)
        {
            this.texto = texto;
            this.icon = icon;
            this.onClick = onClick;
            this.fontSize = fontSize;
            this.requiereSeleccion = requiereSeleccion;
        }

        public bool requiereSeleccion;
        public Image icon;
        public string texto;
        public Action<string> onClick;
        public float fontSize;
    }

    public class FiltroBusqeda
    {
        public string textoAMostrar = "";
        public string propiedad;
        public string valor1;
        public string valor2;
        public TipoFiltro tipo = TipoFiltro.Nada;

        public FiltroBusqeda(TipoFiltro tipo, string textoAMostrar = null, string propiedad = null)
        {
            this.textoAMostrar = textoAMostrar;
            this.propiedad = propiedad;
            this.tipo = tipo;
            valor1 = " ";
            valor2 = " ";
        }

        public string ObtenerWhereConsulta()
        {
            if (tipo == TipoFiltro.Nada) return "1=1";
            if (tipo == TipoFiltro.String) return propiedad + " LIKE '%" + valor1 + "%'";
            if (tipo == TipoFiltro.Fecha) return propiedad + "= '" + valor1 + "'";
            if (tipo == TipoFiltro.Numero) return propiedad + "=" + valor1;
            if (tipo == TipoFiltro.NumeroRango) return propiedad + " BETWEEN " + valor1 + " AND " + valor2;
            if (tipo == TipoFiltro.FechaRango) return propiedad + " BETWEEN '" + valor1 + "' AND '" + valor2 + "'";
            return "";
        }


    }

    public enum TipoFiltro
    {
        Nada,
        String,
        Fecha,
        Numero,
        NumeroRango,
        FechaRango
    }
}
