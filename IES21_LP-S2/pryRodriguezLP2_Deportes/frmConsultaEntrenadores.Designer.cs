namespace pryRodriguezBaseDeDatosDeportesV2
{
    partial class frmConsultaEntrenadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEntrenadores));
            this.SSConsulta = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.DGVConsultaEntrenadores = new System.Windows.Forms.DataGridView();
            this.SSConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultaEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // SSConsulta
            // 
            this.SSConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.SSConsulta.Location = new System.Drawing.Point(0, 228);
            this.SSConsulta.Name = "SSConsulta";
            this.SSConsulta.Size = new System.Drawing.Size(671, 22);
            this.SSConsulta.TabIndex = 28;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(580, 168);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 36);
            this.cmdConsultar.TabIndex = 27;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 168);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 36);
            this.cmdSalir.TabIndex = 26;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // DGVConsultaEntrenadores
            // 
            this.DGVConsultaEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsultaEntrenadores.Location = new System.Drawing.Point(12, 12);
            this.DGVConsultaEntrenadores.Name = "DGVConsultaEntrenadores";
            this.DGVConsultaEntrenadores.Size = new System.Drawing.Size(643, 150);
            this.DGVConsultaEntrenadores.TabIndex = 25;
            // 
            // frmConsultaEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 250);
            this.Controls.Add(this.SSConsulta);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.DGVConsultaEntrenadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenadores_Load);
            this.SSConsulta.ResumeLayout(false);
            this.SSConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultaEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SSConsulta;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView DGVConsultaEntrenadores;
    }
}