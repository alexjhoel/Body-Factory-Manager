
namespace Body_Factory_Manager
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarBTN = new System.Windows.Forms.Button();
            this.editarBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.buscarTBX = new System.Windows.Forms.TextBox();
            this.buscarBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDGV
            // 
            this.tablaDGV.AllowUserToAddRows = false;
            this.tablaDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tablaDGV.BackgroundColor = System.Drawing.Color.Red;
            this.tablaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre});
            this.tablaDGV.GridColor = System.Drawing.Color.Maroon;
            this.tablaDGV.Location = new System.Drawing.Point(12, 112);
            this.tablaDGV.Margin = new System.Windows.Forms.Padding(12);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.ReadOnly = true;
            this.tablaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDGV.ShowEditingIcon = false;
            this.tablaDGV.Size = new System.Drawing.Size(494, 178);
            this.tablaDGV.TabIndex = 0;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // agregarBTN
            // 
            this.agregarBTN.BackColor = System.Drawing.Color.Red;
            this.agregarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(3, 3);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(75, 76);
            this.agregarBTN.TabIndex = 1;
            this.agregarBTN.Text = "Nuevo Cliente";
            this.agregarBTN.UseVisualStyleBackColor = false;
            this.agregarBTN.Click += new System.EventHandler(this.agregarBTN_Click);
            // 
            // editarBTN
            // 
            this.editarBTN.BackColor = System.Drawing.Color.Red;
            this.editarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBTN.Location = new System.Drawing.Point(84, 3);
            this.editarBTN.Name = "editarBTN";
            this.editarBTN.Size = new System.Drawing.Size(75, 76);
            this.editarBTN.TabIndex = 2;
            this.editarBTN.Text = "Editar datos";
            this.editarBTN.UseVisualStyleBackColor = false;
            this.editarBTN.Click += new System.EventHandler(this.editarClienteBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.BackColor = System.Drawing.Color.Red;
            this.EliminarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EliminarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.Location = new System.Drawing.Point(165, 3);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(82, 76);
            this.EliminarBTN.TabIndex = 3;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = false;
            this.EliminarBTN.Click += new System.EventHandler(this.borrarClienteBTN_Click);
            // 
            // buscarTBX
            // 
            this.buscarTBX.Location = new System.Drawing.Point(32, 86);
            this.buscarTBX.Name = "buscarTBX";
            this.buscarTBX.Size = new System.Drawing.Size(215, 20);
            this.buscarTBX.TabIndex = 4;
            this.buscarTBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarTBX_KeyPress);
            // 
            // buscarBTN
            // 
            this.buscarBTN.Image = global::Body_Factory_Manager.Properties.Resources.tatu;
            this.buscarBTN.Location = new System.Drawing.Point(3, 85);
            this.buscarBTN.Name = "buscarBTN";
            this.buscarBTN.Size = new System.Drawing.Size(23, 20);
            this.buscarBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscarBTN.TabIndex = 5;
            this.buscarBTN.TabStop = false;
            this.buscarBTN.Click += new System.EventHandler(this.buscarBTN_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buscarBTN);
            this.Controls.Add(this.buscarTBX);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.editarBTN);
            this.Controls.Add(this.agregarBTN);
            this.Controls.Add(this.tablaDGV);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(518, 302);
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.Button agregarBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button editarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.TextBox buscarTBX;
        private System.Windows.Forms.PictureBox buscarBTN;
    }
}
