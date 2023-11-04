using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRodriguezTPAgriculturaV1
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        //Creamos un char para separar los caracteres
        public char Separador = Convert.ToChar(",");

        private void cmdCargarLocalidad_Click(object sender, EventArgs e)
        {
            string IDLocalidad = mskIDLocalidad.Text;
            string NombreLocalidad= txtNombreLocalidad.Text;

            //Creo un boolean para que me haga de bandera para controlar si esta o no repetido el ID
            bool check = false;

            //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
            StreamWriter swArchivoLocalidad = new StreamWriter("./Localidades.txt", true);

            //Cierra el archivo
            swArchivoLocalidad.Close();

            //Creo un streamReader para que lea el archivo
            StreamReader srLocalidades = new StreamReader("./Localidades.txt");

            //Con esta linea busco saber si el archivo tiene algo
            while (!srLocalidades.EndOfStream)
            {
                //Almaceno todo lo del archivo en mi vector
                string[] NombreLoc = srLocalidades.ReadLine().Split(Separador);

                //Valido si es que ya existe el mismo ID de localidad
                if (IDLocalidad == NombreLoc[0])
                {
                    check = true;
                }
            }
            srLocalidades.Close();

            //En caso de que el ID no este repetido lo carga
            //En caso de estar repetido no ingresaria
            if (check == false)
            {
                //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
                StreamWriter swLocalidad = new StreamWriter("./Localidades.txt", true);

                //Escribo en el archivo el ID de la localidad junto a su nombre
                //y luego lo cerramos
                swLocalidad.WriteLine(IDLocalidad + "," + NombreLocalidad);

                //Cierro el archivo
                swLocalidad.Close();

                MessageBox.Show("La localidad se cargo con exito");

                //Limpio la msk y la txt
                mskIDLocalidad.Text = "";
                txtNombreLocalidad.Text = "";

                //Dejo el foco en la msk para que carguen nuevamente
                //No funca PREGUNTAR
                mskIDLocalidad.Focus();
            }
            else
            {
                MessageBox.Show("El ID " + mskIDLocalidad.Text + " ya existe, por favor intente nuevamente");

                //Limpio la msk para que intente cargar nuevamente
                mskIDLocalidad.Text = "";

                //Dejo el foco en la msk para que carguen nuevamente
                //No funca PREGUNTAR
                mskIDLocalidad.Focus();
            }
        }

        //Cuando la Mascara este cargada y este cargada la textbox me habilita el boton de carga
        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            if (txtNombreLocalidad.Text != "" && mskIDLocalidad.Text != "")
            {
                cmdCargarLocalidad.Enabled = true;
            }
            else
            {
                cmdCargarLocalidad.Enabled = false;
            }
        }

        //Cuando la msk este cargada junto a la textbox me habilita el boton de carga
        //Me parece que se puede optimizar PREGUNTAR si puedo con un IF
        private void mskIDLocalidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtNombreLocalidad.Text != "" && mskIDLocalidad.Text != "")
            {
                cmdCargarLocalidad.Enabled = true;
            }
            else
            {
                cmdCargarLocalidad.Enabled = false;
            }
        }

        //Cuando la msk este cargada junto a la textbox me habilita el boton de carga
        //Me parece que se puede optimizar PREGUNTAR si puedo con un IF
        private void txtNombreLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreLocalidad.Text != "" && mskIDLocalidad.Text != "")
            {
                cmdCargarLocalidad.Enabled = true;
            }
            else
            {
                cmdCargarLocalidad.Enabled = false;
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
