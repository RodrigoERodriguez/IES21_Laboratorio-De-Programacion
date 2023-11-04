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
    public partial class frmAccesoSocios : Form
    {
        public frmAccesoSocios()
        {
            InitializeComponent();
        }

        private void cmdNuevoSocio_Click(object sender, EventArgs e)
        {
            frmNuevoSocio NuevoSocio = new frmNuevoSocio();
            NuevoSocio.ShowDialog();
        }

        private void cmdListadoSocio_Click(object sender, EventArgs e)
        {
            frmListadoDeSocios ListadoDeSocios = new frmListadoDeSocios();
            ListadoDeSocios.ShowDialog();
        }

        private void cmdBuscarSocio_Click(object sender, EventArgs e)
        {
            frmBuscarSocio BuscarSocio = new frmBuscarSocio();
            BuscarSocio.ShowDialog();
        }

        private void cmdModificarSocio_Click(object sender, EventArgs e)
        {
            frmModificarSocio ModificarSocio = new frmModificarSocio();
            ModificarSocio.ShowDialog();
        }

        private void cmdDarDeBaja_Click(object sender, EventArgs e)
        {
            frmDarDeBaja DarDeBaja = new frmDarDeBaja();
            DarDeBaja.ShowDialog();
        }

        private void cmdSocioConDeuda_Click(object sender, EventArgs e)
        {
            frmListadoDeudores ListadoDeudores = new frmListadoDeudores();
            ListadoDeudores.ShowDialog();
        }
    }
}
