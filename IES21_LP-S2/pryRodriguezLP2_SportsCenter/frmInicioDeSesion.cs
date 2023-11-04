using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web;

namespace pryRodriguezSportsCenterIEFI
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        //Permite mover el formulario del inicio de sesion

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        //==============================================================================================================

        private void cmdIniciarSesion_Click(object sender, EventArgs e)
        {
            frmInicioSistema inicioSistema = new frmInicioSistema();
            inicioSistema.Show();
            this.Hide();
        }

        //==============================================================================================================

        private void lblOlvidasteTuContraseña_Click(object sender, EventArgs e)
        {
            frmReestablecer Reestablecer = new frmReestablecer();
            Reestablecer.Show();
            this.Hide();
        }

        //==============================================================================================================

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistroDeUsuario registrar = new frmRegistroDeUsuario();
            registrar.Show();
            this.Hide();
        }

        //==============================================================================================================

        //Muesta el usuario y Contraseña del programa

        private void cmdInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: TORITO \n Contraseña: 2222 ");
        }

        //==============================================================================================================

        //Cierra el formulario

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        //Cuando paso el mause por encima cambia a color azul

        private void lblOlvidasteTuContraseña_MouseMove(object sender, MouseEventArgs e)
        {
            lblOlvidasteTuContraseña.ForeColor = Color.Blue;
        }

        //==============================================================================================================

        //Estado por defecto es blanco

        private void lblOlvidasteTuContraseña_MouseLeave(object sender, EventArgs e)
        {
            lblOlvidasteTuContraseña.ForeColor = Color.White;
        }

        //==============================================================================================================

        //Habilita y deshabilita el boton de inicar sesion dependiendo el contenido de los textsboxs

        private void Check()
        {
            if (txtContraseña.Text == "2222" & txtUsuario.Text == "TORITO")
            {
                cmdIniciarSesion.Enabled = true;
            }
            else
            {
                cmdIniciarSesion.Enabled = false;
            }
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

        //==============================================================================================================

        private void frmInicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        //==============================================================================================================

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        //==============================================================================================================

        //Hace que regrese el texto del comando

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.White;
            }
        }

        //==============================================================================================================


        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        //==============================================================================================================

        //Hace que regrese el texto del comando

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        //==============================================================================================================

        //Nos permite arrastrar el formulario

        private void frmInicioDeSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PBLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PInferior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
