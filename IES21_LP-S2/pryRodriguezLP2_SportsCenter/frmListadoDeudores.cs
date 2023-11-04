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
    public partial class frmListadoDeudores : Form
    {
        public frmListadoDeudores()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsSocios Listar = new clsSocios();
            Listar.ListarDeudores(dgvListadoDeudores);
            lblSociosDeudores.Text = Convert.ToString(Listar.CLIENTES);
            lblMontoDeuda.Text = Convert.ToString(Listar.SALDO);
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
