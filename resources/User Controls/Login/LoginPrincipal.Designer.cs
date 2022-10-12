
namespace Body_Factory_Manager
{
    partial class LoginPrincipal
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
            this.usuarioTBX = new System.Windows.Forms.TextBox();
            this.recuperarContraseñaBTN = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.claveTBX = new System.Windows.Forms.TextBox();
            this.configuracionBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioTBX
            // 
            this.usuarioTBX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuarioTBX.BackColor = System.Drawing.SystemColors.Desktop;
            this.usuarioTBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTBX.ForeColor = System.Drawing.SystemColors.Info;
            this.usuarioTBX.Location = new System.Drawing.Point(274, 203);
            this.usuarioTBX.Name = "usuarioTBX";
            this.usuarioTBX.Size = new System.Drawing.Size(174, 19);
            this.usuarioTBX.TabIndex = 5;
            // 
            // recuperarContraseñaBTN
            // 
            this.recuperarContraseñaBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recuperarContraseñaBTN.BackColor = System.Drawing.Color.Black;
            this.recuperarContraseñaBTN.FlatAppearance.BorderSize = 0;
            this.recuperarContraseñaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recuperarContraseñaBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperarContraseñaBTN.ForeColor = System.Drawing.Color.White;
            this.recuperarContraseñaBTN.Location = new System.Drawing.Point(189, 469);
            this.recuperarContraseñaBTN.Name = "recuperarContraseñaBTN";
            this.recuperarContraseñaBTN.Size = new System.Drawing.Size(193, 34);
            this.recuperarContraseñaBTN.TabIndex = 8;
            this.recuperarContraseñaBTN.Text = "Recuperar contraseña";
            this.recuperarContraseñaBTN.UseVisualStyleBackColor = false;
            this.recuperarContraseñaBTN.Click += new System.EventHandler(this.recuperarContraseñaBTN_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBTN.BackColor = System.Drawing.Color.Black;
            this.loginBTN.FlatAppearance.BorderSize = 0;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.Color.White;
            this.loginBTN.Location = new System.Drawing.Point(259, 320);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(177, 32);
            this.loginBTN.TabIndex = 7;
            this.loginBTN.Text = "Iniciar Sesión";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // claveTBX
            // 
            this.claveTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.claveTBX.BackColor = System.Drawing.SystemColors.Desktop;
            this.claveTBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claveTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTBX.ForeColor = System.Drawing.SystemColors.Info;
            this.claveTBX.Location = new System.Drawing.Point(273, 245);
            this.claveTBX.Name = "claveTBX";
            this.claveTBX.Size = new System.Drawing.Size(174, 19);
            this.claveTBX.TabIndex = 6;
            this.claveTBX.UseSystemPasswordChar = true;
            this.claveTBX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.claveTBX_KeyDown);
            // 
            // configuracionBTN
            // 
            this.configuracionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configuracionBTN.BackColor = System.Drawing.Color.White;
            this.configuracionBTN.BackgroundImage = global::Body_Factory_Manager.Properties.Resources.build_FILL0_wght400_GRAD0_opsz48;
            this.configuracionBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.configuracionBTN.FlatAppearance.BorderSize = 0;
            this.configuracionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configuracionBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionBTN.Location = new System.Drawing.Point(509, 14);
            this.configuracionBTN.Name = "configuracionBTN";
            this.configuracionBTN.Size = new System.Drawing.Size(36, 36);
            this.configuracionBTN.TabIndex = 9;
            this.configuracionBTN.UseVisualStyleBackColor = false;
            this.configuracionBTN.Click += new System.EventHandler(this.configuracionBTN_Click);
            // 
            // LoginPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Body_Factory_Manager.Properties.Resources.LoginV3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.configuracionBTN);
            this.Controls.Add(this.usuarioTBX);
            this.Controls.Add(this.recuperarContraseñaBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.claveTBX);
            this.Name = "LoginPrincipal";
            this.Size = new System.Drawing.Size(560, 562);
            this.Enter += new System.EventHandler(this.LoginPrincipal_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configuracionBTN;
        private System.Windows.Forms.TextBox usuarioTBX;
        private System.Windows.Forms.Button recuperarContraseñaBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox claveTBX;
    }
}
