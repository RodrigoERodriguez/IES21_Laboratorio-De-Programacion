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
    public partial class frmModificarActividad : Form
    {
        public frmModificarActividad()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            string ACTIVIDAD = txtActividad.Text;
            clsActividad Buscar = new clsActividad();
            Buscar.Buscar(ACTIVIDAD);

            if (Buscar.ACTIVIDAD != ACTIVIDAD)
            {
                MessageBox.Show("El socio no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = Buscar.NOMBREPROFESOR;
                txtActividad.Text = Buscar.ACTIVIDAD;
                mskValor.Text = Convert.ToString(Buscar.VALOR);
                mskTelefono.Text = Convert.ToString(Buscar.TELEFONO);
                txtEmail.Text = Buscar.EMAIL;

                Check();
            }
        }

        //==============================================================================================================

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento MODIFICAR
            //y la informacion con la que se llenen los campos
            //los datos cargados se almacenaran en la variable local
            //de la clase y posteriormente lo almacenara.
            string ACTIVIDAD = txtActividad.Text;
            clsActividad Modificar = new clsActividad();
            Modificar.NOMBREPROFESOR = txtNombre.Text;
            Modificar.TELEFONO = Convert.ToInt32(mskTelefono.Text);
            Modificar.VALOR = Convert.ToInt32(mskValor.Text);
            Modificar.EMAIL = Convert.ToString(txtEmail.Text);
            Modificar.Modificar(ACTIVIDAD);

            Limpiar();
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        //Con el procedimiento Limpiar borro el contenido de los campos
        private void Limpiar()
        {
            txtActividad.Text = "";
            txtNombre.Text = "";
            mskTelefono.Text = "";
            mskValor.Text = "";
            txtEmail.Text = "";
        }

        //==============================================================================================================

        //Con el procedimiento Check controlo si los campos fueron rellenados antes de activar el boton
        private void Check()
        {
            if (txtNombre.Text != "" & txtActividad.Text != "" & mskTelefono.Text != "" & mskValor.Text != "" & txtEmail.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            if (txtActividad.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
