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
    internal class clsEntrenador
    {
        //Establezco la conexion con la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        //
        private OleDbCommand Comando = new OleDbCommand();
        //
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Establezco la ruta de la base de datos
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";
        //Por comodidad declaro una variable para que me almacene la tabla que voy a trabajar
        private string Tabla = "ENTRENADORES";
        //Declaro de manera local las variables
        private string CodigoEntrenadores;
        private string NombreEntrenadores;
        private string ApellidoEntrenadores;
        private string DireccionEntrenadores;
        private string Provincia;
        private string Deporte;

        //Despues de declarar las variables, declaro las propiedades de las mismas
        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena
        public string CEntrenador
        {
            get { return CodigoEntrenadores; }
            set { CodigoEntrenadores = value; }
        }
        public string Nombre
        {
            get { return NombreEntrenadores; }
            set { NombreEntrenadores = value; }
        }
        public string Apellido
        {
            get { return ApellidoEntrenadores; }
            set { ApellidoEntrenadores = value; }
        }
        public string Direccion
        {
            get { return DireccionEntrenadores; }
            set { DireccionEntrenadores = value; }
        }
        public string Prov
        {
            get { return Provincia; }
            set { Provincia = value; }
        }
        public string Deportes
        {
            get { return Deporte; }
            set { Deporte = value; }
        }

        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO ENTRENADORES ([CODIGO ENTRENADORES], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    "VALUES ('" + CodigoEntrenadores + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Provincia + "','" + Deporte + "')";
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

        public void Listar(DataGridView DGVConsultaEntrenadores)
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
            DGVConsultaEntrenadores.DataSource = DataConsulta.Tables[0];
            Conexion.Close();
        }

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
                            CodigoEntrenadores = Lector.GetString(0);
                            NombreEntrenadores = Lector.GetString(1);
                            ApellidoEntrenadores = Lector.GetString(2);
                            DireccionEntrenadores = Lector.GetString(3);
                            Provincia = Lector.GetString(4);
                            Deporte = Lector.GetString(5);
                        }
                    }
                }
                Conexion.Close();
                MessageBox.Show("Datos encontrados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no se encontraron");
            }
        }

        public void Modificar(string CEntrenador)
        {
            try
            {
                string Sql = "UPDATE ENTRENADORES SET NOMBRE= '" + Nombre + "',APELLIDO= '" + Apellido + "',DIRECCION= '" + Direccion + "', PROVINCIA='" + Prov + "',DEPORTE='" + Deporte + "' WHERE [CODIGO ENTRENADORES] = '" + CEntrenador + "'";
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

        public void Eliminar(string CodigoEntrenadores)
        {
            try
            {
                string Sql = "DELETE FROM ENTRENADORES WHERE ('" + CodigoEntrenadores + "'= [CODIGO ENTRENADORES])";
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
