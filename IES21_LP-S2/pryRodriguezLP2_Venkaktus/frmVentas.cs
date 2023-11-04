using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezTPVenkaktusV1
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        //Creamos un char para separar los caracteres
        public char separador = Convert.ToChar(",");

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            this.Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //Creo un streamReader para que lea el archivo
            StreamReader srClientes = new StreamReader("./Clientes.txt");

            while (!srClientes.EndOfStream)
            {
                //Almacena todo en un vector y lo carga en la lista desplegable
                string[] Clientes = srClientes.ReadLine().Split(separador);
                lstIDCliente.Items.Add(Clientes[0]);
            }

            //Cierra el archivo Clientes.txt
            srClientes.Close();

            //Creo un streamReader para que lea el archivo
            StreamReader srVendedores = new StreamReader("./Vendedores.txt");

            while (!srVendedores.EndOfStream)
            {
                //Almacena todo en un vector y lo carga en la lista desplegable
                string[] Vendedores = srVendedores.ReadLine().Split(separador);
                lstIDVendedor.Items.Add(Vendedores[0]);
            }

            //Cierra el archivo Vendedores.txt
            srVendedores.Close();


        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string Factura = lstTipo.Text;
            string IDCliente = lstIDCliente.Text;
            string IDVendedor = lstIDVendedor.Text;
            string Numero = mskNumero.Text;
            DateTime Fecha = dtpFecha.Value.Date;
            string Monto = mskMonto.Text;

            //Creo la variable MENSAJE para poder escribir en el archivo de una forma mas "Limpia"
            string Mensaje;
            Mensaje = Factura + "," + Numero + "," + Fecha + "," + IDCliente + "," + IDVendedor + "," + Monto;

            //Con la funcion StreamWriter creamos el archivo en caso de que no este creado
            StreamWriter swVentas = new StreamWriter("./Ventas.txt", true);

            //Hace que cuando se carge el archivo escriba la variable MENSAJE junto a los elementos que se puse
            swVentas.WriteLine(Mensaje);

            //Cierra el archivo Ventas.txt
            swVentas.Close();

            MessageBox.Show("Datos cargados con exito");

            //Deja las listas desplegables sin algun elemento seleccionado luego de la carga
            lstIDCliente.SelectedIndex = -1;
            lstIDVendedor.SelectedIndex = -1;
            lstTipo.SelectedIndex = -1;
            mskNumero.Text = "";
            mskMonto.Text = "";
        }
    }
}
