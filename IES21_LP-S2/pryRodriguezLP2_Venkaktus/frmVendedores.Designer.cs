namespace pryRodriguezTPVenkaktusV1
{
    partial class frmVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedores));
            this.cmdCargarVendedor = new System.Windows.Forms.Button();
            this.lblLeyendaVendedores = new System.Windows.Forms.Label();
            this.mskIDVendedores = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblIDVendedor = new System.Windows.Forms.Label();
            this.mrcMarco = new System.Windows.Forms.GroupBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcMarco.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCargarVendedor
            // 
            this.cmdCargarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVendedor.Location = new System.Drawing.Point(274, 253);
            this.cmdCargarVendedor.Name = "cmdCargarVendedor";
            this.cmdCargarVendedor.Size = new System.Drawing.Size(75, 35);
            this.cmdCargarVendedor.TabIndex = 17;
            this.cmdCargarVendedor.Text = "Cargar";
            this.cmdCargarVendedor.UseVisualStyleBackColor = true;
            this.cmdCargarVendedor.Click += new System.EventHandler(this.cmdCargarVendedor_Click);
            // 
            // lblLeyendaVendedores
            // 
            this.lblLeyendaVendedores.AutoSize = true;
            this.lblLeyendaVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblLeyendaVendedores.Location = new System.Drawing.Point(66, 22);
            this.lblLeyendaVendedores.Name = "lblLeyendaVendedores";
            this.lblLeyendaVendedores.Size = new System.Drawing.Size(237, 31);
            this.lblLeyendaVendedores.TabIndex = 19;
            this.lblLeyendaVendedores.Text = "Ingreso de Datos";
            // 
            // mskIDVendedores
            // 
            this.mskIDVendedores.Location = new System.Drawing.Point(184, 49);
            this.mskIDVendedores.Mask = "99999";
            this.mskIDVendedores.Name = "mskIDVendedores";
            this.mskIDVendedores.Size = new System.Drawing.Size(60, 20);
            this.mskIDVendedores.TabIndex = 14;
            this.mskIDVendedores.ValidatingType = typeof(int);
            this.mskIDVendedores.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIDVendedores_MaskInputRejected);
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(20, 96);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(132, 13);
            this.lblNombreVendedor.TabIndex = 18;
            this.lblNombreVendedor.Text = "Nombre del vendedor:";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(184, 93);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(143, 20);
            this.txtNombreVendedor.TabIndex = 16;
            this.txtNombreVendedor.TextChanged += new System.EventHandler(this.txtNombreVendedor_TextChanged);
            // 
            // lblIDVendedor
            // 
            this.lblIDVendedor.AutoSize = true;
            this.lblIDVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVendedor.Location = new System.Drawing.Point(20, 52);
            this.lblIDVendedor.Name = "lblIDVendedor";
            this.lblIDVendedor.Size = new System.Drawing.Size(102, 13);
            this.lblIDVendedor.TabIndex = 15;
            this.lblIDVendedor.Text = "ID del vendedor:";
            // 
            // mrcMarco
            // 
            this.mrcMarco.Controls.Add(this.lblIDVendedor);
            this.mrcMarco.Controls.Add(this.txtNombreVendedor);
            this.mrcMarco.Controls.Add(this.lblNombreVendedor);
            this.mrcMarco.Controls.Add(this.mskIDVendedores);
            this.mrcMarco.Location = new System.Drawing.Point(10, 78);
            this.mrcMarco.Name = "mrcMarco";
            this.mrcMarco.Size = new System.Drawing.Size(339, 165);
            this.mrcMarco.TabIndex = 22;
            this.mrcMarco.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 253);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 35);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 300);
            this.Controls.Add(this.mrcMarco);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargarVendedor);
            this.Controls.Add(this.lblLeyendaVendedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            this.mrcMarco.ResumeLayout(false);
            this.mrcMarco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdCargarVendedor;
        private System.Windows.Forms.Label lblLeyendaVendedores;
        private System.Windows.Forms.MaskedTextBox mskIDVendedores;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblIDVendedor;
        private System.Windows.Forms.GroupBox mrcMarco;
        private System.Windows.Forms.Button cmdSalir;
    }
}