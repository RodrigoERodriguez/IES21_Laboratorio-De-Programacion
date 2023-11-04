namespace pryRodriguezBaseDeDatosDeportesV2
{
    partial class frmRegistroDeportistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeportistas));
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.mskEdad = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.PBInformacion = new System.Windows.Forms.PictureBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.SSRegistro = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).BeginInit();
            this.SSRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblCodigoDeportista);
            this.mrcDatos.Controls.Add(this.lstDeporte);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.mskTelefono);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.mskEdad);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.lblEdad);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblDeporte);
            this.mrcDatos.Controls.Add(this.txtCodigo);
            this.mrcDatos.Location = new System.Drawing.Point(12, 91);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(249, 240);
            this.mrcDatos.TabIndex = 75;
            this.mrcDatos.TabStop = false;
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportista.Location = new System.Drawing.Point(6, 16);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoDeportista.TabIndex = 47;
            this.lblCodigoDeportista.Text = "Codigo Deportista:";
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "RUGBY",
            "ATLETISMO",
            "PADEL",
            "HANDBALL"});
            this.lstDeporte.Location = new System.Drawing.Point(143, 194);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 60;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(143, 132);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(100, 20);
            this.mskTelefono.TabIndex = 59;
            this.mskTelefono.ValidatingType = typeof(int);
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "Apellido:";
            // 
            // mskEdad
            // 
            this.mskEdad.Location = new System.Drawing.Point(143, 164);
            this.mskEdad.Mask = "00";
            this.mskEdad.Name = "mskEdad";
            this.mskEdad.Size = new System.Drawing.Size(42, 20);
            this.mskEdad.TabIndex = 58;
            this.mskEdad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskEdad_MaskInputRejected);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 109);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 50;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(143, 103);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 57;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 140);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 13);
            this.lblTelefono.TabIndex = 51;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(143, 74);
            this.txtApellido.MaxLength = 10;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 56;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(6, 171);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 13);
            this.lblEdad.TabIndex = 52;
            this.lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 45);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 55;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(6, 202);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(56, 13);
            this.lblDeporte.TabIndex = 53;
            this.lblDeporte.Text = "Deporte:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(143, 16);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ShortcutsEnabled = false;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 54;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(184, 347);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(79, 33);
            this.cmdCargar.TabIndex = 70;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // PBInformacion
            // 
            this.PBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("PBInformacion.Image")));
            this.PBInformacion.Location = new System.Drawing.Point(12, 22);
            this.PBInformacion.Name = "PBInformacion";
            this.PBInformacion.Size = new System.Drawing.Size(52, 50);
            this.PBInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBInformacion.TabIndex = 74;
            this.PBInformacion.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 347);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(79, 33);
            this.cmdSalir.TabIndex = 71;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(70, 28);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(193, 44);
            this.lblLeyenda.TabIndex = 73;
            this.lblLeyenda.Text = "El codigo deportista es UNICO e INSTRASFERIBLE, se conforma unicamente por LETRAS" +
    ".";
            // 
            // SSRegistro
            // 
            this.SSRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.SSRegistro.Location = new System.Drawing.Point(0, 421);
            this.SSRegistro.Name = "SSRegistro";
            this.SSRegistro.Size = new System.Drawing.Size(280, 22);
            this.SSRegistro.TabIndex = 72;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // frmRegistroDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 443);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.PBInformacion);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.SSRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeportistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Deportistas";
            this.Load += new System.EventHandler(this.frmRegistroDeportistas_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).EndInit();
            this.SSRegistro.ResumeLayout(false);
            this.SSRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox mskEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.PictureBox PBInformacion;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.StatusStrip SSRegistro;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}