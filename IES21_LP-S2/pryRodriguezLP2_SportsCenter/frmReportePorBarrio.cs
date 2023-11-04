﻿using System;
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
    public partial class frmReportePorBarrio : Form
    {
        public frmReportePorBarrio()
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
            Generar.ReporteBarrio();
        }

        //==============================================================================================================

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocios Imprimir = new clsSocios();
            Imprimir.ImprimirReporteBarrio(e);
        }

        private void cmdListar2_Click(object sender, EventArgs e)
        {
            Int32 CodigoBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            clsSocios Listar = new clsSocios();
            Listar.ListadoReporteBarrio(dgvReporteBarrio, CodigoBarrio);
        }

        private void frmReportePorBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio Barrios = new clsBarrio();
            Barrios.ListarBarrios(lstBarrio);
            lstBarrio.SelectedIndex = -1;
        }
    }
}
