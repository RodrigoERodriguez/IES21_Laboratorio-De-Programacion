namespace pryRodriguezSportsCenterIEFI
{
    partial class frmBuscarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarSocio));
            this.PCentral = new System.Windows.Forms.Panel();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mrcEstadoCliente = new System.Windows.Forms.GroupBox();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblDatosDelSocio = new System.Windows.Forms.Label();
            this.PLateral = new System.Windows.Forms.Panel();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.PCentral.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.mrcEstadoCliente.SuspendLayout();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.cmdBuscar);
            this.PCentral.Controls.Add(this.mrcDatos);
            this.PCentral.Controls.Add(this.mrcEstadoCliente);
            this.PCentral.Controls.Add(this.cmdImprimir);
            this.PCentral.Controls.Add(this.txtDni);
            this.PCentral.Controls.Add(this.lblDni);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.lblDatosDelSocio);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(190, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(430, 640);
            this.PCentral.TabIndex = 15;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBuscar.Enabled = false;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(317, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 31);
            this.cmdBuscar.TabIndex = 15;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtBarrio);
            this.mrcDatos.Controls.Add(this.txtActividad);
            this.mrcDatos.Controls.Add(this.txtSexo);
            this.mrcDatos.Controls.Add(this.txtFechaDeNacimiento);
            this.mrcDatos.Controls.Add(this.lblFechaDeNacimiento);
            this.mrcDatos.Controls.Add(this.txtDomicilio);
            this.mrcDatos.Controls.Add(this.txtEmail);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.txtTelefono);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblBarrio);
            this.mrcDatos.Controls.Add(this.lblEmail);
            this.mrcDatos.Controls.Add(this.lblActividad);
            this.mrcDatos.Controls.Add(this.lblDomicilio);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lblSexo);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Location = new System.Drawing.Point(38, 113);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(364, 295);
            this.mrcDatos.TabIndex = 21;
            this.mrcDatos.TabStop = false;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.Location = new System.Drawing.Point(200, 209);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.ReadOnly = true;
            this.txtBarrio.Size = new System.Drawing.Size(117, 21);
            this.txtBarrio.TabIndex = 28;
            this.txtBarrio.TextChanged += new System.EventHandler(this.txtBarrio_TextChanged);
            // 
            // txtActividad
            // 
            this.txtActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad.Location = new System.Drawing.Point(29, 209);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.ReadOnly = true;
            this.txtActividad.Size = new System.Drawing.Size(117, 21);
            this.txtActividad.TabIndex = 27;
            this.txtActividad.TextChanged += new System.EventHandler(this.txtActividad_TextChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(29, 104);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(117, 21);
            this.txtSexo.TabIndex = 26;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(200, 104);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.ReadOnly = true;
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(117, 21);
            this.txtFechaDeNacimiento.TabIndex = 25;
            this.txtFechaDeNacimiento.TextChanged += new System.EventHandler(this.txtFechaDeNacimiento_TextChanged);
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(197, 84);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(155, 16);
            this.lblFechaDeNacimiento.TabIndex = 24;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(29, 158);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(117, 21);
            this.txtDomicilio.TabIndex = 13;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(29, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(271, 21);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(200, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(117, 21);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(197, 136);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 16);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(200, 158);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(117, 21);
            this.txtTelefono.TabIndex = 16;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(29, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(117, 21);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.ForeColor = System.Drawing.Color.White;
            this.lblBarrio.Location = new System.Drawing.Point(197, 190);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(53, 16);
            this.lblBarrio.TabIndex = 7;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(26, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.Color.White;
            this.lblActividad.Location = new System.Drawing.Point(26, 190);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(76, 16);
            this.lblActividad.TabIndex = 8;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(26, 136);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(76, 16);
            this.lblDomicilio.TabIndex = 5;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(197, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(26, 84);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 16);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(26, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // mrcEstadoCliente
            // 
            this.mrcEstadoCliente.Controls.Add(this.lblEstadoCliente);
            this.mrcEstadoCliente.Controls.Add(this.txtSaldo);
            this.mrcEstadoCliente.Controls.Add(this.lblSaldo);
            this.mrcEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEstadoCliente.ForeColor = System.Drawing.Color.White;
            this.mrcEstadoCliente.Location = new System.Drawing.Point(42, 441);
            this.mrcEstadoCliente.Name = "mrcEstadoCliente";
            this.mrcEstadoCliente.Size = new System.Drawing.Size(360, 128);
            this.mrcEstadoCliente.TabIndex = 9;
            this.mrcEstadoCliente.TabStop = false;
            this.mrcEstadoCliente.Text = "Estado de Cliente";
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCliente.Location = new System.Drawing.Point(51, 60);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(245, 47);
            this.lblEstadoCliente.TabIndex = 20;
            this.lblEstadoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(146, 24);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(117, 21);
            this.txtSaldo.TabIndex = 19;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(26, 30);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(52, 16);
            this.lblSaldo.TabIndex = 19;
            this.lblSaldo.Text = "Saldo:";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImprimir.Enabled = false;
            this.cmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Location = new System.Drawing.Point(327, 583);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(75, 31);
            this.cmdImprimir.TabIndex = 8;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = false;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(138, 28);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 21);
            this.txtDni.TabIndex = 14;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(32, 32);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(87, 16);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI SOCIO:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(42, 583);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 7;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblDatosDelSocio
            // 
            this.lblDatosDelSocio.AutoSize = true;
            this.lblDatosDelSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelSocio.ForeColor = System.Drawing.Color.White;
            this.lblDatosDelSocio.Location = new System.Drawing.Point(107, 85);
            this.lblDatosDelSocio.Name = "lblDatosDelSocio";
            this.lblDatosDelSocio.Size = new System.Drawing.Size(218, 25);
            this.lblDatosDelSocio.TabIndex = 0;
            this.lblDatosDelSocio.Text = "DATOS DEL SOCIO";
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 640);
            this.PLateral.TabIndex = 14;
            // 
            // PLogo
            // 
            this.PLogo.Controls.Add(this.PBLogo);
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(190, 100);
            this.PLogo.TabIndex = 0;
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.White;
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(190, 100);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 3;
            this.PBLogo.TabStop = false;
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // frmBuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 640);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Buscar socio";
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.mrcEstadoCliente.ResumeLayout(false);
            this.mrcEstadoCliente.PerformLayout();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox mrcEstadoCliente;
        private System.Windows.Forms.Label lblEstadoCliente;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblDatosDelSocio;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}