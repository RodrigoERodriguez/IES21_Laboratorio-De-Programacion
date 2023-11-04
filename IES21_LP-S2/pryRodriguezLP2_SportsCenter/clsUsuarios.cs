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
    internal class clsUsuarios
    {
        private OleDbConnection Conexion = new OleDbConnection(); //Creo la conexion de la BD
        private OleDbCommand Comando = new OleDbCommand(); //Creo el comando de la BD
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter(); //Creo un adaptador 
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "SportsCenter.accdb"; //Establezco la ruta de la base de datos
        private string TablaU = "Usuarios"; //Por comodidad declaro una variable para cada tabla que voy a trabajar

        //==============================================================================================================

        //Declaro de manera local las variables

        private string Usuario;
        private string Contraseña;

        //==============================================================================================================

        //Despues de declarar las variables, declaro las propiedades de las mismas
        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena

        public string USUARIO
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public string CONTRASEÑA
        {
            get { return Contraseña; }
            set { Contraseña = value; }
        }

        //==============================================================================================================

        //Registro de nuevo usuario

        public void NuevoUsuario()
        {
            try
            {
                //Creo la variable SQL para almacenar el procedimiento de carga de datos en la BD
                string sql = "INSERT INTO Usuarios ([NOMBRE DE USUARIO], [CONTRASEÑAS])" + "VALUES ('" + USUARIO + "','" + CONTRASEÑA + "')";
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.Text; //Trae el texto de la BD
                Comando.CommandText = sql; //Toma la variable sql antes declarada
                Comando.ExecuteNonQuery(); //Escribe o almacena los datos en la tabla
                Conexion.Close(); //Cierra la conexion
                MessageBox.Show("Usuario registrado de manera exitosa, No olvides tu usuario y contraseña!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Busqueda de datos del usuario

        public void BuscarUsuario(string NombreUsuario)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaU; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == NombreUsuario)
                        {
                            Usuario = Lector.GetString(0);
                            Contraseña = Lector.GetString(1);
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

        //Modifica los la contraseña del usuario

        public void OlvidasteTuContraseña(string Usuario)
        {
            try
            {
                ////Creo la variable SQL para almacenar el procedimiento de modificacion de datos en la BD
                string sql = "UPDATE Usuarios SET [CONTRASEÑAS] ='" + CONTRASEÑA + "' WHERE [NOMBRE DE USUARIO] = '" + Usuario + "";
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.Text; //Trae el texto de la BD
                Comando.CommandText = sql; //Toma la variable sql antes declarada
                Comando.ExecuteNonQuery(); //Modifica los campos de la tabla
                Conexion.Close(); //Cierra la conexion
                MessageBox.Show("Contraseña modificada de manera exitosa, No olvides tu usuario y contraseña!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
