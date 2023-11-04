namespace pryRodriguezSportsCenterIEFI
{
    partial class frmAccesoActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoActividades));
            this.PCentral = new System.Windows.Forms.Panel();
            this.PLateral = new System.Windows.Forms.Panel();
            this.cmdModificarActividad = new System.Windows.Forms.Button();
            this.cmdListadoPorActividad = new System.Windows.Forms.Button();
            this.cmdActividades = new System.Windows.Forms.Button();
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
            this.PCentral.TabIndex = 17;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.cmdModificarActividad);
            this.PLateral.Controls.Add(this.cmdListadoPorActividad);
            this.PLateral.Controls.Add(this.cmdActividades);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(183, 564);
            this.PLateral.TabIndex = 16;
            // 
            // cmdModificarActividad
            // 
            this.cmdModificarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdModificarActividad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdModificarActividad.FlatAppearance.BorderSize = 0;
            this.cmdModificarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarActividad.ForeColor = System.Drawing.Color.White;
            this.cmdModificarActividad.Location = new System.Drawing.Point(0, 107);
            this.cmdModificarActividad.Name = "cmdModificarActividad";
            this.cmdModificarActividad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cmdModificarActividad.Size = new System.Drawing.Size(183, 62);
            this.cmdModificarActividad.TabIndex = 9;
            this.cmdModificarActividad.Text = "Modificar actividad";
            this.cmdModificarActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificarActividad.UseVisualStyleBackColor = true;
            this.cmdModificarActividad.Click += new System.EventHandler(this.cmdModificarActividad_Click);
            // 
            // cmdListadoPorActividad
            // 
            this.cmdListadoPorActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListadoPorActividad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListadoPorActividad.FlatAppearance.BorderSize = 0;
            this.cmdListadoPorActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListadoPorActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListadoPorActividad.ForeColor = System.Drawing.Color.White;
            this.cmdListadoPorActividad.Location = new System.Drawing.Point(0, 45);
            this.cmdListadoPorActividad.Name = "cmdListadoPorActividad";
            this.cmdListadoPorActividad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cmdListadoPorActividad.Size = new System.Drawing.Size(183, 62);
            this.cmdListadoPorActividad.TabIndex = 8;
            this.cmdListadoPorActividad.Text = "Listado actividades";
            this.cmdListadoPorActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdListadoPorActividad.UseVisualStyleBackColor = true;
            this.cmdListadoPorActividad.Click += new System.EventHandler(this.cmdListadoPorActividad_Click);
            // 
            // cmdActividades
            // 
            this.cmdActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.cmdActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActividades.ForeColor = System.Drawing.Color.White;
            this.cmdActividades.Location = new System.Drawing.Point(0, 0);
            this.cmdActividades.Name = "cmdActividades";
            this.cmdActividades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cmdActividades.Size = new System.Drawing.Size(183, 45);
            this.cmdActividades.TabIndex = 6;
            this.cmdActividades.Text = "Actividades";
            this.cmdActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdActividades.UseVisualStyleBackColor = false;
            // 
            // frmAccesoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 564);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccesoActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Button cmdModificarActividad;
        private System.Windows.Forms.Button cmdListadoPorActividad;
        private System.Windows.Forms.Button cmdActividades;
    }
}