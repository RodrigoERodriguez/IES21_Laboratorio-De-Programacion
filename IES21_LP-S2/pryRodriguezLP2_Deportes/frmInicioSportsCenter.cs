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
    public partial class frmInicioSportsCenter : Form
    {
        public frmInicioSportsCenter()
        {
            InitializeComponent();
        }

        private void frmPantallaDeInicio_Load(object sender, EventArgs e)
        {

        }

        //Dependiendo de donde haga click entra a uno u otro formulario
        private void TSMRegistroDeportista_Click(object sender, EventArgs e)
        {
            frmRegistroDeportistas RegistroDeportista = new frmRegistroDeportistas();
            RegistroDeportista.ShowDialog();
        }

        private void TSMConsultaDeportista_Click(object sender, EventArgs e)
        {
            frmConsultaDeportistas ConsultaDeportista = new frmConsultaDeportistas();
            ConsultaDeportista.ShowDialog();
        }

        private void TSMModificarDeportista_Click(object sender, EventArgs e)
        {
            frmModificarDeportistas ModificarDeportistas = new frmModificarDeportistas();
            ModificarDeportistas.ShowDialog();
        }

        private void TSMEliminarDeportista_Click(object sender, EventArgs e)
        {
            frmEliminarDeportistas EliminarDeportistas = new frmEliminarDeportistas();
            EliminarDeportistas.ShowDialog();
        }

        private void TSMSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMRegistroEntrenador_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenadores RegistroEntrenadores = new frmRegistroEntrenadores();
            RegistroEntrenadores.ShowDialog();
        }

        private void TSMConsultaEntrenador_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenadores ConsultaEntrenadores = new frmConsultaEntrenadores();
            ConsultaEntrenadores.ShowDialog();
        }

        private void TSMModificarEntrenadores_Click(object sender, EventArgs e)
        {
            frmModificarEntrenadores ModificarEntrenadores = new frmModificarEntrenadores();
            ModificarEntrenadores.ShowDialog();
        }

        private void TSMEliminarEntrenadores_Click(object sender, EventArgs e)
        {
            frmEliminarEntrenadores EliminarEntrenadores = new frmEliminarEntrenadores();
            EliminarEntrenadores.ShowDialog();
        }
    }
}
