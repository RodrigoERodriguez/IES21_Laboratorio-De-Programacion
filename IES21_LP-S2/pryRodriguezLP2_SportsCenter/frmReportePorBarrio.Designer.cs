namespace pryRodriguezSportsCenterIEFI
{
    partial class frmReportePorBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePorBarrio));
            this.PCentral = new System.Windows.Forms.Panel();
            this.dgvReporteBarrio = new System.Windows.Forms.DataGridView();
            this.NumeroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar2 = new System.Windows.Forms.Button();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblActividades = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.PLateral = new System.Windows.Forms.Panel();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.cmdImprimirReporte = new System.Windows.Forms.Button();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteBarrio)).BeginInit();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.dgvReporteBarrio);
            this.PCentral.Controls.Add(this.cmdListar2);
            this.PCentral.Controls.Add(this.lstBarrio);
            this.PCentral.Controls.Add(this.lblActividades);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.cmdListar);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(245, 0);
            this.PCentral.Margin = new System.Windows.Forms.Padding(4);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1040, 413);
            this.PCentral.TabIndex = 13;
            // 
            // dgvReporteBarrio
            // 
            this.dgvReporteBarrio.AllowUserToAddRows = false;
            this.dgvReporteBarrio.AllowUserToDeleteRows = false;
            this.dgvReporteBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvReporteBarrio.Location = new System.Drawing.Point(32, 178);
            this.dgvReporteBarrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporteBarrio.Name = "dgvReporteBarrio";
            this.dgvReporteBarrio.ReadOnly = true;
            this.dgvReporteBarrio.RowHeadersWidth = 51;
            this.dgvReporteBarrio.RowTemplate.Height = 24;
            this.dgvReporteBarrio.Size = new System.Drawing.Size(924, 197);
            this.dgvReporteBarrio.TabIndex = 28;
            // 
            // NumeroDeSocio
            // 
            this.NumeroDeSocio.HeaderText = "N SOCIO";
            this.NumeroDeSocio.MinimumWidth = 6;
            this.NumeroDeSocio.Name = "NumeroDeSocio";
            this.NumeroDeSocio.ReadOnly = true;
            this.NumeroDeSocio.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 125;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "BARRIO";
            this.Barrio.MinimumWidth = 6;
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 125;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "ACTIVIDAD";
            this.Actividad.MinimumWidth = 6;
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            this.Actividad.Width = 125;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "SALDO";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 125;
            // 
            // cmdListar2
            // 
            this.cmdListar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdListar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar2.Location = new System.Drawing.Point(591, 126);
            this.cmdListar2.Margin = new System.Windows.Forms.Padding(4);
            this.cmdListar2.Name = "cmdListar2";
            this.cmdListar2.Size = new System.Drawing.Size(100, 38);
            this.cmdListar2.TabIndex = 27;
            this.cmdListar2.Text = "Listar";
            this.cmdListar2.UseVisualStyleBackColor = false;
            this.cmdListar2.Click += new System.EventHandler(this.cmdListar2_Click);
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(418, 140);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(128, 24);
            this.lstBarrio.TabIndex = 25;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.ForeColor = System.Drawing.Color.White;
            this.lblActividades.Location = new System.Drawing.Point(278, 133);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(134, 31);
            this.lblActividades.TabIndex = 24;
            this.lblActividades.Text = "BARRIO:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(35, 516);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(100, 38);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(28, 9);
            this.lblLeyenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(832, 143);
            this.lblLeyenda.TabIndex = 22;
            this.lblLeyenda.Text = "Puedes imprimir el reporte detallado con toda la informacion presionando el boton" +
    " \"IMPRIMIR REPORTE\"\r\nPuedes generar un reporte junto a un balance general presio" +
    "nando el boton \"GENERAR REPORTE\"\r\n";
            // 
            // cmdListar
            // 
            this.cmdListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(356, 516);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(100, 38);
            this.cmdListar.TabIndex = 20;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Controls.Add(this.cmdImprimirReporte);
            this.PLateral.Controls.Add(this.cmdGenerarReporte);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Margin = new System.Windows.Forms.Padding(4);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(245, 413);
            this.PLateral.TabIndex = 12;
            // 
            // PLogo
            // 
            this.PLogo.Controls.Add(this.PBLogo);
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(245, 123);
            this.PLogo.TabIndex = 0;
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.White;
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(245, 123);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 3;
            this.PBLogo.TabStop = false;
            // 
            // cmdImprimirReporte
            // 
            this.cmdImprimirReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdImprimirReporte.BackColor = System.Drawing.Color.Silver;
            this.cmdImprimirReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImprimirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImprimirReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimirReporte.Location = new System.Drawing.Point(16, 178);
            this.cmdImprimirReporte.Margin = new System.Windows.Forms.Padding(4);
            this.cmdImprimirReporte.Name = "cmdImprimirReporte";
            this.cmdImprimirReporte.Size = new System.Drawing.Size(224, 38);
            this.cmdImprimirReporte.TabIndex = 22;
            this.cmdImprimirReporte.Text = "IMPRIMIR REPORTE";
            this.cmdImprimirReporte.UseVisualStyleBackColor = false;
            this.cmdImprimirReporte.Click += new System.EventHandler(this.cmdImprimirReporte_Click);
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdGenerarReporte.BackColor = System.Drawing.Color.Silver;
            this.cmdGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerarReporte.Location = new System.Drawing.Point(16, 275);
            this.cmdGenerarReporte.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(224, 38);
            this.cmdGenerarReporte.TabIndex = 21;
            this.cmdGenerarReporte.Text = "GENERAR REPORTE";
            this.cmdGenerarReporte.UseVisualStyleBackColor = false;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // frmReportePorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 413);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportePorBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Reporte barrios";
            this.Load += new System.EventHandler(this.frmReportePorBarrio_Load);
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteBarrio)).EndInit();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Button cmdImprimirReporte;
        private System.Windows.Forms.Button cmdGenerarReporte;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Button cmdListar2;
        private System.Windows.Forms.DataGridView dgvReporteBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}