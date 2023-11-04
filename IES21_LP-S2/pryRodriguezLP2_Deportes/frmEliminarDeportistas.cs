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
    public partial class frmEliminarDeportistas : Form
    {
        public frmEliminarDeportistas()
        {
            InitializeComponent();
        }

        private void frmEliminarDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {            
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            string Codigo = txtCodigoDeportista.Text;
            clsDeportista Buscar= new clsDeportista();
            Buscar.Buscar(Codigo);

            if (Buscar.CDeportista != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                lblCodigoDeportistaED.Text = Buscar.CDeportista;
                lblNombreED.Text = Buscar.Nombre;
                lblApellidoED.Text = Buscar.Apellido;
                lblDireccionED.Text = Buscar.Direccion;
                lblTelefonoED.Text = Convert.ToString(Buscar.Telefono);
                lblEdadED.Text = Convert.ToString(Buscar.Edad);
                lblDeporteED.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento ELIMINAR
            //y este eliminara toda la fila seleccionada
            //por el CodigoDeportista
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista EliminarED = new clsDeportista();
            EliminarED.Eliminar(CodigoDeportista);

            Limpiar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            //Limpia el todos los controladores
            lblCodigoDeportistaED.Text = "";
            lblNombreED.Text = "";
            lblApellidoED.Text = "";
            lblDireccionED.Text = "";
            lblTelefonoED.Text = "";
            lblEdadED.Text = "";
            lblDeporteED.Text = "";
        }
        //Con el procedimiento check controlo si los campos fueron rellenados antes de activar el boton
        private void Check()
        {
            if (lblCodigoDeportistaED.Text != "" & lblNombreED.Text != "" & lblApellidoED.Text != "" & lblDireccionED.Text != "" & lblTelefonoED.Text != "" & lblEdadED.Text != "" & lblDeporteED.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
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
        //Una vez se llenen los campos el boton de guardar se activa
        //en caso contrario, no se habilita
        private void lblCodigoDeportistaED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblNombreED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblApellidoED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDireccionED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblTelefonoED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblEdadED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDeporteED_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
