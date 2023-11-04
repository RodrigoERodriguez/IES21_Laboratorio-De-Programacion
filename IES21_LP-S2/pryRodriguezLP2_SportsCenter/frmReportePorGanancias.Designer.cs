namespace pryRodriguezSportsCenterIEFI
{
    partial class frmReportePorGanancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePorGanancias));
            this.PCentral = new System.Windows.Forms.Panel();
            this.dgvReporteGanancias = new System.Windows.Forms.DataGridView();
            this.NumeroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.PLateral = new System.Windows.Forms.Panel();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.cmdImprimirReporte = new System.Windows.Forms.Button();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGanancias)).BeginInit();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.dgvReporteGanancias);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.cmdListar);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(190, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(803, 450);
            this.PCentral.TabIndex = 13;
            // 
            // dgvReporteGanancias
            // 
            this.dgvReporteGanancias.AllowUserToAddRows = false;
            this.dgvReporteGanancias.AllowUserToDeleteRows = false;
            this.dgvReporteGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteGanancias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvReporteGanancias.Location = new System.Drawing.Point(26, 123);
            this.dgvReporteGanancias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReporteGanancias.Name = "dgvReporteGanancias";
            this.dgvReporteGanancias.ReadOnly = true;
            this.dgvReporteGanancias.RowHeadersWidth = 51;
            this.dgvReporteGanancias.RowTemplate.Height = 24;
            this.dgvReporteGanancias.Size = new System.Drawing.Size(753, 239);
            this.dgvReporteGanancias.TabIndex = 24;
            // 
            // NumeroDeSocio
            // 
            this.NumeroDeSocio.HeaderText = "N SOCIO";
            this.NumeroDeSocio.Name = "NumeroDeSocio";
            this.NumeroDeSocio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "BARRIO";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "ACTIVIDAD";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "SALDO";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(22, 384);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(23, 9);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(775, 103);
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
            this.cmdListar.Location = new System.Drawing.Point(700, 384);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 31);
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
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 450);
            this.PLateral.TabIndex = 12;
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
            // cmdImprimirReporte
            // 
            this.cmdImprimirReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdImprimirReporte.BackColor = System.Drawing.Color.Silver;
            this.cmdImprimirReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImprimirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImprimirReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimirReporte.Location = new System.Drawing.Point(12, 202);
            this.cmdImprimirReporte.Name = "cmdImprimirReporte";
            this.cmdImprimirReporte.Size = new System.Drawing.Size(168, 31);
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
            this.cmdGenerarReporte.Location = new System.Drawing.Point(12, 281);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(168, 31);
            this.cmdGenerarReporte.TabIndex = 21;
            this.cmdGenerarReporte.Text = "GENERAR REPORTE";
            this.cmdGenerarReporte.UseVisualStyleBackColor = false;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmReportePorGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportePorGanancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Reporte ganancias";
            this.Load += new System.EventHandler(this.frmReportePorGanancias_Load);
            this.PCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGanancias)).EndInit();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.DataGridView dgvReporteGanancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Button cmdImprimirReporte;
        private System.Windows.Forms.Button cmdGenerarReporte;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}