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
    public partial class frmNuevoBarrio : Form
    {
        public frmNuevoBarrio()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string NOMBREBARRIO = txtNombreBarrio.Text;
            clsBarrio Buscar = new clsBarrio();
            Buscar.Buscar(NOMBREBARRIO);
            if (Buscar.NOMBREBARRIO == NOMBREBARRIO)
            {
                MessageBox.Show("El barrio ya se encuentra en la base de datos");
            }
            else
            {
                clsBarrio Registro = new clsBarrio();
                Registro.NOMBREBARRIO = txtNombreBarrio.Text;

                Registro.Agregar();

                Limpiar();
            }
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        private void txtNombreBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtNombreBarrio.Text = "";
        }

        //==============================================================================================================

        private void Check()
        {
            if (txtNombreBarrio.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtNombreBarrio_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
