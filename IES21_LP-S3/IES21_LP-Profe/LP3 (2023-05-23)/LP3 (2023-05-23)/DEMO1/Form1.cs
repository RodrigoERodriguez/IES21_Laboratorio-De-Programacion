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

namespace DEMO1
{
    public partial class Form1 : Form
    {

        string[] alumnos = { "ANA", "PEDRO", "ESTELA", "LUISA", "JOSE" };
        int[] notas1 = { 7, 3, 10, 5, 8 };
        int[] notas2 = { 2, 10, 4, 7, 3 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Series serie = chart1.Series.Add("PRIMER PARCIAL");

            serie.Points.AddXY("ANA", 9);
            serie.Points.AddXY("PEDRO", 3);
            serie.Points.AddXY("PATRICIA", 7);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series serie = chart1.Series.Add("PRIMER PARCIAL");
          
            int i = 0;
            while(i<alumnos.Length)
            {
                serie.Points.AddXY(alumnos[i], notas1[i]);
                i++;
            }

            chart1.Titles.Clear();
            chart1.Titles.Add("LABORATORIO DE PROGRAMACION 3");

            chart1.ChartAreas[0].AxisX.Title = "ALUMNOS";
            chart1.ChartAreas[0].AxisY.Title = "NOTA";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series serie1 = chart1.Series.Add("PRIMER PARCIAL");
            Series serie2 = chart1.Series.Add("SEGUNDO PARCIAL");

            int i = 0;
            while (i < alumnos.Length)
            {
                serie1.Points.AddXY(alumnos[i], notas1[i]);
                serie2.Points.AddXY(alumnos[i], notas2[i]);
                i++;
            }

            chart1.Titles.Clear();
            chart1.Titles.Add("LABORATORIO DE PROGRAMACION 3");

            chart1.ChartAreas[0].AxisX.Title = "ALUMNOS";
            chart1.ChartAreas[0].AxisY.Title = "NOTA";
        }
    }
}
