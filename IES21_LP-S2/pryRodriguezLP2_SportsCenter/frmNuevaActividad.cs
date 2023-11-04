using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSportsCenterIEFI
{
    public partial class frmNuevaActividad : Form
    {
        public frmNuevaActividad()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string NOMBREACTIVIDAD = txtActividad.Text;
            clsActividad Buscar = new clsActividad();
            Buscar.Buscar(NOMBREACTIVIDAD);

            if (Buscar.ACTIVIDAD == NOMBREACTIVIDAD)
            {
                MessageBox.Show("La actividad ya se encuentra en la base de datos");
            }
            else
            {
                clsActividad Registro = new clsActividad();
                Registro.NOMBREPROFESOR = txtNombre.Text;
                Registro.ACTIVIDAD = txtActividad.Text;
                Registro.VALOR = Convert.ToInt32(mskValor.Text);
                Registro.TELEFONO = Convert.ToInt32(mskTelefono.Text);
                Registro.EMAIL = Convert.ToString(txtEmail.Text);
                Registro.Agregar();

                Limpiar();
            }
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtActividad.Text = "";
            mskValor.Text = "";
            mskTelefono.Text = "";
            txtEmail.Text = "";
        }

        //==============================================================================================================

        private void Check()
        {
            if (txtNombre.Text != "" & txtActividad.Text != "" & mskValor.Text != "" & mskTelefono.Text != "" & txtEmail.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //==============================================================================================================

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
