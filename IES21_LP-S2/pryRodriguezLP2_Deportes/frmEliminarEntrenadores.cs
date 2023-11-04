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
    public partial class frmEliminarEntrenadores : Form
    {
        public frmEliminarEntrenadores()
        {
            InitializeComponent();
        }

        private void frmEliminarEntrenadores_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            string Codigo = txtCodigo.Text;
            clsEntrenador Buscar = new clsEntrenador();
            Buscar.Buscar(Codigo);

            if (Buscar.CEntrenador != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                lblNombreEE.Text = Buscar.Nombre;
                lblApellidoEE.Text = Buscar.Apellido;
                lblDireccionEE.Text = Buscar.Direccion;
                lblProvinciaEE.Text = Buscar.Prov;
                lblDeporteEE.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento ELIMINAR
            //y este eliminara toda la fila seleccionada
            //por el CodigoDeportista
            string CodigoEntrenadores = txtCodigo.Text;
            clsEntrenador Eliminar = new clsEntrenador();
            Eliminar.Eliminar(CodigoEntrenadores);

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
            lblNombreEE.Text = "";
            lblApellidoEE.Text = "";
            lblDireccionEE.Text = "";
            lblProvinciaEE.Text = "";
            lblDeporteEE.Text = "";
        }
        //Con el procedimiento check controlo si los campos fueron rellenados antes de activar el boton
        private void Check()
        {
            if (lblNombreEE.Text != "" & lblApellidoEE.Text != "" & lblDireccionEE.Text != "" & lblProvinciaEE.Text != "" & lblDeporteEE.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
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
        //Una vez se llenen los campos el boton de guardar se activa
        //en caso contrario, no se habilita
        private void lblCodigoEntrenadorEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblNombreEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblApellidoEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDireccionEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblProvinciaEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDeporteEE_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
