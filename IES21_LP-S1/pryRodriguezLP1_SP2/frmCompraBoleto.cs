using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezRodrigoSP2
{
    public partial class frmCompraBoleto : Form
    {
        public frmCompraBoleto()
        {
            InitializeComponent();
        }

        private void cmdComprar_Click(object sender, EventArgs e)
        {   
            //Declaramos las variables

            int destino;
            int tiempo;
            int resultado;
            int descuento;
            int total;

            tiempo = 0;
            destino = int.Parse(txtDestino.Text);
            resultado = int.Parse(txtTiempo.Text);
            descuento = (destino * 5) * 50 / 100;
            total = (destino * 5) - descuento;

            if (destino >= 100 && tiempo >= 7)
            {
                descuento = (destino * 5) * 50 / 100;
                total = ((destino * 5) - descuento) * 2;
            }
            if (destino >= 100 && tiempo < 7)
            {
                descuento = (destino * 5) * 50 / 100;
                total = ((destino * 5) - descuento) * 2;
            }
            if (destino < 100 && tiempo >= 7)
            {
                descuento = (destino * 5) * 50 / 100;
                total = (destino * 5) * 2;
            }
            if (destino < 100 && tiempo < 7)
            {
                total = destino * 5;
                total = (destino * 5) * 2;
            }
            MessageBox.Show("Su total a pagar por los boletos ida y vuelta es " + total);
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            //Una vez llenado el dato el boton "ACEPTAR" se habilita
            //Si no se llena o se borra el dato el boton "ACEPTAR" se Deshabilita

            if (txtTiempo.Text != "")
            {
                cmdComprar.Enabled = true;
            }
            else
            {
                cmdComprar.Enabled = false;
            }
            

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            //Una vez llenado el dato el boton "ACEPTAR" se habilita
            //Si no se llena o se borra el dato el boton "ACEPTAR" se Deshabilita
            if (txtDestino.Text != "")
            {
                cmdComprar.Enabled = true;
            }
            else
            {
                cmdComprar.Enabled = false;
            }
        }

        private void txtDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Es un evento que permite solamente la escritura de numeros
            if (e.KeyChar > '0' && e.KeyChar < '9' || e.KeyChar == ((char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Es un evento que permite solamente la escritura de numeros
            if (e.KeyChar > '0' && e.KeyChar < '9' || e.KeyChar == ((char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
