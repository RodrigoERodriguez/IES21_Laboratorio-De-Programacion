namespace pryRodriguezSportsCenterIEFI
{
    partial class frmListadoDeSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeSocios));
            this.dgvListadoSocios = new System.Windows.Forms.DataGridView();
            this.NumeroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLateral = new System.Windows.Forms.Panel();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PCentral = new System.Windows.Forms.Panel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSocios)).BeginInit();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoSocios
            // 
            this.dgvListadoSocios.AllowUserToAddRows = false;
            this.dgvListadoSocios.AllowUserToDeleteRows = false;
            this.dgvListadoSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSocio,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.FechaNacimiento,
            this.Sexo,
            this.Telefono,
            this.Domicilio,
            this.Barrio,
            this.Actividad,
            this.Saldo,
            this.Correo});
            this.dgvListadoSocios.Location = new System.Drawing.Point(216, 40);
            this.dgvListadoSocios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListadoSocios.Name = "dgvListadoSocios";
            this.dgvListadoSocios.ReadOnly = true;
            this.dgvListadoSocios.RowHeadersWidth = 51;
            this.dgvListadoSocios.RowTemplate.Height = 24;
            this.dgvListadoSocios.Size = new System.Drawing.Size(1255, 239);
            this.dgvListadoSocios.TabIndex = 20;
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
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "FECHA DE NACIMIENTO";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
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
            // Correo
            // 
            this.Correo.HeaderText = "EMAIL";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.lblLeyenda);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 362);
            this.PLateral.TabIndex = 19;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(21, 128);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(152, 187);
            this.lblLeyenda.TabIndex = 2;
            this.lblLeyenda.Text = "Pulsa LISTAR para obtener una vista de todos los clientes que tenemos asociados e" +
    "n nuestra red de gimnasios en CORDOBA";
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
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.cmdListar);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(1483, 362);
            this.PCentral.TabIndex = 21;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(612, 295);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 16;
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
            this.cmdListar.Location = new System.Drawing.Point(992, 295);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 31);
            this.cmdListar.TabIndex = 17;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmListadoDeSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 362);
            this.Controls.Add(this.dgvListadoSocios);
            this.Controls.Add(this.PLateral);
            this.Controls.Add(this.PCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Listado de socios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSocios)).EndInit();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdListar;
    }
}