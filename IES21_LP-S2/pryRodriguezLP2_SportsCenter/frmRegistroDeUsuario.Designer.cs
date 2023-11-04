namespace pryRodriguezSportsCenterIEFI
{
    partial class frmRegistroDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeUsuario));
            this.PCentral = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmdRegistrarse = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.PCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Controls.Add(this.lblSubTitulo);
            this.PCentral.Controls.Add(this.lblLeyenda);
            this.PCentral.Controls.Add(this.txtContraseña);
            this.PCentral.Controls.Add(this.lblContraseña);
            this.PCentral.Controls.Add(this.txtUsuario);
            this.PCentral.Controls.Add(this.lblUsuario);
            this.PCentral.Controls.Add(this.cmdRegistrarse);
            this.PCentral.Controls.Add(this.cmdCancelar);
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(0, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(413, 273);
            this.PCentral.TabIndex = 1;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(121, 33);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(164, 48);
            this.lblSubTitulo.TabIndex = 16;
            this.lblSubTitulo.Text = "Es rápido y fácil.\r\n\r\n";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(3, 9);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(405, 50);
            this.lblLeyenda.TabIndex = 15;
            this.lblLeyenda.Text = "Registrar tu usuario en Sports Center\r\n\r\n";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(28, 178);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(146, 20);
            this.txtContraseña.TabIndex = 14;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(25, 151);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(158, 24);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "CONTRASEÑA:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(28, 114);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 20);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(25, 87);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(106, 24);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // cmdRegistrarse
            // 
            this.cmdRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrarse.Enabled = false;
            this.cmdRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarse.Location = new System.Drawing.Point(284, 221);
            this.cmdRegistrarse.Name = "cmdRegistrarse";
            this.cmdRegistrarse.Size = new System.Drawing.Size(105, 31);
            this.cmdRegistrarse.TabIndex = 10;
            this.cmdRegistrarse.Text = "Registrarse";
            this.cmdRegistrarse.UseVisualStyleBackColor = false;
            this.cmdRegistrarse.Click += new System.EventHandler(this.cmdRegistrarse_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(28, 221);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(105, 31);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmRegistroDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 273);
            this.Controls.Add(this.PCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PCentral.ResumeLayout(false);
            this.PCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button cmdRegistrarse;
        private System.Windows.Forms.Button cmdCancelar;
    }
}