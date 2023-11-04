namespace pryRodriguezSportsCenterIEFI
{
    partial class frmListadoPorActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPorActividades));
            this.dgvListadoPorActividad = new System.Windows.Forms.DataGridView();
            this.NumeroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLateral = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.P = new System.Windows.Forms.Panel();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPorActividad)).BeginInit();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.P.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoPorActividad
            // 
            this.dgvListadoPorActividad.AllowUserToAddRows = false;
            this.dgvListadoPorActividad.AllowUserToDeleteRows = false;
            this.dgvListadoPorActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPorActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Sexo,
            this.NumeroTelefono,
            this.Barrio});
            this.dgvListadoPorActividad.Location = new System.Drawing.Point(216, 140);
            this.dgvListadoPorActividad.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListadoPorActividad.Name = "dgvListadoPorActividad";
            this.dgvListadoPorActividad.ReadOnly = true;
            this.dgvListadoPorActividad.RowHeadersWidth = 51;
            this.dgvListadoPorActividad.RowTemplate.Height = 24;
            this.dgvListadoPorActividad.Size = new System.Drawing.Size(753, 239);
            this.dgvListadoPorActividad.TabIndex = 24;
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
            // NumeroTelefono
            // 
            this.NumeroTelefono.HeaderText = "NUMERO DE TELEFONO";
            this.NumeroTelefono.Name = "NumeroTelefono";
            this.NumeroTelefono.ReadOnly = true;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "BARRIO";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.lblClientes);
            this.PLateral.Controls.Add(this.lblCantidadDeClientes);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 450);
            this.PLateral.TabIndex = 23;
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
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeClientes.ForeColor = System.Drawing.Color.White;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(25, 207);
            this.lblCantidadDeClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(122, 46);
            this.lblCantidadDeClientes.TabIndex = 17;
            this.lblCantidadDeClientes.Text = "CANTIDAD DE SOCIOS:";
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
            // P
            // 
            this.P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.P.Controls.Add(this.lstActividad);
            this.P.Controls.Add(this.lblActividades);
            this.P.Controls.Add(this.lblLeyenda);
            this.P.Controls.Add(this.cmdSalir);
            this.P.Controls.Add(this.cmdListar);
            this.P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P.Location = new System.Drawing.Point(0, 0);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(986, 450);
            this.P.TabIndex = 25;
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(579, 86);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(2);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(97, 21);
            this.lstActividad.TabIndex = 21;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.ForeColor = System.Drawing.Color.White;
            this.lblActividades.Location = new System.Drawing.Point(465, 86);
            this.lblActividades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(110, 20);
            this.lblActividades.TabIndex = 20;
            this.lblActividades.Text = "ACTIVIDAD:";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(389, 19);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(497, 42);
            this.lblLeyenda.TabIndex = 22;
            this.lblLeyenda.Text = "Selecciona la actividad y luego pulsa LISTAR";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(216, 398);
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
            this.cmdListar.Location = new System.Drawing.Point(894, 398);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 31);
            this.cmdListar.TabIndex = 21;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmListadoPorActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.dgvListadoPorActividad);
            this.Controls.Add(this.PLateral);
            this.Controls.Add(this.P);
            this.Name = "frmListadoPorActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Listado por actividad";
            this.Load += new System.EventHandler(this.frmListadoPorActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPorActividad)).EndInit();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.P.ResumeLayout(false);
            this.P.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPorActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Panel P;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdListar;
    }
}