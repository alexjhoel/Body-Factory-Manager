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
            this.label4 = new System.Windows.Forms.Label();
            this.cobroCBX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descuentosCBX = new System.Windows.Forms.ComboBox();
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
            this.agregarBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 316);
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
            this.cobroCBX.Location = new System.Drawing.Point(204, 189);
            this.cobroCBX.Name = "cobroCBX";
            this.cobroCBX.Size = new System.Drawing.Size(154, 28);
            this.cobroCBX.TabIndex = 45;
            this.cobroCBX.SelectedIndexChanged += new System.EventHandler(this.montosCBX_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(15, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(159, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "%";
            // 
            // descuentosCBX
            // 
            this.descuentosCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descuentosCBX.FormattingEnabled = true;
            this.descuentosCBX.Items.AddRange(new object[] {
            "Sin descuento",
            "Personalizado"});
            this.descuentosCBX.Location = new System.Drawing.Point(204, 247);
            this.descuentosCBX.Name = "descuentosCBX";
            this.descuentosCBX.Size = new System.Drawing.Size(154, 28);
            this.descuentosCBX.TabIndex = 42;
            this.descuentosCBX.SelectedIndexChanged += new System.EventHandler(this.descuentosCBX_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cuota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fecha de adjudicación";
            // 
            // adjudDTP
            // 
            this.adjudDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjudDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adjudDTP.Location = new System.Drawing.Point(17, 376);
            this.adjudDTP.Name = "adjudDTP";
            this.adjudDTP.Size = new System.Drawing.Size(165, 26);
            this.adjudDTP.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cobro:";
            // 
            // totalTbx
            // 
            this.totalTbx.AutoSize = true;
            this.totalTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTbx.Location = new System.Drawing.Point(34, 316);
            this.totalTbx.Name = "totalTbx";
            this.totalTbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalTbx.Size = new System.Drawing.Size(24, 25);
            this.totalTbx.TabIndex = 48;
            this.totalTbx.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 233);
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
            this.panel1.Location = new System.Drawing.Point(364, 141);
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
            "Entrega parcial",
            "Paga después"});
            this.entregaCBX.Location = new System.Drawing.Point(14, 48);
            this.entregaCBX.Name = "entregaCBX";
            this.entregaCBX.Size = new System.Drawing.Size(161, 28);
            this.entregaCBX.TabIndex = 49;
            this.entregaCBX.SelectedIndexChanged += new System.EventHandler(this.pagoCBX_SelectedIndexChanged);
            // 
            // descartarBTN
            // 
            this.descartarBTN.BackColor = System.Drawing.Color.Red;
            this.descartarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.descartarBTN.FlatAppearance.BorderSize = 0;
            this.descartarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.descartarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descartarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descartarBTN.ForeColor = System.Drawing.Color.Black;
            this.descartarBTN.Location = new System.Drawing.Point(204, 432);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(170, 44);
            this.descartarBTN.TabIndex = 51;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = false;
            // 
            // vencimientoDTP
            // 
            this.vencimientoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimientoDTP.Location = new System.Drawing.Point(204, 376);
            this.vencimientoDTP.Name = "vencimientoDTP";
            this.vencimientoDTP.Size = new System.Drawing.Size(154, 26);
            this.vencimientoDTP.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Fecha de vencimiento:";
            // 
            // guardarBTN
            // 
            this.guardarBTN.BackColor = System.Drawing.Color.Red;
            this.guardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBTN.FlatAppearance.BorderSize = 0;
            this.guardarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.guardarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBTN.ForeColor = System.Drawing.Color.Black;
            this.guardarBTN.Location = new System.Drawing.Point(391, 432);
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
            this.cobroNUD.Location = new System.Drawing.Point(39, 190);
            this.cobroNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cobroNUD.Minimum = new decimal(new int[] {
            100,
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
            this.descuentoNUD.Location = new System.Drawing.Point(19, 249);
            this.descuentoNUD.Name = "descuentoNUD";
            this.descuentoNUD.Size = new System.Drawing.Size(134, 26);
            this.descuentoNUD.TabIndex = 56;
            this.descuentoNUD.ValueChanged += new System.EventHandler(this.descuentoNUD_ValueChanged);
            // 
            // agregarBTN
            // 
            this.agregarBTN.BackColor = System.Drawing.Color.Red;
            this.agregarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarBTN.FlatAppearance.BorderSize = 0;
            this.agregarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(84, 137);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(78, 34);
            this.agregarBTN.TabIndex = 57;
            this.agregarBTN.Text = "Buscar";
            this.agregarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarBTN.UseVisualStyleBackColor = false;
            // 
            // DatosMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 488);
            this.Controls.Add(this.agregarBTN);
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
            this.Controls.Add(this.descuentosCBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobroCBX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox descuentosCBX;
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
        private System.Windows.Forms.Button agregarBTN;
    }
}