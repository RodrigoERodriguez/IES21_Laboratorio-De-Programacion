using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] comidas = {
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS",
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS",
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS",
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS"

            };

            foreach(string comida in comidas)
            {
                ListViewItem lvi = lv.Items.Add(comida);
                lvi.Tag = "xxx";


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lv.Items)
            {
                if(lvi.Checked==true)
                {
                    MessageBox.Show(lvi.Text);
                }
            }
        }
    }
}
