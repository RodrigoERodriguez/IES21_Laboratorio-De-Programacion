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
    public partial class frmRegistroDeUsuario : Form
    {
        public frmRegistroDeUsuario()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            string NombreUsuario = Convert.ToString(txtUsuario.Text);
            clsUsuarios Buscar = new clsUsuarios();
            Buscar.BuscarUsuario(NombreUsuario);

            if (Buscar.USUARIO == NombreUsuario)
            {
                MessageBox.Show("El usuario ya se encuentra registrado, por favor intenta con otro usuario o inicia sesion");
                txtUsuario.Focus();
            }
            else
            {
                clsUsuarios Registro = new clsUsuarios();
                Registro.USUARIO = txtUsuario.Text;
                Registro.CONTRASEÑA = txtContraseña.Text;
                Registro.NuevoUsuario();

                frmInicioDeSesion Inicio = new frmInicioDeSesion();
                Inicio.Show();
                this.Hide();

                Limpiar();
            }
        }

        //==============================================================================================================

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion Inicio = new frmInicioDeSesion();
            Inicio.Show();
            this.Hide();
        }

        //==============================================================================================================

        private void Check()
        {
            if (txtContraseña.Text != "" & txtUsuario.Text != "")
            {
                cmdRegistrarse.Enabled = true;
            }
            else
            {
                cmdRegistrarse.Enabled = false;
            }
        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        //==============================================================================================================

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        //==============================================================================================================

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
