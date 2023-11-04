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

namespace DEMO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();

            Series serie = chart1.Series.Add("TIRADAS DE BOLAS");

            Random r = new Random();
            int bolas;
            int menores = 0;
            int mayores = 0;

            for(bolas=0;bolas<50;bolas++)
            {
                int v = r.Next(0, 36);
                serie.Points.Add(v);
                if(v>18)
                {
                    mayores++;
                }else
                {
                    menores++;
                }

            }

            label1.Text = menores.ToString();
            label2.Text = mayores.ToString();
        }
    }
}
