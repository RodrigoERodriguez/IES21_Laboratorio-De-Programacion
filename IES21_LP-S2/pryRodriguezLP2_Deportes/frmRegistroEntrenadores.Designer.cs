namespace pryRodriguezBaseDeDatosDeportesV2
{
    partial class frmRegistroEntrenadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEntrenadores));
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.PBInformacion = new System.Windows.Forms.PictureBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.SSRegistro = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).BeginInit();
            this.SSRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lstDeporte);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.txtProvincia);
            this.mrcDatos.Controls.Add(this.lblProvincia);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.lblDeporte);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.txtCodigo);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Location = new System.Drawing.Point(12, 95);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(249, 232);
            this.mrcDatos.TabIndex = 77;
            this.mrcDatos.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(116, 13);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "Codigo Entrenador:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 48;
            this.lblApellido.Text = "Apellido:";
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
            this.lstDeporte.Location = new System.Drawing.Point(143, 190);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 57;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 49;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(143, 156);
            this.txtProvincia.MaxLength = 15;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ShortcutsEnabled = false;
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 56;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            this.txtProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvincia_KeyPress);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(6, 159);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(64, 13);
            this.lblProvincia.TabIndex = 50;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(143, 122);
            this.txtDireccion.MaxLength = 25;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 55;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(6, 198);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(56, 13);
            this.lblDeporte.TabIndex = 51;
            this.lblDeporte.Text = "Deporte:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(143, 93);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 54;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(143, 35);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ShortcutsEnabled = false;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 52;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 64);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 53;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // PBInformacion
            // 
            this.PBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("PBInformacion.Image")));
            this.PBInformacion.Location = new System.Drawing.Point(12, 18);
            this.PBInformacion.Name = "PBInformacion";
            this.PBInformacion.Size = new System.Drawing.Size(52, 50);
            this.PBInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBInformacion.TabIndex = 76;
            this.PBInformacion.TabStop = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(70, 18);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(191, 59);
            this.lblLeyenda.TabIndex = 75;
            this.lblLeyenda.Text = "El codigo entrenador es UNICO e INSTRASFERIBLE, se conforma unicamente por LETRAS" +
    ".";
            // 
            // SSRegistro
            // 
            this.SSRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.SSRegistro.Location = new System.Drawing.Point(0, 402);
            this.SSRegistro.Name = "SSRegistro";
            this.SSRegistro.Size = new System.Drawing.Size(275, 22);
            this.SSRegistro.TabIndex = 74;
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
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 343);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(79, 33);
            this.cmdSalir.TabIndex = 73;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(182, 343);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(79, 33);
            this.cmdCargar.TabIndex = 72;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmRegistroEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 424);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.PBInformacion);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.SSRegistro);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Entrenadores";
            this.Load += new System.EventHandler(this.frmRegistroEntrenadores_Load);
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
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox PBInformacion;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.StatusStrip SSRegistro;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCargar;
    }
}