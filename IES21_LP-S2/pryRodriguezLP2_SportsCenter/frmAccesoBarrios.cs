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
    public partial class frmAccesoBarrios : Form
    {
        public frmAccesoBarrios()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdListadoBarrios_Click(object sender, EventArgs e)
        {
            frmListadoPorBarrio ListadoPorBarrio = new frmListadoPorBarrio();
            ListadoPorBarrio.ShowDialog();
        }
    }
}
