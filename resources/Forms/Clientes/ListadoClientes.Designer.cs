
namespace Body_Factory_Manager
{
    partial class ListadoClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDGV
            // 
            this.tablaDGV.AllowUserToAddRows = false;
            this.tablaDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tablaDGV.BackgroundColor = System.Drawing.Color.White;
            this.tablaDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDGV.ColumnHeadersHeight = 30;
            this.tablaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDGV.EnableHeadersVisualStyles = false;
            this.tablaDGV.GridColor = System.Drawing.Color.Black;
            this.tablaDGV.Location = new System.Drawing.Point(0, 0);
            this.tablaDGV.Margin = new System.Windows.Forms.Padding(0);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.ReadOnly = true;
            this.tablaDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaDGV.RowTemplate.Height = 35;
            this.tablaDGV.RowTemplate.ReadOnly = true;
            this.tablaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDGV.ShowEditingIcon = false;
            this.tablaDGV.Size = new System.Drawing.Size(695, 342);
            this.tablaDGV.TabIndex = 1;
            this.tablaDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaDGV_CellMouseClick);
            this.tablaDGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tablaDGV_CellPainting);
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
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(695, 342);
            this.Controls.Add(this.tablaDGV);
            this.Name = "ListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de clientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}