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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            //Creo un SR para que lea el archivo
            StreamReader srConsultas = new StreamReader("./Vendedores.txt");

            //Creo una variable tipo CHAR para poder separar los elementos en mi archivo
            char Separador = Convert.ToChar(",");

            while (!srConsultas.EndOfStream)
            {
                //Creo una variable para que me lea la linea del archivo
                string Vendedores = srConsultas.ReadLine();

                //Cargo el vector con la linea leida en el archivo
                string[] Ventas = Vendedores.Split(Separador);

                //Muestra los datos en la grilla de CONSULTAS
                dgvConsultas.Rows.Add(Ventas[0], Ventas[1], Ventas[2], Ventas[3], Ventas[4], Ventas[5]);
            }

            //Cerra el archibo
            srConsultas.Close();
        }
    }
}
