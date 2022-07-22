
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.nombreTBX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agregarBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
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
            this.Nombre,
            this.Apellido});
            this.tablaDGV.GridColor = System.Drawing.Color.Maroon;
            this.tablaDGV.Location = new System.Drawing.Point(232, 43);
            this.tablaDGV.Margin = new System.Windows.Forms.Padding(12);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.ReadOnly = true;
            this.tablaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDGV.ShowEditingIcon = false;
            this.tablaDGV.Size = new System.Drawing.Size(418, 138);
            this.tablaDGV.TabIndex = 1;
            // 
            // nombreTBX
            // 
            this.nombreTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTBX.Location = new System.Drawing.Point(15, 71);
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(186, 26);
            this.nombreTBX.TabIndex = 21;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cédula";
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
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 26);
            this.textBox2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Teléfono";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(15, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 26);
            this.textBox3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellido";
            // 
            // agregarBTN
            // 
            this.agregarBTN.BackColor = System.Drawing.Color.Red;
            this.agregarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(232, 196);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(78, 40);
            this.agregarBTN.TabIndex = 30;
            this.agregarBTN.Text = "Buscar";
            this.agregarBTN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Ver datos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SelectorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agregarBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombreTBX);
            this.Controls.Add(this.tablaDGV);
            this.Name = "SelectorClientes";
            this.Size = new System.Drawing.Size(662, 244);
            this.Load += new System.EventHandler(this.SelectorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.TextBox nombreTBX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregarBTN;
        private System.Windows.Forms.Button button1;
    }
}
