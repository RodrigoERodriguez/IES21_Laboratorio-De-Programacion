namespace pryRodriguezSportsCenterIEFI
{
    partial class frmNuevaActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaActividad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.mrcDatos);
            this.panel1.Controls.Add(this.cmdSalir);
            this.panel1.Controls.Add(this.cmdGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 394);
            this.panel1.TabIndex = 2;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.mskTelefono);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.mskValor);
            this.mrcDatos.Controls.Add(this.label1);
            this.mrcDatos.Controls.Add(this.txtActividad);
            this.mrcDatos.Controls.Add(this.txtEmail);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblEmail);
            this.mrcDatos.Controls.Add(this.lblActividad);
            this.mrcDatos.Controls.Add(this.lblNombreProfesor);
            this.mrcDatos.Location = new System.Drawing.Point(12, 12);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(355, 307);
            this.mrcDatos.TabIndex = 11;
            this.mrcDatos.TabStop = false;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefono.Location = new System.Drawing.Point(33, 206);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(117, 20);
            this.mskTelefono.TabIndex = 30;
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(30, 188);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 16);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "Telefono:";
            // 
            // mskValor
            // 
            this.mskValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValor.Location = new System.Drawing.Point(30, 147);
            this.mskValor.Mask = "000000000";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(117, 20);
            this.mskValor.TabIndex = 28;
            this.mskValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskValor_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor:";
            // 
            // txtActividad
            // 
            this.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActividad.Location = new System.Drawing.Point(30, 95);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(117, 20);
            this.txtActividad.TabIndex = 26;
            this.txtActividad.TextChanged += new System.EventHandler(this.txtActividad_TextChanged);
            this.txtActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActividad_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(33, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(30, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 245);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.ForeColor = System.Drawing.Color.White;
            this.lblActividad.Location = new System.Drawing.Point(27, 76);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(76, 16);
            this.lblActividad.TabIndex = 8;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProfesor.Location = new System.Drawing.Point(27, 25);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(128, 16);
            this.lblNombreProfesor.TabIndex = 1;
            this.lblNombreProfesor.Text = "Nombre profesor:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 332);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 31);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardar.Enabled = false;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(292, 332);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 31);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frmNuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 394);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Nueva actividad";
            this.panel1.ResumeLayout(false);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
    }
}