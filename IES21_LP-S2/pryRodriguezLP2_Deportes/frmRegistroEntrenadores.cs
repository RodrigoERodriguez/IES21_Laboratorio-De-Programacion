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
    public partial class frmRegistroEntrenadores : Form
    {
        public frmRegistroEntrenadores()
        {
            InitializeComponent();
        }

        private void frmRegistroEntrenadores_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento AGREGAR
            //y la informacion con la que se llenen los campos
            //los datos cargados se almacenaran en la variable local
            //de la clase y posteriormente lo almacenara.
            clsEntrenador Registro = new clsEntrenador();
            Registro.CEntrenador = txtCodigo.Text;
            Registro.Nombre = txtNombre.Text;
            Registro.Apellido = txtApellido.Text;
            Registro.Direccion = txtDireccion.Text;
            Registro.Prov = txtProvincia.Text;
            Registro.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Registro.Agregar();
            Limpiar();

            txtCodigo.Focus();
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
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
        }
        //Con el procedimiento check controlo si los campos fueron rellenados antes de activar el boton
        private void Check()
        {
            if (txtCodigo.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtDireccion.Text != "" & txtProvincia.Text != "" & lstDeporte.SelectedIndex > 0)
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
        //Solamente ingresa letras mayusculas y minusculas
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
        //Solamente ingresa letras mayusculas y minusculas, en caso de que el entrenador
        //tenga 2 apellidos, permite usar la tecla de espacio.
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //Solamente ingresa letras mayusculas y minusculas, en caso de que la provincia
        //se divida en 2 partes, permite usar la tecla de espacio.
        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        //Una vez se llenen los campos el boton de guardar se activa
        //en caso contrario, no se habilita
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

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

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
