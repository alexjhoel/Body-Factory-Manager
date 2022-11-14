using System.Drawing;

namespace Body_Factory_Manager
{
    partial class SeccionMensualidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeccionMensualidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pagasCBX = new System.Windows.Forms.CheckBox();
            this.diasNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pestaniasTCL = new System.Windows.Forms.TabControl();
            this.porCliente = new System.Windows.Forms.TabPage();
            this.opcionesPNL = new System.Windows.Forms.Panel();
            this.verPagosBTN = new System.Windows.Forms.Button();
            this.pagarBTN = new System.Windows.Forms.Button();
            this.anotarBTN = new System.Windows.Forms.Button();
            this.borrarBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.anioNUD = new System.Windows.Forms.NumericUpDown();
            this.antMesBTN = new System.Windows.Forms.Button();
            this.sigMesBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.estadoPNL = new System.Windows.Forms.Panel();
            this.buscarClienteBTN = new System.Windows.Forms.Button();
            this.nombreTBX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cedulaTBX = new System.Windows.Forms.TextBox();
            this.todo = new System.Windows.Forms.TabPage();
            this.estadoLBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diasNUD)).BeginInit();
            this.pestaniasTCL.SuspendLayout();
            this.porCliente.SuspendLayout();
            this.opcionesPNL.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioNUD)).BeginInit();
            this.panel3.SuspendLayout();
            this.estadoPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pagasCBX);
            this.panel1.Controls.Add(this.diasNUD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 43);
            this.panel1.TabIndex = 8;
            // 
            // pagasCBX
            // 
            this.pagasCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagasCBX.AutoSize = true;
            this.pagasCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagasCBX.Location = new System.Drawing.Point(3, 7);
            this.pagasCBX.Name = "pagasCBX";
            this.pagasCBX.Size = new System.Drawing.Size(183, 24);
            this.pagasCBX.TabIndex = 0;
            this.pagasCBX.Text = "Mensualidades pagas";
            this.pagasCBX.UseVisualStyleBackColor = true;
            this.pagasCBX.CheckedChanged += new System.EventHandler(this.pagasCBX_CheckedChanged);
            // 
            // diasNUD
            // 
            this.diasNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasNUD.Location = new System.Drawing.Point(616, 5);
            this.diasNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.diasNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diasNUD.Name = "diasNUD";
            this.diasNUD.Size = new System.Drawing.Size(55, 26);
            this.diasNUD.TabIndex = 6;
            this.diasNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.diasNUD.ValueChanged += new System.EventHandler(this.diasNUD_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vencidas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(387, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por vencer dentro de ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(222, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "días";
            // 
            // pestaniasTCL
            // 
            this.pestaniasTCL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pestaniasTCL.Controls.Add(this.porCliente);
            this.pestaniasTCL.Controls.Add(this.todo);
            this.pestaniasTCL.Location = new System.Drawing.Point(0, 0);
            this.pestaniasTCL.Name = "pestaniasTCL";
            this.pestaniasTCL.SelectedIndex = 0;
            this.pestaniasTCL.Size = new System.Drawing.Size(846, 429);
            this.pestaniasTCL.TabIndex = 9;
            // 
            // porCliente
            // 
            this.porCliente.Controls.Add(this.opcionesPNL);
            this.porCliente.Controls.Add(this.tableLayoutPanel1);
            this.porCliente.Location = new System.Drawing.Point(4, 22);
            this.porCliente.Name = "porCliente";
            this.porCliente.Padding = new System.Windows.Forms.Padding(3);
            this.porCliente.Size = new System.Drawing.Size(838, 403);
            this.porCliente.TabIndex = 1;
            this.porCliente.Text = "Por cliente";
            this.porCliente.UseVisualStyleBackColor = true;
            // 
            // opcionesPNL
            // 
            this.opcionesPNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.opcionesPNL.Controls.Add(this.verPagosBTN);
            this.opcionesPNL.Controls.Add(this.pagarBTN);
            this.opcionesPNL.Controls.Add(this.anotarBTN);
            this.opcionesPNL.Controls.Add(this.borrarBTN);
            this.opcionesPNL.Location = new System.Drawing.Point(2, 329);
            this.opcionesPNL.Name = "opcionesPNL";
            this.opcionesPNL.Size = new System.Drawing.Size(837, 74);
            this.opcionesPNL.TabIndex = 7;
            // 
            // verPagosBTN
            // 
            this.verPagosBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verPagosBTN.BackColor = System.Drawing.Color.Red;
            this.verPagosBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verPagosBTN.FlatAppearance.BorderSize = 0;
            this.verPagosBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verPagosBTN.Font = new System.Drawing.Font("Bebas Neue", 11F, System.Drawing.FontStyle.Bold);
            this.verPagosBTN.Image = ((System.Drawing.Image)(resources.GetObject("verPagosBTN.Image")));
            this.verPagosBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verPagosBTN.Location = new System.Drawing.Point(151, 5);
            this.verPagosBTN.Margin = new System.Windows.Forms.Padding(5);
            this.verPagosBTN.Name = "verPagosBTN";
            this.verPagosBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.verPagosBTN.Size = new System.Drawing.Size(64, 64);
            this.verPagosBTN.TabIndex = 3;
            this.verPagosBTN.Text = "Ver pagos";
            this.verPagosBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verPagosBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.verPagosBTN.UseCompatibleTextRendering = true;
            this.verPagosBTN.UseVisualStyleBackColor = false;
            this.verPagosBTN.Click += new System.EventHandler(this.verPagosBTN_Click);
            // 
            // pagarBTN
            // 
            this.pagarBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pagarBTN.BackColor = System.Drawing.Color.Red;
            this.pagarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pagarBTN.FlatAppearance.BorderSize = 0;
            this.pagarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagarBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagarBTN.Image = ((System.Drawing.Image)(resources.GetObject("pagarBTN.Image")));
            this.pagarBTN.Location = new System.Drawing.Point(77, 5);
            this.pagarBTN.Margin = new System.Windows.Forms.Padding(5);
            this.pagarBTN.Name = "pagarBTN";
            this.pagarBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pagarBTN.Size = new System.Drawing.Size(64, 64);
            this.pagarBTN.TabIndex = 2;
            this.pagarBTN.Text = "Pagar";
            this.pagarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pagarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pagarBTN.UseCompatibleTextRendering = true;
            this.pagarBTN.UseVisualStyleBackColor = false;
            this.pagarBTN.Click += new System.EventHandler(this.pagarBTN_Click);
            // 
            // anotarBTN
            // 
            this.anotarBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.anotarBTN.BackColor = System.Drawing.Color.Red;
            this.anotarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anotarBTN.FlatAppearance.BorderSize = 0;
            this.anotarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anotarBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotarBTN.Image = ((System.Drawing.Image)(resources.GetObject("anotarBTN.Image")));
            this.anotarBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anotarBTN.Location = new System.Drawing.Point(3, 5);
            this.anotarBTN.Margin = new System.Windows.Forms.Padding(5);
            this.anotarBTN.Name = "anotarBTN";
            this.anotarBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.anotarBTN.Size = new System.Drawing.Size(64, 64);
            this.anotarBTN.TabIndex = 0;
            this.anotarBTN.Text = "Asignar";
            this.anotarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anotarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.anotarBTN.UseCompatibleTextRendering = true;
            this.anotarBTN.UseVisualStyleBackColor = false;
            this.anotarBTN.Click += new System.EventHandler(this.anotarBTN_Click);
            // 
            // borrarBTN
            // 
            this.borrarBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borrarBTN.BackColor = System.Drawing.Color.Red;
            this.borrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrarBTN.Enabled = false;
            this.borrarBTN.FlatAppearance.BorderSize = 0;
            this.borrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarBTN.Image = ((System.Drawing.Image)(resources.GetObject("borrarBTN.Image")));
            this.borrarBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarBTN.Location = new System.Drawing.Point(225, 5);
            this.borrarBTN.Margin = new System.Windows.Forms.Padding(5);
            this.borrarBTN.Name = "borrarBTN";
            this.borrarBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.borrarBTN.Size = new System.Drawing.Size(64, 64);
            this.borrarBTN.TabIndex = 1;
            this.borrarBTN.Text = "Borrar";
            this.borrarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.borrarBTN.UseCompatibleTextRendering = true;
            this.borrarBTN.UseVisualStyleBackColor = false;
            this.borrarBTN.Click += new System.EventHandler(this.borrarBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tablaDGV, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 326);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.Nombre,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
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
            this.tablaDGV.Location = new System.Drawing.Point(0, 82);
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
            this.tablaDGV.RowTemplate.Height = 30;
            this.tablaDGV.RowTemplate.ReadOnly = true;
            this.tablaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDGV.ShowEditingIcon = false;
            this.tablaDGV.Size = new System.Drawing.Size(837, 244);
            this.tablaDGV.TabIndex = 4;
            this.tablaDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tablaDGV_RowPostPaint);
            this.tablaDGV.SelectionChanged += new System.EventHandler(this.tablaDGV_SelectionChanged);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Mes";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Día de ingreso";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor($)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descuento(%)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total($)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda($)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vencimiento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha del pago";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.estadoPNL);
            this.panel2.Controls.Add(this.anioNUD);
            this.panel2.Controls.Add(this.antMesBTN);
            this.panel2.Controls.Add(this.sigMesBTN);
            this.panel2.Location = new System.Drawing.Point(271, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 36);
            this.panel2.TabIndex = 1;
            // 
            // anioNUD
            // 
            this.anioNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.anioNUD.Location = new System.Drawing.Point(63, 4);
            this.anioNUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.anioNUD.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.anioNUD.Name = "anioNUD";
            this.anioNUD.Size = new System.Drawing.Size(84, 29);
            this.anioNUD.TabIndex = 4;
            this.anioNUD.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.anioNUD.ValueChanged += new System.EventHandler(this.anioNUD_ValueChanged);
            // 
            // antMesBTN
            // 
            this.antMesBTN.BackColor = System.Drawing.Color.Red;
            this.antMesBTN.FlatAppearance.BorderSize = 0;
            this.antMesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.antMesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.antMesBTN.Location = new System.Drawing.Point(3, 4);
            this.antMesBTN.Name = "antMesBTN";
            this.antMesBTN.Size = new System.Drawing.Size(54, 29);
            this.antMesBTN.TabIndex = 1;
            this.antMesBTN.Text = "<";
            this.antMesBTN.UseVisualStyleBackColor = false;
            this.antMesBTN.Click += new System.EventHandler(this.antMesBTN_Click);
            // 
            // sigMesBTN
            // 
            this.sigMesBTN.BackColor = System.Drawing.Color.Red;
            this.sigMesBTN.FlatAppearance.BorderSize = 0;
            this.sigMesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sigMesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sigMesBTN.Location = new System.Drawing.Point(153, 5);
            this.sigMesBTN.Name = "sigMesBTN";
            this.sigMesBTN.Size = new System.Drawing.Size(52, 28);
            this.sigMesBTN.TabIndex = 0;
            this.sigMesBTN.Text = ">";
            this.sigMesBTN.UseVisualStyleBackColor = false;
            this.sigMesBTN.Click += new System.EventHandler(this.sigMesBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buscarClienteBTN);
            this.panel3.Controls.Add(this.nombreTBX);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cedulaTBX);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 34);
            this.panel3.TabIndex = 3;
            // 
            // estadoPNL
            // 
            this.estadoPNL.Controls.Add(this.estadoLBL);
            this.estadoPNL.Location = new System.Drawing.Point(211, 5);
            this.estadoPNL.Name = "estadoPNL";
            this.estadoPNL.Size = new System.Drawing.Size(73, 28);
            this.estadoPNL.TabIndex = 37;
            this.estadoPNL.Click += new System.EventHandler(this.estadoPanel_Click);
            // 
            // buscarClienteBTN
            // 
            this.buscarClienteBTN.BackColor = System.Drawing.Color.Red;
            this.buscarClienteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarClienteBTN.FlatAppearance.BorderSize = 0;
            this.buscarClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarClienteBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarClienteBTN.Location = new System.Drawing.Point(89, 2);
            this.buscarClienteBTN.Name = "buscarClienteBTN";
            this.buscarClienteBTN.Size = new System.Drawing.Size(78, 29);
            this.buscarClienteBTN.TabIndex = 36;
            this.buscarClienteBTN.Text = "Buscar";
            this.buscarClienteBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscarClienteBTN.UseVisualStyleBackColor = false;
            this.buscarClienteBTN.Click += new System.EventHandler(this.buscarClienteBTN_Click);
            // 
            // nombreTBX
            // 
            this.nombreTBX.AutoSize = true;
            this.nombreTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombreTBX.Location = new System.Drawing.Point(365, 6);
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(114, 20);
            this.nombreTBX.TabIndex = 35;
            this.nombreTBX.Text = "No encontrado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cliente:";
            // 
            // cedulaTBX
            // 
            this.cedulaTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTBX.Location = new System.Drawing.Point(173, 3);
            this.cedulaTBX.MaxLength = 8;
            this.cedulaTBX.Name = "cedulaTBX";
            this.cedulaTBX.Size = new System.Drawing.Size(186, 26);
            this.cedulaTBX.TabIndex = 32;
            this.cedulaTBX.TextChanged += new System.EventHandler(this.cedulaTBX_TextChanged);
            // 
            // todo
            // 
            this.todo.Location = new System.Drawing.Point(4, 22);
            this.todo.Name = "todo";
            this.todo.Padding = new System.Windows.Forms.Padding(3);
            this.todo.Size = new System.Drawing.Size(838, 403);
            this.todo.TabIndex = 0;
            this.todo.Text = "Todo";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // estadoLBL
            // 
            this.estadoLBL.AutoSize = true;
            this.estadoLBL.Font = new System.Drawing.Font("Bebas Neue", 16F, System.Drawing.FontStyle.Bold);
            this.estadoLBL.Location = new System.Drawing.Point(3, 1);
            this.estadoLBL.Name = "estadoLBL";
            this.estadoLBL.Size = new System.Drawing.Size(62, 26);
            this.estadoLBL.TabIndex = 34;
            this.estadoLBL.Text = "Activo";
            this.estadoLBL.Click += new System.EventHandler(this.estadoLBL_Click);
            // 
            // SeccionMensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pestaniasTCL);
            this.Controls.Add(this.panel1);
            this.Name = "SeccionMensualidades";
            this.Size = new System.Drawing.Size(846, 473);
            this.Load += new System.EventHandler(this.SeccionMensualidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diasNUD)).EndInit();
            this.pestaniasTCL.ResumeLayout(false);
            this.porCliente.ResumeLayout(false);
            this.opcionesPNL.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anioNUD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.estadoPNL.ResumeLayout(false);
            this.estadoPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Listado listado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox pagasCBX;
        private System.Windows.Forms.NumericUpDown diasNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl pestaniasTCL;
        private System.Windows.Forms.TabPage todo;
        private System.Windows.Forms.TabPage porCliente;
        private System.Windows.Forms.Panel opcionesPNL;
        private System.Windows.Forms.Button anotarBTN;
        private System.Windows.Forms.Button borrarBTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown anioNUD;
        private System.Windows.Forms.Button antMesBTN;
        private System.Windows.Forms.Button sigMesBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buscarClienteBTN;
        private System.Windows.Forms.Label nombreTBX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cedulaTBX;
        private System.Windows.Forms.Button verPagosBTN;
        private System.Windows.Forms.Button pagarBTN;
        private System.Windows.Forms.Panel estadoPNL;
        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label estadoLBL;
    }
}
