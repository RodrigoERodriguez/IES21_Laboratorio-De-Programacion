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
    public partial class frmReportePorActividad : Form
    {
        public frmReportePorActividad()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdListar_Click(object sender, EventArgs e)
        {

        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        private void cmdImprimirReporte_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente");
        }

        //==============================================================================================================

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            clsSocios Generar = new clsSocios();
            Generar.ReporteActividad();
            MessageBox.Show("Reporte generado exitosamente");
        }

        //==============================================================================================================

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocios Imprimir = new clsSocios();
            Imprimir.ImprimirReporteActividad(e);
        }

        private void cmdListar2_Click(object sender, EventArgs e)
        {
            Int32 CodigoActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsSocios Listar = new clsSocios();
            Listar.ListadoReporteActividad(dgvReporteActividad, CodigoActividad);
        }

        private void frmReportePorActividad_Load(object sender, EventArgs e)
        {
            clsActividad Actividades = new clsActividad();
            Actividades.ListarActividades(lstActividad);
            lstActividad.SelectedIndex = -1;
        }
    }
}
