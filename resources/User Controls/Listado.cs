using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Listado : UserControl
    {
        public DataTable datos;
        public int dias = -1;
        string identificador;
        Transicion transicion = new Transicion(1);
        bool estado;

        string propiedadOrden;
        SortOrder orden = SortOrder.None;

        private Action<string, SortOrder> Ordenar;
        public Listado(string identificador, List<ListadoButtonDatos> buttonsDatos, Action<string,SortOrder> Ordenar)

        {
            this.identificador = identificador;
            InitializeComponent();
            tablaDGV.RowTemplate.MinimumHeight = 35;
            foreach (ListadoButtonDatos data in buttonsDatos)
            {
                Button button = new Button();
                button.Image = new Bitmap(data.icon, new Size(30, 30


                    ));
                button.Text = data.texto;
                button.BackColor = System.Drawing.Color.Red;
                button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
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
                };

                opcionesFLP.Controls.Add(button);
                
            }
            this.Ordenar = Ordenar;
        }

        public void SetearButtons()
        {

        }
        public void EstablecerButtons()
        {

        }

        public void Recargar(string ocultar = null, int dias = -1)
        {
            int index = 0;
            if (tablaDGV.SelectedRows.Count > 0) index = tablaDGV.SelectedRows[0].Index;

            tablaDGV.Columns.Clear();
            tablaDGV.DataSource = datos;
            /*foreach(DataGridViewColumn dc in tablaDGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            */
            //tablaDGV.Rows[index].Selected = true;
            if(ocultar != null)
            {
                tablaDGV.Columns[ocultar].Visible = false;
            }

            if (dias < 0) return;
            for (int i = 0; i < tablaDGV.Rows.Count; i++)
            {
                DateTime fecha = (DateTime)tablaDGV.Rows[i].Cells.GetCellValueFromColumnHeader("Vencimiento");
                if (DateTime.Now > fecha)
                {
                    tablaDGV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;

                    continue;
                }
                if (fecha.Subtract(DateTime.Now).Days <= dias)
                {
                    tablaDGV.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    tablaDGV.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;
                }


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
            opcionesFLP.Location = new Point(0,this.Height  + (int) transicion.Obtener() * (-1));
        }


        private void tablaDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dias == -1) return;
            DateTime fecha = (DateTime)tablaDGV.Rows[e.RowIndex].Cells.GetCellValueFromColumnHeader("Vencimiento");
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

        private void tablaDGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            return;
            foreach (DataGridViewColumn dc in tablaDGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.Programmatic;
                dc.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            if (propiedadOrden != tablaDGV.Columns[e.ColumnIndex].Name || orden == SortOrder.None) orden = SortOrder.Descending;
            else if  (orden == SortOrder.Descending) orden = SortOrder.Ascending;
            else if(orden == SortOrder.Ascending) orden = SortOrder.None;
            
            tablaDGV.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            propiedadOrden = tablaDGV.Columns[e.ColumnIndex].Name;
            Ordenar(propiedadOrden, orden);
        }
    }

    public class ListadoButtonDatos
    {
        public ListadoButtonDatos(string texto, Image icon, Action<string> onClick)
        {
            this.texto = texto;
            this.icon = icon;
            this.onClick = onClick;
        }

        public Image icon;
        public string texto;
        public Action<string> onClick;
    }
}
