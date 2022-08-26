
namespace Body_Factory_Manager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginConfiguracion1 = new Body_Factory_Manager.LoginConfiguracion();
            this.loginPrincipal1 = new Body_Factory_Manager.LoginPrincipal();
            this.SuspendLayout();
            // 
            // loginConfiguracion1
            // 
            this.loginConfiguracion1.Location = new System.Drawing.Point(182, 120);
            this.loginConfiguracion1.Name = "loginConfiguracion1";
            this.loginConfiguracion1.Size = new System.Drawing.Size(214, 283);
            this.loginConfiguracion1.TabIndex = 1;
            this.loginConfiguracion1.Visible = false;
            // 
            // loginPrincipal1
            // 
            this.loginPrincipal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPrincipal1.BackgroundImage")));
            this.loginPrincipal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginPrincipal1.Location = new System.Drawing.Point(-5, -1);
            this.loginPrincipal1.Name = "loginPrincipal1";
            this.loginPrincipal1.Size = new System.Drawing.Size(565, 562);
            this.loginPrincipal1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 517);
            this.Controls.Add(this.loginConfiguracion1);
            this.Controls.Add(this.loginPrincipal1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPrincipal loginPrincipal1;
        private LoginConfiguracion loginConfiguracion1;
    }
}