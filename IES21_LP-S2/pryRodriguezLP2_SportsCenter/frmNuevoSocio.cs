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
    public partial class frmNuevoSocio : Form
    {
        public frmNuevoSocio()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void frmNuevoSocio_Load(object sender, EventArgs e)
        {
            clsActividad Actividades = new clsActividad();
            Actividades.ListarActividades(lstActividad);
            clsBarrio Barrios = new clsBarrio();
            Barrios.ListarBarrios(lstBarrio);

            lstActividad.SelectedIndex = -1;
            lstBarrio.SelectedIndex = -1;
            lstSexo.SelectedIndex = -1;
        }

        //==============================================================================================================

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Int32 DNI = Convert.ToInt32(mskDni.Text);
            clsSocios Buscar = new clsSocios();
            Buscar.Buscar(DNI);
            if (Buscar.DNI == DNI)
            {
                MessageBox.Show("El socio ya se encuentra en la base de datos, por favor corrobora el DNI");
                mskDni.Focus();
            }
            else
            {
                clsSocios Registro = new clsSocios();
                Registro.NOMBRE = txtNombre.Text;
                Registro.APELLIDO = txtApellido.Text;
                Registro.DNI = Convert.ToInt32(mskDni.Text);
                Registro.FECHANACIMIENTO = Convert.ToString(mskFecha.Text);
                Registro.SEXO = Convert.ToString(lstSexo.SelectedItem);
                Registro.TELEFONO = Convert.ToInt32(mskTelefono.Text);
                Registro.DOMICILIO = txtDomicilio.Text;
                Registro.BARRIO = Convert.ToInt32(lstBarrio.SelectedValue);
                Registro.ACTIVIDADES = Convert.ToInt32(lstActividad.SelectedValue);
                Registro.SALDO = Convert.ToInt32(txtSaldo.Text);
                Registro.CORREO = Convert.ToString(txtEmail.Text);
                Registro.Agregar();

                Limpiar();
            }
        }

        //==============================================================================================================

        private void cmdAgregarBarrio_Click(object sender, EventArgs e)
        {
            frmNuevoBarrio NuevoBarrio = new frmNuevoBarrio();
            NuevoBarrio.ShowDialog();
        }

        //==============================================================================================================

        private void cmdAgregarActividad_Click(object sender, EventArgs e)
        {
            frmNuevaActividad NuevaActividad = new frmNuevaActividad();
            NuevaActividad.ShowDialog();
        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        //Limpia los comandos

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mskDni.Text = "";
            lstSexo.SelectedIndex = -1;
            mskTelefono.Text = "";
            txtDomicilio.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";
            txtEmail.Text = "";
        }

        //==============================================================================================================

        //Habilita o deshabilita el boton dependiendo el contenido de los comandos

        private void Check()
        {
            if (txtNombre.Text != "" & txtApellido.Text != "" & mskDni.Text != "" & lstSexo.SelectedIndex >= 0 & mskTelefono.Text != "" & txtDomicilio.Text != "" & lstBarrio.SelectedIndex >= 0 & lstActividad.SelectedIndex >= 0 & txtSaldo.Text != "" & txtEmail.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        //==============================================================================================================

        //Solamente permite el ingreso de letras y permite utilizar el espacio

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //==============================================================================================================

        //Verifica el contenido de los comandos para habilitar el boton

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskDni_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void mskFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void lstSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {           
            Check();
        }
    }
}
