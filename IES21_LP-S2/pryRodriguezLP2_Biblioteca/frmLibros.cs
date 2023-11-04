using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezTpBibliotecaV2
{
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        //Declaracion Variables globales e indice
        public string[,] Libros = new string[21, 5];
        public int Contador = 0;

        //Declaro un separador tipo char
        public char Separador = Convert.ToChar(",");

        private void frmLibros_Load(object sender, EventArgs e)
        {

            //Creo una variable para controlar el while
            int i = 0;

            StreamReader srLibro = new StreamReader("./LIBRO.txt");

            while (!srLibro.EndOfStream && i<21)
            {
                //Creo un vector en el cual almaceno todo lo del archivo Libro.txt
                string[] VecLibro = srLibro.ReadLine().Split(Separador);

                //Borro el espacio en blanco del archivo
                for (int pos = 0; pos < VecLibro.Length; pos++)
                {
                    //La funcion regex.Replace hace que se borren los espacios en blando dentro del archivo
                    //dejando solamente el texto dentro de el
                    VecLibro[pos] = Regex.Replace(VecLibro[pos], @"\t", "");
                }

                //En el vector cargo la info del libro en cada columna de la matriz
                Libros[i,0] = VecLibro[0];
                Libros[i,1] = VecLibro[1];
                Libros[i,2] = VecLibro[2];
                Libros[i,3] = VecLibro[3];
                Libros[i,4] = VecLibro[4];

                //Busco el nombre de la editorial y lo cargo en la matriz
                //Estructura explicada con el profe
                //PREGUNTAR xq quedaron dudas
                NombreEditorial(i);

                //Busco el nombre de la distribuidora y lo cargo en la matriz
                //Estructura explicada con el profe
                //PREGUNTAR xq quedaron dudas
                NombreDistribuidora(i);

                i++;
            }
            //Cierra el archivo Libro.txt
            srLibro.Close();

            txtCodigo.Text = Libros[0, 0];
            txtNombre.Text = Libros[0, 1];
            txtCodigoEdit.Text = Libros[0,2];
            txtCodigoAut.Text = Libros[0,3];
            txtCodigoDist.Text = Libros[0,4];
        }








        private void NombreEditorial(int index)
        {
            //Creo un streamReader para que lea el archivo
            StreamReader LectorEditorial = new StreamReader("./EDITORIAL.txt");

            while (!LectorEditorial.EndOfStream)
            {
                //Compraro el codigo del LIBRO con el codigo de EDITORIAL
                //devuelve el nombre de la Editorial

                string[] VecEditorial = LectorEditorial.ReadLine().Split(Separador);

                for (int pos = 0; pos < VecEditorial.Length; pos++)
                {
                    //La funcion regex.Replace hace que se borren los espacios en blando dentro del archivo
                    //dejando solamente el texto dentro de el
                    //Funcion encontrada en el archivo explicativo en la pagina de vs
                    VecEditorial[pos] = Regex.Replace(VecEditorial[pos], @"\t", "");
                }

                //Pongo el nombre de la editorial correspondiente
                if (VecEditorial[0] == Libros[index, 2])
                {
                    //Sobreescribro en la Columna N4 con el nombre de la Editorial que almacene en el vector
                    Libros[index, 2] = VecEditorial[1];
                }
            }

            //Cierra el archivo Editorial.txt
            LectorEditorial.Close();

            
        }

        private void NombreDistribuidora(int index)
        {
            //Creo un streamReader para que lea el archivo
            StreamReader LectorDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");

            while (!LectorDistribuidora.EndOfStream)
            {
                //Compraro el codigo del LIBRO con el codigo de EDITORIAL
                //devuelve el nombre de la Editorial
                //Creo un vector en el cual almaceno todo lo del archivo Distribuidora.txt
                string[] VecDistribuidora = LectorDistribuidora.ReadLine().Split(Separador);

                //Borro el espacio en blanco del archivo
                for (int pos = 0; pos < VecDistribuidora.Length; pos++)
                {
                    //La funcion regex.Replace hace que se borren los espacios en blando dentro del archivo
                    //dejando solamente el texto dentro de el
                    VecDistribuidora[pos] = Regex.Replace(VecDistribuidora[pos], @"\t", "");
                }

                //Pongo el nombre de la distribuidora correspondiente
                if (VecDistribuidora[0] == Libros[index,4])
                {
                    //Sobreescribro en la Columna N4 con el nombre de la distribuidora que almacene en el vector
                    Libros[index, 4] = VecDistribuidora[1];
                }
            }
            //Cierra el archivo Distribuidora.txt
            LectorDistribuidora.Close();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            //Cada vez que haga click en el boton ">>" muestra el siguiente e
            //incrementa mi contador en 1
            Contador++;

            txtCodigo.Text = Libros[Contador, 0];
            txtNombre.Text = Libros[Contador, 1];
            txtCodigoEdit.Text = Libros[Contador, 2];
            txtCodigoAut.Text = Libros[Contador, 3];
            txtCodigoDist.Text = Libros[Contador, 4];

            cmdAnterior.Enabled = true;

            
            if (Contador == Libros.GetLength(0) - 1)
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            //Cada vez que haga click en el boton "<<" muestra el siguiente e
            //disminuye mi contador en 1
            Contador--;
            if (Contador >= 0)
            {
                txtCodigo.Text = Libros[Contador, 0];
                txtNombre.Text = Libros[Contador, 1];
                txtCodigoEdit.Text = Libros[Contador,2];
                txtCodigoAut.Text = Libros[Contador,3];
                txtCodigoDist.Text = Libros[Contador,4];

                if (Contador == 0)
                {
                    cmdAnterior.Enabled = false;
                }
            }
            else
            {
                cmdAnterior.Enabled = false;
            }

        }
    }
}

