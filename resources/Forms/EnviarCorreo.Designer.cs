namespace Body_Factory_Manager
{
    partial class EnviarCorreo
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
            this.destinatario = new System.Windows.Forms.TextBox();
            this.enviarBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.asuntoTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mensajeTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // destinatario
            // 
            this.destinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinatario.Location = new System.Drawing.Point(12, 25);
            this.destinatario.MaxLength = 50;
            this.destinatario.Name = "destinatario";
            this.destinatario.Size = new System.Drawing.Size(478, 26);
            this.destinatario.TabIndex = 23;
            // 
            // enviarBTN
            // 
            this.enviarBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.enviarBTN.BackColor = System.Drawing.Color.Red;
            this.enviarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enviarBTN.FlatAppearance.BorderSize = 0;
            this.enviarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.enviarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarBTN.ForeColor = System.Drawing.Color.Black;
            this.enviarBTN.Location = new System.Drawing.Point(190, 261);
            this.enviarBTN.Name = "enviarBTN";
            this.enviarBTN.Size = new System.Drawing.Size(129, 40);
            this.enviarBTN.TabIndex = 22;
            this.enviarBTN.Text = "Enviar";
            this.enviarBTN.UseVisualStyleBackColor = false;
            this.enviarBTN.Click += new System.EventHandler(this.enviarBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Destinatario";
            // 
            // asuntoTBX
            // 
            this.asuntoTBX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asuntoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asuntoTBX.Location = new System.Drawing.Point(12, 70);
            this.asuntoTBX.MaxLength = 50;
            this.asuntoTBX.Name = "asuntoTBX";
            this.asuntoTBX.Size = new System.Drawing.Size(478, 26);
            this.asuntoTBX.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Asunto";
            // 
            // mensajeTBX
            // 
            this.mensajeTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mensajeTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeTBX.Location = new System.Drawing.Point(12, 115);
            this.mensajeTBX.MaxLength = 50;
            this.mensajeTBX.Multiline = true;
            this.mensajeTBX.Name = "mensajeTBX";
            this.mensajeTBX.Size = new System.Drawing.Size(478, 140);
            this.mensajeTBX.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mensaje";
            // 
            // EnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 309);
            this.Controls.Add(this.mensajeTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asuntoTBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinatario);
            this.Controls.Add(this.enviarBTN);
            this.Controls.Add(this.label9);
            this.Name = "EnviarCorreo";
            this.Text = "Enviar un email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox destinatario;
        private System.Windows.Forms.Button enviarBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox asuntoTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mensajeTBX;
        private System.Windows.Forms.Label label2;
    }
}