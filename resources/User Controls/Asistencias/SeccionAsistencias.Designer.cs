
using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    partial class SeccionAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeccionAsistencias));
            this.calendarioDGV = new System.Windows.Forms.DataGridView();
            this.domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anioNUD = new System.Windows.Forms.NumericUpDown();
            this.mesCBX = new System.Windows.Forms.ComboBox();
            this.antMesBTN = new System.Windows.Forms.Button();
            this.sigMesBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscarClienteBTN = new System.Windows.Forms.Button();
            this.nombreTBX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cedulaTBX = new System.Windows.Forms.TextBox();
            this.anotarBTN = new System.Windows.Forms.Button();
            this.borrarBTN = new System.Windows.Forms.Button();
            this.opcionesPNL = new System.Windows.Forms.Panel();
            this.faltaBTN = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.proCliente = new System.Windows.Forms.TabPage();
            this.todas = new System.Windows.Forms.TabPage();
            this.listadoPNL = new System.Windows.Forms.Panel();
            this.opcionesPNL2 = new System.Windows.Forms.Panel();
            this.faltaCBX = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioNUD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.opcionesPNL.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.proCliente.SuspendLayout();
            this.todas.SuspendLayout();
            this.opcionesPNL2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarioDGV
            // 
            this.calendarioDGV.AllowUserToAddRows = false;
            this.calendarioDGV.AllowUserToDeleteRows = false;
            this.calendarioDGV.AllowUserToResizeColumns = false;
            this.calendarioDGV.AllowUserToResizeRows = false;
            this.calendarioDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.calendarioDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.calendarioDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarioDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarioDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.calendarioDGV.ColumnHeadersHeight = 25;
            this.calendarioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calendarioDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domingo,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bebas Neue", 17F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calendarioDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.calendarioDGV.EnableHeadersVisualStyles = false;
            this.calendarioDGV.GridColor = System.Drawing.Color.Black;
            this.calendarioDGV.Location = new System.Drawing.Point(207, 85);
            this.calendarioDGV.MaximumSize = new System.Drawing.Size(999999, 500);
            this.calendarioDGV.MultiSelect = false;
            this.calendarioDGV.Name = "calendarioDGV";
            this.calendarioDGV.ReadOnly = true;
            this.calendarioDGV.RowHeadersVisible = false;
            this.calendarioDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.calendarioDGV.Size = new System.Drawing.Size(294, 296);
            this.calendarioDGV.TabIndex = 2;
            // 
            // domingo
            // 
            this.domingo.FillWeight = 33F;
            this.domingo.HeaderText = "DO";
            this.domingo.Name = "domingo";
            this.domingo.ReadOnly = true;
            this.domingo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.domingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.domingo.Width = 42;
            // 
            // lunes
            // 
            this.lunes.FillWeight = 33F;
            this.lunes.HeaderText = "LU";
            this.lunes.Name = "lunes";
            this.lunes.ReadOnly = true;
            this.lunes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lunes.Width = 42;
            // 
            // martes
            // 
            this.martes.FillWeight = 33F;
            this.martes.HeaderText = "MA";
            this.martes.Name = "martes";
            this.martes.ReadOnly = true;
            this.martes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.martes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.martes.Width = 42;
            // 
            // miercoles
            // 
            this.miercoles.FillWeight = 33F;
            this.miercoles.HeaderText = "MI";
            this.miercoles.Name = "miercoles";
            this.miercoles.ReadOnly = true;
            this.miercoles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.miercoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.miercoles.Width = 41;
            // 
            // jueves
            // 
            this.jueves.FillWeight = 33F;
            this.jueves.HeaderText = "JU";
            this.jueves.Name = "jueves";
            this.jueves.ReadOnly = true;
            this.jueves.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.jueves.Width = 42;
            // 
            // viernes
            // 
            this.viernes.FillWeight = 33F;
            this.viernes.HeaderText = "VI";
            this.viernes.Name = "viernes";
            this.viernes.ReadOnly = true;
            this.viernes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.viernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.viernes.Width = 42;
            // 
            // sabado
            // 
            this.sabado.FillWeight = 33F;
            this.sabado.HeaderText = "SA";
            this.sabado.Name = "sabado";
            this.sabado.ReadOnly = true;
            this.sabado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sabado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sabado.Width = 42;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.anioNUD);
            this.panel1.Controls.Add(this.mesCBX);
            this.panel1.Controls.Add(this.antMesBTN);
            this.panel1.Controls.Add(this.sigMesBTN);
            this.panel1.Location = new System.Drawing.Point(181, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 36);
            this.panel1.TabIndex = 1;
            // 
            // anioNUD
            // 
            this.anioNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.anioNUD.Location = new System.Drawing.Point(198, 3);
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
            // mesCBX
            // 
            this.mesCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mesCBX.FormattingEnabled = true;
            this.mesCBX.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.mesCBX.Location = new System.Drawing.Point(62, 3);
            this.mesCBX.Name = "mesCBX";
            this.mesCBX.Size = new System.Drawing.Size(121, 28);
            this.mesCBX.TabIndex = 3;
            this.mesCBX.SelectedIndexChanged += new System.EventHandler(this.mesCBX_SelectedIndexChanged);
            // 
            // antMesBTN
            // 
            this.antMesBTN.BackColor = System.Drawing.Color.Red;
            this.antMesBTN.FlatAppearance.BorderSize = 0;
            this.antMesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.antMesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.antMesBTN.Location = new System.Drawing.Point(2, 3);
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
            this.sigMesBTN.Location = new System.Drawing.Point(288, 3);
            this.sigMesBTN.Name = "sigMesBTN";
            this.sigMesBTN.Size = new System.Drawing.Size(52, 28);
            this.sigMesBTN.TabIndex = 0;
            this.sigMesBTN.Text = ">";
            this.sigMesBTN.UseVisualStyleBackColor = false;
            this.sigMesBTN.Click += new System.EventHandler(this.sigMesBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.calendarioDGV, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 384);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buscarClienteBTN);
            this.panel2.Controls.Add(this.nombreTBX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cedulaTBX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 34);
            this.panel2.TabIndex = 3;
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
            // anotarBTN
            // 
            this.anotarBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.anotarBTN.BackColor = System.Drawing.Color.Red;
            this.anotarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anotarBTN.Enabled = false;
            this.anotarBTN.FlatAppearance.BorderSize = 0;
            this.anotarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anotarBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotarBTN.Image = ((System.Drawing.Image)(resources.GetObject("anotarBTN.Image")));
            this.anotarBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anotarBTN.Location = new System.Drawing.Point(247, 5);
            this.anotarBTN.Margin = new System.Windows.Forms.Padding(5);
            this.anotarBTN.Name = "anotarBTN";
            this.anotarBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.anotarBTN.Size = new System.Drawing.Size(64, 64);
            this.anotarBTN.TabIndex = 0;
            this.anotarBTN.Text = "Anotar";
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
            this.borrarBTN.Location = new System.Drawing.Point(395, 5);
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
            // opcionesPNL
            // 
            this.opcionesPNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opcionesPNL.Controls.Add(this.faltaBTN);
            this.opcionesPNL.Controls.Add(this.anotarBTN);
            this.opcionesPNL.Controls.Add(this.borrarBTN);
            this.opcionesPNL.Location = new System.Drawing.Point(0, 387);
            this.opcionesPNL.Name = "opcionesPNL";
            this.opcionesPNL.Size = new System.Drawing.Size(707, 74);
            this.opcionesPNL.TabIndex = 5;
            // 
            // faltaBTN
            // 
            this.faltaBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.faltaBTN.BackColor = System.Drawing.Color.Red;
            this.faltaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.faltaBTN.Enabled = false;
            this.faltaBTN.FlatAppearance.BorderSize = 0;
            this.faltaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faltaBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faltaBTN.Image = ((System.Drawing.Image)(resources.GetObject("faltaBTN.Image")));
            this.faltaBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.faltaBTN.Location = new System.Drawing.Point(321, 5);
            this.faltaBTN.Margin = new System.Windows.Forms.Padding(5);
            this.faltaBTN.Name = "faltaBTN";
            this.faltaBTN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.faltaBTN.Size = new System.Drawing.Size(64, 64);
            this.faltaBTN.TabIndex = 2;
            this.faltaBTN.Text = "Falta";
            this.faltaBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.faltaBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.faltaBTN.UseCompatibleTextRendering = true;
            this.faltaBTN.UseVisualStyleBackColor = false;
            this.faltaBTN.Click += new System.EventHandler(this.faltaBTN_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.proCliente);
            this.tabControl1.Controls.Add(this.todas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 487);
            this.tabControl1.TabIndex = 2;
            // 
            // proCliente
            // 
            this.proCliente.Controls.Add(this.tableLayoutPanel1);
            this.proCliente.Controls.Add(this.opcionesPNL);
            this.proCliente.Location = new System.Drawing.Point(4, 22);
            this.proCliente.Name = "proCliente";
            this.proCliente.Padding = new System.Windows.Forms.Padding(3);
            this.proCliente.Size = new System.Drawing.Size(704, 461);
            this.proCliente.TabIndex = 0;
            this.proCliente.Text = "Por cliente";
            this.proCliente.UseVisualStyleBackColor = true;
            // 
            // todas
            // 
            this.todas.Controls.Add(this.listadoPNL);
            this.todas.Controls.Add(this.opcionesPNL2);
            this.todas.Location = new System.Drawing.Point(4, 22);
            this.todas.Name = "todas";
            this.todas.Size = new System.Drawing.Size(704, 461);
            this.todas.TabIndex = 1;
            this.todas.Text = "Todas";
            this.todas.UseVisualStyleBackColor = true;
            // 
            // listadoPNL
            // 
            this.listadoPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoPNL.Location = new System.Drawing.Point(0, 0);
            this.listadoPNL.Name = "listadoPNL";
            this.listadoPNL.Size = new System.Drawing.Size(704, 428);
            this.listadoPNL.TabIndex = 1;
            // 
            // opcionesPNL2
            // 
            this.opcionesPNL2.Controls.Add(this.faltaCBX);
            this.opcionesPNL2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.opcionesPNL2.Location = new System.Drawing.Point(0, 428);
            this.opcionesPNL2.Name = "opcionesPNL2";
            this.opcionesPNL2.Size = new System.Drawing.Size(704, 33);
            this.opcionesPNL2.TabIndex = 0;
            // 
            // faltaCBX
            // 
            this.faltaCBX.AutoSize = true;
            this.faltaCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.faltaCBX.Location = new System.Drawing.Point(576, 3);
            this.faltaCBX.Name = "faltaCBX";
            this.faltaCBX.Size = new System.Drawing.Size(125, 24);
            this.faltaCBX.TabIndex = 0;
            this.faltaCBX.Text = "Mostrar faltas";
            this.faltaCBX.UseVisualStyleBackColor = true;
            this.faltaCBX.CheckedChanged += new System.EventHandler(this.faltaCBX_CheckedChanged);
            // 
            // SeccionAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SeccionAsistencias";
            this.Size = new System.Drawing.Size(712, 487);
            this.Load += new System.EventHandler(this.Assitencias_Load);
            this.SizeChanged += new System.EventHandler(this.MenuAsistencias_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.calendarioDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anioNUD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.opcionesPNL.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.proCliente.ResumeLayout(false);
            this.todas.ResumeLayout(false);
            this.opcionesPNL2.ResumeLayout(false);
            this.opcionesPNL2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sigMesBTN;
        private System.Windows.Forms.Button antMesBTN;
        private System.Windows.Forms.NumericUpDown anioNUD;
        private System.Windows.Forms.ComboBox mesCBX;
        private System.Windows.Forms.DataGridView calendarioDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nombreTBX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cedulaTBX;
        private System.Windows.Forms.Button buscarClienteBTN;
        private System.Windows.Forms.Button anotarBTN;
        Listado listado;
        private Button borrarBTN;
        private Panel opcionesPNL;
        private TabControl tabControl1;
        private TabPage proCliente;
        private TabPage todas;
        private Panel opcionesPNL2;
        private CheckBox faltaCBX;
        private Panel listadoPNL;
        private Button faltaBTN;
    }
}
