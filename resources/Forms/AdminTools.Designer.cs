namespace Body_Factory_Manager
{
    partial class AdminTools
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
            this.consultaTbx = new System.Windows.Forms.TextBox();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.recibirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaTbx
            // 
            this.consultaTbx.Location = new System.Drawing.Point(12, 12);
            this.consultaTbx.Multiline = true;
            this.consultaTbx.Name = "consultaTbx";
            this.consultaTbx.Size = new System.Drawing.Size(262, 95);
            this.consultaTbx.TabIndex = 0;
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(64, 113);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(75, 23);
            this.enviarBtn.TabIndex = 1;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // tablaDGV
            // 
            this.tablaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDGV.Location = new System.Drawing.Point(302, 12);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.Size = new System.Drawing.Size(443, 124);
            this.tablaDGV.TabIndex = 2;
            // 
            // recibirBtn
            // 
            this.recibirBtn.Location = new System.Drawing.Point(154, 113);
            this.recibirBtn.Name = "recibirBtn";
            this.recibirBtn.Size = new System.Drawing.Size(75, 23);
            this.recibirBtn.TabIndex = 3;
            this.recibirBtn.Text = "Recibir";
            this.recibirBtn.UseVisualStyleBackColor = true;
            this.recibirBtn.Click += new System.EventHandler(this.recibirBtn_Click);
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 175);
            this.Controls.Add(this.recibirBtn);
            this.Controls.Add(this.tablaDGV);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.consultaTbx);
            this.Name = "AdminTools";
            this.Text = "AdminTools";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consultaTbx;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.Button recibirBtn;
    }
}