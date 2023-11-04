namespace pryRodriguezBaseDeDatosDeportesV2
{
    partial class frmEliminarDeportistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarDeportistas));
            this.SSEliminar = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblApellidoED = new System.Windows.Forms.Label();
            this.lblDireccionED = new System.Windows.Forms.Label();
            this.lblDeporteED = new System.Windows.Forms.Label();
            this.lblEdadED = new System.Windows.Forms.Label();
            this.lblTelefonoED = new System.Windows.Forms.Label();
            this.lblNombreED = new System.Windows.Forms.Label();
            this.lblCodigoDeportistaED = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.PBInformacion = new System.Windows.Forms.PictureBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.SSEliminar.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // SSEliminar
            // 
            this.SSEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.SSEliminar.Location = new System.Drawing.Point(0, 471);
            this.SSEliminar.Name = "SSEliminar";
            this.SSEliminar.Size = new System.Drawing.Size(294, 22);
            this.SSEliminar.TabIndex = 68;
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
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.Location = new System.Drawing.Point(170, 85);
            this.txtCodigoDeportista.MaxLength = 5;
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeportista.TabIndex = 67;
            this.txtCodigoDeportista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDeportista_KeyPress);
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportista.Location = new System.Drawing.Point(12, 88);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoDeportista.TabIndex = 66;
            this.lblCodigoDeportista.Text = "Codigo Deportista:";
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblApellidoED);
            this.mrcDatos.Controls.Add(this.lblDireccionED);
            this.mrcDatos.Controls.Add(this.lblDeporteED);
            this.mrcDatos.Controls.Add(this.lblEdadED);
            this.mrcDatos.Controls.Add(this.lblTelefonoED);
            this.mrcDatos.Controls.Add(this.lblNombreED);
            this.mrcDatos.Controls.Add(this.lblCodigoDeportistaED);
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.lblEdad);
            this.mrcDatos.Controls.Add(this.lblDeporte);
            this.mrcDatos.Location = new System.Drawing.Point(15, 159);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(258, 243);
            this.mrcDatos.TabIndex = 65;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos Deportista";
            // 
            // lblApellidoED
            // 
            this.lblApellidoED.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellidoED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellidoED.Location = new System.Drawing.Point(155, 79);
            this.lblApellidoED.Name = "lblApellidoED";
            this.lblApellidoED.Size = new System.Drawing.Size(82, 22);
            this.lblApellidoED.TabIndex = 78;
            this.lblApellidoED.Click += new System.EventHandler(this.lblApellidoED_Click);
            // 
            // lblDireccionED
            // 
            this.lblDireccionED.BackColor = System.Drawing.SystemColors.Control;
            this.lblDireccionED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDireccionED.Location = new System.Drawing.Point(155, 108);
            this.lblDireccionED.Name = "lblDireccionED";
            this.lblDireccionED.Size = new System.Drawing.Size(82, 22);
            this.lblDireccionED.TabIndex = 77;
            this.lblDireccionED.Click += new System.EventHandler(this.lblDireccionED_Click);
            // 
            // lblDeporteED
            // 
            this.lblDeporteED.BackColor = System.Drawing.SystemColors.Control;
            this.lblDeporteED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeporteED.Location = new System.Drawing.Point(155, 201);
            this.lblDeporteED.Name = "lblDeporteED";
            this.lblDeporteED.Size = new System.Drawing.Size(82, 22);
            this.lblDeporteED.TabIndex = 76;
            this.lblDeporteED.Click += new System.EventHandler(this.lblDeporteED_Click);
            // 
            // lblEdadED
            // 
            this.lblEdadED.BackColor = System.Drawing.SystemColors.Control;
            this.lblEdadED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEdadED.Location = new System.Drawing.Point(155, 170);
            this.lblEdadED.Name = "lblEdadED";
            this.lblEdadED.Size = new System.Drawing.Size(82, 22);
            this.lblEdadED.TabIndex = 75;
            this.lblEdadED.Click += new System.EventHandler(this.lblEdadED_Click);
            // 
            // lblTelefonoED
            // 
            this.lblTelefonoED.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelefonoED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefonoED.Location = new System.Drawing.Point(155, 139);
            this.lblTelefonoED.Name = "lblTelefonoED";
            this.lblTelefonoED.Size = new System.Drawing.Size(82, 22);
            this.lblTelefonoED.TabIndex = 74;
            this.lblTelefonoED.Click += new System.EventHandler(this.lblTelefonoED_Click);
            // 
            // lblNombreED
            // 
            this.lblNombreED.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreED.Location = new System.Drawing.Point(155, 48);
            this.lblNombreED.Name = "lblNombreED";
            this.lblNombreED.Size = new System.Drawing.Size(82, 22);
            this.lblNombreED.TabIndex = 73;
            this.lblNombreED.Click += new System.EventHandler(this.lblNombreED_Click);
            // 
            // lblCodigoDeportistaED
            // 
            this.lblCodigoDeportistaED.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigoDeportistaED.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoDeportistaED.Location = new System.Drawing.Point(155, 17);
            this.lblCodigoDeportistaED.Name = "lblCodigoDeportistaED";
            this.lblCodigoDeportistaED.Size = new System.Drawing.Size(82, 22);
            this.lblCodigoDeportistaED.TabIndex = 72;
            this.lblCodigoDeportistaED.Click += new System.EventHandler(this.lblCodigoDeportistaED_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(112, 13);
            this.lblCodigo.TabIndex = 69;
            this.lblCodigo.Text = "Codigo Deportista:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 70;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(15, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 71;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(15, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 61;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(15, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 13);
            this.lblTelefono.TabIndex = 62;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(15, 179);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 13);
            this.lblEdad.TabIndex = 63;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(15, 210);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(56, 13);
            this.lblDeporte.TabIndex = 64;
            this.lblDeporte.Text = "Deporte:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(15, 417);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 28);
            this.cmdSalir.TabIndex = 62;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(198, 417);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 28);
            this.cmdEliminar.TabIndex = 63;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(195, 121);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 64;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // PBInformacion
            // 
            this.PBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("PBInformacion.Image")));
            this.PBInformacion.Location = new System.Drawing.Point(15, 12);
            this.PBInformacion.Name = "PBInformacion";
            this.PBInformacion.Size = new System.Drawing.Size(52, 50);
            this.PBInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBInformacion.TabIndex = 76;
            this.PBInformacion.TabStop = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(86, 18);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(193, 44);
            this.lblLeyenda.TabIndex = 75;
            this.lblLeyenda.Text = "Recuerda, el codigo deportista es UNICO e INSTRASFERIBLE, se conforma unicamente " +
    "por LETRAS.";
            // 
            // frmEliminarDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 493);
            this.Controls.Add(this.PBInformacion);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.SSEliminar);
            this.Controls.Add(this.txtCodigoDeportista);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarDeportistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Deportistas";
            this.Load += new System.EventHandler(this.frmEliminarDeportistas_Load);
            this.SSEliminar.ResumeLayout(false);
            this.SSEliminar.PerformLayout();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SSEliminar;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblApellidoED;
        private System.Windows.Forms.Label lblDireccionED;
        private System.Windows.Forms.Label lblDeporteED;
        private System.Windows.Forms.Label lblEdadED;
        private System.Windows.Forms.Label lblTelefonoED;
        private System.Windows.Forms.Label lblNombreED;
        private System.Windows.Forms.Label lblCodigoDeportistaED;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.PictureBox PBInformacion;
        private System.Windows.Forms.Label lblLeyenda;
    }
}