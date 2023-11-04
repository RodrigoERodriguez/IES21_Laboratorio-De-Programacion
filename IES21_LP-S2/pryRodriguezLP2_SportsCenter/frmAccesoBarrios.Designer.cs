namespace pryRodriguezSportsCenterIEFI
{
    partial class frmAccesoBarrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoBarrios));
            this.PCentral = new System.Windows.Forms.Panel();
            this.PLateral = new System.Windows.Forms.Panel();
            this.cmdListadoBarrios = new System.Windows.Forms.Button();
            this.cmdBarrios = new System.Windows.Forms.Button();
            this.PLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(183, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(697, 564);
            this.PCentral.TabIndex = 19;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.cmdListadoBarrios);
            this.PLateral.Controls.Add(this.cmdBarrios);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(183, 564);
            this.PLateral.TabIndex = 18;
            // 
            // cmdListadoBarrios
            // 
            this.cmdListadoBarrios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListadoBarrios.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListadoBarrios.FlatAppearance.BorderSize = 0;
            this.cmdListadoBarrios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListadoBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListadoBarrios.ForeColor = System.Drawing.Color.White;
            this.cmdListadoBarrios.Location = new System.Drawing.Point(0, 45);
            this.cmdListadoBarrios.Name = "cmdListadoBarrios";
            this.cmdListadoBarrios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cmdListadoBarrios.Size = new System.Drawing.Size(183, 62);
            this.cmdListadoBarrios.TabIndex = 9;
            this.cmdListadoBarrios.Text = "Listado Barrios";
            this.cmdListadoBarrios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdListadoBarrios.UseVisualStyleBackColor = true;
            this.cmdListadoBarrios.Click += new System.EventHandler(this.cmdListadoBarrios_Click);
            // 
            // cmdBarrios
            // 
            this.cmdBarrios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.cmdBarrios.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBarrios.ForeColor = System.Drawing.Color.White;
            this.cmdBarrios.Location = new System.Drawing.Point(0, 0);
            this.cmdBarrios.Name = "cmdBarrios";
            this.cmdBarrios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cmdBarrios.Size = new System.Drawing.Size(183, 45);
            this.cmdBarrios.TabIndex = 4;
            this.cmdBarrios.Text = "Barrios";
            this.cmdBarrios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBarrios.UseVisualStyleBackColor = false;
            // 
            // frmAccesoBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 564);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccesoBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Button cmdListadoBarrios;
        private System.Windows.Forms.Button cmdBarrios;
    }
}