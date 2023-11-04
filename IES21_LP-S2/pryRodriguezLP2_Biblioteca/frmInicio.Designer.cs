namespace pryRodriguezTpBibliotecaV2
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.MSInicio = new System.Windows.Forms.MenuStrip();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSInicio
            // 
            this.MSInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibliotecaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MSInicio.Location = new System.Drawing.Point(0, 0);
            this.MSInicio.Name = "MSInicio";
            this.MSInicio.Size = new System.Drawing.Size(703, 24);
            this.MSInicio.TabIndex = 0;
            this.MSInicio.Text = "menuStrip1";
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem});
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bibliotecaToolStripMenuItem.Text = "Biblioteca";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 299);
            this.Controls.Add(this.MSInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MSInicio;
            this.Name = "frmInicio";
            this.Text = "Inicio Biblioteca";
            this.MSInicio.ResumeLayout(false);
            this.MSInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSInicio;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

