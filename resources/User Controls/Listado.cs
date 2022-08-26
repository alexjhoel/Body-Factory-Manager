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
        string identificador;
        Transicion transicion = new Transicion(1);
        bool estado;
        public Listado(string identificador, List<ListadoButtonDatos> buttonsDatos)

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
        }

        public void SetearButtons()
        {

        }
        public void EstablecerButtons()
        {

        }

        public void Recargar(string ocultar = null)
        {
            int index = 0;
            if (tablaDGV.SelectedRows.Count > 0) index = tablaDGV.SelectedRows[0].Index;

            tablaDGV.Columns.Clear();
            tablaDGV.DataSource = datos;
            //tablaDGV.Rows[index].Selected = true;
            if(ocultar != null)
            {
                tablaDGV.Columns[ocultar].Visible = false;
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

        public void PintarCeldasPorVencimiento(int dias)
        {
            for (int i = 0; i < ((DataTable)tablaDGV.DataSource).Rows[]; i++)
            {

            }
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
