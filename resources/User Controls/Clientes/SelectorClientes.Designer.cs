
namespace Body_Factory_Manager
{
    partial class SelectorClientes
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
            this.cedulaTBX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.agregarBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreTBX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cedulaTBX
            // 
            this.cedulaTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTBX.Location = new System.Drawing.Point(15, 71);
            this.cedulaTBX.MaxLength = 8;
            this.cedulaTBX.Name = "cedulaTBX";
            this.cedulaTBX.Size = new System.Drawing.Size(186, 26);
            this.cedulaTBX.TabIndex = 21;
            this.cedulaTBX.TextChanged += new System.EventHandler(this.cedulaTBX_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cédula";
            // 
            // agregarBTN
            // 
            this.agregarBTN.BackColor = System.Drawing.Color.Red;
            this.agregarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(90, 12);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(78, 40);
            this.agregarBTN.TabIndex = 30;
            this.agregarBTN.Text = "Buscar";
            this.agregarBTN.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cliente:";
            // 
            // nombreTBX
            // 
            this.nombreTBX.AutoSize = true;
            this.nombreTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombreTBX.Location = new System.Drawing.Point(207, 73);
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(114, 20);
            this.nombreTBX.TabIndex = 31;
            this.nombreTBX.Text = "No encontrado";
            // 
            // SelectorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nombreTBX);
            this.Controls.Add(this.agregarBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cedulaTBX);
            this.Name = "SelectorClientes";
            this.Size = new System.Drawing.Size(745, 125);
            this.Load += new System.EventHandler(this.SelectorClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cedulaTBX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregarBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nombreTBX;
    }
}
