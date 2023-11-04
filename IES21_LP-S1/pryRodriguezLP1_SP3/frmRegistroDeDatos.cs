using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezRodrigoSP3
{
    public partial class frmRegistroDeRepuesto : Form
    {
        public frmRegistroDeRepuesto()
        {
            InitializeComponent();
        }

        //Creamos la estructura "DATOS" para ingresar los datos
        public struct Datos
        {
            public string Marca;
            public string Origen;
            public string Descripcion;
            public float Precio;
            public int Codigo;
        }

        //Se crea el vector llamado "REPUESTO"
        Datos[] Repuesto = new Datos[100];

        //Declaro el indice del vector
        Int32 IND = 0;

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            //Limpiamos los comandos en caso de error o no querer cargar
            mskCodigo.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            lstDatos.SelectedIndex = -1;
            //Consultar Profe, pedir ayuda
            optImportadoDatos.Checked = false;
            optNacionalConsulta.Checked = false;
        }

        private void frmRegistroDeRepuesto_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
           
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (IND == Repuesto.Length)
            {
                MessageBox.Show("No es posible seguir cargando datos");
            }
            else
            {
                //Boolean es una variable que funciona para chekear
                //si la situacion que seleccione pasara

                Boolean Check = true;
                for (int i = 0; i < Repuesto.Length; i++)
                {
                    if (Repuesto[i].Codigo == Convert.ToInt32(mskCodigo.Text))
                    {
                        Check = false;
                        MessageBox.Show("Codigo ya existente");

                        //Se limpian los comandos
                        txtPrecio.Text = "";
                        mskCodigo.Text = "";
                        txtDescripcion.Text = "";
                        lstDatos.SelectedIndex = -1;
                        optImportadoDatos.Checked = false;
                        optNacionalConsulta.Checked = true;
                    }
                }
                if (Check)
                {
                    //Cargo el origen al vector segun lo que seleccione en los radio buttons
                    string Origen;

                    if (optNacionalConsulta.Checked == true)
                    {
                        Origen = "Nacional";
                    }
                    else
                    {
                        Origen = "Importado";
                    }
                    Repuesto[IND].Codigo = Convert.ToInt32(mskCodigo.Text);
                    Repuesto[IND].Marca = lstDatos.SelectedItem.ToString();
                    Repuesto[IND].Precio = float.Parse(txtPrecio.Text);
                    Repuesto[IND].Descripcion = txtDescripcion.Text;
                    Repuesto[IND].Origen = Origen;
                    IND = IND + 1;
                }
            }
            MessageBox.Show("Se cargo correctamente");

            //Se limpian los comandos
            txtPrecio.Text = "";
            mskCodigo.Text = "";
            txtDescripcion.Text = "";
            lstDatos.SelectedIndex = -1;
            optImportadoDatos.Checked = false;
            optNacionalConsulta.Checked = true;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            dvgConsulta.Rows.Clear();
            //Creo un indice nuevo para que recorra el vector
            Int32 i = 0;
            //Mientras el indice "i" sea menor al indice "IND"
            //Genera un bucle las veces necesarias para poder cargar los datos con exito
            //En la grilla
            while (i<IND)
            {
                //Si este boton esta seleccionado, solamente muestra los repuestos de cada marca
                //y con el origen que corresponda
                if (optImportadoConsulta.Checked == true)
                {
                    //Carga los datos en la grilla
                    if (Repuesto[i].Marca == lstConsulta.Text && Repuesto[i].Origen == "Importado")
                    {
                        dvgConsulta.Rows.Add(Repuesto[i].Marca ,Repuesto[i].Codigo, Repuesto[i].Origen, Repuesto[i].Precio ,Repuesto[i].Descripcion);

                    }
                }
                else
                {
                    //Carga los datos en la grilla
                    if (Repuesto[i].Marca == lstConsulta.Text && Repuesto[i].Origen == "Nacional")
                    {
                        dvgConsulta.Rows.Add(Repuesto[i].Marca, Repuesto[i].Codigo, Repuesto[i].Origen, Repuesto[i].Precio, Repuesto[i].Descripcion);

                    }
                }

                i++;
            }
                
        }

        private void mskCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
               
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '0' && e.KeyChar < '9' || e.KeyChar == ((char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mskCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '0' && e.KeyChar < '9' || e.KeyChar == ((char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
