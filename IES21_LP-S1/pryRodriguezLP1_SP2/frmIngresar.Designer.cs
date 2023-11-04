namespace pryRodriguezRodrigoSP2
{
    partial class frmIngresar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresar));
            this.lblFerro = new System.Windows.Forms.Label();
            this.picTren = new System.Windows.Forms.PictureBox();
            this.cmdIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTren)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFerro
            // 
            this.lblFerro.AutoSize = true;
            this.lblFerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFerro.Location = new System.Drawing.Point(14, 154);
            this.lblFerro.Name = "lblFerro";
            this.lblFerro.Size = new System.Drawing.Size(243, 24);
            this.lblFerro.TabIndex = 17;
            this.lblFerro.Text = "FERROCARILES FERRO";
            // 
            // picTren
            // 
            this.picTren.Image = ((System.Drawing.Image)(resources.GetObject("picTren.Image")));
            this.picTren.Location = new System.Drawing.Point(56, 27);
            this.picTren.Name = "picTren";
            this.picTren.Size = new System.Drawing.Size(148, 112);
            this.picTren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTren.TabIndex = 16;
            this.picTren.TabStop = false;
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresar.Location = new System.Drawing.Point(46, 205);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(158, 57);
            this.cmdIngresar.TabIndex = 15;
            this.cmdIngresar.Text = "INGRESAR";
            this.cmdIngresar.UseVisualStyleBackColor = true;
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            // 
            // frmIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 285);
            this.Controls.Add(this.lblFerro);
            this.Controls.Add(this.picTren);
            this.Controls.Add(this.cmdIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIngresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            ((System.ComponentModel.ISupportInitialize)(this.picTren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFerro;
        private System.Windows.Forms.PictureBox picTren;
        private System.Windows.Forms.Button cmdIngresar;
    }
}

