namespace pryRodriguezSportsCenterIEFI
{
    partial class frmNuevoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoSocio));
            this.PCentral = new System.Windows.Forms.Panel();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmdAgregarActividad = new System.Windows.Forms.Button();
            this.cmdAgregarBarrio = new System.Windows.Forms.Button();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lstSexo = new System.Windows.Forms.ComboBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDatosDelSocio = new System.Windows.Forms.Label();
            this.PLateral = new System.Windows.Forms.Panel();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.mrcDatos.SuspendLayout();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.pickFoto);
            this.PCentral.Controls.Add(this.cmdGuardar);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.mrcDatos);
            this.PCentral.Controls.Add(this.lblDatosDelSocio);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(190, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(669, 524);
            this.PCentral.TabIndex = 13;
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(51, 161);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(163, 161);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 26;
            this.pickFoto.TabStop = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardar.Enabled = false;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(563, 466);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 31);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(248, 466);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 7;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.cmdAgregarActividad);
            this.mrcDatos.Controls.Add(this.cmdAgregarBarrio);
            this.mrcDatos.Controls.Add(this.mskFecha);
            this.mrcDatos.Controls.Add(this.lblFechaDeNacimiento);
            this.mrcDatos.Controls.Add(this.txtSaldo);
            this.mrcDatos.Controls.Add(this.lblSaldo);
            this.mrcDatos.Controls.Add(this.lstSexo);
            this.mrcDatos.Controls.Add(this.mskDni);
            this.mrcDatos.Controls.Add(this.mskTelefono);
            this.mrcDatos.Controls.Add(this.lstBarrio);
            this.mrcDatos.Controls.Add(this.lstActividad);
            this.mrcDatos.Controls.Add(this.txtDomicilio);
            this.mrcDatos.Controls.Add(this.txtEmail);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblEmail);
            this.mrcDatos.Controls.Add(this.lblActividad);
            this.mrcDatos.Controls.Add(this.lblBarrio);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.lblDomicilio);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lblDni);
            this.mrcDatos.Controls.Add(this.lblSexo);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Location = new System.Drawing.Point(246, 88);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(392, 346);
            this.mrcDatos.TabIndex = 1;
            this.mrcDatos.TabStop = false;
            // 
            // cmdAgregarActividad
            // 
            this.cmdAgregarActividad.Location = new System.Drawing.Point(153, 250);
            this.cmdAgregarActividad.Name = "cmdAgregarActividad";
            this.cmdAgregarActividad.Size = new System.Drawing.Size(25, 26);
            this.cmdAgregarActividad.TabIndex = 25;
            this.cmdAgregarActividad.Text = "+";
            this.cmdAgregarActividad.UseVisualStyleBackColor = true;
            this.cmdAgregarActividad.Click += new System.EventHandler(this.cmdAgregarActividad_Click);
            // 
            // cmdAgregarBarrio
            // 
            this.cmdAgregarBarrio.Location = new System.Drawing.Point(348, 195);
            this.cmdAgregarBarrio.Name = "cmdAgregarBarrio";
            this.cmdAgregarBarrio.Size = new System.Drawing.Size(25, 26);
            this.cmdAgregarBarrio.TabIndex = 24;
            this.cmdAgregarBarrio.Text = "+";
            this.cmdAgregarBarrio.UseVisualStyleBackColor = true;
            this.cmdAgregarBarrio.Click += new System.EventHandler(this.cmdAgregarBarrio_Click);
            // 
            // mskFecha
            // 
            this.mskFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFecha.Location = new System.Drawing.Point(221, 89);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(117, 20);
            this.mskFecha.TabIndex = 23;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            this.mskFecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskFecha_MaskInputRejected);
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(218, 73);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(155, 16);
            this.lblFechaDeNacimiento.TabIndex = 22;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(221, 250);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(117, 20);
            this.txtSaldo.TabIndex = 20;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(218, 231);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(52, 16);
            this.lblSaldo.TabIndex = 21;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lstSexo
            // 
            this.lstSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.lstSexo.Location = new System.Drawing.Point(30, 143);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(117, 21);
            this.lstSexo.TabIndex = 18;
            this.lstSexo.SelectedIndexChanged += new System.EventHandler(this.lstSexo_SelectedIndexChanged);
            // 
            // mskDni
            // 
            this.mskDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDni.Location = new System.Drawing.Point(29, 89);
            this.mskDni.Mask = "00000000";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(117, 20);
            this.mskDni.TabIndex = 17;
            this.mskDni.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDni_MaskInputRejected);
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(221, 142);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(117, 20);
            this.mskTelefono.TabIndex = 16;
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(221, 197);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(117, 21);
            this.lstBarrio.TabIndex = 15;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(30, 251);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(117, 21);
            this.lstActividad.TabIndex = 14;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(30, 196);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(117, 20);
            this.txtDomicilio.TabIndex = 13;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(30, 304);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(222, 44);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(117, 20);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(30, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(27, 285);
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
            this.lblActividad.Location = new System.Drawing.Point(27, 231);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(76, 16);
            this.lblActividad.TabIndex = 8;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.ForeColor = System.Drawing.Color.White;
            this.lblBarrio.Location = new System.Drawing.Point(218, 177);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(53, 16);
            this.lblBarrio.TabIndex = 7;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(218, 124);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 16);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(27, 177);
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
            this.lblApellido.Location = new System.Drawing.Point(219, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(27, 73);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 16);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "Dni:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(27, 124);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 16);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(27, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDatosDelSocio
            // 
            this.lblDatosDelSocio.AutoSize = true;
            this.lblDatosDelSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelSocio.ForeColor = System.Drawing.Color.White;
            this.lblDatosDelSocio.Location = new System.Drawing.Point(217, 44);
            this.lblDatosDelSocio.Name = "lblDatosDelSocio";
            this.lblDatosDelSocio.Size = new System.Drawing.Size(218, 25);
            this.lblDatosDelSocio.TabIndex = 0;
            this.lblDatosDelSocio.Text = "DATOS DEL SOCIO";
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.lblLeyenda);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 524);
            this.PLateral.TabIndex = 12;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(8, 177);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(176, 156);
            this.lblLeyenda.TabIndex = 3;
            this.lblLeyenda.Text = "No olvides pedir todos los datos necesarios para el registro al cliente";
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
            // frmNuevoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 524);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Nuevo socio";
            this.Load += new System.EventHandler(this.frmNuevoSocio_Load);
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.PictureBox pickFoto;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button cmdAgregarActividad;
        private System.Windows.Forms.Button cmdAgregarBarrio;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox lstSexo;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDatosDelSocio;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
    }
}