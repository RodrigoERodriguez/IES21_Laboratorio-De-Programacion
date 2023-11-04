using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("ESTOY EN LA FICHA 1");
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("ESTOY EN LA FICHA 2");
        }
    }
}
