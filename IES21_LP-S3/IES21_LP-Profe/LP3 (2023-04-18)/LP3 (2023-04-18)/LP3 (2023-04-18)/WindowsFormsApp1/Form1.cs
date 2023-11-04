using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivos de texto|*.txt|Archivos Acrobat|*.pdf";
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);

        }
    }
}
