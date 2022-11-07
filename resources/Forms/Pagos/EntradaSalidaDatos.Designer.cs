namespace Body_Factory_Manager
{
    partial class EntradaSalidaDatos
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
            this.entregaNUD = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.pagoFechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pagoTituloLBL = new System.Windows.Forms.Label();
            this.entregaCBX = new System.Windows.Forms.ComboBox();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.descartarBTN = new System.Windows.Forms.Button();
            this.motivoTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.responsableTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // entregaNUD
            // 
            this.entregaNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaNUD.Location = new System.Drawing.Point(31, 117);
            this.entregaNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.entregaNUD.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.entregaNUD.Name = "entregaNUD";
            this.entregaNUD.Size = new System.Drawing.Size(141, 26);
            this.entregaNUD.TabIndex = 1;
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
            this.label16.Location = new System.Drawing.Point(8, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Fecha";
            // 
            // pagoFechaDTP
            // 
            this.pagoFechaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoFechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pagoFechaDTP.Location = new System.Drawing.Point(11, 387);
            this.pagoFechaDTP.Name = "pagoFechaDTP";
            this.pagoFechaDTP.Size = new System.Drawing.Size(154, 26);
            this.pagoFechaDTP.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Importe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(7, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "$";
            // 
            // pagoTituloLBL
            // 
            this.pagoTituloLBL.AutoSize = true;
            this.pagoTituloLBL.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTituloLBL.Location = new System.Drawing.Point(12, 9);
            this.pagoTituloLBL.Name = "pagoTituloLBL";
            this.pagoTituloLBL.Size = new System.Drawing.Size(154, 29);
            this.pagoTituloLBL.TabIndex = 62;
            this.pagoTituloLBL.Text = "Entrada o salida";
            // 
            // entregaCBX
            // 
            this.entregaCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaCBX.FormattingEnabled = true;
            this.entregaCBX.Items.AddRange(new object[] {
            "Salida",
            "Entrada"});
            this.entregaCBX.Location = new System.Drawing.Point(11, 58);
            this.entregaCBX.Name = "entregaCBX";
            this.entregaCBX.Size = new System.Drawing.Size(161, 28);
            this.entregaCBX.TabIndex = 0;
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
            this.guardarBTN.Location = new System.Drawing.Point(183, 440);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(170, 44);
            this.guardarBTN.TabIndex = 5;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.UseVisualStyleBackColor = false;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
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
            this.descartarBTN.Location = new System.Drawing.Point(11, 440);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(166, 44);
            this.descartarBTN.TabIndex = 63;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = false;
            // 
            // motivoTBX
            // 
            this.motivoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoTBX.Location = new System.Drawing.Point(12, 237);
            this.motivoTBX.MaxLength = 200;
            this.motivoTBX.Multiline = true;
            this.motivoTBX.Name = "motivoTBX";
            this.motivoTBX.Size = new System.Drawing.Size(341, 108);
            this.motivoTBX.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Origen, destino o persona";
            // 
            // responsableTBX
            // 
            this.responsableTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsableTBX.Location = new System.Drawing.Point(12, 172);
            this.responsableTBX.Name = "responsableTBX";
            this.responsableTBX.Size = new System.Drawing.Size(340, 26);
            this.responsableTBX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Motivo o descripción:";
            // 
            // EntradaSalidaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.responsableTBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motivoTBX);
            this.Controls.Add(this.entregaNUD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pagoFechaDTP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pagoTituloLBL);
            this.Controls.Add(this.entregaCBX);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.descartarBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntradaSalidaDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada/Salida";
            this.Load += new System.EventHandler(this.EntradaSalidaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entregaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown entregaNUD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker pagoFechaDTP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label pagoTituloLBL;
        private System.Windows.Forms.ComboBox entregaCBX;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Button descartarBTN;
        private System.Windows.Forms.TextBox motivoTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox responsableTBX;
        private System.Windows.Forms.Label label2;
    }
}