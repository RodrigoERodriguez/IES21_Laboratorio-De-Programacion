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
    public partial class frmReportePorGanancias : Form
    {
        public frmReportePorGanancias()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsSocios Listar = new clsSocios();
            Listar.ListadoReporteGanancias(dgvReporteGanancias);
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
            Generar.ReporteGanancias();
            MessageBox.Show("Reporte generado exitosamente");
        }

        //==============================================================================================================

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocios Imprimir = new clsSocios();
            Imprimir.ImprimirReporteGanancias(e);
        }

        //==============================================================================================================

        private void frmReportePorGanancias_Load(object sender, EventArgs e)
        {

        }
    }
}
