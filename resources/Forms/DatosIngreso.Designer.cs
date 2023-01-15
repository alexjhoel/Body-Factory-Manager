namespace Body_Factory_Manager
{
    partial class DatosIngreso
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
            this.components = new System.ComponentModel.Container();
            this.fechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comentarioTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fechaDTP
            // 
            this.fechaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDTP.Location = new System.Drawing.Point(15, 25);
            this.fechaDTP.Name = "fechaDTP";
            this.fechaDTP.Size = new System.Drawing.Size(154, 26);
            this.fechaDTP.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Fecha";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comentarioTbx
            // 
            this.comentarioTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentarioTbx.Location = new System.Drawing.Point(15, 83);
            this.comentarioTbx.MaxLength = 100;
            this.comentarioTbx.Multiline = true;
            this.comentarioTbx.Name = "comentarioTbx";
            this.comentarioTbx.Size = new System.Drawing.Size(154, 114);
            this.comentarioTbx.TabIndex = 62;
            this.comentarioTbx.Text = "Reingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Comentario";
            // 
            // guardarBTN
            // 
            this.guardarBTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guardarBTN.BackColor = System.Drawing.Color.Red;
            this.guardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBTN.FlatAppearance.BorderSize = 0;
            this.guardarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBTN.Location = new System.Drawing.Point(30, 203);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(130, 29);
            this.guardarBTN.TabIndex = 64;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarBTN.UseVisualStyleBackColor = false;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // DatosIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 244);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comentarioTbx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fechaDTP);
            this.Name = "DatosIngreso";
            this.Text = "Ingreso o reingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaDTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox comentarioTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarBTN;
    }
}