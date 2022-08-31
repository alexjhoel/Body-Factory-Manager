
namespace Body_Factory_Manager
{
    partial class DatosCliente
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
            this.subirFotoBTN = new System.Windows.Forms.Button();
            this.abrirFotoFD = new System.Windows.Forms.OpenFileDialog();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.descartarBTN = new System.Windows.Forms.Button();
            this.perfilPBX = new Body_Factory_Manager.resources.Custom.RoundPictureBox();
            this.ingresoDTP = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.revisarEsto = new System.Windows.Forms.TextBox();
            this.observacionesTbx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupoSanguineoCBX = new System.Windows.Forms.ComboBox();
            this.nombreTBX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patologiasTbx = new System.Windows.Forms.TextBox();
            this.apellidoTBX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cedulaTBX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direccionTBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enviarMensajeBTN = new System.Windows.Forms.Button();
            this.nacimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonoTBX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.correoTBX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPBX)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subirFotoBTN
            // 
            this.subirFotoBTN.Location = new System.Drawing.Point(12, 198);
            this.subirFotoBTN.Name = "subirFotoBTN";
            this.subirFotoBTN.Size = new System.Drawing.Size(128, 23);
            this.subirFotoBTN.TabIndex = 1;
            this.subirFotoBTN.Text = "Subir foto";
            this.subirFotoBTN.UseVisualStyleBackColor = true;
            this.subirFotoBTN.Click += new System.EventHandler(this.subirFotoBTN_Click);
            // 
            // abrirFotoFD
            // 
            this.abrirFotoFD.FileName = "openFileDialog1";
            // 
            // guardarBTN
            // 
            this.guardarBTN.BackColor = System.Drawing.Color.Red;
            this.guardarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBTN.FlatAppearance.BorderSize = 0;
            this.guardarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.guardarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBTN.ForeColor = System.Drawing.Color.Black;
            this.guardarBTN.Location = new System.Drawing.Point(649, 385);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(170, 44);
            this.guardarBTN.TabIndex = 16;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.UseVisualStyleBackColor = false;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // descartarBTN
            // 
            this.descartarBTN.BackColor = System.Drawing.Color.Red;
            this.descartarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.descartarBTN.FlatAppearance.BorderSize = 0;
            this.descartarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.descartarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descartarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descartarBTN.ForeColor = System.Drawing.Color.Black;
            this.descartarBTN.Location = new System.Drawing.Point(473, 385);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(170, 44);
            this.descartarBTN.TabIndex = 17;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = false;
            this.descartarBTN.Click += new System.EventHandler(this.descartarBTN_Click);
            // 
            // perfilPBX
            // 
            this.perfilPBX.BackColor = System.Drawing.Color.DarkGray;
            this.perfilPBX.Image = global::Body_Factory_Manager.Properties.Resources.cliente;
            this.perfilPBX.Location = new System.Drawing.Point(12, 37);
            this.perfilPBX.Name = "perfilPBX";
            this.perfilPBX.Size = new System.Drawing.Size(128, 128);
            this.perfilPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.perfilPBX.TabIndex = 0;
            this.perfilPBX.TabStop = false;
            // 
            // ingresoDTP
            // 
            this.ingresoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ingresoDTP.Location = new System.Drawing.Point(12, 255);
            this.ingresoDTP.Name = "ingresoDTP";
            this.ingresoDTP.Size = new System.Drawing.Size(128, 26);
            this.ingresoDTP.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Fecha de ingreso";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Agregado por:";
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLBL.Location = new System.Drawing.Point(9, 317);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(65, 20);
            this.usuarioLBL.TabIndex = 33;
            this.usuarioLBL.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.revisarEsto);
            this.panel1.Controls.Add(this.observacionesTbx);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grupoSanguineoCBX);
            this.panel1.Controls.Add(this.nombreTBX);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.patologiasTbx);
            this.panel1.Controls.Add(this.apellidoTBX);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cedulaTBX);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.direccionTBX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.enviarMensajeBTN);
            this.panel1.Controls.Add(this.nacimientoDTP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.telefonoTBX);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.correoTBX);
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel1.Size = new System.Drawing.Size(674, 367);
            this.panel1.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Número centro de salud";
            // 
            // revisarEsto
            // 
            this.revisarEsto.BackColor = System.Drawing.Color.Red;
            this.revisarEsto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisarEsto.Location = new System.Drawing.Point(9, 455);
            this.revisarEsto.Name = "revisarEsto";
            this.revisarEsto.Size = new System.Drawing.Size(186, 26);
            this.revisarEsto.TabIndex = 29;
            this.revisarEsto.Text = "EN PROCESO";
            // 
            // observacionesTbx
            // 
            this.observacionesTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionesTbx.Location = new System.Drawing.Point(443, 393);
            this.observacionesTbx.Multiline = true;
            this.observacionesTbx.Name = "observacionesTbx";
            this.observacionesTbx.Size = new System.Drawing.Size(186, 92);
            this.observacionesTbx.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Personales:";
            // 
            // grupoSanguineoCBX
            // 
            this.grupoSanguineoCBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoSanguineoCBX.FormattingEnabled = true;
            this.grupoSanguineoCBX.Items.AddRange(new object[] {
            "No especificado",
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.grupoSanguineoCBX.Location = new System.Drawing.Point(9, 391);
            this.grupoSanguineoCBX.Name = "grupoSanguineoCBX";
            this.grupoSanguineoCBX.Size = new System.Drawing.Size(186, 28);
            this.grupoSanguineoCBX.TabIndex = 26;
            // 
            // nombreTBX
            // 
            this.nombreTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTBX.Location = new System.Drawing.Point(7, 73);
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(216, 26);
            this.nombreTBX.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Patologías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // patologiasTbx
            // 
            this.patologiasTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patologiasTbx.Location = new System.Drawing.Point(229, 391);
            this.patologiasTbx.Multiline = true;
            this.patologiasTbx.Name = "patologiasTbx";
            this.patologiasTbx.Size = new System.Drawing.Size(186, 95);
            this.patologiasTbx.TabIndex = 24;
            // 
            // apellidoTBX
            // 
            this.apellidoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTBX.Location = new System.Drawing.Point(229, 73);
            this.apellidoTBX.Name = "apellidoTBX";
            this.apellidoTBX.Size = new System.Drawing.Size(406, 26);
            this.apellidoTBX.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Grupo sanguíneo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Datos de salud:";
            // 
            // cedulaTBX
            // 
            this.cedulaTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTBX.Location = new System.Drawing.Point(7, 140);
            this.cedulaTBX.MaxLength = 8;
            this.cedulaTBX.Name = "cedulaTBX";
            this.cedulaTBX.Size = new System.Drawing.Size(185, 26);
            this.cedulaTBX.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cédula";
            // 
            // direccionTBX
            // 
            this.direccionTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTBX.Location = new System.Drawing.Point(325, 140);
            this.direccionTBX.Name = "direccionTBX";
            this.direccionTBX.Size = new System.Drawing.Size(310, 26);
            this.direccionTBX.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contacto:";
            // 
            // enviarMensajeBTN
            // 
            this.enviarMensajeBTN.Location = new System.Drawing.Point(421, 266);
            this.enviarMensajeBTN.Name = "enviarMensajeBTN";
            this.enviarMensajeBTN.Size = new System.Drawing.Size(93, 29);
            this.enviarMensajeBTN.TabIndex = 18;
            this.enviarMensajeBTN.Text = "Enviar Mensaje";
            this.enviarMensajeBTN.UseVisualStyleBackColor = true;
            this.enviarMensajeBTN.Click += new System.EventHandler(this.enviarMensajeBTN_Click);
            // 
            // nacimientoDTP
            // 
            this.nacimientoDTP.CalendarForeColor = System.Drawing.Color.White;
            this.nacimientoDTP.CalendarMonthBackground = System.Drawing.Color.Red;
            this.nacimientoDTP.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.nacimientoDTP.CalendarTitleForeColor = System.Drawing.Color.White;
            this.nacimientoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimientoDTP.Location = new System.Drawing.Point(198, 140);
            this.nacimientoDTP.Name = "nacimientoDTP";
            this.nacimientoDTP.Size = new System.Drawing.Size(121, 26);
            this.nacimientoDTP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // telefonoTBX
            // 
            this.telefonoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTBX.Location = new System.Drawing.Point(229, 269);
            this.telefonoTBX.MaxLength = 9;
            this.telefonoTBX.Name = "telefonoTBX";
            this.telefonoTBX.Size = new System.Drawing.Size(186, 26);
            this.telefonoTBX.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Correo electrónico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de teléfono";
            // 
            // correoTBX
            // 
            this.correoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTBX.Location = new System.Drawing.Point(9, 269);
            this.correoTBX.Name = "correoTBX";
            this.correoTBX.Size = new System.Drawing.Size(186, 26);
            this.correoTBX.TabIndex = 14;
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usuarioLBL);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ingresoDTP);
            this.Controls.Add(this.descartarBTN);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.subirFotoBTN);
            this.Controls.Add(this.perfilPBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DatosCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.DatosCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilPBX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private resources.Custom.RoundPictureBox perfilPBX;
        private System.Windows.Forms.Button subirFotoBTN;
        private System.Windows.Forms.OpenFileDialog abrirFotoFD;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Button descartarBTN;
        private System.Windows.Forms.DateTimePicker ingresoDTP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox revisarEsto;
        private System.Windows.Forms.TextBox observacionesTbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox grupoSanguineoCBX;
        private System.Windows.Forms.TextBox nombreTBX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patologiasTbx;
        private System.Windows.Forms.TextBox apellidoTBX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cedulaTBX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccionTBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enviarMensajeBTN;
        private System.Windows.Forms.DateTimePicker nacimientoDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonoTBX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox correoTBX;
    }
}