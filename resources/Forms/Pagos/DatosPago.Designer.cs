
namespace Body_Factory_Manager
{
    partial class DatosPago
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
            this.stardustEssentialsDataSet1 = new Body_Factory_Manager.StardustEssentialsDataSet();
            this.label16 = new System.Windows.Forms.Label();
            this.pagoFechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deudaLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.entregaCBX = new System.Windows.Forms.ComboBox();
            this.buscarBTN = new System.Windows.Forms.Button();
            this.cancelarBTN = new System.Windows.Forms.Button();
            this.entregaNUD = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.vencimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.totalTbx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adjudDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agregarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stardustEssentialsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // stardustEssentialsDataSet1
            // 
            this.stardustEssentialsDataSet1.DataSetName = "StardustEssentialsDataSet";
            this.stardustEssentialsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 385);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Fecha realizado";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // pagoFechaDTP
            // 
            this.pagoFechaDTP.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.pagoFechaDTP.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.pagoFechaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoFechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pagoFechaDTP.Location = new System.Drawing.Point(208, 401);
            this.pagoFechaDTP.Name = "pagoFechaDTP";
            this.pagoFechaDTP.Size = new System.Drawing.Size(154, 26);
            this.pagoFechaDTP.TabIndex = 68;
            this.pagoFechaDTP.ValueChanged += new System.EventHandler(this.pagoFechaDTP_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Deuda";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Entrega";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(19, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "$";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // deudaLBL
            // 
            this.deudaLBL.AutoSize = true;
            this.deudaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudaLBL.Location = new System.Drawing.Point(37, 402);
            this.deudaLBL.Name = "deudaLBL";
            this.deudaLBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deudaLBL.Size = new System.Drawing.Size(24, 25);
            this.deudaLBL.TabIndex = 64;
            this.deudaLBL.Text = "0";
            this.deudaLBL.Click += new System.EventHandler(this.deudaLBL_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "$";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 29);
            this.label9.TabIndex = 62;
            this.label9.Text = "Pago";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // entregaCBX
            // 
            this.entregaCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaCBX.FormattingEnabled = true;
            this.entregaCBX.Items.AddRange(new object[] {
            "Pago total",
            "Entrega parcial"});
            this.entregaCBX.Location = new System.Drawing.Point(208, 342);
            this.entregaCBX.Name = "entregaCBX";
            this.entregaCBX.Size = new System.Drawing.Size(161, 28);
            this.entregaCBX.TabIndex = 61;
            this.entregaCBX.SelectedIndexChanged += new System.EventHandler(this.entregaCBX_SelectedIndexChanged);
            // 
            // buscarBTN
            // 
            this.buscarBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buscarBTN.BackColor = System.Drawing.Color.Red;
            this.buscarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buscarBTN.FlatAppearance.BorderSize = 0;
            this.buscarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.buscarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBTN.ForeColor = System.Drawing.Color.Black;
            this.buscarBTN.Location = new System.Drawing.Point(153, 439);
            this.buscarBTN.Name = "buscarBTN";
            this.buscarBTN.Size = new System.Drawing.Size(113, 33);
            this.buscarBTN.TabIndex = 70;
            this.buscarBTN.Text = "Buscar";
            this.buscarBTN.UseVisualStyleBackColor = false;
            this.buscarBTN.Click += new System.EventHandler(this.buscarBTN_Click);
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelarBTN.BackColor = System.Drawing.Color.Red;
            this.cancelarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelarBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBTN.FlatAppearance.BorderSize = 0;
            this.cancelarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.cancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBTN.ForeColor = System.Drawing.Color.Black;
            this.cancelarBTN.Location = new System.Drawing.Point(23, 439);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(113, 33);
            this.cancelarBTN.TabIndex = 71;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.UseVisualStyleBackColor = false;
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // entregaNUD
            // 
            this.entregaNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaNUD.Location = new System.Drawing.Point(43, 343);
            this.entregaNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.entregaNUD.Name = "entregaNUD";
            this.entregaNUD.Size = new System.Drawing.Size(141, 26);
            this.entregaNUD.TabIndex = 72;
            this.entregaNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.entregaNUD.ValueChanged += new System.EventHandler(this.entregaNUD_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Fecha de vencimiento:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // vencimientoDTP
            // 
            this.vencimientoDTP.Enabled = false;
            this.vencimientoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimientoDTP.Location = new System.Drawing.Point(209, 261);
            this.vencimientoDTP.Name = "vencimientoDTP";
            this.vencimientoDTP.Size = new System.Drawing.Size(154, 26);
            this.vencimientoDTP.TabIndex = 79;
            this.vencimientoDTP.ValueChanged += new System.EventHandler(this.vencimientoDTP_ValueChanged);
            // 
            // totalTbx
            // 
            this.totalTbx.AutoSize = true;
            this.totalTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTbx.Location = new System.Drawing.Point(39, 201);
            this.totalTbx.Name = "totalTbx";
            this.totalTbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalTbx.Size = new System.Drawing.Size(24, 25);
            this.totalTbx.TabIndex = 78;
            this.totalTbx.Text = "0";
            this.totalTbx.Click += new System.EventHandler(this.totalTbx_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "Cuota o cobro";
            // 
            // adjudDTP
            // 
            this.adjudDTP.Enabled = false;
            this.adjudDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjudDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adjudDTP.Location = new System.Drawing.Point(22, 261);
            this.adjudDTP.Name = "adjudDTP";
            this.adjudDTP.Size = new System.Drawing.Size(165, 26);
            this.adjudDTP.TabIndex = 73;
            this.adjudDTP.ValueChanged += new System.EventHandler(this.adjudDTP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fecha de adjudicación";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // agregarBTN
            // 
            this.agregarBTN.BackColor = System.Drawing.Color.Red;
            this.agregarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarBTN.FlatAppearance.BorderSize = 0;
            this.agregarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(188, 148);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(78, 29);
            this.agregarBTN.TabIndex = 81;
            this.agregarBTN.Text = "Buscar";
            this.agregarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarBTN.UseVisualStyleBackColor = false;
            // 
            // DatosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 503);
            this.Controls.Add(this.agregarBTN);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.vencimientoDTP);
            this.Controls.Add(this.totalTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adjudDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.entregaNUD);
            this.Controls.Add(this.cancelarBTN);
            this.Controls.Add(this.buscarBTN);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pagoFechaDTP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deudaLBL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.entregaCBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatosPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar";
            this.Load += new System.EventHandler(this.DatosPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stardustEssentialsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StardustEssentialsDataSet stardustEssentialsDataSet1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker pagoFechaDTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label deudaLBL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox entregaCBX;
        private System.Windows.Forms.Button buscarBTN;
        private System.Windows.Forms.Button cancelarBTN;
        private System.Windows.Forms.NumericUpDown entregaNUD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker vencimientoDTP;
        private System.Windows.Forms.Label totalTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker adjudDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button agregarBTN;
    }
}