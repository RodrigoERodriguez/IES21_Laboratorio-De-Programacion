using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezRodrigoSP2
{
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            //Este comando hace que se muestre la ventana del formulario
            //"frmCompraBoleto" una vez se precione el boton "INGRESAR"
            frmCompraBoleto objVentana = new frmCompraBoleto();
            objVentana.ShowDialog();
        }
    }
}
