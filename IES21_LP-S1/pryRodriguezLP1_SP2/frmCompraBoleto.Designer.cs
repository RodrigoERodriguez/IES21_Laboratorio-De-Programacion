namespace pryRodriguezRodrigoSP2
{
    partial class frmCompraBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraBoleto));
            this.lblFerro = new System.Windows.Forms.Label();
            this.picTren = new System.Windows.Forms.PictureBox();
            this.lblADondeQuieresIr = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdComprar = new System.Windows.Forms.Button();
            this.mcrMarco = new System.Windows.Forms.GroupBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblTiempoDeEstadia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTren)).BeginInit();
            this.mcrMarco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFerro
            // 
            this.lblFerro.AutoSize = true;
            this.lblFerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFerro.Location = new System.Drawing.Point(111, 49);
            this.lblFerro.Name = "lblFerro";
            this.lblFerro.Size = new System.Drawing.Size(162, 15);
            this.lblFerro.TabIndex = 27;
            this.lblFerro.Text = "FERROCARILES FERRO";
            // 
            // picTren
            // 
            this.picTren.Image = ((System.Drawing.Image)(resources.GetObject("picTren.Image")));
            this.picTren.Location = new System.Drawing.Point(12, 24);
            this.picTren.Name = "picTren";
            this.picTren.Size = new System.Drawing.Size(93, 73);
            this.picTren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTren.TabIndex = 26;
            this.picTren.TabStop = false;
            // 
            // lblADondeQuieresIr
            // 
            this.lblADondeQuieresIr.AutoSize = true;
            this.lblADondeQuieresIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADondeQuieresIr.Location = new System.Drawing.Point(26, 117);
            this.lblADondeQuieresIr.Name = "lblADondeQuieresIr";
            this.lblADondeQuieresIr.Size = new System.Drawing.Size(227, 16);
            this.lblADondeQuieresIr.TabIndex = 24;
            this.lblADondeQuieresIr.Text = " ¿A DONDE QUIERES VIAJAR? ";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdCancelar.Location = new System.Drawing.Point(29, 322);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(105, 34);
            this.cmdCancelar.TabIndex = 22;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdComprar
            // 
            this.cmdComprar.BackColor = System.Drawing.Color.Green;
            this.cmdComprar.Enabled = false;
            this.cmdComprar.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdComprar.Location = new System.Drawing.Point(160, 322);
            this.cmdComprar.Name = "cmdComprar";
            this.cmdComprar.Size = new System.Drawing.Size(105, 34);
            this.cmdComprar.TabIndex = 23;
            this.cmdComprar.Text = "COMPRAR";
            this.cmdComprar.UseVisualStyleBackColor = false;
            this.cmdComprar.Click += new System.EventHandler(this.cmdComprar_Click);
            // 
            // mcrMarco
            // 
            this.mcrMarco.Controls.Add(this.txtDestino);
            this.mcrMarco.Controls.Add(this.txtTiempo);
            this.mcrMarco.Controls.Add(this.lblDestino);
            this.mcrMarco.Controls.Add(this.lblTiempoDeEstadia);
            this.mcrMarco.Location = new System.Drawing.Point(29, 148);
            this.mcrMarco.Name = "mcrMarco";
            this.mcrMarco.Size = new System.Drawing.Size(236, 156);
            this.mcrMarco.TabIndex = 25;
            this.mcrMarco.TabStop = false;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDestino.Location = new System.Drawing.Point(114, 45);
            this.txtDestino.MaxLength = 999;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(105, 20);
            this.txtDestino.TabIndex = 5;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            this.txtDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestino_KeyPress);
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTiempo.Location = new System.Drawing.Point(161, 92);
            this.txtTiempo.MaxLength = 999;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(58, 20);
            this.txtTiempo.TabIndex = 5;
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(23, 48);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(62, 13);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "DESTINO";
            // 
            // lblTiempoDeEstadia
            // 
            this.lblTiempoDeEstadia.AutoSize = true;
            this.lblTiempoDeEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoDeEstadia.Location = new System.Drawing.Point(23, 99);
            this.lblTiempoDeEstadia.Name = "lblTiempoDeEstadia";
            this.lblTiempoDeEstadia.Size = new System.Drawing.Size(132, 13);
            this.lblTiempoDeEstadia.TabIndex = 0;
            this.lblTiempoDeEstadia.Text = "TIEMPO DE ESTADIA";
            // 
            // frmCompraBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.lblFerro);
            this.Controls.Add(this.picTren);
            this.Controls.Add(this.lblADondeQuieresIr);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdComprar);
            this.Controls.Add(this.mcrMarco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompraBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra tu Boleto";
            ((System.ComponentModel.ISupportInitialize)(this.picTren)).EndInit();
            this.mcrMarco.ResumeLayout(false);
            this.mcrMarco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFerro;
        private System.Windows.Forms.PictureBox picTren;
        private System.Windows.Forms.Label lblADondeQuieresIr;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdComprar;
        private System.Windows.Forms.GroupBox mcrMarco;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblTiempoDeEstadia;
    }
}