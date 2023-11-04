namespace pryRodriguezTPAgriculturaV1
{
    partial class frmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstNombreCultivo = new System.Windows.Forms.ComboBox();
            this.lstNombreLocalidad = new System.Windows.Forms.ComboBox();
            this.mskToneladaPro = new System.Windows.Forms.MaskedTextBox();
            this.cmdCargarProduccion = new System.Windows.Forms.Button();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lblNombreCultivoP = new System.Windows.Forms.Label();
            this.lblLeyendaProduccion = new System.Windows.Forms.Label();
            this.lblNombreLocalidadP = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFecha.Location = new System.Drawing.Point(92, 68);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(258, 23);
            this.dtpFecha.TabIndex = 40;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(14, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "Fecha:";
            // 
            // lstNombreCultivo
            // 
            this.lstNombreCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreCultivo.FormattingEnabled = true;
            this.lstNombreCultivo.Location = new System.Drawing.Point(198, 153);
            this.lstNombreCultivo.Name = "lstNombreCultivo";
            this.lstNombreCultivo.Size = new System.Drawing.Size(152, 21);
            this.lstNombreCultivo.TabIndex = 38;
            // 
            // lstNombreLocalidad
            // 
            this.lstNombreLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreLocalidad.FormattingEnabled = true;
            this.lstNombreLocalidad.Location = new System.Drawing.Point(198, 107);
            this.lstNombreLocalidad.Name = "lstNombreLocalidad";
            this.lstNombreLocalidad.Size = new System.Drawing.Size(152, 21);
            this.lstNombreLocalidad.TabIndex = 37;
            // 
            // mskToneladaPro
            // 
            this.mskToneladaPro.Location = new System.Drawing.Point(198, 196);
            this.mskToneladaPro.Mask = "99999";
            this.mskToneladaPro.Name = "mskToneladaPro";
            this.mskToneladaPro.Size = new System.Drawing.Size(46, 20);
            this.mskToneladaPro.TabIndex = 36;
            this.mskToneladaPro.ValidatingType = typeof(int);
            // 
            // cmdCargarProduccion
            // 
            this.cmdCargarProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarProduccion.Location = new System.Drawing.Point(275, 243);
            this.cmdCargarProduccion.Name = "cmdCargarProduccion";
            this.cmdCargarProduccion.Size = new System.Drawing.Size(75, 30);
            this.cmdCargarProduccion.TabIndex = 35;
            this.cmdCargarProduccion.Text = "Cargar";
            this.cmdCargarProduccion.UseVisualStyleBackColor = true;
            this.cmdCargarProduccion.Click += new System.EventHandler(this.cmdCargarProduccion_Click);
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladas.Location = new System.Drawing.Point(14, 199);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(137, 13);
            this.lblToneladas.TabIndex = 34;
            this.lblToneladas.Text = "Toneladas Producidas:";
            // 
            // lblNombreCultivoP
            // 
            this.lblNombreCultivoP.AutoSize = true;
            this.lblNombreCultivoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCultivoP.Location = new System.Drawing.Point(14, 156);
            this.lblNombreCultivoP.Name = "lblNombreCultivoP";
            this.lblNombreCultivoP.Size = new System.Drawing.Size(115, 13);
            this.lblNombreCultivoP.TabIndex = 33;
            this.lblNombreCultivoP.Text = "Nombre de Cultivo:";
            // 
            // lblLeyendaProduccion
            // 
            this.lblLeyendaProduccion.AutoSize = true;
            this.lblLeyendaProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblLeyendaProduccion.Location = new System.Drawing.Point(77, 20);
            this.lblLeyendaProduccion.Name = "lblLeyendaProduccion";
            this.lblLeyendaProduccion.Size = new System.Drawing.Size(223, 30);
            this.lblLeyendaProduccion.TabIndex = 32;
            this.lblLeyendaProduccion.Text = "Ingrese los datos";
            // 
            // lblNombreLocalidadP
            // 
            this.lblNombreLocalidadP.AutoSize = true;
            this.lblNombreLocalidadP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidadP.Location = new System.Drawing.Point(14, 110);
            this.lblNombreLocalidadP.Name = "lblNombreLocalidadP";
            this.lblNombreLocalidadP.Size = new System.Drawing.Size(131, 13);
            this.lblNombreLocalidadP.TabIndex = 31;
            this.lblNombreLocalidadP.Text = "Nombre de Localidad:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(17, 243);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 27);
            this.cmdSalir.TabIndex = 41;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 285);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lstNombreCultivo);
            this.Controls.Add(this.lstNombreLocalidad);
            this.Controls.Add(this.mskToneladaPro);
            this.Controls.Add(this.cmdCargarProduccion);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblNombreCultivoP);
            this.Controls.Add(this.lblLeyendaProduccion);
            this.Controls.Add(this.lblNombreLocalidadP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox lstNombreCultivo;
        private System.Windows.Forms.ComboBox lstNombreLocalidad;
        private System.Windows.Forms.MaskedTextBox mskToneladaPro;
        private System.Windows.Forms.Button cmdCargarProduccion;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.Label lblNombreCultivoP;
        private System.Windows.Forms.Label lblLeyendaProduccion;
        private System.Windows.Forms.Label lblNombreLocalidadP;
        private System.Windows.Forms.Button cmdSalir;
    }
}