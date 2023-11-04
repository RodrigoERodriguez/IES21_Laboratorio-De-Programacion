namespace pryRodriguezRodrigoSP3
{
    partial class frmRegistroDeRepuesto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeRepuesto));
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.ColumnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.mrcOrigenConsulta = new System.Windows.Forms.GroupBox();
            this.optNacionalConsulta = new System.Windows.Forms.RadioButton();
            this.optImportadoConsulta = new System.Windows.Forms.RadioButton();
            this.lstConsulta = new System.Windows.Forms.ComboBox();
            this.mrcProductos = new System.Windows.Forms.GroupBox();
            this.lstDatos = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optNacionalDatos = new System.Windows.Forms.RadioButton();
            this.optImportadoDatos = new System.Windows.Forms.RadioButton();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.mrcConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.mrcOrigenConsulta.SuspendLayout();
            this.mrcProductos.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mrcConsulta.Controls.Add(this.cmdSalir);
            this.mrcConsulta.Controls.Add(this.dvgConsulta);
            this.mrcConsulta.Controls.Add(this.cmdConsultar);
            this.mrcConsulta.Controls.Add(this.mrcOrigenConsulta);
            this.mrcConsulta.Controls.Add(this.lstConsulta);
            this.mrcConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsulta.Location = new System.Drawing.Point(12, 276);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(304, 305);
            this.mrcConsulta.TabIndex = 10;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta";
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.LightCoral;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(18, 264);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(84, 23);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaMarca,
            this.ColumnaCodigo,
            this.ColumnaOrigen,
            this.ColumnaPrecio,
            this.ColumnaDescripcion});
            this.dvgConsulta.Location = new System.Drawing.Point(12, 136);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.Size = new System.Drawing.Size(292, 122);
            this.dvgConsulta.TabIndex = 3;
            // 
            // ColumnaMarca
            // 
            this.ColumnaMarca.HeaderText = "Marca";
            this.ColumnaMarca.Name = "ColumnaMarca";
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Codigo";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            // 
            // ColumnaOrigen
            // 
            this.ColumnaOrigen.HeaderText = "Origen";
            this.ColumnaOrigen.Name = "ColumnaOrigen";
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.HeaderText = "Descripcion";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(206, 264);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(84, 23);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // mrcOrigenConsulta
            // 
            this.mrcOrigenConsulta.Controls.Add(this.optNacionalConsulta);
            this.mrcOrigenConsulta.Controls.Add(this.optImportadoConsulta);
            this.mrcOrigenConsulta.Location = new System.Drawing.Point(176, 19);
            this.mrcOrigenConsulta.Name = "mrcOrigenConsulta";
            this.mrcOrigenConsulta.Size = new System.Drawing.Size(117, 103);
            this.mrcOrigenConsulta.TabIndex = 2;
            this.mrcOrigenConsulta.TabStop = false;
            this.mrcOrigenConsulta.Text = "Origen";
            // 
            // optNacionalConsulta
            // 
            this.optNacionalConsulta.AutoSize = true;
            this.optNacionalConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNacionalConsulta.Location = new System.Drawing.Point(16, 34);
            this.optNacionalConsulta.Name = "optNacionalConsulta";
            this.optNacionalConsulta.Size = new System.Drawing.Size(75, 17);
            this.optNacionalConsulta.TabIndex = 2;
            this.optNacionalConsulta.TabStop = true;
            this.optNacionalConsulta.Text = "Nacional";
            this.optNacionalConsulta.UseVisualStyleBackColor = true;
            // 
            // optImportadoConsulta
            // 
            this.optImportadoConsulta.AutoSize = true;
            this.optImportadoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImportadoConsulta.Location = new System.Drawing.Point(16, 69);
            this.optImportadoConsulta.Name = "optImportadoConsulta";
            this.optImportadoConsulta.Size = new System.Drawing.Size(81, 17);
            this.optImportadoConsulta.TabIndex = 2;
            this.optImportadoConsulta.TabStop = true;
            this.optImportadoConsulta.Text = "Importado";
            this.optImportadoConsulta.UseVisualStyleBackColor = true;
            // 
            // lstConsulta
            // 
            this.lstConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.lstConsulta.Location = new System.Drawing.Point(14, 30);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(121, 21);
            this.lstConsulta.TabIndex = 1;
            // 
            // mrcProductos
            // 
            this.mrcProductos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mrcProductos.Controls.Add(this.lstDatos);
            this.mrcProductos.Controls.Add(this.lblDescripcion);
            this.mrcProductos.Controls.Add(this.cmdBorrar);
            this.mrcProductos.Controls.Add(this.cmdCargar);
            this.mrcProductos.Controls.Add(this.lblMarca);
            this.mrcProductos.Controls.Add(this.lblCodigo);
            this.mrcProductos.Controls.Add(this.txtDescripcion);
            this.mrcProductos.Controls.Add(this.mrcOrigen);
            this.mrcProductos.Controls.Add(this.mskCodigo);
            this.mrcProductos.Controls.Add(this.lblPrecio);
            this.mrcProductos.Controls.Add(this.txtPrecio);
            this.mrcProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcProductos.Location = new System.Drawing.Point(12, 12);
            this.mrcProductos.Name = "mrcProductos";
            this.mrcProductos.Size = new System.Drawing.Size(304, 258);
            this.mrcProductos.TabIndex = 9;
            this.mrcProductos.TabStop = false;
            this.mrcProductos.Text = "Datos del Repuesto";
            // 
            // lstDatos
            // 
            this.lstDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Items.AddRange(new object[] {
            "Fiat",
            "Peugeot",
            "Renault"});
            this.lstDatos.Location = new System.Drawing.Point(82, 34);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(85, 21);
            this.lstDatos.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 15);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.ForeColor = System.Drawing.Color.Black;
            this.cmdBorrar.Location = new System.Drawing.Point(18, 223);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(84, 23);
            this.cmdBorrar.TabIndex = 1;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = false;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(206, 223);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(84, 23);
            this.cmdCargar.TabIndex = 1;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(15, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "MARCA";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 77);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 111);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(160, 43);
            this.txtDescripcion.TabIndex = 2;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optNacionalDatos);
            this.mrcOrigen.Controls.Add(this.optImportadoDatos);
            this.mrcOrigen.Location = new System.Drawing.Point(181, 11);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(117, 94);
            this.mrcOrigen.TabIndex = 1;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optNacionalDatos
            // 
            this.optNacionalDatos.AutoSize = true;
            this.optNacionalDatos.Checked = true;
            this.optNacionalDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNacionalDatos.Location = new System.Drawing.Point(16, 27);
            this.optNacionalDatos.Name = "optNacionalDatos";
            this.optNacionalDatos.Size = new System.Drawing.Size(75, 17);
            this.optNacionalDatos.TabIndex = 2;
            this.optNacionalDatos.TabStop = true;
            this.optNacionalDatos.Text = "Nacional";
            this.optNacionalDatos.UseVisualStyleBackColor = true;
            // 
            // optImportadoDatos
            // 
            this.optImportadoDatos.AutoSize = true;
            this.optImportadoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImportadoDatos.Location = new System.Drawing.Point(16, 62);
            this.optImportadoDatos.Name = "optImportadoDatos";
            this.optImportadoDatos.Size = new System.Drawing.Size(81, 17);
            this.optImportadoDatos.TabIndex = 2;
            this.optImportadoDatos.Text = "Importado";
            this.optImportadoDatos.UseVisualStyleBackColor = true;
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(82, 72);
            this.mskCodigo.Mask = "   000000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(85, 20);
            this.mskCodigo.TabIndex = 3;
            this.mskCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigo_MaskInputRejected);
            this.mskCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCodigo_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(15, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 15);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "PRECIO ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(94, 178);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(73, 20);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // frmRegistroDeRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 589);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.mrcProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeRepuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Repuestos";
            this.Load += new System.EventHandler(this.frmRegistroDeRepuesto_Load);
            this.mrcConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.mrcOrigenConsulta.ResumeLayout(false);
            this.mrcOrigenConsulta.PerformLayout();
            this.mrcProductos.ResumeLayout(false);
            this.mrcProductos.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.GroupBox mrcOrigenConsulta;
        private System.Windows.Forms.RadioButton optNacionalConsulta;
        private System.Windows.Forms.RadioButton optImportadoConsulta;
        private System.Windows.Forms.ComboBox lstConsulta;
        private System.Windows.Forms.GroupBox mrcProductos;
        private System.Windows.Forms.ComboBox lstDatos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optNacionalDatos;
        private System.Windows.Forms.RadioButton optImportadoDatos;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
    }
}

