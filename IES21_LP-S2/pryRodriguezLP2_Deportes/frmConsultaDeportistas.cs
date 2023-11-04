using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezBaseDeDatosDeportesV2
{
    public partial class frmConsultaDeportistas : Form
    {
        public frmConsultaDeportistas()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento LISTAR
            //y me mostrara en la grilla toda la tabla de
            //la base de datos que tengo seleccionada en la
            //clase.
            DGVConsultaDeportista.DataSource = null;
            clsDeportista Consulta = new clsDeportista();
            Consulta.Listar(DGVConsultaDeportista);       
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
