using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezRodrigoSP1
{
    public partial class frmLogin : Form
    {
        int count = 0;
        public frmLogin()
        {
            InitializeComponent();
            lstModulo.SelectedIndex = 0;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (count ==2)
            {
                Application.Exit();
            }

            //Declaracion de las variables

            string contrasenia;
            string usuario;
            string modulo;

            modulo = lstModulo.SelectedItem.ToString();
            usuario = txtUsuario.Text;
            contrasenia = txtContraseña.Text;

            if (usuario == "Adm" && contrasenia == "@la" && modulo != "SIST")
            {
                frmBienvenida objBienvenido = new frmBienvenida();

                objBienvenido.Show();

            }

            else if (usuario == "God" && contrasenia == "*@#4d")
            {

                frmBienvenida objBienvenido = new frmBienvenida();

                objBienvenido.Show();

            }
            else if (usuario == "Ceci" && contrasenia == "*@3c" && modulo != "SIST" && modulo != "COM")
            {

                frmBienvenida objBienvenido = new frmBienvenida();

                objBienvenido.Show();
            }
            else if (usuario == "John" && contrasenia == "*2b" && modulo == "SIST")
            {

                frmBienvenida objBienvenido = new frmBienvenida();

                objBienvenido.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                count += 1;
            }
            

            
        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //Activo el boton "ACEPTAR" si se rellena el usuario 
            //Desactivo el boton "ACEPTAR" si no se rellena o se borra el usuario
            if (txtUsuario.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            //Cierro el formulario en caso de apretar el boton "CANCELAR"
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '0' && e.KeyChar < '9')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            //Activo el boton "ACEPTAR" si se coloco la contrasenia 
            //Desactivo el boton "ACEPTAR" si no coloco la contrasenia o la borro
            if (txtContraseña.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }
    }
}
