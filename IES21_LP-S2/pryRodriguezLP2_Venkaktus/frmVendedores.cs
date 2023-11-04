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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
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

        private void cmdCargarVendedor_Click(object sender, EventArgs e)
        {
            string IDVendedores = mskIDVendedores.Text;
            string NombreVendedores = txtNombreVendedor.Text;

            //Creo la variable MENSAJE para poder escribir en el archivo de una forma mas "Limpia"
            string Mensaje;
            Mensaje = IDVendedores + "," + NombreVendedores;

            //Creo un boolean para que me haga de bandera para controlar si esta o no repetido el ID
            bool check = false;

            //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
            StreamWriter swArchivoVendedores = new StreamWriter("./Vendedores.txt", true);

            //Cierra el archivo Vendedores.txt
            swArchivoVendedores.Close();

            //Creo un streamReader para que lea el archivo
            StreamReader srVendedores = new StreamReader("./Vendedores.txt");

            //Corroboro si el ID ya fue cargado usando como condicion el fin de archivo
            while (!srVendedores.EndOfStream)
            {
                //Almaceno todo lo del archivo en mi vector
                string[] Vendedores = srVendedores.ReadLine().Split(separador);

                if (Vendedores[0] == IDVendedores)
                {
                    //Confirmo que el id esta repetido en el archivo
                    check = true;
                }
            }

            //Cierra el archivo Vendedores.txt
            srVendedores.Close();

            //Si no esta repetido accede y me lo carga 
            if (!check)
            {
                //Escribe en el archivo
                StreamWriter swVendedores = new StreamWriter("./Vendedores.txt", true);

                //Hace que cuando se carge el archivo escriba la variable MENSAJE junto a los elementos que se puse
                swVendedores.WriteLine(Mensaje);

                //Cierra el archivo Vendedores.txt
                swVendedores.Close();

                MessageBox.Show("El ID " + IDVendedores + " Cargado con exito");

                //Limpia los elementos
                mskIDVendedores.Text = "";
                txtNombreVendedor.Text = "";

                //Deja el cursor en la msk
                //No funciona, PREGUNTAR
                mskIDVendedores.Focus();
            }
            else
            {
                MessageBox.Show("El ID " + IDVendedores + " Se encuentra repetido");

                //Limpia la msk para que reingrese un nuevo ID
                mskIDVendedores.Text = "";

                //Deja el cursor en la msk
                //No funciona, PREGUNTAR
                mskIDVendedores.Focus();
            }
        }

        
        //Cuando la Mascara este cargada y este cargada la textbox me habilita el boton de carga
        private void frmVendedores_Load(object sender, EventArgs e)
        {
            mskIDVendedores.Focus();
            if (txtNombreVendedor.Text != "" && mskIDVendedores.Text != "")
            {
                cmdCargarVendedor.Enabled = true;
            }
            else
            {
                cmdCargarVendedor.Enabled = false;
            }
        }

        //Cuando la msk este cargada junto a la textbox me habilita el boton de carga
        //Me parece que se puede optimizar PREGUNTAR
        private void mskIDVendedores_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtNombreVendedor.Text != "" && mskIDVendedores.Text != "")
            {
                cmdCargarVendedor.Enabled = true;
            }
            else
            {
                cmdCargarVendedor.Enabled = false;
            }
        }

        //Cuando la textbox este cargada junto a la msk me habilita el boton de carga
        //Me parece que se puede optimizar PREGUNTAR
        private void txtNombreVendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreVendedor.Text != "" && mskIDVendedores.Text != "")
            {
                cmdCargarVendedor.Enabled = true;
            }
            else
            {
                cmdCargarVendedor.Enabled = false;
            }
        }
    }
}
