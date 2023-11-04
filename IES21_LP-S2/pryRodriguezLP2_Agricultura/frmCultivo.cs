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

namespace pryRodriguezTPAgriculturaV1
{
    public partial class frmCultivo : Form
    {
        public frmCultivo()
        {
            InitializeComponent();
        }

        //Creamos un char para separar los caracteres
        public char Separador = Convert.ToChar(",");

        private void cmdCargarCultivo_Click(object sender, EventArgs e)
        {
            string IDCultivo = mskIDCultivo.Text;
            string NombreCultivo = txtNombreCultivo.Text;

            //Creo un boolean para que me haga de bandera para controlar si esta o no repetido el ID
            bool checkCultivo = false;

            //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
            StreamWriter swArchivoCultivo = new StreamWriter("./Cultivo.txt", true);

            //Cierro el archivo
            swArchivoCultivo.Close();

            //Creo un streamReader para que lea el archivo
            StreamReader srCultivo = new StreamReader("./Cultivo.txt");

            //Con esta linea busco saber si el archivo tiene algo
            while (!srCultivo.EndOfStream)
            {
                //Almaceno todo lo del archivo en mi vector
                string[] NombreCult = srCultivo.ReadLine().Split(Separador);

                //Valido si es que ya existe el mismo ID de Cultivo
                if (IDCultivo == NombreCult[0])
                {
                    checkCultivo = true;
                }
            }
            //Cierro el archivo
            srCultivo.Close();

            //En caso de que el ID no este repetido lo carga
            //En caso de estar repetido no ingresaria
            if (checkCultivo == false)
            {
                //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
                StreamWriter swCultivo = new StreamWriter("./Cultivo.txt", true);

                //Escribo en el archivo el ID de la cultivo junto a su nombre
                //y luego lo cerramos
                swCultivo.WriteLine(IDCultivo + "," + NombreCultivo);
                swCultivo.Close();

                MessageBox.Show("El Cultivo se cargo con exito");

                //Limpio la msk y la txt
                mskIDCultivo.Text = "";
                txtNombreCultivo.Text = "";

                //Dejo el foco en la msk para que carguen nuevamente
                mskIDCultivo.Focus();
            }
            else
            {
                MessageBox.Show("El ID " + mskIDCultivo.Text + " ya existe, por favor intente nuevamente");
                mskIDCultivo.Text = "";
                mskIDCultivo.Focus();
            }
        }

        private void frmCultivo_Load(object sender, EventArgs e)
        {
            if (txtNombreCultivo.Text != "" && mskIDCultivo.Text != "")
            {
                cmdCargarCultivo.Enabled = true;
            }
            else
            {
                cmdCargarCultivo.Enabled = false;
            }
        }
        //Cuando la Mascara este cargada y este cargada la textbox me habilita el boton de carga
        private void mskIDCultivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtNombreCultivo.Text != "" && mskIDCultivo.Text != "")
            {
                cmdCargarCultivo.Enabled = true;
            }
            else
            {
                cmdCargarCultivo.Enabled = false;
            }
        }
        //Cuando la textbox este cargada me habilita el boton
        private void txtNombreCultivo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreCultivo.Text != "" && mskIDCultivo.Text != "")
            {
                cmdCargarCultivo.Enabled = true;
            }
            else
            {
                cmdCargarCultivo.Enabled = false;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
