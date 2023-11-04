namespace pryRodriguezTPAgriculturaV1
{
    partial class frmLocalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidades));
            this.mskIDLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.cmdCargarLocalidad = new System.Windows.Forms.Button();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblLeyendaLocalidad = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblIDLocalidad = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskIDLocalidad
            // 
            this.mskIDLocalidad.Location = new System.Drawing.Point(169, 70);
            this.mskIDLocalidad.Mask = "99999";
            this.mskIDLocalidad.Name = "mskIDLocalidad";
            this.mskIDLocalidad.Size = new System.Drawing.Size(42, 20);
            this.mskIDLocalidad.TabIndex = 9;
            this.mskIDLocalidad.ValidatingType = typeof(int);
            this.mskIDLocalidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIDLocalidad_MaskInputRejected);
            // 
            // cmdCargarLocalidad
            // 
            this.cmdCargarLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarLocalidad.Location = new System.Drawing.Point(188, 164);
            this.cmdCargarLocalidad.Name = "cmdCargarLocalidad";
            this.cmdCargarLocalidad.Size = new System.Drawing.Size(75, 30);
            this.cmdCargarLocalidad.TabIndex = 14;
            this.cmdCargarLocalidad.Text = "Cargar";
            this.cmdCargarLocalidad.UseVisualStyleBackColor = true;
            this.cmdCargarLocalidad.Click += new System.EventHandler(this.cmdCargarLocalidad_Click);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(169, 113);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(94, 20);
            this.txtNombreLocalidad.TabIndex = 13;
            this.txtNombreLocalidad.TextChanged += new System.EventHandler(this.txtNombreLocalidad_TextChanged);
            // 
            // lblLeyendaLocalidad
            // 
            this.lblLeyendaLocalidad.AutoSize = true;
            this.lblLeyendaLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.lblLeyendaLocalidad.Location = new System.Drawing.Point(30, 19);
            this.lblLeyendaLocalidad.Name = "lblLeyendaLocalidad";
            this.lblLeyendaLocalidad.Size = new System.Drawing.Size(223, 30);
            this.lblLeyendaLocalidad.TabIndex = 12;
            this.lblLeyendaLocalidad.Text = "Ingrese los datos";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(12, 113);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(131, 13);
            this.lblNombreLocalidad.TabIndex = 11;
            this.lblNombreLocalidad.Text = "Nombre de Localidad:";
            // 
            // lblIDLocalidad
            // 
            this.lblIDLocalidad.AutoSize = true;
            this.lblIDLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLocalidad.Location = new System.Drawing.Point(12, 73);
            this.lblIDLocalidad.Name = "lblIDLocalidad";
            this.lblIDLocalidad.Size = new System.Drawing.Size(129, 13);
            this.lblIDLocalidad.TabIndex = 10;
            this.lblIDLocalidad.Text = "Número Identificador:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(15, 167);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 27);
            this.cmdSalir.TabIndex = 15;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 206);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.mskIDLocalidad);
            this.Controls.Add(this.cmdCargarLocalidad);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.lblLeyendaLocalidad);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblIDLocalidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalidades";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskIDLocalidad;
        private System.Windows.Forms.Button cmdCargarLocalidad;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblLeyendaLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblIDLocalidad;
        private System.Windows.Forms.Button cmdSalir;
    }
}