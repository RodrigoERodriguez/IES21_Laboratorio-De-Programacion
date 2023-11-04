namespace pryRodriguezSportsCenterIEFI
{
    partial class frmInicioDeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioDeSesion));
            this.PCentral = new System.Windows.Forms.Panel();
            this.lblOlvidasteTuContraseña = new System.Windows.Forms.Label();
            this.cmdIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.cmdRegistrarse = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.PInferior = new System.Windows.Forms.Panel();
            this.cmdInformacion = new System.Windows.Forms.PictureBox();
            this.PLateral = new System.Windows.Forms.Panel();
            this.cmdCerrar = new System.Windows.Forms.PictureBox();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdInformacion)).BeginInit();
            this.PLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.lblOlvidasteTuContraseña);
            this.PCentral.Controls.Add(this.cmdIniciarSesion);
            this.PCentral.Controls.Add(this.txtContraseña);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.cmdRegistrarse);
            this.PCentral.Controls.Add(this.txtUsuario);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(287, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(411, 294);
            this.PCentral.TabIndex = 21;
            this.PCentral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCentral_MouseDown);
            // 
            // lblOlvidasteTuContraseña
            // 
            this.lblOlvidasteTuContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidasteTuContraseña.ForeColor = System.Drawing.Color.White;
            this.lblOlvidasteTuContraseña.Location = new System.Drawing.Point(124, 270);
            this.lblOlvidasteTuContraseña.Name = "lblOlvidasteTuContraseña";
            this.lblOlvidasteTuContraseña.Size = new System.Drawing.Size(159, 17);
            this.lblOlvidasteTuContraseña.TabIndex = 0;
            this.lblOlvidasteTuContraseña.Text = "¿Olvidaste tu contraseña?";
            this.lblOlvidasteTuContraseña.Click += new System.EventHandler(this.lblOlvidasteTuContraseña_Click);
            this.lblOlvidasteTuContraseña.MouseLeave += new System.EventHandler(this.lblOlvidasteTuContraseña_MouseLeave);
            this.lblOlvidasteTuContraseña.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOlvidasteTuContraseña_MouseMove);
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIniciarSesion.Enabled = false;
            this.cmdIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarSesion.Location = new System.Drawing.Point(141, 230);
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(123, 37);
            this.cmdIniciarSesion.TabIndex = 3;
            this.cmdIniciarSesion.Text = "Iniciar sesion";
            this.cmdIniciarSesion.UseVisualStyleBackColor = true;
            this.cmdIniciarSesion.Click += new System.EventHandler(this.cmdIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(25, 173);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(258, 31);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(22, 58);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(377, 24);
            this.lblLeyenda.TabIndex = 3;
            this.lblLeyenda.Text = "INICIAR SESION EN SPORTS CENTER";
            // 
            // cmdRegistrarse
            // 
            this.cmdRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarse.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarse.Location = new System.Drawing.Point(288, 0);
            this.cmdRegistrarse.Name = "cmdRegistrarse";
            this.cmdRegistrarse.Size = new System.Drawing.Size(123, 37);
            this.cmdRegistrarse.TabIndex = 2;
            this.cmdRegistrarse.Text = "Registrarse";
            this.cmdRegistrarse.UseVisualStyleBackColor = true;
            this.cmdRegistrarse.Click += new System.EventHandler(this.cmdRegistrarse_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(25, 121);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(258, 31);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // PInferior
            // 
            this.PInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PInferior.Dock = System.Windows.Forms.DockStyle.Left;
            this.PInferior.Location = new System.Drawing.Point(248, 0);
            this.PInferior.Name = "PInferior";
            this.PInferior.Size = new System.Drawing.Size(39, 294);
            this.PInferior.TabIndex = 20;
            this.PInferior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PInferior_MouseDown);
            // 
            // cmdInformacion
            // 
            this.cmdInformacion.Image = ((System.Drawing.Image)(resources.GetObject("cmdInformacion.Image")));
            this.cmdInformacion.Location = new System.Drawing.Point(209, 252);
            this.cmdInformacion.Name = "cmdInformacion";
            this.cmdInformacion.Size = new System.Drawing.Size(39, 42);
            this.cmdInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdInformacion.TabIndex = 0;
            this.cmdInformacion.TabStop = false;
            this.cmdInformacion.Click += new System.EventHandler(this.cmdInformacion_Click);
            // 
            // PLateral
            // 
            this.PLateral.Controls.Add(this.cmdCerrar);
            this.PLateral.Controls.Add(this.cmdInformacion);
            this.PLateral.Controls.Add(this.PBLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(248, 294);
            this.PLateral.TabIndex = 19;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(0, 0);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(39, 42);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.White;
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(248, 294);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 3;
            this.PBLogo.TabStop = false;
            this.PBLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBLogo_MouseDown);
            // 
            // frmInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 294);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PInferior);
            this.Controls.Add(this.PLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio sesion - Sports Center";
            this.Load += new System.EventHandler(this.frmInicioDeSesion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmInicioDeSesion_MouseDown);
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdInformacion)).EndInit();
            this.PLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Label lblOlvidasteTuContraseña;
        private System.Windows.Forms.Button cmdIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button cmdRegistrarse;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel PInferior;
        private System.Windows.Forms.PictureBox cmdInformacion;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.PictureBox cmdCerrar;
        private System.Windows.Forms.PictureBox PBLogo;
    }
}

