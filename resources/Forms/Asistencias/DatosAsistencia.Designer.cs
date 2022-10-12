namespace Body_Factory_Manager
{
    partial class DatosAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAsistencia));
            this.guardarBTN = new System.Windows.Forms.Button();
            this.borrarBTN = new System.Windows.Forms.Button();
            this.observacionTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asisteBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guardarBTN
            // 
            this.guardarBTN.BackColor = System.Drawing.Color.Red;
            this.guardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBTN.FlatAppearance.BorderSize = 0;
            this.guardarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBTN.Location = new System.Drawing.Point(12, 253);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(87, 29);
            this.guardarBTN.TabIndex = 37;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarBTN.UseVisualStyleBackColor = false;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // borrarBTN
            // 
            this.borrarBTN.BackColor = System.Drawing.Color.Red;
            this.borrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrarBTN.FlatAppearance.BorderSize = 0;
            this.borrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarBTN.Location = new System.Drawing.Point(105, 253);
            this.borrarBTN.Name = "borrarBTN";
            this.borrarBTN.Size = new System.Drawing.Size(87, 29);
            this.borrarBTN.TabIndex = 38;
            this.borrarBTN.Text = "Borrar";
            this.borrarBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarBTN.UseVisualStyleBackColor = false;
            this.borrarBTN.Click += new System.EventHandler(this.borrarBTN_Click);
            // 
            // observacionTBX
            // 
            this.observacionTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionTBX.Location = new System.Drawing.Point(12, 90);
            this.observacionTBX.MaxLength = 200;
            this.observacionTBX.Multiline = true;
            this.observacionTBX.Name = "observacionTBX";
            this.observacionTBX.Size = new System.Drawing.Size(180, 157);
            this.observacionTBX.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Observación/justificación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // asisteBTN
            // 
            this.asisteBTN.BackColor = System.Drawing.Color.Red;
            this.asisteBTN.FlatAppearance.BorderSize = 0;
            this.asisteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asisteBTN.Font = new System.Drawing.Font("Bebas Neue", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asisteBTN.Location = new System.Drawing.Point(71, 25);
            this.asisteBTN.Name = "asisteBTN";
            this.asisteBTN.Size = new System.Drawing.Size(55, 45);
            this.asisteBTN.TabIndex = 41;
            this.asisteBTN.Text = "no";
            this.asisteBTN.UseVisualStyleBackColor = false;
            this.asisteBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Asistencia";
            // 
            // DatosAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asisteBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.observacionTBX);
            this.Controls.Add(this.borrarBTN);
            this.Controls.Add(this.guardarBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Asistencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Button borrarBTN;
        private System.Windows.Forms.TextBox observacionTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button asisteBTN;
        private System.Windows.Forms.Label label2;
    }
}