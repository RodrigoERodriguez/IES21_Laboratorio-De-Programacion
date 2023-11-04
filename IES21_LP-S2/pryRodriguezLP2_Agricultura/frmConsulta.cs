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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //PREGUNTAR al profe como seguir
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            //Creo un SR para que lea el archivo
            StreamReader srProduccion = new StreamReader("./Produccion.txt");

            //Creo una variable tipo CHAR para poder separar los elementos en mi archivo
            char varSeparador = Convert.ToChar(",");      

            while (!srProduccion.EndOfStream)
            {
                //Creo una variable para que me lea la linea del archivo
                string Cultivo = srProduccion.ReadLine();

                //Cargo el vector con la linea leida en el archivo
                string[] Produccion = Cultivo.Split(varSeparador);

                //Muestra los datos en la grilla de CONSULTAS
                dgvConsulta.Rows.Add(Produccion[0], Produccion[1], Produccion[2], Produccion[3]);
            }

            //Cerra el archibo
            srProduccion.Close();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
