namespace pryRodriguezSportsCenterIEFI
{
    partial class frmListadoDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeudores));
            this.PLateral = new System.Windows.Forms.Panel();
            this.lblMontoDeuda = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblSociosDeudores = new System.Windows.Forms.Label();
            this.lblCantidadSociosDeudores = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PCentral = new System.Windows.Forms.Panel();
            this.dgvListadoDeudores = new System.Windows.Forms.DataGridView();
            this.NumeroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.lblMontoDeuda);
            this.PLateral.Controls.Add(this.lblTotalDeuda);
            this.PLateral.Controls.Add(this.lblSociosDeudores);
            this.PLateral.Controls.Add(this.lblCantidadSociosDeudores);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 419);
            this.PLateral.TabIndex = 24;
            // 
            // lblMontoDeuda
            // 
            this.lblMontoDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDeuda.ForeColor = System.Drawing.Color.White;
            this.lblMontoDeuda.Location = new System.Drawing.Point(24, 284);
            this.lblMontoDeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoDeuda.Name = "lblMontoDeuda";
            this.lblMontoDeuda.Size = new System.Drawing.Size(131, 25);
            this.lblMontoDeuda.TabIndex = 23;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeuda.Location = new System.Drawing.Point(21, 253);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(127, 18);
            this.lblTotalDeuda.TabIndex = 22;
            this.lblTotalDeuda.Text = "TOTAL DEUDA:";
            // 
            // lblSociosDeudores
            // 
            this.lblSociosDeudores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSociosDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSociosDeudores.ForeColor = System.Drawing.Color.White;
            this.lblSociosDeudores.Location = new System.Drawing.Point(24, 200);
            this.lblSociosDeudores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSociosDeudores.Name = "lblSociosDeudores";
            this.lblSociosDeudores.Size = new System.Drawing.Size(131, 25);
            this.lblSociosDeudores.TabIndex = 21;
            // 
            // lblCantidadSociosDeudores
            // 
            this.lblCantidadSociosDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSociosDeudores.ForeColor = System.Drawing.Color.White;
            this.lblCantidadSociosDeudores.Location = new System.Drawing.Point(21, 148);
            this.lblCantidadSociosDeudores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadSociosDeudores.Name = "lblCantidadSociosDeudores";
            this.lblCantidadSociosDeudores.Size = new System.Drawing.Size(167, 41);
            this.lblCantidadSociosDeudores.TabIndex = 20;
            this.lblCantidadSociosDeudores.Text = "CANTIDAD SOCIOS DEUDORES:";
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
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.dgvListadoDeudores);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.cmdListar);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1192, 419);
            this.PCentral.TabIndex = 25;
            // 
            // dgvListadoDeudores
            // 
            this.dgvListadoDeudores.AllowUserToAddRows = false;
            this.dgvListadoDeudores.AllowUserToDeleteRows = false;
            this.dgvListadoDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Telefono,
            this.Domicilio,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvListadoDeudores.Location = new System.Drawing.Point(226, 102);
            this.dgvListadoDeudores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListadoDeudores.Name = "dgvListadoDeudores";
            this.dgvListadoDeudores.ReadOnly = true;
            this.dgvListadoDeudores.RowHeadersWidth = 51;
            this.dgvListadoDeudores.RowTemplate.Height = 24;
            this.dgvListadoDeudores.Size = new System.Drawing.Size(954, 239);
            this.dgvListadoDeudores.TabIndex = 22;
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
            // Telefono
            // 
            this.Telefono.HeaderText = "TELEFONO";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "DOMICILIO";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
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
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(267, 29);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(875, 62);
            this.lblLeyenda.TabIndex = 2;
            this.lblLeyenda.Text = "Pulsa LISTAR para obtener una vista de todos los socios en situacion de DEUDA";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(226, 361);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 20;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(1105, 361);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 31);
            this.cmdListar.TabIndex = 21;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmListadoDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 419);
            this.Controls.Add(this.PLateral);
            this.Controls.Add(this.PCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Listado socios deudores";
            this.PLateral.ResumeLayout(false);
            this.PLateral.PerformLayout();
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Label lblMontoDeuda;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblSociosDeudores;
        private System.Windows.Forms.Label lblCantidadSociosDeudores;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.DataGridView dgvListadoDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdListar;
    }
}