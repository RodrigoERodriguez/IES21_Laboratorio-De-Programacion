using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezTPVenkaktusV1
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedores frmVendedores = new frmVendedores();
            frmVendedores.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultas = new frmConsultas();
            frmConsultas.ShowDialog();
        }
    }
}
