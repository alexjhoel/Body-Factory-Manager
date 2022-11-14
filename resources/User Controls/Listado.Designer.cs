using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcionesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hastaLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valor2Tbx = new System.Windows.Forms.TextBox();
            this.filtrosCbx = new System.Windows.Forms.ComboBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.valor2DTP = new System.Windows.Forms.DateTimePicker();
            this.valor2NUD = new System.Windows.Forms.NumericUpDown();
            this.valor1NUD = new System.Windows.Forms.NumericUpDown();
            this.valor1Tbx = new System.Windows.Forms.TextBox();
            this.valor1DTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.panelTabla.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor1NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDGV
            // 
            this.tablaDGV.AllowUserToAddRows = false;
            this.tablaDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDGV.BackgroundColor = System.Drawing.Color.White;
            this.tablaDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDGV.EnableHeadersVisualStyles = false;
            this.tablaDGV.GridColor = System.Drawing.Color.Black;
            this.tablaDGV.Location = new System.Drawing.Point(0, 41);
            this.tablaDGV.Margin = new System.Windows.Forms.Padding(0);
            this.tablaDGV.MultiSelect = false;
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
            this.tablaDGV.RowHeadersVisible = false;
            this.tablaDGV.RowTemplate.Height = 35;
            this.tablaDGV.RowTemplate.ReadOnly = true;
            this.tablaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDGV.ShowEditingIcon = false;
            this.tablaDGV.Size = new System.Drawing.Size(751, 303);
            this.tablaDGV.TabIndex = 2;
            this.tablaDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDGV_CellDoubleClick);
            this.tablaDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tablaDGV_DataBindingComplete);
            this.tablaDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tablaDGV_RowPostPaint);
            this.tablaDGV.SelectionChanged += new System.EventHandler(this.tablaDGV_SelectionChanged);
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
            this.opcionesFLP.Paint += new System.Windows.Forms.PaintEventHandler(this.opcionesFLP_Paint);
            // 
            // panelTabla
            // 
            this.panelTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabla.AutoScroll = true;
            this.panelTabla.Controls.Add(this.panel1);
            this.panelTabla.Controls.Add(this.tablaDGV);
            this.panelTabla.Location = new System.Drawing.Point(0, 0);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(751, 417);
            this.panelTabla.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.hastaLBL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.valor2Tbx);
            this.panel1.Controls.Add(this.filtrosCbx);
            this.panel1.Controls.Add(this.buscarBtn);
            this.panel1.Controls.Add(this.valor2DTP);
            this.panel1.Controls.Add(this.valor2NUD);
            this.panel1.Controls.Add(this.valor1NUD);
            this.panel1.Controls.Add(this.valor1Tbx);
            this.panel1.Controls.Add(this.valor1DTP);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 38);
            this.panel1.TabIndex = 3;
            // 
            // hastaLBL
            // 
            this.hastaLBL.AutoSize = true;
            this.hastaLBL.Font = new System.Drawing.Font("Bebas Neue", 10F, System.Drawing.FontStyle.Bold);
            this.hastaLBL.Location = new System.Drawing.Point(456, 12);
            this.hastaLBL.Name = "hastaLBL";
            this.hastaLBL.Size = new System.Drawing.Size(36, 17);
            this.hastaLBL.TabIndex = 5;
            this.hastaLBL.Text = "Hasta";
            this.hastaLBL.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por:";
            // 
            // valor2Tbx
            // 
            this.valor2Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2Tbx.Location = new System.Drawing.Point(498, 6);
            this.valor2Tbx.Name = "valor2Tbx";
            this.valor2Tbx.Size = new System.Drawing.Size(160, 26);
            this.valor2Tbx.TabIndex = 3;
            this.valor2Tbx.Visible = false;
            // 
            // filtrosCbx
            // 
            this.filtrosCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filtrosCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filtrosCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrosCbx.FormattingEnabled = true;
            this.filtrosCbx.Items.AddRange(new object[] {
            "Sin filtros(Mostrar todo)"});
            this.filtrosCbx.Location = new System.Drawing.Point(110, 5);
            this.filtrosCbx.Name = "filtrosCbx";
            this.filtrosCbx.Size = new System.Drawing.Size(175, 28);
            this.filtrosCbx.TabIndex = 2;
            this.filtrosCbx.SelectionChangeCommitted += new System.EventHandler(this.filtrosCbx_SelectedIndexChanged);
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.Color.Red;
            this.buscarBtn.FlatAppearance.BorderSize = 0;
            this.buscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarBtn.Image = ((System.Drawing.Image)(resources.GetObject("buscarBtn.Image")));
            this.buscarBtn.Location = new System.Drawing.Point(664, 6);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(42, 26);
            this.buscarBtn.TabIndex = 0;
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // valor2DTP
            // 
            this.valor2DTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.valor2DTP.Location = new System.Drawing.Point(498, 6);
            this.valor2DTP.Name = "valor2DTP";
            this.valor2DTP.Size = new System.Drawing.Size(160, 26);
            this.valor2DTP.TabIndex = 9;
            this.valor2DTP.Visible = false;
            // 
            // valor2NUD
            // 
            this.valor2NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor2NUD.Location = new System.Drawing.Point(498, 6);
            this.valor2NUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valor2NUD.Name = "valor2NUD";
            this.valor2NUD.Size = new System.Drawing.Size(160, 26);
            this.valor2NUD.TabIndex = 7;
            this.valor2NUD.Visible = false;
            // 
            // valor1NUD
            // 
            this.valor1NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valor1NUD.Location = new System.Drawing.Point(291, 7);
            this.valor1NUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valor1NUD.Name = "valor1NUD";
            this.valor1NUD.Size = new System.Drawing.Size(160, 26);
            this.valor1NUD.TabIndex = 6;
            this.valor1NUD.Visible = false;
            // 
            // valor1Tbx
            // 
            this.valor1Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1Tbx.Location = new System.Drawing.Point(291, 6);
            this.valor1Tbx.Name = "valor1Tbx";
            this.valor1Tbx.Size = new System.Drawing.Size(160, 26);
            this.valor1Tbx.TabIndex = 1;
            this.valor1Tbx.Visible = false;
            // 
            // valor1DTP
            // 
            this.valor1DTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.valor1DTP.Location = new System.Drawing.Point(290, 6);
            this.valor1DTP.Name = "valor1DTP";
            this.valor1DTP.Size = new System.Drawing.Size(160, 26);
            this.valor1DTP.TabIndex = 8;
            this.valor1DTP.Visible = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor1NUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.FlowLayoutPanel opcionesFLP;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filtrosCbx;
        private System.Windows.Forms.TextBox valor1Tbx;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox valor2Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hastaLBL;
        private System.Windows.Forms.DateTimePicker valor1DTP;
        private System.Windows.Forms.NumericUpDown valor2NUD;
        private System.Windows.Forms.NumericUpDown valor1NUD;
        private System.Windows.Forms.DateTimePicker valor2DTP;
    }
}
