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
    public partial class frmInicioSistema : Form
    {
        public frmInicioSistema()
        {
            InitializeComponent();
            PersonalizarBotones();
        }

        //==============================================================================================================

        private void PersonalizarBotones()
        {
            PSubMenuSocios.Visible = false;
            PSubMenuActividades.Visible = false;
            PSubMenuBarrio.Visible = false;
            PSubMenuAdministracion.Visible = false;
            PSubMenuMas.Visible = false;
        }

        //==============================================================================================================

        private void EsconderSubMenu() //Con este procedimiento ocultara los SubMenus
        {
            //En caso de que este visible, cambiaremos
            //la propiedad a falso
            if (PSubMenuSocios.Visible == true)
            {
                PSubMenuSocios.Visible = false;
            }

            if (PSubMenuActividades.Visible == true)
            {
                PSubMenuActividades.Visible = false;
            }

            if (PSubMenuBarrio.Visible == true)
            {
                PSubMenuBarrio.Visible = false;
            }

            if (PSubMenuAdministracion.Visible == true)
            {
                PSubMenuAdministracion.Visible = false;
            }

            if (PSubMenuMas.Visible == true)
            {
                PSubMenuMas.Visible = false;
            }
        }

        //==============================================================================================================

        private void MostrarSubMenu(Panel SubMenu) //Alternara la visibilidad del submenu
        {
            if (SubMenu.Visible == false)
            {
                EsconderSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
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

        private void cmdSocios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuSocios);
        }

        private void cmdAccesoASocios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAccesoSocios());
            EsconderSubMenu();
        }

        private void cmdActividades_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuActividades);
        }

        private void cmdAccesoActividades_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAccesoActividades());
            EsconderSubMenu();
        }

        private void cmdBarrio_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuBarrio);
        }

        private void cmdAccesoBarrios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAccesoBarrios());
            EsconderSubMenu();
        }

        private void cmdAdministracion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuAdministracion);
        }

        private void cmdReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmReportes());
            EsconderSubMenu();
        }

        private void cmdMas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuMas);
        }

        private void cmdAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAcercaDe());
            EsconderSubMenu();
        }

        private void cmdSistema_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmSistema());
            EsconderSubMenu();
        }
    }
}
