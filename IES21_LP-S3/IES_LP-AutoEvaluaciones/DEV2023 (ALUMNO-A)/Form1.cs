using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DEV2023
{
    public partial class Form1 : Form
    {
        clsLenguajes objLenguajes;
        clsPaises objPaises;
        clsPaisesYLenguajes obsjPaisesYLenguajes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objPaises = new clsPaises();
                DataTable Paises = objPaises.getAll();
                foreach (DataRow filatablapaises in Paises.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = filatablapaises["nombre"].ToString();
                    item.Tag = filatablapaises["pais"];
                    listView1.Items.Add(item);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("error en la base de datos");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objLenguajes = new clsLenguajes();
                obsjPaisesYLenguajes = new clsPaisesYLenguajes();
                DataTable Lenguajes = objLenguajes.getAll();
                DataTable PaisesLenguaje = obsjPaisesYLenguajes.getAll();
                Series series = new Series();
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Cantidad de programadores y lenguajes por paises");
                int suma = 0;
                int sumatotal = 0;

                string NombreLenguaje = "";
                int Lenguaje = 0;

                foreach (DataRow filaLenguaje in Lenguajes.Rows)
                {
                    NombreLenguaje = filaLenguaje["nombre"].ToString();
                    Lenguaje = Convert.ToInt32(filaLenguaje["lenguaje"]);

                    series = chart1.Series.Add(NombreLenguaje.ToString());
                }

                foreach (ListViewItem a in listView1.CheckedItems)
                {
                    foreach (DataRow filapaises in PaisesLenguaje.Rows)
                    {
                        if (Convert.ToInt32(a.Tag) == Convert.ToInt32(filapaises["pais"]) && Lenguaje == Convert.ToInt32(filapaises["lenguaje"]))
                        {
                            suma = suma + Convert.ToInt32(filapaises["cantidad"]);
                            sumatotal = sumatotal + Convert.ToInt32(filapaises["cantidad"]);
                        }
                    }
                    series.Points.AddXY(a.Text, suma);
                    suma = 0;
                }

                toolStripStatusLabel1.Text = "Cantidad total: " + sumatotal;
            }
            catch (Exception)
            {
                MessageBox.Show("error en la base de datos");
                this.Close();
            }
        }
    }
}
