namespace pryRodriguezBaseDeDatosDeportesV2
{
    partial class frmEliminarEntrenadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarEntrenadores));
            this.PBInformacion = new System.Windows.Forms.PictureBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.SSEliminar = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblApellidoEE = new System.Windows.Forms.Label();
            this.lblDireccionEE = new System.Windows.Forms.Label();
            this.lblDeporteEE = new System.Windows.Forms.Label();
            this.lblProvinciaEE = new System.Windows.Forms.Label();
            this.lblNombreEE = new System.Windows.Forms.Label();
            this.lblCodigoEntrenadorEE = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).BeginInit();
            this.SSEliminar.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBInformacion
            // 
            this.PBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("PBInformacion.Image")));
            this.PBInformacion.Location = new System.Drawing.Point(12, 12);
            this.PBInformacion.Name = "PBInformacion";
            this.PBInformacion.Size = new System.Drawing.Size(52, 50);
            this.PBInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBInformacion.TabIndex = 85;
            this.PBInformacion.TabStop = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(83, 18);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(193, 44);
            this.lblLeyenda.TabIndex = 84;
            this.lblLeyenda.Text = "Recuerda, el codigo deportista es UNICO e INSTRASFERIBLE, se conforma unicamente " +
    "por LETRAS.";
            // 
            // SSEliminar
            // 
            this.SSEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.SSEliminar.Location = new System.Drawing.Point(0, 447);
            this.SSEliminar.Name = "SSEliminar";
            this.SSEliminar.Size = new System.Drawing.Size(285, 22);
            this.SSEliminar.TabIndex = 83;
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
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(167, 85);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 82;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(9, 88);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoEntrenador.TabIndex = 81;
            this.lblCodigoEntrenador.Text = "Codigo Deportista:";
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblApellidoEE);
            this.mrcDatos.Controls.Add(this.lblDireccionEE);
            this.mrcDatos.Controls.Add(this.lblDeporteEE);
            this.mrcDatos.Controls.Add(this.lblProvinciaEE);
            this.mrcDatos.Controls.Add(this.lblNombreEE);
            this.mrcDatos.Controls.Add(this.lblCodigoEntrenadorEE);
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblProvincia);
            this.mrcDatos.Controls.Add(this.lblDeporte);
            this.mrcDatos.Location = new System.Drawing.Point(12, 159);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(258, 215);
            this.mrcDatos.TabIndex = 80;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos Entrenador";
            // 
            // lblApellidoEE
            // 
            this.lblApellidoEE.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellidoEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellidoEE.Location = new System.Drawing.Point(155, 79);
            this.lblApellidoEE.Name = "lblApellidoEE";
            this.lblApellidoEE.Size = new System.Drawing.Size(82, 22);
            this.lblApellidoEE.TabIndex = 78;
            this.lblApellidoEE.Click += new System.EventHandler(this.lblApellidoEE_Click);
            // 
            // lblDireccionEE
            // 
            this.lblDireccionEE.BackColor = System.Drawing.SystemColors.Control;
            this.lblDireccionEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDireccionEE.Location = new System.Drawing.Point(155, 108);
            this.lblDireccionEE.Name = "lblDireccionEE";
            this.lblDireccionEE.Size = new System.Drawing.Size(82, 22);
            this.lblDireccionEE.TabIndex = 77;
            this.lblDireccionEE.Click += new System.EventHandler(this.lblDireccionEE_Click);
            // 
            // lblDeporteEE
            // 
            this.lblDeporteEE.BackColor = System.Drawing.SystemColors.Control;
            this.lblDeporteEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeporteEE.Location = new System.Drawing.Point(155, 174);
            this.lblDeporteEE.Name = "lblDeporteEE";
            this.lblDeporteEE.Size = new System.Drawing.Size(86, 22);
            this.lblDeporteEE.TabIndex = 76;
            this.lblDeporteEE.Click += new System.EventHandler(this.lblDeporteEE_Click);
            // 
            // lblProvinciaEE
            // 
            this.lblProvinciaEE.BackColor = System.Drawing.SystemColors.Control;
            this.lblProvinciaEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProvinciaEE.Location = new System.Drawing.Point(155, 139);
            this.lblProvinciaEE.Name = "lblProvinciaEE";
            this.lblProvinciaEE.Size = new System.Drawing.Size(82, 22);
            this.lblProvinciaEE.TabIndex = 74;
            this.lblProvinciaEE.Click += new System.EventHandler(this.lblProvinciaEE_Click);
            // 
            // lblNombreEE
            // 
            this.lblNombreEE.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombreEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEE.Location = new System.Drawing.Point(155, 48);
            this.lblNombreEE.Name = "lblNombreEE";
            this.lblNombreEE.Size = new System.Drawing.Size(82, 22);
            this.lblNombreEE.TabIndex = 73;
            this.lblNombreEE.Click += new System.EventHandler(this.lblNombreEE_Click);
            // 
            // lblCodigoEntrenadorEE
            // 
            this.lblCodigoEntrenadorEE.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigoEntrenadorEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEntrenadorEE.Location = new System.Drawing.Point(155, 17);
            this.lblCodigoEntrenadorEE.Name = "lblCodigoEntrenadorEE";
            this.lblCodigoEntrenadorEE.Size = new System.Drawing.Size(82, 22);
            this.lblCodigoEntrenadorEE.TabIndex = 72;
            this.lblCodigoEntrenadorEE.Click += new System.EventHandler(this.lblCodigoEntrenadorEE_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(116, 13);
            this.lblCodigo.TabIndex = 69;
            this.lblCodigo.Text = "Codigo Entrenador:";
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
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(15, 148);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(64, 13);
            this.lblProvincia.TabIndex = 62;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(15, 183);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(56, 13);
            this.lblDeporte.TabIndex = 64;
            this.lblDeporte.Text = "Deporte:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(17, 391);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 28);
            this.cmdSalir.TabIndex = 77;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(200, 391);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 28);
            this.cmdEliminar.TabIndex = 78;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(192, 121);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 79;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // frmEliminarEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 469);
            this.Controls.Add(this.PBInformacion);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.SSEliminar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoEntrenador);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Entrenadores";
            this.Load += new System.EventHandler(this.frmEliminarEntrenadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBInformacion)).EndInit();
            this.SSEliminar.ResumeLayout(false);
            this.SSEliminar.PerformLayout();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBInformacion;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.StatusStrip SSEliminar;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblApellidoEE;
        private System.Windows.Forms.Label lblDireccionEE;
        private System.Windows.Forms.Label lblDeporteEE;
        private System.Windows.Forms.Label lblProvinciaEE;
        private System.Windows.Forms.Label lblNombreEE;
        private System.Windows.Forms.Label lblCodigoEntrenadorEE;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdBuscar;
    }
}