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
    public partial class frmModificarSocio : Form
    {
        public frmModificarSocio()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void frmModificarSocio_Load(object sender, EventArgs e)
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento BUSCAR
            //traera la informacion que tengo cargadas en las
            //variables de la clase y posteriormente las mostrara
            Int32 DNI = Convert.ToInt32(txtDni.Text);
            clsSocios Buscar = new clsSocios();
            Buscar.Buscar(DNI);

            if (Buscar.DNI != DNI)
            {
                MessageBox.Show("El socio no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = Buscar.NOMBRE;
                txtApellido.Text = Buscar.APELLIDO;
                lstSexo.SelectedItem = Buscar.SEXO;
                mskFecha.Text = Convert.ToString(Buscar.FECHANACIMIENTO);
                txtDomicilio.Text = Buscar.DOMICILIO;
                mskTelefono.Text = Convert.ToString(Buscar.TELEFONO);
                lstActividad.SelectedValue = Buscar.ACTIVIDADES;
                lstBarrio.SelectedValue = Buscar.BARRIO;
                txtEmail.Text = Buscar.CORREO;
                txtSaldo.Text = Convert.ToString(Buscar.SALDO);
                Check();
            }
        }

        //==============================================================================================================

        private void cmdGuardar_Click(object sender, EventArgs e)
        {          
            //Llamo a la clase y al procedimiento MODIFICAR
            //y la informacion con la que se llenen los campos
            //los datos cargados se almacenaran en la variable local
            //de la clase y posteriormente lo almacenara.
            Int32 DNI = Convert.ToInt32(txtDni.Text);
            clsSocios Modificar = new clsSocios();
            Modificar.NOMBRE = txtNombre.Text;
            Modificar.APELLIDO = txtApellido.Text;
            Modificar.FECHANACIMIENTO = Convert.ToString(mskFecha.Text);
            Modificar.SEXO = Convert.ToString(lstSexo.SelectedItem);
            Modificar.TELEFONO = Convert.ToInt32(mskTelefono.Text);
            Modificar.DOMICILIO = txtDomicilio.Text;
            Modificar.BARRIO = Convert.ToInt32(lstBarrio.SelectedValue);
            Modificar.ACTIVIDADES = Convert.ToInt32(lstActividad.SelectedValue);
            Modificar.SALDO = Convert.ToInt32(txtSaldo.Text);
            Modificar.CORREO = Convert.ToString(txtEmail.Text);
            Modificar.Modificar(DNI);

            Limpiar();

        }

        //==============================================================================================================

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mskFecha.Text = "";
            lstSexo.SelectedIndex = -1;
            mskTelefono.Text = "";
            txtDomicilio.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";
            txtEmail.Text = "";
        }

        //==============================================================================================================

        private void Check()
        {
            if (txtNombre.Text != "" & txtApellido.Text != "" & lstSexo.SelectedIndex > -1 & mskTelefono.Text != "" & txtDomicilio.Text != "" & lstBarrio.SelectedIndex > -1 & lstActividad.SelectedIndex > -1 & txtSaldo.Text != "" & txtEmail.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }
        //==============================================================================================================

        private void HabilitarControles()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            mskFecha.Enabled = true;
            mskTelefono.Enabled = true;
            txtDomicilio.Enabled = true;
            txtSaldo.Enabled = true;
            txtEmail.Enabled = true;
        }

        //==============================================================================================================

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                cmdBuscar.Enabled = true;
                HabilitarControles();
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        //==============================================================================================================

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
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
