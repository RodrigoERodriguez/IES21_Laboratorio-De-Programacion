namespace pryRodriguezTPVenkaktusV1
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblIDCliente1 = new System.Windows.Forms.Label();
            this.lstIDVendedor = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lstIDCliente = new System.Windows.Forms.ComboBox();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.mskMonto = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblIDVendedor1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblLeyendaVentas = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblIDCliente1);
            this.mrcDatos.Controls.Add(this.lstIDVendedor);
            this.mrcDatos.Controls.Add(this.lblTipoFactura);
            this.mrcDatos.Controls.Add(this.lstIDCliente);
            this.mrcDatos.Controls.Add(this.lstTipo);
            this.mrcDatos.Controls.Add(this.mskMonto);
            this.mrcDatos.Controls.Add(this.lblNumeroFactura);
            this.mrcDatos.Controls.Add(this.lblMonto);
            this.mrcDatos.Controls.Add(this.mskNumero);
            this.mrcDatos.Controls.Add(this.lblIDVendedor1);
            this.mrcDatos.Controls.Add(this.dtpFecha);
            this.mrcDatos.Controls.Add(this.lblFecha);
            this.mrcDatos.Location = new System.Drawing.Point(12, 59);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(309, 271);
            this.mrcDatos.TabIndex = 51;
            this.mrcDatos.TabStop = false;
            // 
            // lblIDCliente1
            // 
            this.lblIDCliente1.AutoSize = true;
            this.lblIDCliente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente1.Location = new System.Drawing.Point(15, 25);
            this.lblIDCliente1.Name = "lblIDCliente1";
            this.lblIDCliente1.Size = new System.Drawing.Size(88, 13);
            this.lblIDCliente1.TabIndex = 42;
            this.lblIDCliente1.Text = "ID del Cliente:";
            // 
            // lstIDVendedor
            // 
            this.lstIDVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstIDVendedor.FormattingEnabled = true;
            this.lstIDVendedor.Location = new System.Drawing.Point(147, 64);
            this.lstIDVendedor.Name = "lstIDVendedor";
            this.lstIDVendedor.Size = new System.Drawing.Size(121, 21);
            this.lstIDVendedor.TabIndex = 47;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(15, 111);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(98, 13);
            this.lblTipoFactura.TabIndex = 36;
            this.lblTipoFactura.Text = "Tipo de factura:";
            // 
            // lstIDCliente
            // 
            this.lstIDCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstIDCliente.FormattingEnabled = true;
            this.lstIDCliente.Location = new System.Drawing.Point(147, 22);
            this.lstIDCliente.Name = "lstIDCliente";
            this.lstIDCliente.Size = new System.Drawing.Size(121, 21);
            this.lstIDCliente.TabIndex = 46;
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipo.Location = new System.Drawing.Point(147, 108);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(102, 21);
            this.lstTipo.TabIndex = 37;
            // 
            // mskMonto
            // 
            this.mskMonto.Location = new System.Drawing.Point(147, 234);
            this.mskMonto.Mask = "99999";
            this.mskMonto.Name = "mskMonto";
            this.mskMonto.Size = new System.Drawing.Size(57, 20);
            this.mskMonto.TabIndex = 45;
            this.mskMonto.ValidatingType = typeof(int);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(15, 150);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(116, 13);
            this.lblNumeroFactura.TabIndex = 38;
            this.lblNumeroFactura.Text = "Número de factura:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(15, 241);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(46, 13);
            this.lblMonto.TabIndex = 44;
            this.lblMonto.Text = "Monto:";
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(147, 147);
            this.mskNumero.Mask = "9999";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(42, 20);
            this.mskNumero.TabIndex = 39;
            this.mskNumero.ValidatingType = typeof(int);
            // 
            // lblIDVendedor1
            // 
            this.lblIDVendedor1.AutoSize = true;
            this.lblIDVendedor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVendedor1.Location = new System.Drawing.Point(15, 67);
            this.lblIDVendedor1.Name = "lblIDVendedor1";
            this.lblIDVendedor1.Size = new System.Drawing.Size(103, 13);
            this.lblIDVendedor1.TabIndex = 43;
            this.lblIDVendedor1.Text = "ID del Vendedor:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFecha.Location = new System.Drawing.Point(87, 193);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 40;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 193);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(246, 346);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 35);
            this.cmdCargar.TabIndex = 49;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblLeyendaVentas
            // 
            this.lblLeyendaVentas.AutoSize = true;
            this.lblLeyendaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblLeyendaVentas.Location = new System.Drawing.Point(47, 9);
            this.lblLeyendaVentas.Name = "lblLeyendaVentas";
            this.lblLeyendaVentas.Size = new System.Drawing.Size(237, 31);
            this.lblLeyendaVentas.TabIndex = 50;
            this.lblLeyendaVentas.Text = "Ingreso de Datos";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 346);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 35);
            this.cmdSalir.TabIndex = 49;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 392);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblLeyendaVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblIDCliente1;
        private System.Windows.Forms.ComboBox lstIDVendedor;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox lstIDCliente;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.MaskedTextBox mskMonto;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.Label lblIDVendedor1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblLeyendaVentas;
        private System.Windows.Forms.Button cmdSalir;
    }
}