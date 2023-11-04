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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            string archivo = saveFileDialog1.FileName;

            StreamWriter sw = new StreamWriter(archivo);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            sw.Dispose();

            
        }
    }
}
