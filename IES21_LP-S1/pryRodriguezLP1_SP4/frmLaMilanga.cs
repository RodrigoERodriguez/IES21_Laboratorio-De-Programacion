using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezRodrigoSP4
{
    public partial class frmBarLaMilanga : Form
    {
        public frmBarLaMilanga()
        {
            InitializeComponent();
        }

        //declaro matriz, utilizando "," para indicar la dimension
        float[,] Ventas = new float[5, 4];
        //Lleno previamente el vector con los nombres de los mozos
        string[] Mozos = new string[5] { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        //Lleno previamente el vector con la categoría de las ventas.
        string[] Categoría = new string[4] { "Comidas", "Bebidas sin Alcohol", "Bebidas con Alcohol", "Postre" };

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //Cerramos el formulario
            this.Close();
        }

        private void frmBarLaMilanga_Load(object sender, EventArgs e)
        {
            //Con este evento cargo las filas de cada columna
            for (Int32 i = 0; i < Mozos.Length; i++)
            {
                //Relleno la grilla en base los nombres guardados del vector
                dgvVentas.Rows.Add(Mozos[i], 0, 0, 0, 0);
            }

            //Nadie puede modificar los nombres de los mozos
            //Primer columna de la matriz es el nombre del mozo
            dgvVentas.Columns[0].ReadOnly = true;

            //con esta instrucción no se selecciona ninguna celda
            dgvVentas.ClearSelection();
        }

        private void cmdLimpiar1_Click(object sender, EventArgs e)
        {
            //Boro los valores cargados por el usuario
            dgvVentas.Rows.Clear();
        }

        private void cmdValidar_Click(object sender, EventArgs e)
        {
            //Con esta variable consulto el tipo de dato
            string DatoCelda = "";
            //float verificar el dato de la celda
            float Numero = 0;
            //Con este booleano indico que si se cumple una u otra condicion
            //Me habilite los siguientes eventos
            //Lo declaro con un valor inicial siendo "TRUE"
            bool TodoOk = true;

            for (Int32 f = 0; f < Mozos.Length; f++)
            {
                //Inicializo en la columna 1 ya que poseo numeros, en la columna 0 no
                for (int c = 1; c < dgvVentas.ColumnCount; c++)
                {   
                    //Transfiero los datos de la celda a la variable DatoCelda
                    DatoCelda = dgvVentas.Rows[f].Cells[c].Value.ToString();

                    //Actua como un booleano arrojando el valor TRUE o FALSE
                    //Siendo el TRUE permitiendo la carga, ya que se encontraron numero
                    //y FALSE denegando la carga, ya que se encuenta la presencia de letras
                    //out es igual a nuestra condicion "NUMERO" siendo este valor distinto
                    //se debera cambiar los datos ingresados

                    if (float.TryParse(DatoCelda, out Numero) == false)
                    {
                        TodoOk = false;
                    }
                }
            }
            if (TodoOk == false)
            {
                MessageBox.Show("Error al cargar los datos, la grilla contiene letras.");
            }
            else
            {
                for (Int32 f = 0; f < Mozos.Length; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Ventas[f, c] = float.Parse(dgvVentas.Rows[f].Cells[c + 1].Value.ToString());
                    }
                }
                MessageBox.Show("Los datos han sido cargados correctamente.");
            }
        }

        private void cmdMostrar2_Click(object sender, EventArgs e)
        {
            float VentasJulio = 0;
            float VentasEsteban = 0;
            float VentasJavier = 0;
            float VentasGonzalo = 0;
            float VentasAlberto = 0;

            //Acumulamos las ventas de cada mozo
            //Comparamos quien tiene la mayor venta

            for (Int32 c = 0; c < Ventas.GetLength(1); c++)
            {
                VentasJulio = VentasJulio + Ventas[0, c];
            }
            for (Int32 c = 0; c < Ventas.GetLength(1); c++)
            {
                VentasEsteban = VentasEsteban + Ventas[1, c];
            }
            for (Int32 c = 0; c < Ventas.GetLength(1); c++)
            {
                VentasJavier = VentasJavier + Ventas[2, c];
            }
            for (Int32 c = 0; c < Ventas.GetLength(1); c++)
            {
                VentasGonzalo = VentasGonzalo + Ventas[3, c];
            }
            for (Int32 c = 0; c < Ventas.GetLength(1); c++)
            {
                VentasAlberto = VentasAlberto + Ventas[4, c];
            }
            if (VentasJulio > VentasEsteban && VentasJulio > VentasJavier && VentasJulio > VentasGonzalo && VentasJulio > VentasAlberto)
            {
                lblMozoDia.Text = "Julio";
                lblTotalDia.Text = VentasJulio.ToString();
            }
            if (VentasEsteban > VentasJulio && VentasEsteban > VentasJavier && VentasEsteban > VentasGonzalo && VentasEsteban > VentasAlberto)
            {
                lblMozoDia.Text = "Esteban";
                lblTotalDia.Text = VentasEsteban.ToString();
            }
            if (VentasJavier > VentasEsteban && VentasJavier > VentasJulio && VentasJavier > VentasGonzalo && VentasJavier > VentasAlberto)
            {
                lblMozoDia.Text = "Javier";
                lblTotalDia.Text = VentasJavier.ToString();
            }
            if (VentasGonzalo > VentasEsteban && VentasGonzalo > VentasJavier && VentasGonzalo > VentasJulio && VentasGonzalo > VentasAlberto)
            {
                lblMozoDia.Text = "Gonzalo";
                lblTotalDia.Text = VentasGonzalo.ToString();
            }
            if (VentasAlberto > VentasEsteban && VentasAlberto > VentasJavier && VentasAlberto > VentasGonzalo && VentasAlberto > VentasJulio)
            {
                lblMozoDia.Text = "Alberto";
                lblTotalDia.Text = VentasAlberto.ToString();
            }
        }

        private void cmdLimpiar2_Click(object sender, EventArgs e)
        {

        }

        private void cmdCalcular2_Click(object sender, EventArgs e)
        {
            //Declaro la variable TotalMozos
            float TotalMozos = 0;
            for (Int32 f = 0; f < Mozos.Length; f++)
            {
                for (int c = 0; c < Ventas.GetLength(1); c++)
                {
                    TotalMozos = TotalMozos + Ventas[f, c];
                }
            }
            lblTotalGeneralMostrar.Text = TotalMozos.ToString();
            //Declaro la variableTotalComida
            float TotalComida = 0;
            //La fila se incrementa
            //Se suma a los diferentes "TOTALES" para despues mostrarlo en las etiquetas correspondientes
            for (Int32 f = 0; f < Mozos.Length; f++)
            {
                TotalComida = TotalComida + Ventas[f, 0];
            }
            lblComidasMostrar.Text = TotalComida.ToString();
            float TotalBebidaSinAlcohol = 0;
            for (Int32 f = 0; f < Mozos.Length; f++)
            {
                TotalBebidaSinAlcohol = TotalBebidaSinAlcohol + Ventas[f, 1];
            }
            lblSAMostrar.Text = TotalBebidaSinAlcohol.ToString();
            float TotalBebidas = 0;
            for (Int32 f = 0; f < Mozos.Length; f++)
            {
                TotalBebidas = TotalBebidas + Ventas[f, 2];
            }
            lblCAMostrar.Text = TotalBebidas.ToString();
            float TotalPostre = 0;
            for (Int32 f = 0; f < Mozos.Length; f++)
            {
                TotalPostre = TotalPostre + Ventas[f, 3];
            }
            lblPostreMostrar.Text = TotalPostre.ToString();
            
        }
    }
}
