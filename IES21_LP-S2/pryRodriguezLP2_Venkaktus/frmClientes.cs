using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezTPVenkaktusV1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        //Creamos un char para separar los caracteres
        public char separador = Convert.ToChar(",");

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            this.Close();
        }

        private void cmdCargarCliente_Click(object sender, EventArgs e)
        {
           string IDCliente = mskIDCliente.Text;
           string NombreCliente = txtNombreCliente.Text;

           //Creo la variable MENSAJE para poder escribir en el archivo de una forma mas "Limpia"
           string MensajeCliente;
           MensajeCliente = IDCliente + "," + NombreCliente;

           //Creo un boolean para que me haga de bandera para controlar si esta o no repetido el ID
           bool check = false;


            //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
            StreamWriter swArchivoDeClientes = new StreamWriter("./Clientes.txt",true);

            //Cierra el archivo Vendedores.txt
            swArchivoDeClientes.Close();

            //Creo un streamReader para que lea el archivo
            StreamReader srClientes = new StreamReader("./Clientes.txt");

            //Corroboro si el ID ya fue cargado
            while (!srClientes.EndOfStream)
            {
                //Almaceno todo lo del archivo en mi vector
                string[] Clientes = srClientes.ReadLine().Split(separador);

                if (Clientes[0] == IDCliente)
                {
                    //Confirmo que el id esta repetido en el archivo
                    check = true;
                }
            }
            //Cierra el archivo Vendedores.txt
            srClientes.Close();

            //Si no esta repetido accede y me lo carga 
            if (!check)
            {
                //Escribe en el archivo
                StreamWriter swClientes = new StreamWriter("./Clientes.txt", true);

                //Hace que cuando se carge el archivo escriba la variable MENSAJE junto a los elementos que se puse
                swClientes.WriteLine(MensajeCliente);

                //Cierra el archivo Clientes.txt
                swClientes.Close();

                MessageBox.Show("El ID " + IDCliente + " Cargado con exito");

                //Limpia los elementos
                mskIDCliente.Text = "";
                txtNombreCliente.Text = "";

                //Deja el cursor en la msk
                //No funciona, PREGUNTAR
                mskIDCliente.Focus();
            }
            else
            {
                MessageBox.Show("El ID " + IDCliente + " Se encuentra repetido");

                //Limpia la msk para que reingrese un nuevo ID
                mskIDCliente.Text = "";

                //Deja el cursor en la msk
                //No funciona, PREGUNTAR
                mskIDCliente.Focus();
            }
        }

        //Cuando la Mascara este cargada y este cargada la textbox me habilita el boton de carga
        private void frmClientes_Load(object sender, EventArgs e)
        {
            mskIDCliente.Focus();
            if (txtNombreCliente.Text != "" && mskIDCliente.Text != "")
            {
                cmdCargarCliente.Enabled = true;
            }
            else
            {
                cmdCargarCliente.Enabled = false;
            }
        }

        //Cuando la msk este cargada junto a la textbox me habilita el boton de carga
        //Me parece que se puede optimizar PREGUNTAR
        private void mskIDCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtNombreCliente.Text != "" && mskIDCliente.Text != "")
            {
                cmdCargarCliente.Enabled = true;
            }
            else
            {
                cmdCargarCliente.Enabled = false;
            }
        }

        //Cuando la textbox este cargada junto a la msk me habilita el boton de carga
        //Me parece que se puede optimizar PREGUNTAR
        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text != "" && mskIDCliente.Text != "")
            {
                cmdCargarCliente.Enabled = true;
            }
            else
            {
                cmdCargarCliente.Enabled = false;
            }
        }
    }
}
