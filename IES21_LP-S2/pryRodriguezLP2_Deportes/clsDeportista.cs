using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezBaseDeDatosDeportesV2
{
    internal class clsDeportista
    {
        //Establezco la conexion con la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        //Establezco el comando de la base de datos
        private OleDbCommand Comando = new OleDbCommand();
        //
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Establezco la ruta de la base de datos
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";
        //Por comodidad declaro una variable para que me almacene la tabla que voy a trabajar
        private string Tabla = "DEPORTISTA";

        //Declaro de manera local las variables
        private string CodigoDeportista;
        private string NombreDeportista;
        private string ApellidoDeportista;
        private string DireccionDeportista;
        private Int32 TelefonoDeportista;
        private Int32 EdadDeportista;
        private string Deporte;

        //Despues de declarar las variables, declaro las propiedades de las mismas
        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena
        public string CDeportista
        {
            get { return CodigoDeportista; }
            set { CodigoDeportista = value; }
        }

        public string Nombre
        {
            get { return NombreDeportista; }
            set { NombreDeportista = value; }
        }

        public string Apellido
        {
            get { return ApellidoDeportista; }
            set { ApellidoDeportista = value; }
        }

        public string Direccion
        {
            get { return DireccionDeportista; }
            set { DireccionDeportista = value; }
        }

        public Int32 Telefono
        {
            get { return TelefonoDeportista; }
            set { TelefonoDeportista = value; }
        }

        public Int32 Edad
        {
            get { return EdadDeportista; }
            set { EdadDeportista = value; }
        }

        public string Deportes
        {
            get { return Deporte; }
            set { Deporte = value; }
        }
        //Con este procedimiento, voy a agregar todos los datos del deportista
        //en la tabla
        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron registrarse");
            }
        }
        //Con este procedimiento, voy a listar todos los datos del deportista
        //en la tabla para luego mostrarlos
        public void Listar(DataGridView DGVConsultaDeportista)
        {
            //Conecto la base de datos
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            //El comando toma la conexion
            Comando.Connection = Conexion;
            //Este comando me trae la tabla del access
            Comando.CommandType = CommandType.TableDirect;
            //Selecciona la tabla
            Comando.CommandText = Tabla;
            Adaptador = new OleDbDataAdapter(Comando);
            //Almacena todo en una "tabla"
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            //Mostraria todo en la grilla
            //La propiedad DataSource toma todo el contenido de un DataSet
            DGVConsultaDeportista.DataSource = DataConsulta.Tables[0];

            Conexion.Close();
        }
        //Con este procedimiento, voy a buscar todos los datos del deportista
        //en la tabla para luego mostrarlos
        public void Buscar(string Codigo)
        {
            try
            {
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                Comando.CommandText = Tabla;
                //Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay registros ingresa
                if (Lector.HasRows)
                {
                    //Mientras tenga datos en la tabla, esto lo va a leer
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == Codigo)
                        {
                            CodigoDeportista = Lector.GetString(0);
                            NombreDeportista = Lector.GetString(1);
                            ApellidoDeportista = Lector.GetString(2);
                            DireccionDeportista = Lector.GetString(3);
                            TelefonoDeportista = int.Parse(Lector.GetString(4));
                            EdadDeportista = Lector.GetInt32(5);
                            Deporte = Lector.GetString(6);
                        }
                    }
                }
                Conexion.Close();
                MessageBox.Show("Datos encontrados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
        }
        //Con este procedimiento, voy a modificar todos los datos del deportista
        //de la tabla
        public void Modificar(string CDeportista)
        {
            try
            {
                string Sql = "UPDATE DEPORTISTA SET NOMBRE= '" + Nombre + "',APELLIDO= '" + Apellido + "',DIRECCION= '" + Direccion + "', TELEFONO=" + Telefono + ", EDAD=" + Edad + ", DEPORTE='" + Deportes + "' WHERE [CODIGO DEPORTISTA] = '" + CDeportista + "'";
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Los datos se modificaron con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron modificarse");
            }
        }
        //Con este procedimiento, voy a eliminar todos los datos del deportista
        //de la tabla
        public void Eliminar(string CodigoDeportista)
        {
            try
            {
                string Sql = "DELETE FROM DEPORTISTA WHERE ('" + CodigoDeportista + "'= [CODIGO DEPORTISTA])";
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Datos borrados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron borrarse");
            }
        }
    }
}
