
namespace Body_Factory_Manager
{
    partial class MenuClientes
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
            this.agregarBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listarBTN = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.informesBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // agregarBTN
            // 
            this.agregarBTN.BackColor = System.Drawing.Color.Red;
            this.agregarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(3, 3);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(100, 100);
            this.agregarBTN.TabIndex = 2;
            this.agregarBTN.Text = "Agregar";
            this.agregarBTN.UseVisualStyleBackColor = false;
            this.agregarBTN.Click += new System.EventHandler(this.agregarBTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.38619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.61381F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 391);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.agregarBTN);
            this.flowLayoutPanel2.Controls.Add(this.listarBTN);
            this.flowLayoutPanel2.Controls.Add(this.buscarButton);
            this.flowLayoutPanel2.Controls.Add(this.informesBTN);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(147, 153);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(424, 106);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // listarBTN
            // 
            this.listarBTN.BackColor = System.Drawing.Color.Red;
            this.listarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listarBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarBTN.Location = new System.Drawing.Point(109, 3);
            this.listarBTN.Name = "listarBTN";
            this.listarBTN.Size = new System.Drawing.Size(100, 100);
            this.listarBTN.TabIndex = 2;
            this.listarBTN.Text = "Listar";
            this.listarBTN.UseVisualStyleBackColor = false;
            this.listarBTN.Click += new System.EventHandler(this.listarBtn_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.Red;
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.Location = new System.Drawing.Point(215, 3);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 100);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            // 
            // informesBTN
            // 
            this.informesBTN.BackColor = System.Drawing.Color.Red;
            this.informesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informesBTN.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informesBTN.Location = new System.Drawing.Point(321, 3);
            this.informesBTN.Name = "informesBTN";
            this.informesBTN.Size = new System.Drawing.Size(100, 100);
            this.informesBTN.TabIndex = 4;
            this.informesBTN.Text = "Informes";
            this.informesBTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "- Seleccione una opción -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuClientes";
            this.Size = new System.Drawing.Size(718, 391);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button agregarBTN;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button listarBTN;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button informesBTN;
        private System.Windows.Forms.Label label1;
    }
}
