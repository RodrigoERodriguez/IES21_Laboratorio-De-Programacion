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
    public partial class frmAccesoActividades : Form
    {
        public frmAccesoActividades()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        void abrirFormulario(Form form) //Con este procedimiento llamara un formulario al panel central
        {
            //Va a borrar lo que este en el panel central
            //permitiendo asi que se abra otro formulario mas
            while (PCentral.Controls.Count > 0)
            {
                PCentral.Controls.RemoveAt(index: 0);
            }
            Form formhijo = form;
            formhijo.TopLevel = false; //TopLevel es una propiedad nativa de los formularios
                                       //La cual deshabilitaremos
            formhijo.FormBorderStyle = FormBorderStyle.None; //Con esto saco el borde del formulario que llamo
            formhijo.Dock = DockStyle.Fill; //Ocupa todo el lugar del panel central

            PCentral.Controls.Add(formhijo);
            formhijo.Show();
        }

        //==============================================================================================================

        private void cmdListadoPorActividad_Click(object sender, EventArgs e)
        {
            frmListadoPorActividades ListadoActividades = new frmListadoPorActividades();
            ListadoActividades.ShowDialog();
        }

        //==============================================================================================================

        private void cmdModificarActividad_Click(object sender, EventArgs e)
        {
            frmModificarActividad ModificarActividad = new frmModificarActividad();
            ModificarActividad.ShowDialog();
        }
    }
}
