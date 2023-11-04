using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezBaseDeDatosDeportesV2
{
    public partial class frmModificarDeportistas : Form
    {
        public frmModificarDeportistas()
        {
            InitializeComponent();
        }

        private void frmModificarDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            string Codigo = txtCodigo.Text;
            clsDeportista Buscar = new clsDeportista();
            Buscar.Buscar(Codigo);

            if (Buscar.CDeportista != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = Buscar.Nombre;
                txtApellido.Text = Buscar.Apellido;
                txtDireccion.Text = Buscar.Direccion;
                mskTelefono.Text = Convert.ToString(Buscar.Telefono);
                mskEdad.Text = Convert.ToString(Buscar.Edad);
                lstDeporte.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento MODIFICAR
            //y la informacion con la que se llenen los campos
            //los datos cargados se almacenaran en la variable local
            //de la clase y posteriormente lo almacenara.
            string CDeportista = txtCodigo.Text;
            clsDeportista Modificar = new clsDeportista();
            Modificar.Nombre = txtNombre.Text;
            Modificar.Apellido = txtApellido.Text;
            Modificar.Direccion = Convert.ToString(txtDireccion.Text);
            Modificar.Telefono = Convert.ToInt32(mskTelefono.Text);
            Modificar.Edad = Convert.ToInt32(mskEdad.Text);
            Modificar.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Modificar.Modificar(CDeportista);

            Limpiar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            mskTelefono.Text = "";
            mskEdad.Text = "";
            lstDeporte.SelectedIndex = -1;
        }
        //Con el procedimiento check controlo si los campos fueron rellenados antes de activar el boton
        private void Check()
        {
            if (txtCodigo.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtDireccion.Text != "" & mskTelefono.Text != "" & mskEdad.Text != "" & lstDeporte.SelectedIndex > 0)
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }
        //Solamente ingresa letras mayusculas y minusculas
        private void txtCodigoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //Solamente ingresa letras mayusculas y minusculas
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //Solamente ingresa letras mayusculas y minusculas, en caso de que el deportista
        //tenga 2 apellidos, permite usar la tecla de espacio.
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //Una vez se llenen los campos el boton de guardar se activa
        //en caso contrario, no se habilita
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
