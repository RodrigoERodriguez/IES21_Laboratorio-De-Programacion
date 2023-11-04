namespace pryRodriguezSportsCenterIEFI
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.PCentral = new System.Windows.Forms.Panel();
            this.PInferior = new System.Windows.Forms.Panel();
            this.cmdReportePorGanancias = new System.Windows.Forms.Button();
            this.cmdReportePorActividad = new System.Windows.Forms.Button();
            this.cmdReportePorBarrio = new System.Windows.Forms.Button();
            this.cmdReportes = new System.Windows.Forms.Button();
            this.PInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(183, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(617, 450);
            this.PCentral.TabIndex = 17;
            // 
            // PInferior
            // 
            this.PInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PInferior.Controls.Add(this.cmdReportePorGanancias);
            this.PInferior.Controls.Add(this.cmdReportePorActividad);
            this.PInferior.Controls.Add(this.cmdReportePorBarrio);
            this.PInferior.Controls.Add(this.cmdReportes);
            this.PInferior.Dock = System.Windows.Forms.DockStyle.Left;
            this.PInferior.Location = new System.Drawing.Point(0, 0);
            this.PInferior.Name = "PInferior";
            this.PInferior.Size = new System.Drawing.Size(183, 450);
            this.PInferior.TabIndex = 16;
            // 
            // cmdReportePorGanancias
            // 
            this.cmdReportePorGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdReportePorGanancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdReportePorGanancias.FlatAppearance.BorderSize = 0;
            this.cmdReportePorGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReportePorGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReportePorGanancias.ForeColor = System.Drawing.Color.White;
            this.cmdReportePorGanancias.Location = new System.Drawing.Point(0, 169);
            this.cmdReportePorGanancias.Name = "cmdReportePorGanancias";
            this.cmdReportePorGanancias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cmdReportePorGanancias.Size = new System.Drawing.Size(183, 62);
            this.cmdReportePorGanancias.TabIndex = 11;
            this.cmdReportePorGanancias.Text = "Reporte de ganancias";
            this.cmdReportePorGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReportePorGanancias.UseVisualStyleBackColor = true;
            this.cmdReportePorGanancias.Click += new System.EventHandler(this.cmdReportePorGanancias_Click);
            // 
            // cmdReportePorActividad
            // 
            this.cmdReportePorActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdReportePorActividad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdReportePorActividad.FlatAppearance.BorderSize = 0;
            this.cmdReportePorActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReportePorActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReportePorActividad.ForeColor = System.Drawing.Color.White;
            this.cmdReportePorActividad.Location = new System.Drawing.Point(0, 107);
            this.cmdReportePorActividad.Name = "cmdReportePorActividad";
            this.cmdReportePorActividad.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cmdReportePorActividad.Size = new System.Drawing.Size(183, 62);
            this.cmdReportePorActividad.TabIndex = 10;
            this.cmdReportePorActividad.Text = "Reporte por actividad";
            this.cmdReportePorActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReportePorActividad.UseVisualStyleBackColor = true;
            this.cmdReportePorActividad.Click += new System.EventHandler(this.cmdReportePorActividad_Click);
            // 
            // cmdReportePorBarrio
            // 
            this.cmdReportePorBarrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdReportePorBarrio.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdReportePorBarrio.FlatAppearance.BorderSize = 0;
            this.cmdReportePorBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReportePorBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReportePorBarrio.ForeColor = System.Drawing.Color.White;
            this.cmdReportePorBarrio.Location = new System.Drawing.Point(0, 45);
            this.cmdReportePorBarrio.Name = "cmdReportePorBarrio";
            this.cmdReportePorBarrio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.cmdReportePorBarrio.Size = new System.Drawing.Size(183, 62);
            this.cmdReportePorBarrio.TabIndex = 9;
            this.cmdReportePorBarrio.Text = "Reporte por barrio";
            this.cmdReportePorBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReportePorBarrio.UseVisualStyleBackColor = true;
            this.cmdReportePorBarrio.Click += new System.EventHandler(this.cmdReportePorBarrio_Click);
            // 
            // cmdReportes
            // 
            this.cmdReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.cmdReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReportes.ForeColor = System.Drawing.Color.White;
            this.cmdReportes.Location = new System.Drawing.Point(0, 0);
            this.cmdReportes.Name = "cmdReportes";
            this.cmdReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cmdReportes.Size = new System.Drawing.Size(183, 45);
            this.cmdReportes.TabIndex = 8;
            this.cmdReportes.Text = "Reportes";
            this.cmdReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReportes.UseVisualStyleBackColor = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PInferior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PInferior;
        private System.Windows.Forms.Button cmdReportePorGanancias;
        private System.Windows.Forms.Button cmdReportePorActividad;
        private System.Windows.Forms.Button cmdReportePorBarrio;
        private System.Windows.Forms.Button cmdReportes;
    }
}