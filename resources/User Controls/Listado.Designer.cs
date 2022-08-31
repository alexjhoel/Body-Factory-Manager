namespace Body_Factory_Manager
{
    partial class Listado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcionesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.timerTransicion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.panelTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaDGV
            // 
            this.tablaDGV.AllowUserToAddRows = false;
            this.tablaDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tablaDGV.BackgroundColor = System.Drawing.Color.White;
            this.tablaDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDGV.ColumnHeadersHeight = 30;
            this.tablaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDGV.EnableHeadersVisualStyles = false;
            this.tablaDGV.GridColor = System.Drawing.Color.Black;
            this.tablaDGV.Location = new System.Drawing.Point(0, 0);
            this.tablaDGV.Margin = new System.Windows.Forms.Padding(0);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.ReadOnly = true;
            this.tablaDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaDGV.RowTemplate.Height = 35;
            this.tablaDGV.RowTemplate.ReadOnly = true;
            this.tablaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDGV.ShowEditingIcon = false;
            this.tablaDGV.Size = new System.Drawing.Size(751, 417);
            this.tablaDGV.TabIndex = 2;
            this.tablaDGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaDGV_ColumnHeaderMouseClick);
            this.tablaDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tablaDGV_RowPostPaint);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // opcionesFLP
            // 
            this.opcionesFLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opcionesFLP.Location = new System.Drawing.Point(0, 347);
            this.opcionesFLP.Name = "opcionesFLP";
            this.opcionesFLP.Size = new System.Drawing.Size(754, 70);
            this.opcionesFLP.TabIndex = 3;
            // 
            // panelTabla
            // 
            this.panelTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabla.AutoScroll = true;
            this.panelTabla.Controls.Add(this.tablaDGV);
            this.panelTabla.Location = new System.Drawing.Point(0, 0);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(751, 417);
            this.panelTabla.TabIndex = 4;
            // 
            // timerTransicion
            // 
            this.timerTransicion.Enabled = true;
            this.timerTransicion.Interval = 1;
            this.timerTransicion.Tick += new System.EventHandler(this.timerTransicion_Tick);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.opcionesFLP);
            this.Controls.Add(this.panelTabla);
            this.Name = "Listado";
            this.Size = new System.Drawing.Size(754, 420);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Listado_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.FlowLayoutPanel opcionesFLP;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Timer timerTransicion;
    }
}
