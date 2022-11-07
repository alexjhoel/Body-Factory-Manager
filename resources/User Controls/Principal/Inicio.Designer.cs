
using System.Drawing;

namespace Body_Factory_Manager
{
    partial class Inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.fechaHoraLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vencidasDGV = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verMasVencidasBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clientesNuevosCHT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.verMasClientesNuevos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cumplesDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verMasCumplesBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.verMasIngresos = new System.Windows.Forms.Button();
            this.ingresosCHT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nuevoClienteBTN = new System.Windows.Forms.Button();
            this.chatBTN = new System.Windows.Forms.Button();
            this.pagarCuotaBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vencidasDGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesNuevosCHT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cumplesDGV)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosCHT)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, admin";
            // 
            // fechaHoraLBL
            // 
            this.fechaHoraLBL.AutoSize = true;
            this.fechaHoraLBL.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaHoraLBL.Location = new System.Drawing.Point(3, 54);
            this.fechaHoraLBL.Name = "fechaHoraLBL";
            this.fechaHoraLBL.Size = new System.Drawing.Size(213, 19);
            this.fechaHoraLBL.TabIndex = 1;
            this.fechaHoraLBL.Text = "Martes 13 de septiembre de 2022 10:30";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.vencidasDGV);
            this.panel1.Controls.Add(this.verMasVencidasBTN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 281);
            this.panel1.TabIndex = 0;
            // 
            // vencidasDGV
            // 
            this.vencidasDGV.AllowUserToAddRows = false;
            this.vencidasDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.vencidasDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.vencidasDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vencidasDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vencidasDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vencidasDGV.BackgroundColor = System.Drawing.Color.White;
            this.vencidasDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vencidasDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.vencidasDGV.ColumnHeadersHeight = 30;
            this.vencidasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vencidasDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.vencidasDGV.EnableHeadersVisualStyles = false;
            this.vencidasDGV.GridColor = System.Drawing.Color.Black;
            this.vencidasDGV.Location = new System.Drawing.Point(3, 38);
            this.vencidasDGV.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.vencidasDGV.Name = "vencidasDGV";
            this.vencidasDGV.ReadOnly = true;
            this.vencidasDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vencidasDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.vencidasDGV.RowHeadersVisible = false;
            this.vencidasDGV.RowTemplate.Height = 35;
            this.vencidasDGV.RowTemplate.ReadOnly = true;
            this.vencidasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vencidasDGV.ShowEditingIcon = false;
            this.vencidasDGV.Size = new System.Drawing.Size(285, 189);
            this.vencidasDGV.TabIndex = 19;
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
            // verMasVencidasBTN
            // 
            this.verMasVencidasBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verMasVencidasBTN.BackColor = System.Drawing.Color.Red;
            this.verMasVencidasBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verMasVencidasBTN.FlatAppearance.BorderSize = 0;
            this.verMasVencidasBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.verMasVencidasBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verMasVencidasBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verMasVencidasBTN.ForeColor = System.Drawing.Color.Black;
            this.verMasVencidasBTN.Location = new System.Drawing.Point(57, 230);
            this.verMasVencidasBTN.Name = "verMasVencidasBTN";
            this.verMasVencidasBTN.Size = new System.Drawing.Size(170, 44);
            this.verMasVencidasBTN.TabIndex = 18;
            this.verMasVencidasBTN.Text = "Ver más";
            this.verMasVencidasBTN.UseVisualStyleBackColor = false;
            this.verMasVencidasBTN.Click += new System.EventHandler(this.verMasVencidasBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 16F);
            this.label3.Location = new System.Drawing.Point(-1, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuotas vencidas y por vencer:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 595);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.clientesNuevosCHT);
            this.panel3.Controls.Add(this.verMasClientesNuevos);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(301, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 302);
            this.panel3.TabIndex = 1;
            // 
            // clientesNuevosCHT
            // 
            this.clientesNuevosCHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesNuevosCHT.BorderSkin.PageColor = System.Drawing.Color.MistyRose;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineWidth = 0;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineWidth = 0;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.Title = "Cantidad";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Bebas Neue", 12F);
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.clientesNuevosCHT.ChartAreas.Add(chartArea4);
            this.clientesNuevosCHT.Location = new System.Drawing.Point(10, 47);
            this.clientesNuevosCHT.Name = "clientesNuevosCHT";
            this.clientesNuevosCHT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.clientesNuevosCHT.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Name = "Total";
            this.clientesNuevosCHT.Series.Add(series4);
            this.clientesNuevosCHT.Size = new System.Drawing.Size(272, 208);
            this.clientesNuevosCHT.TabIndex = 19;
            this.clientesNuevosCHT.Text = "chart1";
            // 
            // verMasClientesNuevos
            // 
            this.verMasClientesNuevos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verMasClientesNuevos.BackColor = System.Drawing.Color.Red;
            this.verMasClientesNuevos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verMasClientesNuevos.FlatAppearance.BorderSize = 0;
            this.verMasClientesNuevos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.verMasClientesNuevos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verMasClientesNuevos.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verMasClientesNuevos.ForeColor = System.Drawing.Color.Black;
            this.verMasClientesNuevos.Location = new System.Drawing.Point(64, 255);
            this.verMasClientesNuevos.Name = "verMasClientesNuevos";
            this.verMasClientesNuevos.Size = new System.Drawing.Size(170, 44);
            this.verMasClientesNuevos.TabIndex = 18;
            this.verMasClientesNuevos.Text = "Ver más";
            this.verMasClientesNuevos.UseVisualStyleBackColor = false;
            this.verMasClientesNuevos.Click += new System.EventHandler(this.verMasClientesNuevos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 16F);
            this.label2.Location = new System.Drawing.Point(-5, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clientes nuevos últimos 6 meses";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cumplesDGV);
            this.panel2.Controls.Add(this.verMasCumplesBTN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(301, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 281);
            this.panel2.TabIndex = 1;
            // 
            // cumplesDGV
            // 
            this.cumplesDGV.AllowUserToAddRows = false;
            this.cumplesDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.cumplesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.cumplesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cumplesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cumplesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cumplesDGV.BackgroundColor = System.Drawing.Color.White;
            this.cumplesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cumplesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.cumplesDGV.ColumnHeadersHeight = 30;
            this.cumplesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cumplesDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.cumplesDGV.EnableHeadersVisualStyles = false;
            this.cumplesDGV.GridColor = System.Drawing.Color.Black;
            this.cumplesDGV.Location = new System.Drawing.Point(0, 38);
            this.cumplesDGV.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.cumplesDGV.Name = "cumplesDGV";
            this.cumplesDGV.ReadOnly = true;
            this.cumplesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cumplesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.cumplesDGV.RowHeadersVisible = false;
            this.cumplesDGV.RowTemplate.Height = 35;
            this.cumplesDGV.RowTemplate.ReadOnly = true;
            this.cumplesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cumplesDGV.ShowEditingIcon = false;
            this.cumplesDGV.Size = new System.Drawing.Size(292, 189);
            this.cumplesDGV.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cédula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // verMasCumplesBTN
            // 
            this.verMasCumplesBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verMasCumplesBTN.BackColor = System.Drawing.Color.Red;
            this.verMasCumplesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verMasCumplesBTN.FlatAppearance.BorderSize = 0;
            this.verMasCumplesBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.verMasCumplesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verMasCumplesBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verMasCumplesBTN.ForeColor = System.Drawing.Color.Black;
            this.verMasCumplesBTN.Location = new System.Drawing.Point(64, 230);
            this.verMasCumplesBTN.Name = "verMasCumplesBTN";
            this.verMasCumplesBTN.Size = new System.Drawing.Size(170, 44);
            this.verMasCumplesBTN.TabIndex = 18;
            this.verMasCumplesBTN.Text = "Ver más";
            this.verMasCumplesBTN.UseVisualStyleBackColor = false;
            this.verMasCumplesBTN.Click += new System.EventHandler(this.verMasCumplesBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 16F);
            this.label4.Location = new System.Drawing.Point(-5, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cumpleaños cercanos:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.verMasIngresos);
            this.panel4.Controls.Add(this.ingresosCHT);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 302);
            this.panel4.TabIndex = 0;
            // 
            // verMasIngresos
            // 
            this.verMasIngresos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verMasIngresos.BackColor = System.Drawing.Color.Red;
            this.verMasIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verMasIngresos.FlatAppearance.BorderSize = 0;
            this.verMasIngresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.verMasIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verMasIngresos.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verMasIngresos.ForeColor = System.Drawing.Color.Black;
            this.verMasIngresos.Location = new System.Drawing.Point(74, 255);
            this.verMasIngresos.Name = "verMasIngresos";
            this.verMasIngresos.Size = new System.Drawing.Size(170, 44);
            this.verMasIngresos.TabIndex = 18;
            this.verMasIngresos.Text = "Ver más";
            this.verMasIngresos.UseVisualStyleBackColor = false;
            this.verMasIngresos.Click += new System.EventHandler(this.verMasIngresos_Click);
            // 
            // ingresosCHT
            // 
            this.ingresosCHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingresosCHT.BorderSkin.PageColor = System.Drawing.Color.MistyRose;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.Title = "Total $";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Bebas Neue", 12F);
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.ingresosCHT.ChartAreas.Add(chartArea3);
            this.ingresosCHT.Location = new System.Drawing.Point(8, 41);
            this.ingresosCHT.Name = "ingresosCHT";
            this.ingresosCHT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ingresosCHT.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Name = "Total";
            this.ingresosCHT.Series.Add(series3);
            this.ingresosCHT.Size = new System.Drawing.Size(272, 208);
            this.ingresosCHT.TabIndex = 4;
            this.ingresosCHT.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 16F);
            this.label5.Location = new System.Drawing.Point(-1, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ingresos ($) últimos 6 meses";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.nuevoClienteBTN);
            this.flowLayoutPanel1.Controls.Add(this.chatBTN);
            this.flowLayoutPanel1.Controls.Add(this.pagarCuotaBTN);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(593, 79);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // nuevoClienteBTN
            // 
            this.nuevoClienteBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nuevoClienteBTN.BackColor = System.Drawing.Color.Red;
            this.nuevoClienteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuevoClienteBTN.FlatAppearance.BorderSize = 0;
            this.nuevoClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoClienteBTN.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoClienteBTN.Image = ((System.Drawing.Image)(resources.GetObject("nuevoClienteBTN.Image")));
            this.nuevoClienteBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoClienteBTN.Location = new System.Drawing.Point(5, 5);
            this.nuevoClienteBTN.Margin = new System.Windows.Forms.Padding(5);
            this.nuevoClienteBTN.Name = "nuevoClienteBTN";
            this.nuevoClienteBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.nuevoClienteBTN.Size = new System.Drawing.Size(69, 69);
            this.nuevoClienteBTN.TabIndex = 1;
            this.nuevoClienteBTN.Text = "Nuevo cliente";
            this.nuevoClienteBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoClienteBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevoClienteBTN.UseVisualStyleBackColor = false;
            this.nuevoClienteBTN.Click += new System.EventHandler(this.nuevoClienteBTN_Click);
            // 
            // chatBTN
            // 
            this.chatBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chatBTN.BackColor = System.Drawing.Color.Red;
            this.chatBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatBTN.FlatAppearance.BorderSize = 0;
            this.chatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatBTN.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Bold);
            this.chatBTN.Image = ((System.Drawing.Image)(resources.GetObject("chatBTN.Image")));
            this.chatBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chatBTN.Location = new System.Drawing.Point(84, 5);
            this.chatBTN.Margin = new System.Windows.Forms.Padding(5);
            this.chatBTN.Name = "chatBTN";
            this.chatBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.chatBTN.Size = new System.Drawing.Size(69, 69);
            this.chatBTN.TabIndex = 3;
            this.chatBTN.Text = "Chat";
            this.chatBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chatBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chatBTN.UseVisualStyleBackColor = false;
            this.chatBTN.Click += new System.EventHandler(this.chatBTN_Click);
            // 
            // pagarCuotaBTN
            // 
            this.pagarCuotaBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pagarCuotaBTN.BackColor = System.Drawing.Color.Red;
            this.pagarCuotaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pagarCuotaBTN.FlatAppearance.BorderSize = 0;
            this.pagarCuotaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagarCuotaBTN.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Bold);
            this.pagarCuotaBTN.Image = ((System.Drawing.Image)(resources.GetObject("pagarCuotaBTN.Image")));
            this.pagarCuotaBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pagarCuotaBTN.Location = new System.Drawing.Point(163, 5);
            this.pagarCuotaBTN.Margin = new System.Windows.Forms.Padding(5);
            this.pagarCuotaBTN.Name = "pagarCuotaBTN";
            this.pagarCuotaBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pagarCuotaBTN.Size = new System.Drawing.Size(69, 69);
            this.pagarCuotaBTN.TabIndex = 2;
            this.pagarCuotaBTN.Text = "Pagar cuota";
            this.pagarCuotaBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pagarCuotaBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pagarCuotaBTN.UseVisualStyleBackColor = false;
            this.pagarCuotaBTN.Click += new System.EventHandler(this.pagarCuotaBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 16F);
            this.label6.Location = new System.Drawing.Point(1, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Accesos directos:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.fechaHoraLBL);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(596, 500);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vencidasDGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesNuevosCHT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cumplesDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosCHT)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechaHoraLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView vencidasDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button verMasVencidasBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView cumplesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button verMasCumplesBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.DataVisualization.Charting.Chart ingresosCHT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button verMasClientesNuevos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button verMasIngresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button nuevoClienteBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pagarCuotaBTN;
        private System.Windows.Forms.Button chatBTN;
        private System.Windows.Forms.DataVisualization.Charting.Chart clientesNuevosCHT;
    }
}
