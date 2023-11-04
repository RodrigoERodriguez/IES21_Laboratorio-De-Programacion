namespace pryRodriguezSportsCenterIEFI
{
    partial class frmListadoPorBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPorBarrio));
            this.PLateral = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblCantidadSocios = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PCentral = new System.Windows.Forms.Panel();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.dgvListadoPorBarrio = new System.Windows.Forms.DataGridView();
            this.NumeroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPorBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.lblClientes);
            this.PLateral.Controls.Add(this.lblCantidadSocios);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 450);
            this.PLateral.TabIndex = 27;
            // 
            // lblClientes
            // 
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(28, 264);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(131, 25);
            this.lblClientes.TabIndex = 19;
            // 
            // lblCantidadSocios
            // 
            this.lblCantidadSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSocios.ForeColor = System.Drawing.Color.White;
            this.lblCantidadSocios.Location = new System.Drawing.Point(25, 207);
            this.lblCantidadSocios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadSocios.Name = "lblCantidadSocios";
            this.lblCantidadSocios.Size = new System.Drawing.Size(122, 46);
            this.lblCantidadSocios.TabIndex = 17;
            this.lblCantidadSocios.Text = "CANTIDAD DE SOCIOS:";
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
            this.PCentral.Controls.Add(this.lstBarrio);
            this.PCentral.Controls.Add(this.lblActividades);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.dgvListadoPorBarrio);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.cmdListar);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1089, 450);
            this.PCentral.TabIndex = 28;
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(593, 92);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(97, 21);
            this.lstBarrio.TabIndex = 21;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.ForeColor = System.Drawing.Color.White;
            this.lblActividades.Location = new System.Drawing.Point(465, 86);
            this.lblActividades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(104, 25);
            this.lblActividades.TabIndex = 20;
            this.lblActividades.Text = "BARRIO:";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(389, 19);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(497, 42);
            this.lblLeyenda.TabIndex = 22;
            this.lblLeyenda.Text = "Selecciona el barrio y luego pulsa LISTAR\r\n";
            // 
            // dgvListadoPorBarrio
            // 
            this.dgvListadoPorBarrio.AllowUserToAddRows = false;
            this.dgvListadoPorBarrio.AllowUserToDeleteRows = false;
            this.dgvListadoPorBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPorBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Sexo,
            this.Telefono,
            this.Direccion,
            this.Actividad});
            this.dgvListadoPorBarrio.Location = new System.Drawing.Point(216, 140);
            this.dgvListadoPorBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListadoPorBarrio.Name = "dgvListadoPorBarrio";
            this.dgvListadoPorBarrio.ReadOnly = true;
            this.dgvListadoPorBarrio.RowHeadersWidth = 51;
            this.dgvListadoPorBarrio.RowTemplate.Height = 24;
            this.dgvListadoPorBarrio.Size = new System.Drawing.Size(850, 239);
            this.dgvListadoPorBarrio.TabIndex = 23;
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
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "NUMERO DE TELEFONO";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "DIRECCION";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "ACTIVIDAD";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(216, 398);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 24;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(991, 398);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 31);
            this.cmdListar.TabIndex = 25;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmListadoPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.PLateral);
            this.Controls.Add(this.PCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoPorBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Informe por barrio";
            this.Load += new System.EventHandler(this.frmListadoPorBarrio_Load);
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPorBarrio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblCantidadSocios;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.DataGridView dgvListadoPorBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdListar;
    }
}