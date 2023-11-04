namespace pryRodriguezTPAgriculturaV1
{
    partial class frmCultivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCultivo));
            this.mskIDCultivo = new System.Windows.Forms.MaskedTextBox();
            this.cmdCargarCultivo = new System.Windows.Forms.Button();
            this.txtNombreCultivo = new System.Windows.Forms.TextBox();
            this.lblLeyendaCultivo = new System.Windows.Forms.Label();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.lblIDCultivo = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskIDCultivo
            // 
            this.mskIDCultivo.Location = new System.Drawing.Point(169, 71);
            this.mskIDCultivo.Mask = "99999";
            this.mskIDCultivo.Name = "mskIDCultivo";
            this.mskIDCultivo.Size = new System.Drawing.Size(45, 20);
            this.mskIDCultivo.TabIndex = 20;
            this.mskIDCultivo.ValidatingType = typeof(int);
            this.mskIDCultivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIDCultivo_MaskInputRejected);
            // 
            // cmdCargarCultivo
            // 
            this.cmdCargarCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarCultivo.Location = new System.Drawing.Point(195, 157);
            this.cmdCargarCultivo.Name = "cmdCargarCultivo";
            this.cmdCargarCultivo.Size = new System.Drawing.Size(75, 30);
            this.cmdCargarCultivo.TabIndex = 19;
            this.cmdCargarCultivo.Text = "Cargar";
            this.cmdCargarCultivo.UseVisualStyleBackColor = true;
            this.cmdCargarCultivo.Click += new System.EventHandler(this.cmdCargarCultivo_Click);
            // 
            // txtNombreCultivo
            // 
            this.txtNombreCultivo.Location = new System.Drawing.Point(169, 111);
            this.txtNombreCultivo.Name = "txtNombreCultivo";
            this.txtNombreCultivo.Size = new System.Drawing.Size(101, 20);
            this.txtNombreCultivo.TabIndex = 18;
            this.txtNombreCultivo.TextChanged += new System.EventHandler(this.txtNombreCultivo_TextChanged);
            // 
            // lblLeyendaCultivo
            // 
            this.lblLeyendaCultivo.AutoSize = true;
            this.lblLeyendaCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblLeyendaCultivo.Location = new System.Drawing.Point(47, 19);
            this.lblLeyendaCultivo.Name = "lblLeyendaCultivo";
            this.lblLeyendaCultivo.Size = new System.Drawing.Size(223, 30);
            this.lblLeyendaCultivo.TabIndex = 17;
            this.lblLeyendaCultivo.Text = "Ingrese los datos";
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.AutoSize = true;
            this.lblNombreCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCultivo.Location = new System.Drawing.Point(21, 114);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(115, 13);
            this.lblNombreCultivo.TabIndex = 16;
            this.lblNombreCultivo.Text = "Nombre de Cultivo:";
            // 
            // lblIDCultivo
            // 
            this.lblIDCultivo.AutoSize = true;
            this.lblIDCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCultivo.Location = new System.Drawing.Point(21, 74);
            this.lblIDCultivo.Name = "lblIDCultivo";
            this.lblIDCultivo.Size = new System.Drawing.Size(129, 13);
            this.lblIDCultivo.TabIndex = 15;
            this.lblIDCultivo.Text = "Número Identificador:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(24, 157);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 30);
            this.cmdSalir.TabIndex = 19;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 199);
            this.Controls.Add(this.mskIDCultivo);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargarCultivo);
            this.Controls.Add(this.txtNombreCultivo);
            this.Controls.Add(this.lblLeyendaCultivo);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.lblIDCultivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCultivo";
            this.Text = "Cultivo";
            this.Load += new System.EventHandler(this.frmCultivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskIDCultivo;
        private System.Windows.Forms.Button cmdCargarCultivo;
        private System.Windows.Forms.TextBox txtNombreCultivo;
        private System.Windows.Forms.Label lblLeyendaCultivo;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.Label lblIDCultivo;
        private System.Windows.Forms.Button cmdSalir;
    }
}