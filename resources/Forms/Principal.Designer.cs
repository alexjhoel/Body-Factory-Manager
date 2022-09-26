﻿
using System.Drawing;

namespace Body_Factory_Manager
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.controlTBLPNL = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreUsuarioLBL = new System.Windows.Forms.Label();
            this.timerMenuPNL = new System.Windows.Forms.Timer(this.components);
            this.timedLogin = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBTN = new System.Windows.Forms.PictureBox();
            this.cerrarVentanaBTN = new System.Windows.Forms.PictureBox();
            this.maximizarVentanaBTN = new System.Windows.Forms.PictureBox();
            this.minimizarVentanaBTN = new System.Windows.Forms.PictureBox();
            this.roundPictureBox1 = new Body_Factory_Manager.resources.Custom.RoundPictureBox();
            this.menuPNL = new Body_Factory_Manager.DoubleBufferPanel();
            this.adminBTN = new System.Windows.Forms.Button();
            this.configBTN = new System.Windows.Forms.Button();
            this.cuotasBTN = new System.Windows.Forms.Button();
            this.asistenciasBTN = new System.Windows.Forms.Button();
            this.clientesBTN = new System.Windows.Forms.Button();
            this.inicioBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoMenuPBX = new System.Windows.Forms.PictureBox();
            this.paginasPNL = new Body_Factory_Manager.DoubleBufferPanel();
            this.controlTBLPNL.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarVentanaBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarVentanaBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarVentanaBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.menuPNL.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMenuPBX)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTBLPNL
            // 
            this.controlTBLPNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlTBLPNL.BackColor = System.Drawing.Color.Transparent;
            this.controlTBLPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.controlTBLPNL.ColumnCount = 4;
            this.controlTBLPNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.controlTBLPNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.18243F));
            this.controlTBLPNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.81757F));
            this.controlTBLPNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.controlTBLPNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.controlTBLPNL.Controls.Add(this.menuBTN, 0, 0);
            this.controlTBLPNL.Controls.Add(this.label2, 1, 0);
            this.controlTBLPNL.Controls.Add(this.nombreUsuarioLBL, 2, 0);
            this.controlTBLPNL.Controls.Add(this.roundPictureBox1, 3, 0);
            this.controlTBLPNL.Location = new System.Drawing.Point(3, 3);
            this.controlTBLPNL.Name = "controlTBLPNL";
            this.controlTBLPNL.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.controlTBLPNL.RowCount = 1;
            this.controlTBLPNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlTBLPNL.Size = new System.Drawing.Size(724, 32);
            this.controlTBLPNL.TabIndex = 2;
            this.controlTBLPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlTBLPNL_MouseDown);
            this.controlTBLPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlTBLPNL_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Urzeit (Personal Use Only)", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(51, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "BODY FACTORY MANAGER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreUsuarioLBL
            // 
            this.nombreUsuarioLBL.AutoSize = true;
            this.nombreUsuarioLBL.BackColor = System.Drawing.Color.Transparent;
            this.nombreUsuarioLBL.Dock = System.Windows.Forms.DockStyle.Right;
            this.nombreUsuarioLBL.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioLBL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nombreUsuarioLBL.Location = new System.Drawing.Point(591, 0);
            this.nombreUsuarioLBL.Name = "nombreUsuarioLBL";
            this.nombreUsuarioLBL.Size = new System.Drawing.Size(62, 32);
            this.nombreUsuarioLBL.TabIndex = 7;
            this.nombreUsuarioLBL.Text = "Usuario";
            this.nombreUsuarioLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerMenuPNL
            // 
            this.timerMenuPNL.Interval = 10;
            this.timerMenuPNL.Tick += new System.EventHandler(this.timerMenuPNL_Tick);
            // 
            // timedLogin
            // 
            this.timedLogin.Interval = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.controlTBLPNL);
            this.panel1.Controls.Add(this.cerrarVentanaBTN);
            this.panel1.Controls.Add(this.maximizarVentanaBTN);
            this.panel1.Controls.Add(this.minimizarVentanaBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 38);
            this.panel1.TabIndex = 5;
            // 
            // menuBTN
            // 
            this.menuBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBTN.Image = global::Body_Factory_Manager.Properties.Resources.menu;
            this.menuBTN.Location = new System.Drawing.Point(18, 3);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(25, 26);
            this.menuBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBTN.TabIndex = 10;
            this.menuBTN.TabStop = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // cerrarVentanaBTN
            // 
            this.cerrarVentanaBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cerrarVentanaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarVentanaBTN.Image = global::Body_Factory_Manager.Properties.Resources.close_FILL0_wght400_GRAD0_opsz481;
            this.cerrarVentanaBTN.Location = new System.Drawing.Point(829, 0);
            this.cerrarVentanaBTN.Name = "cerrarVentanaBTN";
            this.cerrarVentanaBTN.Size = new System.Drawing.Size(37, 38);
            this.cerrarVentanaBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarVentanaBTN.TabIndex = 11;
            this.cerrarVentanaBTN.TabStop = false;
            this.cerrarVentanaBTN.Click += new System.EventHandler(this.cerrarVentanaBTN_Click);
            // 
            // maximizarVentanaBTN
            // 
            this.maximizarVentanaBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizarVentanaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarVentanaBTN.Image = global::Body_Factory_Manager.Properties.Resources.outfull;
            this.maximizarVentanaBTN.Location = new System.Drawing.Point(789, 0);
            this.maximizarVentanaBTN.Name = "maximizarVentanaBTN";
            this.maximizarVentanaBTN.Size = new System.Drawing.Size(34, 38);
            this.maximizarVentanaBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizarVentanaBTN.TabIndex = 12;
            this.maximizarVentanaBTN.TabStop = false;
            this.maximizarVentanaBTN.Click += new System.EventHandler(this.maximizarVentanaBTN_Click);
            // 
            // minimizarVentanaBTN
            // 
            this.minimizarVentanaBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizarVentanaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarVentanaBTN.Image = global::Body_Factory_Manager.Properties.Resources.minimize_png;
            this.minimizarVentanaBTN.Location = new System.Drawing.Point(745, 4);
            this.minimizarVentanaBTN.Name = "minimizarVentanaBTN";
            this.minimizarVentanaBTN.Size = new System.Drawing.Size(38, 32);
            this.minimizarVentanaBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarVentanaBTN.TabIndex = 13;
            this.minimizarVentanaBTN.TabStop = false;
            this.minimizarVentanaBTN.Click += new System.EventHandler(this.minimizarVentanaBTN_Click);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.roundPictureBox1.BackgroundImage = global::Body_Factory_Manager.Properties.Resources.tatu;
            this.roundPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundPictureBox1.Image = global::Body_Factory_Manager.Properties.Resources.tatu;
            this.roundPictureBox1.Location = new System.Drawing.Point(675, 3);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(29, 26);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 9;
            this.roundPictureBox1.TabStop = false;
            // 
            // menuPNL
            // 
            this.menuPNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.menuPNL.Controls.Add(this.adminBTN);
            this.menuPNL.Controls.Add(this.configBTN);
            this.menuPNL.Controls.Add(this.cuotasBTN);
            this.menuPNL.Controls.Add(this.asistenciasBTN);
            this.menuPNL.Controls.Add(this.clientesBTN);
            this.menuPNL.Controls.Add(this.inicioBTN);
            this.menuPNL.Controls.Add(this.panel2);
            this.menuPNL.Location = new System.Drawing.Point(0, 38);
            this.menuPNL.Name = "menuPNL";
            this.menuPNL.Size = new System.Drawing.Size(186, 403);
            this.menuPNL.TabIndex = 3;
            // 
            // adminBTN
            // 
            this.adminBTN.BackColor = System.Drawing.Color.Red;
            this.adminBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.adminBTN.FlatAppearance.BorderSize = 0;
            this.adminBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.adminBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBTN.ForeColor = System.Drawing.Color.Black;
            this.adminBTN.Image = ((System.Drawing.Image)(resources.GetObject("adminBTN.Image")));
            this.adminBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBTN.Location = new System.Drawing.Point(0, 319);
            this.adminBTN.Name = "adminBTN";
            this.adminBTN.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.adminBTN.Size = new System.Drawing.Size(185, 32);
            this.adminBTN.TabIndex = 8;
            this.adminBTN.Tag = "1";
            this.adminBTN.Text = "Admin";
            this.adminBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminBTN.UseVisualStyleBackColor = true;
            this.adminBTN.Click += new System.EventHandler(this.adminBTN_Click);
            // 
            // configBTN
            // 
            this.configBTN.BackColor = System.Drawing.Color.Red;
            this.configBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.configBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.configBTN.FlatAppearance.BorderSize = 0;
            this.configBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.configBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.configBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configBTN.ForeColor = System.Drawing.Color.Black;
            this.configBTN.Image = ((System.Drawing.Image)(resources.GetObject("configBTN.Image")));
            this.configBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configBTN.Location = new System.Drawing.Point(0, 281);
            this.configBTN.Name = "configBTN";
            this.configBTN.Size = new System.Drawing.Size(185, 32);
            this.configBTN.TabIndex = 6;
            this.configBTN.Tag = "1";
            this.configBTN.Text = "Configuración";
            this.configBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.configBTN.UseVisualStyleBackColor = true;
            // 
            // cuotasBTN
            // 
            this.cuotasBTN.BackColor = System.Drawing.Color.Red;
            this.cuotasBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuotasBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cuotasBTN.FlatAppearance.BorderSize = 0;
            this.cuotasBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cuotasBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cuotasBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotasBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotasBTN.ForeColor = System.Drawing.Color.Black;
            this.cuotasBTN.Image = ((System.Drawing.Image)(resources.GetObject("cuotasBTN.Image")));
            this.cuotasBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cuotasBTN.Location = new System.Drawing.Point(0, 243);
            this.cuotasBTN.Name = "cuotasBTN";
            this.cuotasBTN.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cuotasBTN.Size = new System.Drawing.Size(185, 32);
            this.cuotasBTN.TabIndex = 5;
            this.cuotasBTN.Tag = "1";
            this.cuotasBTN.Text = "Finanzas?";
            this.cuotasBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cuotasBTN.UseVisualStyleBackColor = true;
            this.cuotasBTN.Click += new System.EventHandler(this.cuotasBTN_Click);
            // 
            // asistenciasBTN
            // 
            this.asistenciasBTN.BackColor = System.Drawing.Color.Red;
            this.asistenciasBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.asistenciasBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.asistenciasBTN.FlatAppearance.BorderSize = 0;
            this.asistenciasBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.asistenciasBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.asistenciasBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asistenciasBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asistenciasBTN.ForeColor = System.Drawing.Color.Black;
            this.asistenciasBTN.Image = ((System.Drawing.Image)(resources.GetObject("asistenciasBTN.Image")));
            this.asistenciasBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.asistenciasBTN.Location = new System.Drawing.Point(0, 205);
            this.asistenciasBTN.Name = "asistenciasBTN";
            this.asistenciasBTN.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.asistenciasBTN.Size = new System.Drawing.Size(185, 32);
            this.asistenciasBTN.TabIndex = 4;
            this.asistenciasBTN.Tag = "1";
            this.asistenciasBTN.Text = "Asistencias";
            this.asistenciasBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.asistenciasBTN.UseVisualStyleBackColor = true;
            this.asistenciasBTN.Click += new System.EventHandler(this.asistenciasBTN_Click);
            // 
            // clientesBTN
            // 
            this.clientesBTN.BackColor = System.Drawing.Color.Red;
            this.clientesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientesBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.clientesBTN.FlatAppearance.BorderSize = 0;
            this.clientesBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.clientesBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clientesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesBTN.ForeColor = System.Drawing.Color.Black;
            this.clientesBTN.Image = ((System.Drawing.Image)(resources.GetObject("clientesBTN.Image")));
            this.clientesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientesBTN.Location = new System.Drawing.Point(0, 167);
            this.clientesBTN.Name = "clientesBTN";
            this.clientesBTN.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.clientesBTN.Size = new System.Drawing.Size(185, 32);
            this.clientesBTN.TabIndex = 3;
            this.clientesBTN.Tag = "1";
            this.clientesBTN.Text = "Clientes";
            this.clientesBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientesBTN.UseVisualStyleBackColor = true;
            this.clientesBTN.Click += new System.EventHandler(this.clientesBTN_Click);
            // 
            // inicioBTN
            // 
            this.inicioBTN.BackColor = System.Drawing.Color.Red;
            this.inicioBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inicioBTN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.inicioBTN.FlatAppearance.BorderSize = 0;
            this.inicioBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.inicioBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.inicioBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioBTN.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioBTN.ForeColor = System.Drawing.Color.Black;
            this.inicioBTN.Image = ((System.Drawing.Image)(resources.GetObject("inicioBTN.Image")));
            this.inicioBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inicioBTN.Location = new System.Drawing.Point(0, 129);
            this.inicioBTN.Name = "inicioBTN";
            this.inicioBTN.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.inicioBTN.Size = new System.Drawing.Size(185, 32);
            this.inicioBTN.TabIndex = 2;
            this.inicioBTN.Tag = "1";
            this.inicioBTN.Text = "Principal";
            this.inicioBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inicioBTN.UseVisualStyleBackColor = true;
            this.inicioBTN.Click += new System.EventHandler(this.inicioBTN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logoMenuPBX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 123);
            this.panel2.TabIndex = 1;
            // 
            // logoMenuPBX
            // 
            this.logoMenuPBX.BackColor = System.Drawing.Color.Transparent;
            this.logoMenuPBX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoMenuPBX.Image = global::Body_Factory_Manager.Properties.Resources.LogoBodyFactory;
            this.logoMenuPBX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoMenuPBX.Location = new System.Drawing.Point(0, 0);
            this.logoMenuPBX.Name = "logoMenuPBX";
            this.logoMenuPBX.Size = new System.Drawing.Size(186, 123);
            this.logoMenuPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoMenuPBX.TabIndex = 1;
            this.logoMenuPBX.TabStop = false;
            // 
            // paginasPNL
            // 
            this.paginasPNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paginasPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paginasPNL.Location = new System.Drawing.Point(44, 38);
            this.paginasPNL.Name = "paginasPNL";
            this.paginasPNL.Size = new System.Drawing.Size(822, 403);
            this.paginasPNL.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPNL);
            this.Controls.Add(this.paginasPNL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.controlTBLPNL.ResumeLayout(false);
            this.controlTBLPNL.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarVentanaBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarVentanaBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarVentanaBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.menuPNL.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoMenuPBX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel controlTBLPNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombreUsuarioLBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoMenuPBX;
        private System.Windows.Forms.Button inicioBTN;
        private resources.Custom.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.PictureBox menuBTN;
        private System.Windows.Forms.Timer timerMenuPNL;
        private System.Windows.Forms.Timer timedLogin;
        private System.Windows.Forms.PictureBox cerrarVentanaBTN;
        private System.Windows.Forms.PictureBox maximizarVentanaBTN;
        private System.Windows.Forms.PictureBox minimizarVentanaBTN;
        private System.Windows.Forms.Button configBTN;
        private System.Windows.Forms.Button cuotasBTN;
        private System.Windows.Forms.Button asistenciasBTN;
        private System.Windows.Forms.Button clientesBTN;
        private DoubleBufferPanel menuPNL;
        private DoubleBufferPanel paginasPNL;
        private System.Windows.Forms.Button adminBTN;
        private System.Windows.Forms.Panel panel1;
    }
}

