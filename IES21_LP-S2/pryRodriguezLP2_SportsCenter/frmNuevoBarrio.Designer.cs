namespace pryRodriguezSportsCenterIEFI
{
    partial class frmNuevoBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoBarrio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.mrcBarrio = new System.Windows.Forms.GroupBox();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.mrcBarrio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.cmdSalir);
            this.panel1.Controls.Add(this.cmdGuardar);
            this.panel1.Controls.Add(this.mrcBarrio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 175);
            this.panel1.TabIndex = 1;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 132);
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
            this.cmdGuardar.Location = new System.Drawing.Point(241, 132);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 31);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // mrcBarrio
            // 
            this.mrcBarrio.Controls.Add(this.lblNombreBarrio);
            this.mrcBarrio.Controls.Add(this.txtNombreBarrio);
            this.mrcBarrio.Location = new System.Drawing.Point(12, 12);
            this.mrcBarrio.Name = "mrcBarrio";
            this.mrcBarrio.Size = new System.Drawing.Size(304, 111);
            this.mrcBarrio.TabIndex = 3;
            this.mrcBarrio.TabStop = false;
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBarrio.ForeColor = System.Drawing.Color.White;
            this.lblNombreBarrio.Location = new System.Drawing.Point(52, 30);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(190, 18);
            this.lblNombreBarrio.TabIndex = 0;
            this.lblNombreBarrio.Text = "NOMBRE DEL BARRIO:";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBarrio.Location = new System.Drawing.Point(55, 64);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(187, 20);
            this.txtNombreBarrio.TabIndex = 1;
            this.txtNombreBarrio.TextChanged += new System.EventHandler(this.txtNombreBarrio_TextChanged);
            this.txtNombreBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreBarrio_KeyPress);
            // 
            // frmNuevoBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 175);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Center - Nuevo barrio";
            this.panel1.ResumeLayout(false);
            this.mrcBarrio.ResumeLayout(false);
            this.mrcBarrio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox mrcBarrio;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
    }
}