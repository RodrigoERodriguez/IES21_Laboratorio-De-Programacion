namespace pryRodriguezSportsCenterIEFI
{
    partial class frmModificarActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarActividad));
            this.PCentral = new System.Windows.Forms.Panel();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.PLateral = new System.Windows.Forms.Panel();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PCentral.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.PLateral.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.mrcDatos);
            this.PCentral.Controls.Add(this.cmdSalir);
            this.PCentral.Controls.Add(this.cmdGuardar);
            this.PCentral.Controls.Add(this.cmdBuscar);
            this.PCentral.Controls.Add(this.txtActividad);
            this.PCentral.Controls.Add(this.lblNombreBarrio);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(190, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(423, 489);
            this.PCentral.TabIndex = 20;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.mskTelefono);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.mskValor);
            this.mrcDatos.Controls.Add(this.label1);
            this.mrcDatos.Controls.Add(this.txtEmail);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblEmail);
            this.mrcDatos.Controls.Add(this.lblNombreProfesor);
            this.mrcDatos.Location = new System.Drawing.Point(25, 152);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(355, 267);
            this.mrcDatos.TabIndex = 25;
            this.mrcDatos.TabStop = false;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(33, 163);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(117, 20);
            this.mskTelefono.TabIndex = 30;
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(30, 145);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 16);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "Telefono:";
            // 
            // mskValor
            // 
            this.mskValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValor.Location = new System.Drawing.Point(30, 104);
            this.mskValor.Mask = "000000000";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(117, 20);
            this.mskValor.TabIndex = 28;
            this.mskValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskValor_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(33, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(30, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProfesor.Location = new System.Drawing.Point(27, 25);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(128, 16);
            this.lblNombreProfesor.TabIndex = 1;
            this.lblNombreProfesor.Text = "Nombre profesor:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(25, 435);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 24;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardar.Enabled = false;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(305, 435);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 31);
            this.cmdGuardar.TabIndex = 23;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBuscar.Enabled = false;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(288, 80);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 31);
            this.cmdBuscar.TabIndex = 22;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtActividad
            // 
            this.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad.Location = new System.Drawing.Point(251, 53);
            this.txtActividad.MaxLength = 30;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(112, 21);
            this.txtActividad.TabIndex = 21;
            this.txtActividad.TextChanged += new System.EventHandler(this.txtActividad_TextChanged);
            this.txtActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActividad_KeyPress);
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBarrio.ForeColor = System.Drawing.Color.White;
            this.lblNombreBarrio.Location = new System.Drawing.Point(32, 56);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(207, 16);
            this.lblNombreBarrio.TabIndex = 20;
            this.lblNombreBarrio.Text = "NOMBRE DE LA ACTIVIDAD:";
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.lblLeyenda);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(190, 489);
            this.PLateral.TabIndex = 19;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(6, 191);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(181, 212);
            this.lblLeyenda.TabIndex = 16;
            this.lblLeyenda.Text = "Ingresa el NOMBRE de la actividad para poder obtener los datos correspondientes y" +
    " poder modificarlos";
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
            // frmModificarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 489);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Modificar actividad";
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.PLateral.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
    }
}