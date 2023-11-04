using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Threading;

namespace pryRodriguezSportsCenterIEFI
{
    internal class clsBarrio
    {
        private OleDbConnection Conexion = new OleDbConnection(); //Creo la conexion de la BD
        private OleDbCommand Comando = new OleDbCommand(); //Creo el comando de la BD
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter(); //Creo un adaptador 
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "SportsCenter.accdb"; //Establezco la ruta de la base de datos
        private string TablaB = "Barrio"; //Por comodidad declaro una variable para cada tabla que voy a trabajar

        //==============================================================================================================

        //Declaro de manera local las variables

        private Int32 CodigoBarrio;
        private string NombreBarrio;

        //==============================================================================================================

        //Despues de declarar las variables, declaro las propiedades de las mismas
        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena

        public string NOMBREBARRIO
        {
            get { return NombreBarrio; }
            set { NombreBarrio = value; }
        }

        public Int32 CODIGOBARRIO
        {
            get { return CodigoBarrio; }
            set { CodigoBarrio = value; }
        }

        //==============================================================================================================

        public void Agregar()
        {
            try
            {
                //Creo la variable SQL para almacenar el procedimiento de carga de datos en la BD
                string Sql = "INSERT INTO Barrio ([NOMBRE BARRIO])" + "VALUES ('" + NOMBREBARRIO + "')";
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.Text; //Trae el texto de la BD
                Comando.CommandText = Sql; //Toma la variable sql antes declarada
                Comando.ExecuteNonQuery(); //Escribe o almacena los datos en la tabla
                Conexion.Close(); //Cierra la conexion
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        public void Buscar(string NOMBREBARRIO)
        {
            try
            {
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaB; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD

                if (Lector.HasRows) //Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(1) == NOMBREBARRIO)
                        {
                            CodigoBarrio = Lector.GetInt32(0);
                            NombreBarrio = Lector.GetString(1);
                        }
                    }
                }
                Conexion.Close(); //Cierra la conexion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Con este procedimiento, voy a cargar la lista desplegable
        //con los detalles de la tabla 
        public void ListarBarrios(ComboBox Combo)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaB; //Selecciona la tabla
                Adaptador = new OleDbDataAdapter(Comando); //
                DataSet ds = new DataSet(); // 
                Adaptador.Fill(ds, TablaB); //
                Combo.DataSource = ds.Tables[TablaB]; //
                Combo.DisplayMember = "NOMBRE BARRIO";
                Combo.ValueMember = "CODIGO BARRIO";
                Conexion.Close(); //Cierra la conexion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        public string BuscarCodigo(Int32 CodigoBarrio)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaB; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD
                string Barrio = "";
                if (Lector.HasRows) //Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoBarrio)
                        {
                            Barrio = Lector.GetString(1);
                        }
                    }
                }
                Conexion.Close(); //Cierra la conexion
                return Barrio;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
