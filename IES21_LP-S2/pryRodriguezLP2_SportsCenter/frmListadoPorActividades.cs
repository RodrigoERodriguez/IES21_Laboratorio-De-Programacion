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
    public partial class frmListadoPorActividades : Form
    {
        public frmListadoPorActividades()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void frmListadoPorActividades_Load(object sender, EventArgs e)
        {
            clsActividad Actividades = new clsActividad();
            Actividades.ListarActividades(lstActividad);
            lstActividad.SelectedIndex = -1;
        }

        //==============================================================================================================

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 CodigoActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsSocios Listar = new clsSocios();
            Listar.ListarPorActividades(dgvListadoPorActividad, CodigoActividad);
            lblClientes.Text = Convert.ToString(Listar.CLIENTES);
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
