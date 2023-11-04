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
using System.Threading;

namespace pryRodriguezSportsCenterIEFI
{
    internal class clsActividad
    {
        private OleDbConnection Conexion = new OleDbConnection(); //Creo la conexion de la BD
        private OleDbCommand Comando = new OleDbCommand(); //Creo el comando de la BD
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter(); //Creo un adaptador 
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "SportsCenter.accdb"; //Establezco la ruta de la base de datos
        private string TablaA = "Actividad";

        //==============================================================================================================

        //Declaro de manera local las variables

        private string NombreProfesor;
        private string Actividad;
        private Int32 Valor;
        private Int32 Telefono;
        private string Email;

        //==============================================================================================================

        //Despues de declarar las variables, declaro las propiedades de las mismas
        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena

        public string NOMBREPROFESOR
        {
            get { return NombreProfesor; }
            set { NombreProfesor = value; }
        }

        public string ACTIVIDAD
        {
            get { return Actividad; }
            set { Actividad = value; }
        }

        public Int32 VALOR
        {
            get { return Valor; }
            set { Valor = value; }
        }

        public Int32 TELEFONO
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }

        //==============================================================================================================

        public void Agregar()
        {
            try
            {
                //Creo la variable SQL para almacenar el procedimiento de carga de datos en la BD
                string Sql = "INSERT INTO Actividad ([NOMBRE PROFESOR], [ACTIVIDAD], [VALOR], [TELEFONO], [EMAIL])" + "VALUES ('" + NOMBREPROFESOR + "','" + ACTIVIDAD + "','" + VALOR + "','" + TELEFONO + "','" + EMAIL + "')";
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

        //Preguntar que pasa que no modifica
        //Modifica los datos del socio
        public void Modificar(string ACTIVIDAD)
        {
            try
            {
                //Creo la variable SQL para almacenar el procedimiento de modificacion de datos en la BD
                string Sql = "UPDATE Gimnasio SET [NOMBRE PROFESOR]= '" + NOMBREPROFESOR + "', [VALOR]=" + VALOR + ", [TELEFONO]=" + TELEFONO + ", [EMAIL]='" + Email + "' WHERE [ACTIVIDAD] =" + ACTIVIDAD + "";
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.Text; //Trae el texto de la BD
                Comando.CommandText = Sql; //Toma la variable sql antes declarada
                Comando.ExecuteNonQuery(); //Escribe o almacena los datos en la tabla
                Conexion.Close(); //Cierra la conexion
                MessageBox.Show("Los datos se modificaron con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        public void Buscar(string NOMBREACTIVIDAD)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaA; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD

                if (Lector.HasRows)//Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(2) == NOMBREACTIVIDAD)
                        {
                            NombreProfesor = Lector.GetString(1);
                            Actividad = Lector.GetString(2);
                            Valor = Lector.GetInt32(3);
                            Telefono = Lector.GetInt32(4);
                            Email = Lector.GetString(5);
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
        public void ListarActividades(ComboBox Combo)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaA; //Selecciona la tabla
                Adaptador = new OleDbDataAdapter(Comando); //
                DataSet ds = new DataSet(); //
                Adaptador.Fill(ds, TablaA); //Trare los datos con el adaptador y los llena con el dataset
                Combo.DataSource = ds.Tables[TablaA]; //El combobox toma los valores de la tabla
                Combo.DisplayMember = "ACTIVIDAD"; //Lo que quiero que me muestre
                Combo.ValueMember = "CODIGO ACTIVIDAD"; //El valor que toma
                Conexion.Close(); //Cierra la conexion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Funcion de busqueda secuencial
        public string BuscarActividad(Int32 CodigoActividad)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaA; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD
                string Actividad = "";

                if (Lector.HasRows) //Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoActividad)
                        {
                            Actividad = Lector.GetString(2);
                        }
                    }
                }
                Conexion.Close(); //Cierra la conexion
                return Actividad;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
