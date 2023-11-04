namespace pryRodriguezRodrigoSP1
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.picBienvenida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // picBienvenida
            // 
            this.picBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("picBienvenida.Image")));
            this.picBienvenida.Location = new System.Drawing.Point(-1, 0);
            this.picBienvenida.Name = "picBienvenida";
            this.picBienvenida.Size = new System.Drawing.Size(404, 243);
            this.picBienvenida.TabIndex = 0;
            this.picBienvenida.TabStop = false;
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 244);
            this.Controls.Add(this.picBienvenida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBienvenida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBienvenida;
    }
}