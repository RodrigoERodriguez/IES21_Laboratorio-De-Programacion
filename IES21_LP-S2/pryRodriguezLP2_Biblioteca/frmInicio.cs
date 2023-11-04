using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezTpBibliotecaV2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros objVentana = new frmLibros();
            objVentana.ShowDialog();
        }
    }
}
