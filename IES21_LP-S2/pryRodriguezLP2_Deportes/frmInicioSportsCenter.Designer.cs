namespace pryRodriguezBaseDeDatosDeportesV2
{
    partial class frmInicioSportsCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSportsCenter));
            this.MSPantallaDeInicio = new System.Windows.Forms.MenuStrip();
            this.TSMRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRegistroDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRegistroEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConsultaDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConsultaEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMModificarDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMModificarEntrenadores = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEliminarDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEliminarEntrenadores = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.SSInicio = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.MSPantallaDeInicio.SuspendLayout();
            this.SSInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // MSPantallaDeInicio
            // 
            this.MSPantallaDeInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMRegistro,
            this.TSMConsulta,
            this.TSMModificar,
            this.TSMEliminar,
            this.TSMSalir});
            this.MSPantallaDeInicio.Location = new System.Drawing.Point(0, 0);
            this.MSPantallaDeInicio.Name = "MSPantallaDeInicio";
            this.MSPantallaDeInicio.Size = new System.Drawing.Size(391, 24);
            this.MSPantallaDeInicio.TabIndex = 7;
            this.MSPantallaDeInicio.Text = "menuStrip1";
            // 
            // TSMRegistro
            // 
            this.TSMRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMRegistroDeportista,
            this.TSMRegistroEntrenador});
            this.TSMRegistro.Name = "TSMRegistro";
            this.TSMRegistro.Size = new System.Drawing.Size(62, 20);
            this.TSMRegistro.Text = "Registro";
            // 
            // TSMRegistroDeportista
            // 
            this.TSMRegistroDeportista.Name = "TSMRegistroDeportista";
            this.TSMRegistroDeportista.Size = new System.Drawing.Size(132, 22);
            this.TSMRegistroDeportista.Text = "Deportista";
            this.TSMRegistroDeportista.Click += new System.EventHandler(this.TSMRegistroDeportista_Click);
            // 
            // TSMRegistroEntrenador
            // 
            this.TSMRegistroEntrenador.Name = "TSMRegistroEntrenador";
            this.TSMRegistroEntrenador.Size = new System.Drawing.Size(132, 22);
            this.TSMRegistroEntrenador.Text = "Entrenador";
            this.TSMRegistroEntrenador.Click += new System.EventHandler(this.TSMRegistroEntrenador_Click);
            // 
            // TSMConsulta
            // 
            this.TSMConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMConsultaDeportista,
            this.TSMConsultaEntrenador});
            this.TSMConsulta.Name = "TSMConsulta";
            this.TSMConsulta.Size = new System.Drawing.Size(66, 20);
            this.TSMConsulta.Text = "Consulta";
            // 
            // TSMConsultaDeportista
            // 
            this.TSMConsultaDeportista.Name = "TSMConsultaDeportista";
            this.TSMConsultaDeportista.Size = new System.Drawing.Size(132, 22);
            this.TSMConsultaDeportista.Text = "Deportista";
            this.TSMConsultaDeportista.Click += new System.EventHandler(this.TSMConsultaDeportista_Click);
            // 
            // TSMConsultaEntrenador
            // 
            this.TSMConsultaEntrenador.Name = "TSMConsultaEntrenador";
            this.TSMConsultaEntrenador.Size = new System.Drawing.Size(132, 22);
            this.TSMConsultaEntrenador.Text = "Entrenador";
            this.TSMConsultaEntrenador.Click += new System.EventHandler(this.TSMConsultaEntrenador_Click);
            // 
            // TSMModificar
            // 
            this.TSMModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMModificarDeportista,
            this.TSMModificarEntrenadores});
            this.TSMModificar.Name = "TSMModificar";
            this.TSMModificar.Size = new System.Drawing.Size(70, 20);
            this.TSMModificar.Text = "Modificar";
            // 
            // TSMModificarDeportista
            // 
            this.TSMModificarDeportista.Name = "TSMModificarDeportista";
            this.TSMModificarDeportista.Size = new System.Drawing.Size(143, 22);
            this.TSMModificarDeportista.Text = "Deportista";
            this.TSMModificarDeportista.Click += new System.EventHandler(this.TSMModificarDeportista_Click);
            // 
            // TSMModificarEntrenadores
            // 
            this.TSMModificarEntrenadores.Name = "TSMModificarEntrenadores";
            this.TSMModificarEntrenadores.Size = new System.Drawing.Size(143, 22);
            this.TSMModificarEntrenadores.Text = "Entrenadores";
            this.TSMModificarEntrenadores.Click += new System.EventHandler(this.TSMModificarEntrenadores_Click);
            // 
            // TSMEliminar
            // 
            this.TSMEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMEliminarDeportista,
            this.TSMEliminarEntrenadores});
            this.TSMEliminar.Name = "TSMEliminar";
            this.TSMEliminar.Size = new System.Drawing.Size(62, 20);
            this.TSMEliminar.Text = "Eliminar";
            // 
            // TSMEliminarDeportista
            // 
            this.TSMEliminarDeportista.Name = "TSMEliminarDeportista";
            this.TSMEliminarDeportista.Size = new System.Drawing.Size(143, 22);
            this.TSMEliminarDeportista.Text = "Deportista";
            this.TSMEliminarDeportista.Click += new System.EventHandler(this.TSMEliminarDeportista_Click);
            // 
            // TSMEliminarEntrenadores
            // 
            this.TSMEliminarEntrenadores.Name = "TSMEliminarEntrenadores";
            this.TSMEliminarEntrenadores.Size = new System.Drawing.Size(143, 22);
            this.TSMEliminarEntrenadores.Text = "Entrenadores";
            this.TSMEliminarEntrenadores.Click += new System.EventHandler(this.TSMEliminarEntrenadores_Click);
            // 
            // TSMSalir
            // 
            this.TSMSalir.Name = "TSMSalir";
            this.TSMSalir.Size = new System.Drawing.Size(41, 20);
            this.TSMSalir.Text = "Salir";
            this.TSMSalir.Click += new System.EventHandler(this.TSMSalir_Click);
            // 
            // SSInicio
            // 
            this.SSInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.SSInicio.Location = new System.Drawing.Point(0, 227);
            this.SSInicio.Name = "SSInicio";
            this.SSInicio.Size = new System.Drawing.Size(391, 22);
            this.SSInicio.TabIndex = 8;
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
            // PBImagen
            // 
            this.PBImagen.Image = ((System.Drawing.Image)(resources.GetObject("PBImagen.Image")));
            this.PBImagen.Location = new System.Drawing.Point(1, 27);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(390, 197);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 9;
            this.PBImagen.TabStop = false;
            // 
            // frmInicioSportsCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 249);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.SSInicio);
            this.Controls.Add(this.MSPantallaDeInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSportsCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Sports Center";
            this.Load += new System.EventHandler(this.frmPantallaDeInicio_Load);
            this.MSPantallaDeInicio.ResumeLayout(false);
            this.MSPantallaDeInicio.PerformLayout();
            this.SSInicio.ResumeLayout(false);
            this.SSInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSPantallaDeInicio;
        private System.Windows.Forms.ToolStripMenuItem TSMRegistro;
        private System.Windows.Forms.ToolStripMenuItem TSMRegistroDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMRegistroEntrenador;
        private System.Windows.Forms.ToolStripMenuItem TSMConsulta;
        private System.Windows.Forms.ToolStripMenuItem TSMConsultaDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMConsultaEntrenador;
        private System.Windows.Forms.ToolStripMenuItem TSMModificar;
        private System.Windows.Forms.ToolStripMenuItem TSMModificarDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMModificarEntrenadores;
        private System.Windows.Forms.ToolStripMenuItem TSMEliminar;
        private System.Windows.Forms.ToolStripMenuItem TSMEliminarDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMEliminarEntrenadores;
        private System.Windows.Forms.ToolStripMenuItem TSMSalir;
        private System.Windows.Forms.StatusStrip SSInicio;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.PictureBox PBImagen;
    }
}

