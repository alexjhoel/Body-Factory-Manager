
using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosCliente));
            this.abrirFotoFD = new System.Windows.Forms.OpenFileDialog();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.descartarBTN = new System.Windows.Forms.Button();
            this.ingresoDTP = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.telefonoSaludTBX = new System.Windows.Forms.TextBox();
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
            this.nacimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonoTBX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.correoTBX = new System.Windows.Forms.TextBox();
            this.subirFotoBTN = new System.Windows.Forms.Button();
            this.borrarPerfilBTN = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.borrarBTN = new System.Windows.Forms.Button();
            this.darDeBajaBTN = new System.Windows.Forms.Button();
            this.estadoLBL = new System.Windows.Forms.Label();
            this.estadoPNL = new System.Windows.Forms.Panel();
            this.perfilPBX = new Body_Factory_Manager.resources.Custom.RoundPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPBX)).BeginInit();
            this.SuspendLayout();
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
            this.guardarBTN.Location = new System.Drawing.Point(690, 389);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(129, 40);
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
            this.descartarBTN.Location = new System.Drawing.Point(553, 389);
            this.descartarBTN.Name = "descartarBTN";
            this.descartarBTN.Size = new System.Drawing.Size(131, 40);
            this.descartarBTN.TabIndex = 17;
            this.descartarBTN.Text = "Descartar";
            this.descartarBTN.UseVisualStyleBackColor = false;
            this.descartarBTN.Click += new System.EventHandler(this.descartarBTN_Click);
            // 
            // ingresoDTP
            // 
            this.ingresoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ingresoDTP.Location = new System.Drawing.Point(12, 244);
            this.ingresoDTP.Name = "ingresoDTP";
            this.ingresoDTP.Size = new System.Drawing.Size(128, 26);
            this.ingresoDTP.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Fecha de creación";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Agregado por:";
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLBL.Location = new System.Drawing.Point(12, 317);
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
            this.panel1.Controls.Add(this.telefonoSaludTBX);
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
            this.label14.Location = new System.Drawing.Point(5, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Número centro de salud";
            // 
            // telefonoSaludTBX
            // 
            this.telefonoSaludTBX.BackColor = System.Drawing.Color.White;
            this.telefonoSaludTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoSaludTBX.Location = new System.Drawing.Point(6, 449);
            this.telefonoSaludTBX.MaxLength = 20;
            this.telefonoSaludTBX.Name = "telefonoSaludTBX";
            this.telefonoSaludTBX.Size = new System.Drawing.Size(186, 26);
            this.telefonoSaludTBX.TabIndex = 29;
            // 
            // observacionesTbx
            // 
            this.observacionesTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionesTbx.Location = new System.Drawing.Point(440, 382);
            this.observacionesTbx.MaxLength = 200;
            this.observacionesTbx.Multiline = true;
            this.observacionesTbx.Name = "observacionesTbx";
            this.observacionesTbx.Size = new System.Drawing.Size(186, 92);
            this.observacionesTbx.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
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
            this.grupoSanguineoCBX.Location = new System.Drawing.Point(6, 380);
            this.grupoSanguineoCBX.Name = "grupoSanguineoCBX";
            this.grupoSanguineoCBX.Size = new System.Drawing.Size(186, 28);
            this.grupoSanguineoCBX.TabIndex = 26;
            // 
            // nombreTBX
            // 
            this.nombreTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTBX.Location = new System.Drawing.Point(4, 62);
            this.nombreTBX.MaxLength = 50;
            this.nombreTBX.Name = "nombreTBX";
            this.nombreTBX.Size = new System.Drawing.Size(216, 26);
            this.nombreTBX.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Patologías";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // patologiasTbx
            // 
            this.patologiasTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patologiasTbx.Location = new System.Drawing.Point(226, 380);
            this.patologiasTbx.MaxLength = 100;
            this.patologiasTbx.Multiline = true;
            this.patologiasTbx.Name = "patologiasTbx";
            this.patologiasTbx.Size = new System.Drawing.Size(186, 95);
            this.patologiasTbx.TabIndex = 24;
            // 
            // apellidoTBX
            // 
            this.apellidoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTBX.Location = new System.Drawing.Point(226, 62);
            this.apellidoTBX.MaxLength = 50;
            this.apellidoTBX.Name = "apellidoTBX";
            this.apellidoTBX.Size = new System.Drawing.Size(406, 26);
            this.apellidoTBX.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Grupo sanguíneo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Datos de salud:";
            // 
            // cedulaTBX
            // 
            this.cedulaTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTBX.Location = new System.Drawing.Point(4, 129);
            this.cedulaTBX.MaxLength = 8;
            this.cedulaTBX.Name = "cedulaTBX";
            this.cedulaTBX.Size = new System.Drawing.Size(185, 26);
            this.cedulaTBX.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cédula";
            // 
            // direccionTBX
            // 
            this.direccionTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTBX.Location = new System.Drawing.Point(322, 129);
            this.direccionTBX.MaxLength = 50;
            this.direccionTBX.Name = "direccionTBX";
            this.direccionTBX.Size = new System.Drawing.Size(310, 26);
            this.direccionTBX.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contacto:";
            // 
            // nacimientoDTP
            // 
            this.nacimientoDTP.CalendarForeColor = System.Drawing.Color.White;
            this.nacimientoDTP.CalendarMonthBackground = System.Drawing.Color.Red;
            this.nacimientoDTP.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.nacimientoDTP.CalendarTitleForeColor = System.Drawing.Color.White;
            this.nacimientoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimientoDTP.Location = new System.Drawing.Point(195, 129);
            this.nacimientoDTP.Name = "nacimientoDTP";
            this.nacimientoDTP.Size = new System.Drawing.Size(121, 26);
            this.nacimientoDTP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // telefonoTBX
            // 
            this.telefonoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTBX.Location = new System.Drawing.Point(226, 258);
            this.telefonoTBX.MaxLength = 9;
            this.telefonoTBX.Name = "telefonoTBX";
            this.telefonoTBX.Size = new System.Drawing.Size(186, 26);
            this.telefonoTBX.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Correo electrónico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de teléfono";
            // 
            // correoTBX
            // 
            this.correoTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTBX.Location = new System.Drawing.Point(6, 258);
            this.correoTBX.MaxLength = 100;
            this.correoTBX.Name = "correoTBX";
            this.correoTBX.Size = new System.Drawing.Size(186, 26);
            this.correoTBX.TabIndex = 14;
            // 
            // subirFotoBTN
            // 
            this.subirFotoBTN.BackColor = System.Drawing.Color.Red;
            this.subirFotoBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subirFotoBTN.FlatAppearance.BorderSize = 0;
            this.subirFotoBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.subirFotoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subirFotoBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold);
            this.subirFotoBTN.ForeColor = System.Drawing.Color.Black;
            this.subirFotoBTN.Location = new System.Drawing.Point(12, 171);
            this.subirFotoBTN.Name = "subirFotoBTN";
            this.subirFotoBTN.Size = new System.Drawing.Size(86, 26);
            this.subirFotoBTN.TabIndex = 34;
            this.subirFotoBTN.Text = "subir foto";
            this.subirFotoBTN.UseVisualStyleBackColor = false;
            this.subirFotoBTN.Click += new System.EventHandler(this.subirFotoBTN_Click);
            // 
            // borrarPerfilBTN
            // 
            this.borrarPerfilBTN.BackColor = System.Drawing.Color.Red;
            this.borrarPerfilBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrarPerfilBTN.FlatAppearance.BorderSize = 0;
            this.borrarPerfilBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.borrarPerfilBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarPerfilBTN.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Bold);
            this.borrarPerfilBTN.ForeColor = System.Drawing.Color.Black;
            this.borrarPerfilBTN.Image = ((System.Drawing.Image)(resources.GetObject("borrarPerfilBTN.Image")));
            this.borrarPerfilBTN.Location = new System.Drawing.Point(104, 167);
            this.borrarPerfilBTN.Name = "borrarPerfilBTN";
            this.borrarPerfilBTN.Size = new System.Drawing.Size(36, 34);
            this.borrarPerfilBTN.TabIndex = 35;
            this.borrarPerfilBTN.UseVisualStyleBackColor = false;
            this.borrarPerfilBTN.Click += new System.EventHandler(this.borrarBTN_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "HOLA";
            this.notifyIcon1.BalloonTipTitle = "HOLA";
            this.notifyIcon1.Text = "HOLA";
            this.notifyIcon1.Visible = true;
            // 
            // borrarBTN
            // 
            this.borrarBTN.BackColor = System.Drawing.Color.Red;
            this.borrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrarBTN.FlatAppearance.BorderSize = 0;
            this.borrarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.borrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarBTN.ForeColor = System.Drawing.Color.Black;
            this.borrarBTN.Location = new System.Drawing.Point(416, 389);
            this.borrarBTN.Name = "borrarBTN";
            this.borrarBTN.Size = new System.Drawing.Size(131, 40);
            this.borrarBTN.TabIndex = 36;
            this.borrarBTN.Text = "Borrar";
            this.borrarBTN.UseVisualStyleBackColor = false;
            this.borrarBTN.Click += new System.EventHandler(this.borrarBTN_Click_1);
            // 
            // darDeBajaBTN
            // 
            this.darDeBajaBTN.BackColor = System.Drawing.Color.Red;
            this.darDeBajaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.darDeBajaBTN.FlatAppearance.BorderSize = 0;
            this.darDeBajaBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.darDeBajaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darDeBajaBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darDeBajaBTN.ForeColor = System.Drawing.Color.Black;
            this.darDeBajaBTN.Location = new System.Drawing.Point(279, 389);
            this.darDeBajaBTN.Name = "darDeBajaBTN";
            this.darDeBajaBTN.Size = new System.Drawing.Size(131, 40);
            this.darDeBajaBTN.TabIndex = 37;
            this.darDeBajaBTN.Text = "Dar de baja";
            this.darDeBajaBTN.UseVisualStyleBackColor = false;
            this.darDeBajaBTN.Click += new System.EventHandler(this.darDeBajaBTN_Click);
            // 
            // estadoLBL
            // 
            this.estadoLBL.AutoSize = true;
            this.estadoLBL.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoLBL.Location = new System.Drawing.Point(166, 397);
            this.estadoLBL.Name = "estadoLBL";
            this.estadoLBL.Size = new System.Drawing.Size(75, 29);
            this.estadoLBL.TabIndex = 38;
            this.estadoLBL.Text = "Estado:";
            // 
            // estadoPNL
            // 
            this.estadoPNL.BackColor = System.Drawing.Color.Lime;
            this.estadoPNL.Location = new System.Drawing.Point(247, 397);
            this.estadoPNL.Name = "estadoPNL";
            this.estadoPNL.Size = new System.Drawing.Size(26, 26);
            this.estadoPNL.TabIndex = 39;
            // 
            // perfilPBX
            // 
            this.perfilPBX.BackColor = System.Drawing.Color.DarkGray;
            this.perfilPBX.Image = global::Body_Factory_Manager.Properties.Resources.clientePortrait;
            this.perfilPBX.Location = new System.Drawing.Point(12, 23);
            this.perfilPBX.Name = "perfilPBX";
            this.perfilPBX.Size = new System.Drawing.Size(128, 128);
            this.perfilPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.perfilPBX.TabIndex = 0;
            this.perfilPBX.TabStop = false;
            // 
            // DatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 442);
            this.Controls.Add(this.estadoPNL);
            this.Controls.Add(this.estadoLBL);
            this.Controls.Add(this.darDeBajaBTN);
            this.Controls.Add(this.borrarBTN);
            this.Controls.Add(this.borrarPerfilBTN);
            this.Controls.Add(this.subirFotoBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usuarioLBL);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ingresoDTP);
            this.Controls.Add(this.descartarBTN);
            this.Controls.Add(this.guardarBTN);
            this.Controls.Add(this.perfilPBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de cliente";
            this.Load += new System.EventHandler(this.DatosCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private resources.Custom.RoundPictureBox perfilPBX;
        private System.Windows.Forms.OpenFileDialog abrirFotoFD;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Button descartarBTN;
        private System.Windows.Forms.DateTimePicker ingresoDTP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.DateTimePicker nacimientoDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonoTBX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox correoTBX;
        private System.Windows.Forms.Button subirFotoBTN;
        private System.Windows.Forms.Button borrarPerfilBTN;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button borrarBTN;
        private System.Windows.Forms.Button darDeBajaBTN;
        private System.Windows.Forms.Label estadoLBL;
        private System.Windows.Forms.Panel estadoPNL;
        private System.Windows.Forms.TextBox telefonoSaludTBX;
    }
}