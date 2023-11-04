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
    public partial class frmBuscarSocio : Form
    {
        public frmBuscarSocio()
        {
            InitializeComponent();
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
                MessageBox.Show("El cliente no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = Buscar.NOMBRE;
                txtApellido.Text = Buscar.APELLIDO;
                txtSexo.Text = Buscar.SEXO;
                txtFechaDeNacimiento.Text = Convert.ToString(Buscar.FECHANACIMIENTO);
                txtDomicilio.Text = Buscar.DOMICILIO;
                txtTelefono.Text = Convert.ToString(Buscar.TELEFONO);
                clsActividad Actividades = new clsActividad();
                txtActividad.Text = Actividades.BuscarActividad(Buscar.ACTIVIDADES);
                clsBarrio Barrios = new clsBarrio();
                txtBarrio.Text = Barrios.BuscarCodigo(Buscar.BARRIO);
                txtEmail.Text = Buscar.CORREO;
                txtSaldo.Text = Convert.ToString(Buscar.SALDO);
            }
            if (Buscar.SALDO > 0)
            {
                lblEstadoCliente.Text = "DEUDOR";
                lblEstadoCliente.BackColor = Color.Red;
            }
            else
            {
                lblEstadoCliente.Text = "ACTIVO";
                lblEstadoCliente.BackColor = Color.Green;
            }
        }

        //==============================================================================================================

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente");
            Check();
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
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            txtFechaDeNacimiento.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            txtBarrio.Text = "";
            txtActividad.Text = "";
            txtSaldo.Text = "";
            txtEmail.Text = "";
        }

        //==============================================================================================================

        private void Check()
        {
            if (txtNombre.Text != "" & txtApellido.Text != "" & txtDni.Text != "" & txtSexo.Text != "" & txtFechaDeNacimiento.Text != "" & txtDomicilio.Text != "" & txtTelefono.Text != "" & txtBarrio.Text != "" & txtActividad.Text != "" & txtSaldo.Text != "" & txtEmail.Text != "")
            {
                cmdImprimir.Enabled = true;
            }
            else
            {
                cmdImprimir.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                cmdBuscar.Enabled = true;
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

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtFechaDeNacimiento_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtBarrio_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
