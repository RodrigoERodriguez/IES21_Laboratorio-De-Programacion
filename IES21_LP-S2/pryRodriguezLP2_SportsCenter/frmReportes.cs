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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdReportePorBarrio_Click(object sender, EventArgs e)
        {
            frmReportePorBarrio ReporteBarrio = new frmReportePorBarrio();
            ReporteBarrio.ShowDialog();
        }

        //==============================================================================================================

        private void cmdReportePorActividad_Click(object sender, EventArgs e)
        {
            frmReportePorActividad ReporteActividad = new frmReportePorActividad();
            ReporteActividad.ShowDialog();
        }

        //==============================================================================================================

        private void cmdReportePorGanancias_Click(object sender, EventArgs e)
        {
            frmReportePorGanancias ReporteGanancias = new frmReportePorGanancias();
            ReporteGanancias.ShowDialog();
        }
    }
}
