
namespace Body_Factory_Manager
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.ipTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.usuarioTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.claveTbx = new System.Windows.Forms.TextBox();
            this.proobarTbx = new System.Windows.Forms.Button();
            this.guardarTbx = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipTbx
            // 
            this.ipTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTbx.Location = new System.Drawing.Point(12, 25);
            this.ipTbx.MaxLength = 9;
            this.ipTbx.Name = "ipTbx";
            this.ipTbx.Size = new System.Drawing.Size(186, 26);
            this.ipTbx.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(12, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 30);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Usuario y contraseña por defecto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // usuarioTbx
            // 
            this.usuarioTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTbx.Location = new System.Drawing.Point(12, 106);
            this.usuarioTbx.MaxLength = 9;
            this.usuarioTbx.Name = "usuarioTbx";
            this.usuarioTbx.Size = new System.Drawing.Size(186, 26);
            this.usuarioTbx.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contraseña";
            // 
            // claveTbx
            // 
            this.claveTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTbx.Location = new System.Drawing.Point(12, 163);
            this.claveTbx.MaxLength = 9;
            this.claveTbx.Name = "claveTbx";
            this.claveTbx.Size = new System.Drawing.Size(186, 26);
            this.claveTbx.TabIndex = 19;
            this.claveTbx.UseSystemPasswordChar = true;
            // 
            // proobarTbx
            // 
            this.proobarTbx.Location = new System.Drawing.Point(12, 195);
            this.proobarTbx.Name = "proobarTbx";
            this.proobarTbx.Size = new System.Drawing.Size(97, 23);
            this.proobarTbx.TabIndex = 20;
            this.proobarTbx.Text = "Probar conexión";
            this.proobarTbx.UseVisualStyleBackColor = true;
            // 
            // guardarTbx
            // 
            this.guardarTbx.Location = new System.Drawing.Point(115, 195);
            this.guardarTbx.Name = "guardarTbx";
            this.guardarTbx.Size = new System.Drawing.Size(97, 23);
            this.guardarTbx.TabIndex = 21;
            this.guardarTbx.Text = "Guardar";
            this.guardarTbx.UseVisualStyleBackColor = true;
            this.guardarTbx.Click += new System.EventHandler(this.guardarTbx_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ruta del archivo de base de datos:";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guardarTbx);
            this.Controls.Add(this.proobarTbx);
            this.Controls.Add(this.claveTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioTbx);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox usuarioTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox claveTbx;
        private System.Windows.Forms.Button proobarTbx;
        private System.Windows.Forms.Button guardarTbx;
        private System.Windows.Forms.Label label4;
    }
}