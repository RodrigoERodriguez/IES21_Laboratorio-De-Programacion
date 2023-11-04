using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSportsCenterIEFI
{
    public partial class frmListadoPorBarrio : Form
    {
        public frmListadoPorBarrio()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void frmListadoPorBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio Barrios = new clsBarrio();
            Barrios.ListarBarrios(lstBarrio);
            lstBarrio.SelectedIndex = -1;
        }

        //==============================================================================================================

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 CodigoBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            clsSocios Listar = new clsSocios();
            Listar.ListarPorActividades(dgvListadoPorBarrio, CodigoBarrio);
            lblClientes.Text = Convert.ToString(Listar.CLIENTES);
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
