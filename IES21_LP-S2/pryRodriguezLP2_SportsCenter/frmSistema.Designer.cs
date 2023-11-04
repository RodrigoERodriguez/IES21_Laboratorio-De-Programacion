namespace pryRodriguezSportsCenterIEFI
{
    partial class frmSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            this.PBTorito = new System.Windows.Forms.PictureBox();
            this.PBIes21 = new System.Windows.Forms.PictureBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.PLateral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBTorito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIes21)).BeginInit();
            this.SuspendLayout();
            // 
            // PBTorito
            // 
            this.PBTorito.Image = ((System.Drawing.Image)(resources.GetObject("PBTorito.Image")));
            this.PBTorito.Location = new System.Drawing.Point(485, 279);
            this.PBTorito.Name = "PBTorito";
            this.PBTorito.Size = new System.Drawing.Size(221, 157);
            this.PBTorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTorito.TabIndex = 29;
            this.PBTorito.TabStop = false;
            // 
            // PBIes21
            // 
            this.PBIes21.Image = ((System.Drawing.Image)(resources.GetObject("PBIes21.Image")));
            this.PBIes21.Location = new System.Drawing.Point(485, 94);
            this.PBIes21.Name = "PBIes21";
            this.PBIes21.Size = new System.Drawing.Size(221, 150);
            this.PBIes21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIes21.TabIndex = 28;
            this.PBIes21.TabStop = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(156, 57);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(200, 286);
            this.lblLeyenda.TabIndex = 27;
            this.lblLeyenda.Text = resources.GetString("lblLeyenda.Text");
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(157, 358);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(234, 109);
            this.lblDatos.TabIndex = 26;
            this.lblDatos.Text = "Contactanos!!\r\n\r\nTelefono: 3518611479\r\nWhatsapp: 3518611479\r\nE-Mail: Rodrigoerodr" +
    "iguez48@gmail.com\r\n\r\n";
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(84, 518);
            this.PLateral.TabIndex = 25;
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 518);
            this.Controls.Add(this.PBTorito);
            this.Controls.Add(this.PBIes21);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PBTorito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBIes21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBTorito;
        private System.Windows.Forms.PictureBox PBIes21;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Panel PLateral;
    }
}