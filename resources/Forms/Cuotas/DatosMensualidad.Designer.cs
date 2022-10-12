using System.Drawing;

namespace Body_Factory_Manager
{
    partial class DatosMensualidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosMensualidad));
            this.label4 = new System.Windows.Forms.Label();
            this.cobroCBX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descuentoCBX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adjudDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTbx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.entregaNUD = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.pagoFechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deudaLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pagoTituloLBL = new System.Windows.Forms.Label();
            this.entregaCBX = new System.Windows.Forms.ComboBox();
            this.descartarBTN = new System.Windows.Forms.Button();
            this.vencimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.cobroNUD = new System.Windows.Forms.NumericUpDown();
            this.descuentoNUD = new System.Windows.Forms.NumericUpDown();
            this.pagoMensualidadCBX = new System.Windows.Forms.ComboBox();
            this.nombreTBX = new System.Windows.Forms.Label();
            this.buscarClienteBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cedulaTBX = new System.Windows.Forms.TextBox();
            this.selectorClientes = new System.Windows.Forms.Panel();
            this.verClienteCompleto = new System.Windows.Forms.Button();
            this.buscarMensualidadBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoNUD)).BeginInit();
            this.selectorClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "$";
            // 
            // cobroCBX
            // 
            this.cobroCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cobroCBX.FormattingEnabled = true;
            this.cobroCBX.Items.AddRange(new object[] {
            "Personalizado"});
            this.cobroCBX.Location = new System.Drawing.Point(204, 160);
            this.cobroCBX.Name = "cobroCBX";
            this.cobroCBX.Size = new System.Drawing.Size(154, 28);
            this.cobroCBX.TabIndex = 45;
            this.cobroCBX.SelectionChangeCommitted += new System.EventHandler(this.cobroCBX_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(15, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(159, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "%";
            // 
            // descuentoCBX
            // 
            this.descuentoCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descuentoCBX.FormattingEnabled = true;
            this.descuentoCBX.Items.AddRange(new object[] {
            "Sin descuento",
            "Personalizado"});
            this.descuentoCBX.Location = new System.Drawing.Point(204, 218);
            this.descuentoCBX.Name = "descuentoCBX";
            this.descuentoCBX.Size = new System.Drawing.Size(154, 28);
            this.descuentoCBX.TabIndex = 42;
            this.descuentoCBX.SelectionChangeCommitted += new System.EventHandler(this.descuentosCBX_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cuota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fecha de adjudicación";
            // 
            // adjudDTP
            // 
            this.adjudDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjudDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adjudDTP.Location = new System.Drawing.Point(17, 347);
            this.adjudDTP.Name = "adjudDTP";
            this.adjudDTP.Size = new System.Drawing.Size(165, 26);
            this.adjudDTP.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cobro:";
            // 
            // totalTbx
            // 
            this.totalTbx.AutoSize = true;
            this.totalTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTbx.Location = new System.Drawing.Point(34, 287);
            this.totalTbx.Name = "totalTbx";
            this.totalTbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalTbx.Size = new System.Drawing.Size(24, 25);
            this.totalTbx.TabIndex = 48;
            this.totalTbx.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Descuento";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.entregaNUD);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pagoFechaDTP);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.deudaLBL);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pagoTituloLBL);
            this.panel1.Controls.Add(this.entregaCBX);
            this.panel1.Location = new System.Drawing.Point(364, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 270);
            this.panel1.TabIndex = 50;
            // 
            // entregaNUD
            // 
            this.entregaNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaNUD.Location = new System.Drawing.Point(34, 107);
            this.entregaNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.entregaNUD.Name = "entregaNUD";
            this.entregaNUD.Size = new System.Drawing.Size(141, 26);
            this.entregaNUD.TabIndex = 60;
            this.entregaNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.entregaNUD.ValueChanged += new System.EventHandler(this.entregaNUD_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Fecha realizado";
            // 
            // pagoFechaDTP
            // 
            this.pagoFechaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoFechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pagoFechaDTP.Location = new System.Drawing.Point(15, 235);
            this.pagoFechaDTP.Name = "pagoFechaDTP";
            this.pagoFechaDTP.Size = new System.Drawing.Size(154, 26);
            this.pagoFechaDTP.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Deuda";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Entrega";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(10, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "$";
            // 
            // deudaLBL
            // 
            this.deudaLBL.AutoSize = true;
            this.deudaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudaLBL.Location = new System.Drawing.Point(29, 175);
            this.deudaLBL.Name = "deudaLBL";
            this.deudaLBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deudaLBL.Size = new System.Drawing.Size(24, 25);
            this.deudaLBL.TabIndex = 53;
            this.deudaLBL.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "$";
            // 
            // pagoTituloLBL
            // 
            this.pagoTituloLBL.AutoSize = true;
            this.pagoTituloLBL.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTituloLBL.Location = new System.Drawing.Point(3, 0);
            this.pagoTituloLBL.Name = "pagoTituloLBL";
            this.pagoTituloLBL.Size = new System.Drawing.Size(57, 29);
            this.pagoTituloLBL.TabIndex = 51;
            this.pagoTituloLBL.Text = "Pago:";
            // 
            // entregaCBX
            // 
            this.entregaCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaCBX.FormattingEnabled = true;
            this.entregaCBX.Items.AddRange(new object[] {
            "Entrega total",
            "Entrega parcial"});
            this.entregaCBX.Location = new System.Drawing.Point(14, 48);
            this.entregaCBX.Name = "entregaCBX";
            this.entregaCBX.Size = new System.Drawing.Size(161, 28);
            this.entregaCBX.TabIndex = 49;
            this.entregaCBX.SelectionChangeCommitted += new System.EventHandler(this.entregaCBX_SelectionChangeCommitted);
            // 
            // descartarBTN
            // 
            this.descartarBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descartarBTN.BackColor = System.Drawing.Color.Red;
            this.descartarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.descartarBTN.FlatAppearance.BorderSize = 0;
            this.descartarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.descartarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descartarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descartarBTN.ForeColor = System.Drawing.Color.Black;
            this.descartarBTN.Location = new System.Drawing.Point(204, 403);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(170, 44);
            this.descartarBTN.TabIndex = 51;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = false;
            this.descartarBTN.Click += new System.EventHandler(this.descartarBTN_Click);
            // 
            // vencimientoDTP
            // 
            this.vencimientoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimientoDTP.Location = new System.Drawing.Point(204, 347);
            this.vencimientoDTP.Name = "vencimientoDTP";
            this.vencimientoDTP.Size = new System.Drawing.Size(154, 26);
            this.vencimientoDTP.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Fecha de vencimiento:";
            // 
            // guardarBTN
            // 
            this.guardarBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardarBTN.BackColor = System.Drawing.Color.Red;
            this.guardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBTN.FlatAppearance.BorderSize = 0;
            this.guardarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.guardarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBTN.ForeColor = System.Drawing.Color.Black;
            this.guardarBTN.Location = new System.Drawing.Point(391, 403);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(170, 44);
            this.guardarBTN.TabIndex = 54;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.UseVisualStyleBackColor = false;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // cobroNUD
            // 
            this.cobroNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobroNUD.Location = new System.Drawing.Point(39, 161);
            this.cobroNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cobroNUD.Name = "cobroNUD";
            this.cobroNUD.Size = new System.Drawing.Size(143, 26);
            this.cobroNUD.TabIndex = 55;
            this.cobroNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cobroNUD.ValueChanged += new System.EventHandler(this.cobroNUD_ValueChanged);
            // 
            // descuentoNUD
            // 
            this.descuentoNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoNUD.Location = new System.Drawing.Point(19, 220);
            this.descuentoNUD.Name = "descuentoNUD";
            this.descuentoNUD.Size = new System.Drawing.Size(134, 26);
            this.descuentoNUD.TabIndex = 56;
            this.descuentoNUD.ValueChanged += new System.EventHandler(this.descuentoNUD_ValueChanged);
            // 
            // pagoMensualidadCBX
            // 
            this.pagoMensualidadCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pagoMensualidadCBX.FormattingEnabled = true;
            this.pagoMensualidadCBX.Items.AddRange(new object[] {
            "Pago de cuota",
            "Pago sin cuota"});
            this.pagoMensualidadCBX.Location = new System.Drawing.Point(204, 112);
            this.pagoMensualidadCBX.Name = "pagoMensualidadCBX";
            this.pagoMensualidadCBX.Size = new System.Drawing.Size(154, 28);
            this.pagoMensualidadCBX.TabIndex = 58;
            this.pagoMensualidadCBX.Visible = false;
            this.pagoMensualidadCBX.SelectedIndexChanged += new System.EventHandler(this.pagoMensualidadCBX_SelectedIndexChanged);
            // 
            // nombreTBX
            // 
            this.nombreTBX.AutoSize = true;
            this.nombreTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombreTBX.Location = new System.Drawing.Point(336, 50);
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(114, 20);
            this.nombreTBX.TabIndex = 63;
            this.nombreTBX.Text = "No encontrado";
            // 
            // buscarClienteBTN
            // 
            this.buscarClienteBTN.BackColor = System.Drawing.Color.Red;
            this.buscarClienteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarClienteBTN.FlatAppearance.BorderSize = 0;
            this.buscarClienteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarClienteBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarClienteBTN.Image = ((System.Drawing.Image)(resources.GetObject("buscarClienteBTN.Image")));
            this.buscarClienteBTN.Location = new System.Drawing.Point(11, 44);
            this.buscarClienteBTN.Name = "buscarClienteBTN";
            this.buscarClienteBTN.Size = new System.Drawing.Size(61, 36);
            this.buscarClienteBTN.TabIndex = 62;
            this.buscarClienteBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscarClienteBTN.UseVisualStyleBackColor = false;
            this.buscarClienteBTN.Visible = false;
            this.buscarClienteBTN.Click += new System.EventHandler(this.buscarClienteBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cédula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 29);
            this.label10.TabIndex = 60;
            this.label10.Text = "Cliente:";
            // 
            // cedulaTBX
            // 
            this.cedulaTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTBX.Location = new System.Drawing.Point(144, 49);
            this.cedulaTBX.MaxLength = 8;
            this.cedulaTBX.Name = "cedulaTBX";
            this.cedulaTBX.Size = new System.Drawing.Size(186, 26);
            this.cedulaTBX.TabIndex = 59;
            this.cedulaTBX.TextChanged += new System.EventHandler(this.cedulaTBX_TextChanged);
            // 
            // selectorClientes
            // 
            this.selectorClientes.Controls.Add(this.label10);
            this.selectorClientes.Controls.Add(this.nombreTBX);
            this.selectorClientes.Controls.Add(this.cedulaTBX);
            this.selectorClientes.Controls.Add(this.buscarClienteBTN);
            this.selectorClientes.Controls.Add(this.label9);
            this.selectorClientes.Enabled = false;
            this.selectorClientes.Location = new System.Drawing.Point(0, 4);
            this.selectorClientes.Name = "selectorClientes";
            this.selectorClientes.Size = new System.Drawing.Size(574, 87);
            this.selectorClientes.TabIndex = 64;
            // 
            // verClienteCompleto
            // 
            this.verClienteCompleto.BackColor = System.Drawing.Color.Red;
            this.verClienteCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verClienteCompleto.FlatAppearance.BorderSize = 0;
            this.verClienteCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verClienteCompleto.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verClienteCompleto.Image = ((System.Drawing.Image)(resources.GetObject("verClienteCompleto.Image")));
            this.verClienteCompleto.Location = new System.Drawing.Point(78, 48);
            this.verClienteCompleto.Name = "verClienteCompleto";
            this.verClienteCompleto.Size = new System.Drawing.Size(60, 36);
            this.verClienteCompleto.TabIndex = 64;
            this.verClienteCompleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verClienteCompleto.UseVisualStyleBackColor = false;
            this.verClienteCompleto.Click += new System.EventHandler(this.verClienteCompleto_Click);
            // 
            // buscarMensualidadBtn
            // 
            this.buscarMensualidadBtn.BackColor = System.Drawing.Color.Red;
            this.buscarMensualidadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarMensualidadBtn.FlatAppearance.BorderSize = 0;
            this.buscarMensualidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarMensualidadBtn.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarMensualidadBtn.Image = ((System.Drawing.Image)(resources.GetObject("buscarMensualidadBtn.Image")));
            this.buscarMensualidadBtn.Location = new System.Drawing.Point(84, 108);
            this.buscarMensualidadBtn.Name = "buscarMensualidadBtn";
            this.buscarMensualidadBtn.Size = new System.Drawing.Size(61, 36);
            this.buscarMensualidadBtn.TabIndex = 65;
            this.buscarMensualidadBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscarMensualidadBtn.UseVisualStyleBackColor = false;
            this.buscarMensualidadBtn.Click += new System.EventHandler(this.buscarMensualidadBtn_Click);
            // 
            // DatosMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 460);
            this.Controls.Add(this.buscarMensualidadBtn);
            this.Controls.Add(this.verClienteCompleto);
            this.Controls.Add(this.selectorClientes);
            this.Controls.Add(this.pagoMensualidadCBX);
            this.Controls.Add(this.descuentoNUD);
            this.Controls.Add(this.cobroNUD);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.vencimientoDTP);
            this.Controls.Add(this.descartarBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cobroCBX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adjudDTP);
            this.Controls.Add(this.descuentoCBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosMensualidad";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de mensualidad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoNUD)).EndInit();
            this.selectorClientes.ResumeLayout(false);
            this.selectorClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobroCBX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox descuentoCBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker adjudDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button descartarBTN;
        private System.Windows.Forms.DateTimePicker vencimientoDTP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.NumericUpDown cobroNUD;
        private System.Windows.Forms.NumericUpDown descuentoNUD;
        private System.Windows.Forms.NumericUpDown entregaNUD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker pagoFechaDTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label deudaLBL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label pagoTituloLBL;
        private System.Windows.Forms.ComboBox entregaCBX;
        private System.Windows.Forms.ComboBox pagoMensualidadCBX;
        private System.Windows.Forms.Label nombreTBX;
        private System.Windows.Forms.Button buscarClienteBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cedulaTBX;
        private System.Windows.Forms.Panel selectorClientes;
        private System.Windows.Forms.Button verClienteCompleto;
        private System.Windows.Forms.Button buscarMensualidadBtn;
    }
}