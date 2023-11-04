namespace pryRodriguezRodrigoSP4
{
    partial class frmBarLaMilanga
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarLaMilanga));
            this.tabVentanas = new System.Windows.Forms.TabControl();
            this.tabValidarDatos = new System.Windows.Forms.TabPage();
            this.cmdLimpiar1 = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmdValidar = new System.Windows.Forms.Button();
            this.tabTotales = new System.Windows.Forms.TabPage();
            this.mrcMozoDia = new System.Windows.Forms.GroupBox();
            this.cmdMostrar2 = new System.Windows.Forms.Button();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.lblMozoDia = new System.Windows.Forms.Label();
            this.mrcTotalMozos = new System.Windows.Forms.GroupBox();
            this.cmdLimpiar2 = new System.Windows.Forms.Button();
            this.lblTotalGeneralMostrar = new System.Windows.Forms.Label();
            this.lblPostreMostrar = new System.Windows.Forms.Label();
            this.lblComidasMostrar = new System.Windows.Forms.Label();
            this.lblCAMostrar = new System.Windows.Forms.Label();
            this.lblSAMostrar = new System.Windows.Forms.Label();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblBebidasCA = new System.Windows.Forms.Label();
            this.lblBebidasSA = new System.Windows.Forms.Label();
            this.cmdCalcular2 = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.ColumnaMozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaComidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPostres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVentanas.SuspendLayout();
            this.tabValidarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabTotales.SuspendLayout();
            this.mrcMozoDia.SuspendLayout();
            this.mrcTotalMozos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVentanas
            // 
            this.tabVentanas.Controls.Add(this.tabValidarDatos);
            this.tabVentanas.Controls.Add(this.tabTotales);
            this.tabVentanas.Location = new System.Drawing.Point(12, 12);
            this.tabVentanas.Name = "tabVentanas";
            this.tabVentanas.SelectedIndex = 0;
            this.tabVentanas.Size = new System.Drawing.Size(526, 267);
            this.tabVentanas.TabIndex = 10;
            // 
            // tabValidarDatos
            // 
            this.tabValidarDatos.Controls.Add(this.cmdLimpiar1);
            this.tabValidarDatos.Controls.Add(this.dgvVentas);
            this.tabValidarDatos.Controls.Add(this.cmdValidar);
            this.tabValidarDatos.Location = new System.Drawing.Point(4, 22);
            this.tabValidarDatos.Name = "tabValidarDatos";
            this.tabValidarDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabValidarDatos.Size = new System.Drawing.Size(518, 241);
            this.tabValidarDatos.TabIndex = 0;
            this.tabValidarDatos.Text = "Validar datos";
            this.tabValidarDatos.UseVisualStyleBackColor = true;
            // 
            // cmdLimpiar1
            // 
            this.cmdLimpiar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdLimpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar1.Location = new System.Drawing.Point(307, 190);
            this.cmdLimpiar1.Name = "cmdLimpiar1";
            this.cmdLimpiar1.Size = new System.Drawing.Size(82, 33);
            this.cmdLimpiar1.TabIndex = 3;
            this.cmdLimpiar1.Text = "Limpiar";
            this.cmdLimpiar1.UseVisualStyleBackColor = false;
            this.cmdLimpiar1.Click += new System.EventHandler(this.cmdLimpiar1_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaMozo,
            this.ColumnaComidas,
            this.ColumnaBSA,
            this.ColumnaBCA,
            this.ColumnaPostres});
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.Location = new System.Drawing.Point(7, 14);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVentas.Size = new System.Drawing.Size(502, 158);
            this.dgvVentas.TabIndex = 0;
            // 
            // cmdValidar
            // 
            this.cmdValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidar.Location = new System.Drawing.Point(427, 190);
            this.cmdValidar.Name = "cmdValidar";
            this.cmdValidar.Size = new System.Drawing.Size(82, 33);
            this.cmdValidar.TabIndex = 2;
            this.cmdValidar.Text = "Validar ";
            this.cmdValidar.UseVisualStyleBackColor = false;
            this.cmdValidar.Click += new System.EventHandler(this.cmdValidar_Click);
            // 
            // tabTotales
            // 
            this.tabTotales.Controls.Add(this.mrcMozoDia);
            this.tabTotales.Controls.Add(this.mrcTotalMozos);
            this.tabTotales.Location = new System.Drawing.Point(4, 22);
            this.tabTotales.Name = "tabTotales";
            this.tabTotales.Padding = new System.Windows.Forms.Padding(3);
            this.tabTotales.Size = new System.Drawing.Size(518, 241);
            this.tabTotales.TabIndex = 3;
            this.tabTotales.Text = "Totales ";
            this.tabTotales.UseVisualStyleBackColor = true;
            // 
            // mrcMozoDia
            // 
            this.mrcMozoDia.Controls.Add(this.cmdMostrar2);
            this.mrcMozoDia.Controls.Add(this.lblTotalDia);
            this.mrcMozoDia.Controls.Add(this.lblMozoDia);
            this.mrcMozoDia.Location = new System.Drawing.Point(287, 13);
            this.mrcMozoDia.Name = "mrcMozoDia";
            this.mrcMozoDia.Size = new System.Drawing.Size(212, 202);
            this.mrcMozoDia.TabIndex = 9;
            this.mrcMozoDia.TabStop = false;
            this.mrcMozoDia.Text = "Mozo del día";
            // 
            // cmdMostrar2
            // 
            this.cmdMostrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdMostrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostrar2.Location = new System.Drawing.Point(103, 164);
            this.cmdMostrar2.Name = "cmdMostrar2";
            this.cmdMostrar2.Size = new System.Drawing.Size(82, 32);
            this.cmdMostrar2.TabIndex = 10;
            this.cmdMostrar2.Text = "Mostrar";
            this.cmdMostrar2.UseVisualStyleBackColor = false;
            this.cmdMostrar2.Click += new System.EventHandler(this.cmdMostrar2_Click);
            // 
            // lblTotalDia
            // 
            this.lblTotalDia.AutoSize = true;
            this.lblTotalDia.Location = new System.Drawing.Point(23, 97);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(0, 13);
            this.lblTotalDia.TabIndex = 1;
            // 
            // lblMozoDia
            // 
            this.lblMozoDia.AutoSize = true;
            this.lblMozoDia.Location = new System.Drawing.Point(23, 47);
            this.lblMozoDia.Name = "lblMozoDia";
            this.lblMozoDia.Size = new System.Drawing.Size(0, 13);
            this.lblMozoDia.TabIndex = 0;
            // 
            // mrcTotalMozos
            // 
            this.mrcTotalMozos.Controls.Add(this.cmdLimpiar2);
            this.mrcTotalMozos.Controls.Add(this.lblTotalGeneralMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblPostreMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblComidasMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblCAMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblSAMostrar);
            this.mrcTotalMozos.Controls.Add(this.lblTotalGeneral);
            this.mrcTotalMozos.Controls.Add(this.lblPostres);
            this.mrcTotalMozos.Controls.Add(this.lblComidas);
            this.mrcTotalMozos.Controls.Add(this.lblBebidasCA);
            this.mrcTotalMozos.Controls.Add(this.lblBebidasSA);
            this.mrcTotalMozos.Controls.Add(this.cmdCalcular2);
            this.mrcTotalMozos.Location = new System.Drawing.Point(18, 13);
            this.mrcTotalMozos.Name = "mrcTotalMozos";
            this.mrcTotalMozos.Size = new System.Drawing.Size(263, 202);
            this.mrcTotalMozos.TabIndex = 0;
            this.mrcTotalMozos.TabStop = false;
            this.mrcTotalMozos.Text = "Total por mozo";
            // 
            // cmdLimpiar2
            // 
            this.cmdLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar2.Location = new System.Drawing.Point(38, 165);
            this.cmdLimpiar2.Name = "cmdLimpiar2";
            this.cmdLimpiar2.Size = new System.Drawing.Size(82, 31);
            this.cmdLimpiar2.TabIndex = 9;
            this.cmdLimpiar2.Text = "Limpiar";
            this.cmdLimpiar2.UseVisualStyleBackColor = false;
            this.cmdLimpiar2.Click += new System.EventHandler(this.cmdLimpiar2_Click);
            // 
            // lblTotalGeneralMostrar
            // 
            this.lblTotalGeneralMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalGeneralMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGeneralMostrar.Location = new System.Drawing.Point(138, 133);
            this.lblTotalGeneralMostrar.Name = "lblTotalGeneralMostrar";
            this.lblTotalGeneralMostrar.Size = new System.Drawing.Size(82, 22);
            this.lblTotalGeneralMostrar.TabIndex = 11;
            // 
            // lblPostreMostrar
            // 
            this.lblPostreMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPostreMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostreMostrar.Location = new System.Drawing.Point(138, 107);
            this.lblPostreMostrar.Name = "lblPostreMostrar";
            this.lblPostreMostrar.Size = new System.Drawing.Size(82, 22);
            this.lblPostreMostrar.TabIndex = 10;
            // 
            // lblComidasMostrar
            // 
            this.lblComidasMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblComidasMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComidasMostrar.Location = new System.Drawing.Point(138, 29);
            this.lblComidasMostrar.Name = "lblComidasMostrar";
            this.lblComidasMostrar.Size = new System.Drawing.Size(82, 22);
            this.lblComidasMostrar.TabIndex = 9;
            // 
            // lblCAMostrar
            // 
            this.lblCAMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCAMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCAMostrar.Location = new System.Drawing.Point(138, 81);
            this.lblCAMostrar.Name = "lblCAMostrar";
            this.lblCAMostrar.Size = new System.Drawing.Size(82, 22);
            this.lblCAMostrar.TabIndex = 8;
            // 
            // lblSAMostrar
            // 
            this.lblSAMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSAMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSAMostrar.Location = new System.Drawing.Point(138, 55);
            this.lblSAMostrar.Name = "lblSAMostrar";
            this.lblSAMostrar.Size = new System.Drawing.Size(82, 22);
            this.lblSAMostrar.TabIndex = 7;
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Location = new System.Drawing.Point(19, 134);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(74, 13);
            this.lblTotalGeneral.TabIndex = 6;
            this.lblTotalGeneral.Text = "Total General:";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(19, 108);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(45, 13);
            this.lblPostres.TabIndex = 5;
            this.lblPostres.Text = "Postres:";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(19, 30);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(50, 13);
            this.lblComidas.TabIndex = 4;
            this.lblComidas.Text = "Comidas:";
            // 
            // lblBebidasCA
            // 
            this.lblBebidasCA.AutoSize = true;
            this.lblBebidasCA.Location = new System.Drawing.Point(19, 82);
            this.lblBebidasCA.Name = "lblBebidasCA";
            this.lblBebidasCA.Size = new System.Drawing.Size(106, 13);
            this.lblBebidasCA.TabIndex = 3;
            this.lblBebidasCA.Text = "Bebidas con alcohol:";
            // 
            // lblBebidasSA
            // 
            this.lblBebidasSA.AutoSize = true;
            this.lblBebidasSA.Location = new System.Drawing.Point(19, 56);
            this.lblBebidasSA.Name = "lblBebidasSA";
            this.lblBebidasSA.Size = new System.Drawing.Size(101, 13);
            this.lblBebidasSA.TabIndex = 2;
            this.lblBebidasSA.Text = "Bebidas sin alcohol:";
            // 
            // cmdCalcular2
            // 
            this.cmdCalcular2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdCalcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular2.Location = new System.Drawing.Point(127, 165);
            this.cmdCalcular2.Name = "cmdCalcular2";
            this.cmdCalcular2.Size = new System.Drawing.Size(82, 31);
            this.cmdCalcular2.TabIndex = 1;
            this.cmdCalcular2.Text = "Calcular";
            this.cmdCalcular2.UseVisualStyleBackColor = false;
            this.cmdCalcular2.Click += new System.EventHandler(this.cmdCalcular2_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(434, 285);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(100, 27);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // ColumnaMozo
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            this.ColumnaMozo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnaMozo.HeaderText = "Mozo";
            this.ColumnaMozo.Name = "ColumnaMozo";
            // 
            // ColumnaComidas
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnaComidas.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnaComidas.HeaderText = "Comidas";
            this.ColumnaComidas.Name = "ColumnaComidas";
            // 
            // ColumnaBSA
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.ColumnaBSA.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnaBSA.HeaderText = "Bebidas sin alcohol";
            this.ColumnaBSA.Name = "ColumnaBSA";
            // 
            // ColumnaBCA
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.ColumnaBCA.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnaBCA.HeaderText = "Bebidas con alcohol";
            this.ColumnaBCA.Name = "ColumnaBCA";
            // 
            // ColumnaPostres
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.ColumnaPostres.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnaPostres.HeaderText = "Postres";
            this.ColumnaPostres.Name = "ColumnaPostres";
            // 
            // frmBarLaMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 324);
            this.Controls.Add(this.tabVentanas);
            this.Controls.Add(this.cmdSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBarLaMilanga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar La Milanga";
            this.Load += new System.EventHandler(this.frmBarLaMilanga_Load);
            this.tabVentanas.ResumeLayout(false);
            this.tabValidarDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabTotales.ResumeLayout(false);
            this.mrcMozoDia.ResumeLayout(false);
            this.mrcMozoDia.PerformLayout();
            this.mrcTotalMozos.ResumeLayout(false);
            this.mrcTotalMozos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentanas;
        private System.Windows.Forms.TabPage tabValidarDatos;
        private System.Windows.Forms.Button cmdLimpiar1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button cmdValidar;
        private System.Windows.Forms.TabPage tabTotales;
        private System.Windows.Forms.GroupBox mrcMozoDia;
        private System.Windows.Forms.Button cmdMostrar2;
        private System.Windows.Forms.Label lblTotalDia;
        private System.Windows.Forms.Label lblMozoDia;
        private System.Windows.Forms.GroupBox mrcTotalMozos;
        private System.Windows.Forms.Button cmdLimpiar2;
        private System.Windows.Forms.Label lblTotalGeneralMostrar;
        private System.Windows.Forms.Label lblPostreMostrar;
        private System.Windows.Forms.Label lblComidasMostrar;
        private System.Windows.Forms.Label lblCAMostrar;
        private System.Windows.Forms.Label lblSAMostrar;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblBebidasCA;
        private System.Windows.Forms.Label lblBebidasSA;
        private System.Windows.Forms.Button cmdCalcular2;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPostres;
    }
}

