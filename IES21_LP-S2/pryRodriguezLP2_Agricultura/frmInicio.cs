using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezTPAgriculturaV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidades = new frmLocalidades();
            frmLocalidades.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivo frmCultivo = new frmCultivo();
            frmCultivo.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmProduccion = new frmProduccion();
            frmProduccion.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsulta = new frmConsulta();
            frmConsulta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
