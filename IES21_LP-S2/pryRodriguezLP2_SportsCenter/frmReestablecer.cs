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
    public partial class frmReestablecer : Form
    {
        public frmReestablecer()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        void abrirFormulario(Form form) //Con este procedimiento llamara un formulario al panel central
        {
            //Va a borrar lo que este en el panel central
            //permitiendo asi que se abra otro formulario mas
            while (PCentral.Controls.Count > 0)
            {
                PCentral.Controls.RemoveAt(index: 0);
            }
            Form formhijo = form;
            formhijo.TopLevel = false; //TopLevel es una propiedad nativa de los formularios
                                       //La cual deshabilitaremos
            formhijo.FormBorderStyle = FormBorderStyle.None; //Con esto saco el borde del formulario que llamo
            formhijo.Dock = DockStyle.Fill; //Ocupa todo el lugar del panel central

            PCentral.Controls.Add(formhijo);
            formhijo.Show();
        }

        //==============================================================================================================

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento MODIFICAR
            //y la informacion con la que se llenen los campos
            //los datos cargados se almacenaran en la variable local
            //de la clase y posteriormente lo almacenara.
            string Usuario = txtUsuario.Text;
            clsUsuarios Modificar = new clsUsuarios();

            if (Modificar.USUARIO == Usuario)
            {
                Modificar.CONTRASEÑA = txtContraseña.Text;
                Modificar.OlvidasteTuContraseña(Usuario);
            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }

            frmInicioDeSesion InicioSesion = new frmInicioDeSesion();
            InicioSesion.Show();
            this.Hide();
            Limpiar();
        }

        //==============================================================================================================

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion InicioSesion = new frmInicioDeSesion();
            InicioSesion.Show();
            this.Hide();
        }

        //==============================================================================================================

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContraseña.ReadOnly = false;
            }
            else
            {
                txtContraseña.ReadOnly = true;
            }
        }

        //==============================================================================================================

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void frmReestablecer_Load(object sender, EventArgs e)
        {

        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }
    }
}
