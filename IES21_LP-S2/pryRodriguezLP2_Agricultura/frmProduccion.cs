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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        //Creo un separador de tipo char
        char Separador = Convert.ToChar(",");

        private void cmdCargarProduccion_Click(object sender, EventArgs e)
        {
            //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
            StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);

            DateTime varFecha = dtpFecha.Value.Date;
            string NombreLocalidad = lstNombreLocalidad.Text;
            string NombreCultivo = lstNombreCultivo.Text;

            //Creo la variable MENSAJE para poder escribir en el archivo de una forma mas "Limpia"
            string Tonelada = mskToneladaPro.Text;
            string Mensaje;
            Mensaje = varFecha + "," + NombreLocalidad + "," + NombreCultivo + "," + Tonelada;

            MessageBox.Show("Datos cargado correctamente");

            //Limpia la msk
            mskToneladaPro.Text = "";

            //Deja el cursor en la lst
            //No funciona, PREGUNTAR
            lstNombreCultivo.Focus();

            //Hace que cuando se carge el archivo escriba la variable MENSAJE junto a los elementos que se puse
            swProduccion.WriteLine(Mensaje);

            //Cierro el archivo
            swProduccion.Close();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //Traigo los archivos y los abro en la carga del formulario
            StreamReader srCultivos = new StreamReader("./Cultivo.txt");
            StreamReader srLocalidades = new StreamReader("./Localidades.txt");

            while (!srCultivos.EndOfStream)
            {
                //Almaceno todo lo del archivo en mi vector
                string[] NombreCultivo = srCultivos.ReadLine().Split(Separador);

                //Agrego cada elemento del archivo de cultivo y lo cargo en la lista desplegable
                lstNombreCultivo.Items.Add(NombreCultivo[1]);
            }
            //Cierro el archivo
            srCultivos.Close();

            while (!srLocalidades.EndOfStream)
            { 
                //Almaceno todo lo del archivo en mi vector
                string[] NombreLocalidad = srLocalidades.ReadLine().Split(Separador);

                //Agrego cada elemento del archivo de localidades y lo cargo en la lista desplegable
                lstNombreLocalidad.Items.Add(NombreLocalidad[1]);
            }

            //Cierro el archivo
            srLocalidades.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //Cierro el formulario
            this.Close();
        }
    }
}
