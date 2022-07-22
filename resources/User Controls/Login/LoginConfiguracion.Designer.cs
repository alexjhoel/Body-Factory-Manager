
namespace Body_Factory_Manager
{
    partial class LoginConfiguracion
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
            this.label4 = new System.Windows.Forms.Label();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.proobarBTN = new System.Windows.Forms.Button();
            this.claveTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTbx = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTbx = new System.Windows.Forms.TextBox();
            this.descartarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ruta del archivo de base de datos:";
            // 
            // guardarBTN
            // 
            this.guardarBTN.Location = new System.Drawing.Point(106, 190);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(97, 23);
            this.guardarBTN.TabIndex = 31;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.UseVisualStyleBackColor = true;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // proobarBTN
            // 
            this.proobarBTN.Location = new System.Drawing.Point(3, 190);
            this.proobarBTN.Name = "proobarBTN";
            this.proobarBTN.Size = new System.Drawing.Size(97, 23);
            this.proobarBTN.TabIndex = 30;
            this.proobarBTN.Text = "Probar conexión";
            this.proobarBTN.UseVisualStyleBackColor = true;
            // 
            // claveTbx
            // 
            this.claveTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTbx.Location = new System.Drawing.Point(3, 158);
            this.claveTbx.MaxLength = 255;
            this.claveTbx.Name = "claveTbx";
            this.claveTbx.Size = new System.Drawing.Size(200, 26);
            this.claveTbx.TabIndex = 29;
            this.claveTbx.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Usuario";
            // 
            // usuarioTbx
            // 
            this.usuarioTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTbx.Location = new System.Drawing.Point(3, 101);
            this.usuarioTbx.MaxLength = 255;
            this.usuarioTbx.Name = "usuarioTbx";
            this.usuarioTbx.Size = new System.Drawing.Size(200, 26);
            this.usuarioTbx.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(3, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 30);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Usuario y contraseña por defecto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "IP";
            // 
            // ipTbx
            // 
            this.ipTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTbx.Location = new System.Drawing.Point(3, 20);
            this.ipTbx.MaxLength = 255;
            this.ipTbx.Name = "ipTbx";
            this.ipTbx.Size = new System.Drawing.Size(200, 26);
            this.ipTbx.TabIndex = 23;
            // 
            // descartarBTN
            // 
            this.descartarBTN.Location = new System.Drawing.Point(50, 219);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(97, 23);
            this.descartarBTN.TabIndex = 33;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = true;
            // 
            // LoginConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descartarBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.proobarBTN);
            this.Controls.Add(this.claveTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioTbx);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTbx);
            this.Name = "LoginConfiguracion";
            this.Size = new System.Drawing.Size(213, 285);
            this.Enter += new System.EventHandler(this.LoginConfiguracion_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Button proobarBTN;
        private System.Windows.Forms.TextBox claveTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioTbx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTbx;
        private System.Windows.Forms.Button descartarBTN;
    }
}
