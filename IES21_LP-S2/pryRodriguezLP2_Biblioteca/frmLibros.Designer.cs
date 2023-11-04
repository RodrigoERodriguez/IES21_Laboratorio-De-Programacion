namespace pryRodriguezTpBibliotecaV2
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.txtCodigoDist = new System.Windows.Forms.TextBox();
            this.txtCodigoAut = new System.Windows.Forms.TextBox();
            this.txtCodigoEdit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoDist = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoAut = new System.Windows.Forms.Label();
            this.lblCodigoEdit = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSiguiente.Location = new System.Drawing.Point(298, 228);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(75, 23);
            this.cmdSiguiente.TabIndex = 13;
            this.cmdSiguiente.Text = ">>";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnterior.Location = new System.Drawing.Point(32, 228);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(75, 23);
            this.cmdAnterior.TabIndex = 14;
            this.cmdAnterior.Text = "<<";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // txtCodigoDist
            // 
            this.txtCodigoDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoDist.Location = new System.Drawing.Point(178, 168);
            this.txtCodigoDist.Name = "txtCodigoDist";
            this.txtCodigoDist.ReadOnly = true;
            this.txtCodigoDist.Size = new System.Drawing.Size(195, 20);
            this.txtCodigoDist.TabIndex = 8;
            // 
            // txtCodigoAut
            // 
            this.txtCodigoAut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoAut.Location = new System.Drawing.Point(178, 132);
            this.txtCodigoAut.Name = "txtCodigoAut";
            this.txtCodigoAut.ReadOnly = true;
            this.txtCodigoAut.Size = new System.Drawing.Size(195, 20);
            this.txtCodigoAut.TabIndex = 9;
            // 
            // txtCodigoEdit
            // 
            this.txtCodigoEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoEdit.Location = new System.Drawing.Point(178, 93);
            this.txtCodigoEdit.Name = "txtCodigoEdit";
            this.txtCodigoEdit.ReadOnly = true;
            this.txtCodigoEdit.Size = new System.Drawing.Size(195, 20);
            this.txtCodigoEdit.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(178, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(178, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(195, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // lblCodigoDist
            // 
            this.lblCodigoDist.AutoSize = true;
            this.lblCodigoDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDist.Location = new System.Drawing.Point(29, 175);
            this.lblCodigoDist.Name = "lblCodigoDist";
            this.lblCodigoDist.Size = new System.Drawing.Size(137, 13);
            this.lblCodigoDist.TabIndex = 3;
            this.lblCodigoDist.Text = "Codigo Del Distribuidor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoAut
            // 
            this.lblCodigoAut.AutoSize = true;
            this.lblCodigoAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAut.Location = new System.Drawing.Point(29, 139);
            this.lblCodigoAut.Name = "lblCodigoAut";
            this.lblCodigoAut.Size = new System.Drawing.Size(103, 13);
            this.lblCodigoAut.TabIndex = 5;
            this.lblCodigoAut.Text = "Codigo Del Autor";
            // 
            // lblCodigoEdit
            // 
            this.lblCodigoEdit.AutoSize = true;
            this.lblCodigoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEdit.Location = new System.Drawing.Point(29, 100);
            this.lblCodigoEdit.Name = "lblCodigoEdit";
            this.lblCodigoEdit.Size = new System.Drawing.Size(134, 13);
            this.lblCodigoEdit.TabIndex = 6;
            this.lblCodigoEdit.Text = "Codigo De La Editorial";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(29, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Codigo";
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 265);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.txtCodigoDist);
            this.Controls.Add(this.txtCodigoAut);
            this.Controls.Add(this.txtCodigoEdit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoDist);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoAut);
            this.Controls.Add(this.lblCodigoEdit);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.TextBox txtCodigoDist;
        private System.Windows.Forms.TextBox txtCodigoAut;
        private System.Windows.Forms.TextBox txtCodigoEdit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoDist;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoAut;
        private System.Windows.Forms.Label lblCodigoEdit;
        private System.Windows.Forms.Label lblCodigo;
    }
}