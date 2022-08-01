
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
            this.validezDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stardustEssentialsDataSet1 = new Body_Factory_Manager.StardustEssentialsDataSet();
            this.montoTBX = new System.Windows.Forms.TextBox();
            this.descuentoTBX = new System.Windows.Forms.TextBox();
            this.descartarBTN = new System.Windows.Forms.Button();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTbx = new System.Windows.Forms.Label();
            this.descuentosCBX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.montosCBX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stardustEssentialsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // validezDTP
            // 
            this.validezDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validezDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.validezDTP.Location = new System.Drawing.Point(12, 347);
            this.validezDTP.Name = "validezDTP";
            this.validezDTP.Size = new System.Drawing.Size(200, 26);
            this.validezDTP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descuento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de validez del pago";
            // 
            // stardustEssentialsDataSet1
            // 
            this.stardustEssentialsDataSet1.DataSetName = "StardustEssentialsDataSet";
            this.stardustEssentialsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // montoTBX
            // 
            this.montoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTBX.Location = new System.Drawing.Point(39, 168);
            this.montoTBX.Name = "montoTBX";
            this.montoTBX.Size = new System.Drawing.Size(143, 26);
            this.montoTBX.TabIndex = 22;
            this.montoTBX.Text = "0";
            this.montoTBX.TextChanged += new System.EventHandler(this.montoTBX_TextChanged);
            // 
            // descuentoTBX
            // 
            this.descuentoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoTBX.Location = new System.Drawing.Point(16, 228);
            this.descuentoTBX.Name = "descuentoTBX";
            this.descuentoTBX.Size = new System.Drawing.Size(137, 26);
            this.descuentoTBX.TabIndex = 24;
            this.descuentoTBX.Text = "0";
            this.descuentoTBX.TextChanged += new System.EventHandler(this.descuentoTBX_TextChanged);
            // 
            // descartarBTN
            // 
            this.descartarBTN.BackColor = System.Drawing.Color.Red;
            this.descartarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.descartarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descartarBTN.ForeColor = System.Drawing.Color.White;
            this.descartarBTN.Location = new System.Drawing.Point(12, 417);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(170, 44);
            this.descartarBTN.TabIndex = 26;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = false;
            // 
            // guardarBTN
            // 
            this.guardarBTN.BackColor = System.Drawing.Color.Red;
            this.guardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBTN.ForeColor = System.Drawing.Color.White;
            this.guardarBTN.Location = new System.Drawing.Point(188, 417);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(170, 44);
            this.guardarBTN.TabIndex = 25;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.UseVisualStyleBackColor = false;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total:";
            // 
            // totalTbx
            // 
            this.totalTbx.AutoSize = true;
            this.totalTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTbx.Location = new System.Drawing.Point(26, 295);
            this.totalTbx.Name = "totalTbx";
            this.totalTbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalTbx.Size = new System.Drawing.Size(24, 25);
            this.totalTbx.TabIndex = 29;
            this.totalTbx.Text = "0";
            // 
            // descuentosCBX
            // 
            this.descuentosCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descuentosCBX.FormattingEnabled = true;
            this.descuentosCBX.Items.AddRange(new object[] {
            "Sin descuento",
            "Personalizado"});
            this.descuentosCBX.Location = new System.Drawing.Point(204, 226);
            this.descuentosCBX.Name = "descuentosCBX";
            this.descuentosCBX.Size = new System.Drawing.Size(154, 28);
            this.descuentosCBX.TabIndex = 30;
            this.descuentosCBX.SelectedIndexChanged += new System.EventHandler(this.descuentosCBX_SelectedIndexChanged);
            this.descuentosCBX.SelectionChangeCommitted += new System.EventHandler(this.descuentosCBX_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(159, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(15, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "$";
            // 
            // montosCBX
            // 
            this.montosCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.montosCBX.FormattingEnabled = true;
            this.montosCBX.Items.AddRange(new object[] {
            "Cuota asignada",
            "Personalizado"});
            this.montosCBX.Location = new System.Drawing.Point(204, 168);
            this.montosCBX.Name = "montosCBX";
            this.montosCBX.Size = new System.Drawing.Size(154, 28);
            this.montosCBX.TabIndex = 33;
            this.montosCBX.SelectedIndexChanged += new System.EventHandler(this.montosCBX_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "$";
            // 
            // DatosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.montosCBX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descuentosCBX);
            this.Controls.Add(this.totalTbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descartarBTN);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.descuentoTBX);
            this.Controls.Add(this.montoTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.validezDTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatosPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar";
            this.Load += new System.EventHandler(this.DatosPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stardustEssentialsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker validezDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private StardustEssentialsDataSet stardustEssentialsDataSet1;
        private System.Windows.Forms.TextBox montoTBX;
        private System.Windows.Forms.TextBox descuentoTBX;
        private System.Windows.Forms.Button descartarBTN;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalTbx;
        private System.Windows.Forms.ComboBox descuentosCBX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox montosCBX;
        private System.Windows.Forms.Label label4;
    }
}