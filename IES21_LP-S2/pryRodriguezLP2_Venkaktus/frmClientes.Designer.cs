namespace pryRodriguezTPVenkaktusV1
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.mrcMarcoCliente = new System.Windows.Forms.GroupBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.mskIDCliente = new System.Windows.Forms.MaskedTextBox();
            this.cmdCargarCliente = new System.Windows.Forms.Button();
            this.lblLeyendaClientes = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcMarcoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcMarcoCliente
            // 
            this.mrcMarcoCliente.Controls.Add(this.lblIDCliente);
            this.mrcMarcoCliente.Controls.Add(this.txtNombreCliente);
            this.mrcMarcoCliente.Controls.Add(this.lblNombreCliente);
            this.mrcMarcoCliente.Controls.Add(this.mskIDCliente);
            this.mrcMarcoCliente.Location = new System.Drawing.Point(9, 65);
            this.mrcMarcoCliente.Name = "mrcMarcoCliente";
            this.mrcMarcoCliente.Size = new System.Drawing.Size(339, 132);
            this.mrcMarcoCliente.TabIndex = 25;
            this.mrcMarcoCliente.TabStop = false;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(20, 37);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(88, 13);
            this.lblIDCliente.TabIndex = 15;
            this.lblIDCliente.Text = "ID del Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(184, 78);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(143, 20);
            this.txtNombreCliente.TabIndex = 16;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 81);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(118, 13);
            this.lblNombreCliente.TabIndex = 18;
            this.lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // mskIDCliente
            // 
            this.mskIDCliente.Location = new System.Drawing.Point(184, 34);
            this.mskIDCliente.Mask = "99999";
            this.mskIDCliente.Name = "mskIDCliente";
            this.mskIDCliente.Size = new System.Drawing.Size(60, 20);
            this.mskIDCliente.TabIndex = 14;
            this.mskIDCliente.ValidatingType = typeof(int);
            this.mskIDCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskIDCliente_MaskInputRejected);
            // 
            // cmdCargarCliente
            // 
            this.cmdCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarCliente.Location = new System.Drawing.Point(273, 213);
            this.cmdCargarCliente.Name = "cmdCargarCliente";
            this.cmdCargarCliente.Size = new System.Drawing.Size(75, 35);
            this.cmdCargarCliente.TabIndex = 23;
            this.cmdCargarCliente.Text = "Cargar";
            this.cmdCargarCliente.UseVisualStyleBackColor = true;
            this.cmdCargarCliente.Click += new System.EventHandler(this.cmdCargarCliente_Click);
            // 
            // lblLeyendaClientes
            // 
            this.lblLeyendaClientes.AutoSize = true;
            this.lblLeyendaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblLeyendaClientes.Location = new System.Drawing.Point(65, 9);
            this.lblLeyendaClientes.Name = "lblLeyendaClientes";
            this.lblLeyendaClientes.Size = new System.Drawing.Size(237, 31);
            this.lblLeyendaClientes.TabIndex = 24;
            this.lblLeyendaClientes.Text = "Ingreso de Datos";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 213);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 35);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.mrcMarcoCliente);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargarCliente);
            this.Controls.Add(this.lblLeyendaClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.mrcMarcoCliente.ResumeLayout(false);
            this.mrcMarcoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcMarcoCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.MaskedTextBox mskIDCliente;
        private System.Windows.Forms.Button cmdCargarCliente;
        private System.Windows.Forms.Label lblLeyendaClientes;
        private System.Windows.Forms.Button cmdSalir;
    }
}