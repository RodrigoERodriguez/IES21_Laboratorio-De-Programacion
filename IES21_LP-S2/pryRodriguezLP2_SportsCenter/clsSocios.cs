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

namespace pryRodriguezSportsCenterIEFI
{
    internal class clsSocios
    {
        private OleDbConnection Conexion = new OleDbConnection(); //Creo la conexion de la BD
        private OleDbCommand Comando = new OleDbCommand(); //Creo el comando de la BD
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter(); //Creo un adaptador 
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "SportsCenter.accdb"; //Establezco la ruta de la base de datos
        private string TablaG = "Gimnasio"; //Por comodidad declaro una variable para cada tabla que voy a trabajar

        //==============================================================================================================

        //Declaro de manera local las variables

        private string Nombre;
        private string Apellido;
        private Int32 Dni;
        private string FechaNacimiento;
        private string Sexo;
        private Int32 Telefono;
        private string Domicilio;
        private Int32 Barrio;
        private Int32 Actividades;
        private Int32 Saldo;
        private string Correo;
        private Int32 Clientes;
        private Int32 MontoDeuda;
        private Int32 Monto;
        private decimal Promedio;

        //==============================================================================================================

        //Despues de declarar las variables, declaro las propiedades de las mismas
        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena
        public string NOMBRE
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string APELLIDO
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public Int32 DNI
        {
            get { return Dni; }
            set { Dni = value; }
        }
        public string FECHANACIMIENTO
        {
            get { return FechaNacimiento; }
            set { FechaNacimiento = value; }
        }
        public string SEXO
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public Int32 TELEFONO
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public string DOMICILIO
        {
            get { return Domicilio; }
            set { Domicilio = value; }
        }
        public Int32 BARRIO
        {
            get { return Barrio; }
            set { Barrio = value; }
        }
        public Int32 ACTIVIDADES
        {
            get { return Actividades; }
            set { Actividades = value; }
        }
        public Int32 SALDO
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public string CORREO
        {
            get { return Correo; }
            set { Correo = value; }
        }
        public Int32 CLIENTES
        {
            get { return Clientes; }
            set { Clientes = value; }
        }
        public Int32 MONTODEUDA
        {
            get { return MontoDeuda; }
            set { MontoDeuda = value; }
        }
        public Int32 MONTO
        {
            get { return Monto; }
            set { Monto = value; }
        }

        public Decimal PROMEDIO
        {
            get { return Promedio; }
            set { Promedio = value; }
        }

        //==============================================================================================================

        //Agrega un nuevo socio

        public void Agregar()
        {
            try
            {
                //Creo la variable SQL para almacenar el procedimiento de carga de datos en la BD
                string Sql = "INSERT INTO Gimnasio ([NOMBRE], [APELLIDO], [DNI], [FECHA NACIMIENTO], [SEXO], [TELEFONO], [DOMICILIO], [BARRIO], [ACTIVIDADES], [SALDO], [CORREO])" +
                    "VALUES ('" + NOMBRE + "','" + APELLIDO + "','" + DNI + "','" + FECHANACIMIENTO + "','" + SEXO + "','" + TELEFONO + "','" + DOMICILIO + "','" + BARRIO + "','" + ACTIVIDADES + "','" + SALDO + "','" + CORREO + "')";
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

        //Busca los datos del socio

        public void Buscar(Int32 DNI)
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Trae la tabla de la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD
                if (Lector.HasRows)
                {
                    while (Lector.Read()) //Si hay registros ingresa
                    {
                        if (Lector.GetInt32(3) == DNI)
                        {
                            Nombre = Lector.GetString(1);
                            Apellido = Lector.GetString(2);
                            Dni = Lector.GetInt32(3);
                            FechaNacimiento = Lector[4].ToString();
                            Sexo = Lector.GetString(5);
                            Telefono = Lector.GetInt32(6);
                            Domicilio = Lector.GetString(7);
                            Barrio = Lector.GetInt32(8);
                            Actividades = Lector.GetInt32(9);
                            Saldo = Lector.GetInt32(10);
                            Correo = Lector.GetString(11);
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

        //Muestra los datos de los socios en la grilla

        public void Listar(DataGridView dgvListadoClientes)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD         
            dgvListadoClientes.Rows.Clear(); //Limpia la grilla

            //Llamo las clases para mostrar el nombre del barrio
            //y el detalle de la actividad
            clsActividad Actividades = new clsActividad();
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";
            string DetalleActividad = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                    DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                    dgvListadoClientes.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), Lector[4].ToString(), Lector.GetString(5), Lector.GetInt32(6), Lector.GetString(7), NombreBarrio, DetalleActividad, Lector.GetInt32(10), Lector.GetString(11));
                }
            }
        }

        //==============================================================================================================

        //Imprime los datos del socio

        public void ImprimirSocio()
        {

        }

        //==============================================================================================================

        //Modifica los datos del socio

        public void Modificar(Int32 DNI)
        {
            try
            {
                //Creo la variable SQL para almacenar el procedimiento de modificacion de datos en la BD
                string Sql = "UPDATE Gimnasio SET [NOMBRE]= '" + Nombre + "', [APELLIDO]='" + Apellido + "', [FECHA NACIMIENTO]=" + FechaNacimiento + ", [SEXO]='" + Sexo + "', [TELEFONO]=" + Telefono + ", [DOMICILIO]='" + Domicilio + "', [BARRIO]= " + Barrio + ", [ACTIVIDADES]=" + Actividades + ", [SALDO]=" + Saldo + ", [CORREO]='" + Correo + "' WHERE [DNI] =" + DNI + "" ;
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.Text; //Trae el texto de la BD
                Comando.CommandText = Sql; //Toma la variable sql antes declarada
                Comando.ExecuteNonQuery(); //Modifica los campos de la tabla
                Conexion.Close(); //Cierra la conexion
                MessageBox.Show("Los datos se modificaron con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Elimina al socio de la BD

        public void Eliminar(Int32 DNI)
        {
            try
            {
                //Creo la variable SQL para eliminar los datos en la BD
                string Sql = "DELETE FROM Gimnasio WHERE (" + DNI + "= [DNI])";
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.Text; //Trae el texto de la BD
                Comando.CommandText = Sql; //Toma la variable sql antes declarada
                Comando.ExecuteNonQuery(); //Modifica los campos de la tabla
                Conexion.Close(); //Cierra la conexion
                MessageBox.Show("Datos borrados con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Muestra los datos de los socios que poseen deuda

        public void ListarDeudores(DataGridView dgvListadoDeudores)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            //Este comando me trae la tabla del access
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD             
            dgvListadoDeudores.Rows.Clear(); //Limpia la grilla

            //Llamo las clases para mostrar el nombre del barrio
            //y el detalle de la actividad
            clsActividad Actividades = new clsActividad();
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";
            string DetalleActividad = "";
            Clientes = 0;
            Saldo = 0;

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    if (Lector.GetInt32(10) > 0)
                    {
                        //La variable toma la posicion de la tabla
                        //y devuelve el nombre del barrio o detalle de actividad
                        NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                        DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                        dgvListadoDeudores.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), Lector.GetInt32(6), Lector.GetString(7), NombreBarrio, DetalleActividad, Lector.GetInt32(10));
                        Clientes++;
                        Saldo = Saldo + Lector.GetInt32(10);
                    }
                }
            }
            //Mostrar la cantidad de socios deudores
            //junto a la deuda estimada
        }

        //==============================================================================================================

        //Lista segun la actividad seleccionada

        public void ListarPorActividades(DataGridView dgvListadoPorActividad, Int32 CodigoActividad)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD  
            dgvListadoPorActividad.Rows.Clear(); //Limpia la grilla
            Clientes = 0;
            Monto = 0;

            //Llamo las clase para mostrar el nombre del barrio
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    if (Lector.GetInt32(8) == CodigoActividad)
                    {
                        NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                        dgvListadoPorActividad.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), Lector.GetString(5), Lector.GetInt32(6), NombreBarrio);
                        Clientes++;
                    }
                }
            }
        }

        //==============================================================================================================

        //Preguntar profe que puede estar pasando
        //No muestra el nombre de la actividad
        public void ListarPorBarrio(DataGridView dgvListadoPorBarrio, Int32 CodigoBarrio)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 
            dgvListadoPorBarrio.Rows.Clear(); //Limpia la grilla
            Clientes = 0;
            Monto = 0;

            //Llamo las clase para mostrar el nombre de la actividad
            clsActividad Actividad = new clsActividad();
            string DetalleActividad = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    if (Lector.GetInt32(8) == CodigoBarrio)
                    {
                        DetalleActividad = Actividad.BuscarActividad(Lector.GetInt32(8));
                        dgvListadoPorBarrio.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), Lector.GetString(5), Lector.GetInt32(6), Lector.GetString(7), DetalleActividad);
                        Clientes++;
                    }
                }
            }
        }

        //==============================================================================================================

        //Crea un reporte en excel sobre las ganancias
        //Corregir el amontonamiento de la tabla

        public void ReporteGanancias()
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 

                //
                StreamWriter AD = new StreamWriter("ReporteSaldos.csv", false);
                AD.WriteLine("Reporte de saldos\n");
                AD.WriteLine("N Socio ; Nombre ; Apellido ; Dni ; Barrio ; Actividad ; Saldo");
                Clientes = 0;
                MontoDeuda = 0;
                Monto = 0;
                Saldo = 0;

                //
                clsActividad Actividades = new clsActividad();
                clsBarrio Barrios = new clsBarrio();
                string NombreBarrio = "";
                string DetalleActividad = "";

                if (Lector.HasRows) //Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(10) > 0)
                        {
                            NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                            DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));

                            AD.Write(Lector.GetInt32(0));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetString(1));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetString(2));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetInt32(3)); 
                            AD.Write(" ; ");
                            AD.Write(NombreBarrio);
                            AD.Write(" ; ");
                            AD.Write(DetalleActividad);
                            AD.Write(" ; ");
                            AD.Write(Lector.GetInt32(10));
                            Clientes++;
                            MontoDeuda = MontoDeuda + Lector.GetInt32(10);
                            AD.Write("\n");
                        }
                        else
                        {
                            Monto = Monto + Lector.GetInt32(10);
                        }
                        Saldo = MontoDeuda - Monto;
                    }
                    AD.Write("\n");
                    AD.Write("Cantidad de socios: ");
                    AD.WriteLine(Clientes);
                    AD.Write("Monto de deudores: ");
                    AD.WriteLine(MontoDeuda);
                    AD.Write("Monto: ");
                    AD.WriteLine(Monto);
                    AD.Write("Saldos: ");
                    AD.WriteLine(Saldo);
                }
                Conexion.Close(); //Cierra la conexion
                AD.Close(); //Cierro el agregado
                MessageBox.Show("Reporte generado de manera exitosa.");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Imprime el reporte de ganancias

        public void ImprimirReporteGanancias(PrintPageEventArgs Reporte)
        {
            try
            {
                Int32 Linea = 100;
                Font FuenteTexto = new Font("Arial", 8, FontStyle.Italic);
                Font FuenteTitulo = new Font("Arial", 20, FontStyle.Underline);
                Font FuenteSubTitulo = new Font("Arial", 12, FontStyle.Bold);

                Reporte.Graphics.DrawString("Reporte de saldos", FuenteTitulo, Brushes.CadetBlue, 50, Linea - 70);
                Reporte.Graphics.DrawString("N Socio", FuenteSubTitulo, Brushes.Blue, 50, Linea - 15);
                Reporte.Graphics.DrawString("Nombre", FuenteSubTitulo, Brushes.Blue, 150, Linea - 15);
                Reporte.Graphics.DrawString("Apellido", FuenteSubTitulo, Brushes.Blue, 250, Linea - 15);
                Reporte.Graphics.DrawString("Barrio", FuenteSubTitulo, Brushes.Blue, 350, Linea - 15);
                Reporte.Graphics.DrawString("Actividad", FuenteSubTitulo, Brushes.Blue, 450, Linea - 15);
                Reporte.Graphics.DrawString("Saldo", FuenteSubTitulo, Brushes.Blue, 550, Linea - 15);

                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                //El tipo de comando es un acceso directo a una tabla
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                Adaptador = new OleDbDataAdapter(Comando); //Ejecutamos el comando
                DataSet Data = new DataSet(); //Declaramos un DataSet
                Adaptador.Fill(Data, TablaG); //Llenamos el data set
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 

                //
                clsActividad Actividades = new clsActividad();
                clsBarrio Barrios = new clsBarrio();
                string NombreBarrio = "";
                string DetalleActividad = "";

                Clientes = 0;
                MontoDeuda = 0;
                Monto = 0;
                Saldo = 0;

                if (Data.Tables[TablaG].Rows.Count > 0) //Si tiene filas
                {
                    foreach (DataRow fila in Data.Tables[TablaG].Rows)
                    {
                        Reporte.Graphics.DrawString(fila["ID"].ToString(), FuenteTexto, Brushes.Black, 50, Linea);
                        Reporte.Graphics.DrawString(fila["NOMBRE"].ToString(), FuenteTexto, Brushes.Black, 150, Linea);
                        Reporte.Graphics.DrawString(fila["APELLIDO"].ToString(), FuenteTexto, Brushes.Black, 250, Linea);
                        Reporte.Graphics.DrawString(fila["SALDO"].ToString(), FuenteTexto, Brushes.Black, 550, Linea);
                        Linea = Linea + 15;
                    }

                    while (Lector.Read())
                    {
                        NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                        DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                        Reporte.Graphics.DrawString(NombreBarrio, FuenteTexto, Brushes.Black, 350, Linea -25);
                        Reporte.Graphics.DrawString(DetalleActividad, FuenteTexto, Brushes.Black, 450, Linea-25);

                        if (Lector.GetInt32(10) > 0)
                        {
                            Clientes++;
                            MontoDeuda = MontoDeuda + Lector.GetInt32(10);
                        }
                        else
                        {
                            Clientes++;
                            Monto = Monto + Lector.GetInt32(10);
                        }
                        Saldo = MontoDeuda - Monto;
                        Linea = Linea + 15;
                    }
                }
                Conexion.Close(); //Cierra la conexion

                string Mensaje = "Cantidad de socios:" + Clientes + " . " + "Monto de la deuda $" + MontoDeuda + " . " + "Saldo $" + Monto + " . " + "Balance de $" + Saldo + ".";
                Reporte.Graphics.DrawString(Mensaje, FuenteTexto, Brushes.Black, 50, Linea + 10);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Listado del reporte de ganancias

        public void ListadoReporteGanancias(DataGridView dgvReporteGanancias)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 
            dgvReporteGanancias.Rows.Clear(); //Limpia la grilla

            //Llamo las clases para mostrar el nombre del barrio
            //y el detalle de la actividad
            clsActividad Actividades = new clsActividad();
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";
            string DetalleActividad = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                    DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                    dgvReporteGanancias.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), NombreBarrio, DetalleActividad, Lector.GetInt32(10));
                }
            }
        }

        //==============================================================================================================

        //Crea un reporte en excel sobre las actividades

        public void ReporteActividad()
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 

                //
                StreamWriter AD = new StreamWriter("ReporteActividad.csv", false);
                AD.WriteLine("Reporte de saldos\n");
                AD.WriteLine("N Socio ; Nombre ; Apellido ; Dni ; Barrio ; Actividad ; Saldo");
                Clientes = 0;
                MontoDeuda = 0;
                Monto = 0;
                Saldo = 0;

                //
                clsActividad Actividades = new clsActividad();
                clsBarrio Barrios = new clsBarrio();
                string NombreBarrio = "";
                string DetalleActividad = "";

                if (Lector.HasRows) //Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(10) > 0)
                        {
                            NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                            DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));

                            AD.Write(Lector.GetInt32(0));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetString(1));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetString(2));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetInt32(3));
                            AD.Write(" ; ");
                            AD.Write(NombreBarrio);
                            AD.Write(" ; ");
                            AD.Write(DetalleActividad);
                            AD.Write(" ; ");
                            AD.Write(Lector.GetInt32(10));
                            Clientes++;
                            MontoDeuda = MontoDeuda + Lector.GetInt32(10);
                            AD.Write("\n");
                        }
                        else
                        {
                            Monto = Monto + Lector.GetInt32(10);
                        }
                        Saldo = MontoDeuda - Monto;
                    }
                    AD.Write("\n");
                    AD.Write("Cantidad de socios: ");
                    AD.WriteLine(Clientes);
                    AD.Write("Monto de deudores: ");
                    AD.WriteLine(MontoDeuda);
                    AD.Write("Monto: ");
                    AD.WriteLine(Monto);
                    AD.Write("Saldos: ");
                    AD.WriteLine(Saldo);
                }
                Conexion.Close(); //Cierra la conexion
                AD.Close(); //Cierro el agregado
                MessageBox.Show("Reporte generado de manera exitosa.");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Imprime el reporte por actividades

        public void ImprimirReporteActividad(PrintPageEventArgs Reporte)
        {
            try
            {
                Int32 Linea = 100;
                Font FuenteTexto = new Font("Arial", 8, FontStyle.Italic);
                Font FuenteTitulo = new Font("Arial", 20, FontStyle.Underline);
                Font FuenteSubTitulo = new Font("Arial", 12, FontStyle.Bold);

                Reporte.Graphics.DrawString("Reporte de actividades", FuenteTitulo, Brushes.CadetBlue, 50, Linea - 70);
                Reporte.Graphics.DrawString("N Socio", FuenteSubTitulo, Brushes.Blue, 50, Linea - 15);
                Reporte.Graphics.DrawString("Nombre", FuenteSubTitulo, Brushes.Blue, 150, Linea - 15);
                Reporte.Graphics.DrawString("Apellido", FuenteSubTitulo, Brushes.Blue, 250, Linea - 15);
                Reporte.Graphics.DrawString("Barrio", FuenteSubTitulo, Brushes.Blue, 350, Linea - 15);
                Reporte.Graphics.DrawString("Actividad", FuenteSubTitulo, Brushes.Blue, 450, Linea - 15);
                Reporte.Graphics.DrawString("Saldo", FuenteSubTitulo, Brushes.Blue, 550, Linea - 15);

                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                //El tipo de comando es un acceso directo a una tabla
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                Adaptador = new OleDbDataAdapter(Comando); //Ejecutamos el comando
                DataSet Data = new DataSet(); //Declaramos un DataSet
                Adaptador.Fill(Data, TablaG); //Llenamos el data set
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 

                //
                clsActividad Actividades = new clsActividad();
                clsBarrio Barrios = new clsBarrio();
                string NombreBarrio = "";
                string DetalleActividad = "";

                Clientes = 0;
                MontoDeuda = 0;
                Monto = 0;
                Saldo = 0;

                if (Data.Tables[TablaG].Rows.Count > 0) //Si tiene filas
                {
                    foreach (DataRow fila in Data.Tables[TablaG].Rows)
                    {
                        Reporte.Graphics.DrawString(fila["ID"].ToString(), FuenteTexto, Brushes.Black, 50, Linea);
                        Reporte.Graphics.DrawString(fila["NOMBRE"].ToString(), FuenteTexto, Brushes.Black, 150, Linea);
                        Reporte.Graphics.DrawString(fila["APELLIDO"].ToString(), FuenteTexto, Brushes.Black, 250, Linea);
                        Reporte.Graphics.DrawString(fila["SALDO"].ToString(), FuenteTexto, Brushes.Black, 550, Linea);
                        Linea = Linea + 15;
                    }

                    while (Lector.Read())
                    {
                        NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                        DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                        Reporte.Graphics.DrawString(NombreBarrio, FuenteTexto, Brushes.Black, 350, Linea - 25);
                        Reporte.Graphics.DrawString(DetalleActividad, FuenteTexto, Brushes.Black, 450, Linea - 25);

                        if (Lector.GetInt32(10) > 0)
                        {
                            Clientes++;
                            MontoDeuda = MontoDeuda + Lector.GetInt32(10);
                        }
                        else
                        {
                            Clientes++;
                            Monto = Monto + Lector.GetInt32(10);
                        }
                        Saldo = MontoDeuda - Monto;
                        Linea = Linea + 15;
                    }
                }
                Conexion.Close(); //Cierra la conexion

                string Mensaje = "Cantidad de socios:" + Clientes + " . " + "Monto de la deuda $" + MontoDeuda + " . " + "Saldo $" + Monto + " . " + "Balance de $" + Saldo + ".";
                Reporte.Graphics.DrawString(Mensaje, FuenteTexto, Brushes.Black, 50, Linea + 10);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Listado del reporte por actividades

        public void ListadoReporteActividad(DataGridView dgvReporteActividad, Int32 CodigoActividad)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 
            dgvReporteActividad.Rows.Clear(); //Limpia la grilla

            //Llamo las clases para mostrar el nombre del barrio
            //y el detalle de la actividad
            clsActividad Actividades = new clsActividad();
            string DetalleActividad = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                    dgvReporteActividad.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), DetalleActividad, Lector.GetInt32(10));
                }
            }
        }

        //==============================================================================================================

        //Crea un reporte en excel sobre los barrios

        public void ReporteBarrio()
        {
            try
            {
                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 

                //
                StreamWriter AD = new StreamWriter("ReporteBarrios.csv", false);
                AD.WriteLine("Reporte de saldos\n");
                AD.WriteLine("N Socio ; Nombre ; Apellido ; Dni ; Barrio ; Actividad ; Saldo");
                Clientes = 0;
                MontoDeuda = 0;
                Monto = 0;
                Saldo = 0;

                //
                clsActividad Actividades = new clsActividad();
                clsBarrio Barrios = new clsBarrio();
                string NombreBarrio = "";
                string DetalleActividad = "";

                if (Lector.HasRows) //Si hay registros ingresa
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(10) > 0)
                        {
                            NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                            DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));

                            AD.Write(Lector.GetInt32(0));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetString(1));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetString(2));
                            AD.Write(" ; ");
                            AD.Write(Lector.GetInt32(3));
                            AD.Write(" ; ");
                            AD.Write(NombreBarrio);
                            AD.Write(" ; ");
                            AD.Write(DetalleActividad);
                            AD.Write(" ; ");
                            AD.Write(Lector.GetInt32(10));
                            Clientes++;
                            MontoDeuda = MontoDeuda + Lector.GetInt32(10);
                            AD.Write("\n");
                        }
                        else
                        {
                            Monto = Monto + Lector.GetInt32(10);
                        }
                        Saldo = MontoDeuda - Monto;
                    }
                    AD.Write("\n");
                    AD.Write("Cantidad de socios: ");
                    AD.WriteLine(Clientes);
                    AD.Write("Monto de deudores: ");
                    AD.WriteLine(MontoDeuda);
                    AD.Write("Monto: ");
                    AD.WriteLine(Monto);
                    AD.Write("Saldos: ");
                    AD.WriteLine(Saldo);
                }
                Conexion.Close(); //Cierra la conexion
                AD.Close(); //Cierro el agregado
                MessageBox.Show("Reporte generado de manera exitosa.");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        //Imprime el reporte por barrios

        public void ImprimirReporteBarrio(PrintPageEventArgs Reporte)
        {
            try
            {
                Int32 Linea = 100;
                Font FuenteTexto = new Font("Arial", 8, FontStyle.Italic);
                Font FuenteTitulo = new Font("Arial", 20, FontStyle.Underline);
                Font FuenteSubTitulo = new Font("Arial", 12, FontStyle.Bold);

                Reporte.Graphics.DrawString("Reporte de barrios", FuenteTitulo, Brushes.CadetBlue, 50, Linea - 70);
                Reporte.Graphics.DrawString("N Socio", FuenteSubTitulo, Brushes.Blue, 50, Linea - 15);
                Reporte.Graphics.DrawString("Nombre", FuenteSubTitulo, Brushes.Blue, 150, Linea - 15);
                Reporte.Graphics.DrawString("Apellido", FuenteSubTitulo, Brushes.Blue, 250, Linea - 15);
                Reporte.Graphics.DrawString("Barrio", FuenteSubTitulo, Brushes.Blue, 350, Linea - 15);
                Reporte.Graphics.DrawString("Actividad", FuenteSubTitulo, Brushes.Blue, 450, Linea - 15);
                Reporte.Graphics.DrawString("Saldo", FuenteSubTitulo, Brushes.Blue, 550, Linea - 15);

                Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
                Conexion.Open(); //Abrimos la conexion
                Comando.Connection = Conexion; //Establece la conexion con la BD
                //El tipo de comando es un acceso directo a una tabla
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = TablaG; //Selecciona la tabla
                Adaptador = new OleDbDataAdapter(Comando); //Ejecutamos el comando
                DataSet Data = new DataSet(); //Declaramos un DataSet
                Adaptador.Fill(Data, TablaG); //Llenamos el data set
                OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 

                //
                clsActividad Actividades = new clsActividad();
                clsBarrio Barrios = new clsBarrio();
                string NombreBarrio = "";
                string DetalleActividad = "";

                Clientes = 0;
                MontoDeuda = 0;
                Monto = 0;
                Saldo = 0;

                if (Data.Tables[TablaG].Rows.Count > 0) //Si tiene filas
                {
                    foreach (DataRow fila in Data.Tables[TablaG].Rows)
                    {
                        Reporte.Graphics.DrawString(fila["ID"].ToString(), FuenteTexto, Brushes.Black, 50, Linea);
                        Reporte.Graphics.DrawString(fila["NOMBRE"].ToString(), FuenteTexto, Brushes.Black, 150, Linea);
                        Reporte.Graphics.DrawString(fila["APELLIDO"].ToString(), FuenteTexto, Brushes.Black, 250, Linea);
                        Reporte.Graphics.DrawString(fila["SALDO"].ToString(), FuenteTexto, Brushes.Black, 550, Linea);
                        Linea = Linea + 15;
                    }

                    while (Lector.Read())
                    {
                        NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                        DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                        Reporte.Graphics.DrawString(NombreBarrio, FuenteTexto, Brushes.Black, 350, Linea - 25);
                        Reporte.Graphics.DrawString(DetalleActividad, FuenteTexto, Brushes.Black, 450, Linea - 25);

                        if (Lector.GetInt32(10) > 0)
                        {
                            Clientes++;
                            MontoDeuda = MontoDeuda + Lector.GetInt32(10);
                        }
                        else
                        {
                            Clientes++;
                            Monto = Monto + Lector.GetInt32(10);
                        }
                        Saldo = MontoDeuda - Monto;
                        Linea = Linea + 15;
                    }
                }
                Conexion.Close(); //Cierra la conexion

                string Mensaje = "Cantidad de socios:" + Clientes + " . " + "Monto de la deuda $" + MontoDeuda + " . " + "Saldo $" + Monto + " . " + "Balance de $" + Saldo + ".";
                Reporte.Graphics.DrawString(Mensaje, FuenteTexto, Brushes.Black, 50, Linea + 10);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //==============================================================================================================

        public void ListadoReporteBarrio(DataGridView dgvReporteBarrio, Int32 CodigoBarrio)
        {
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD 
            dgvReporteBarrio.Rows.Clear(); //Limpia la grilla

            //Llamo las clases para mostrar el nombre del barrio
            //y el detalle de la actividad
            clsActividad Actividades = new clsActividad();
            string DetalleActividad = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    DetalleActividad = Actividades.BuscarActividad(Lector.GetInt32(9));
                    dgvReporteBarrio.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetInt32(3), DetalleActividad, Lector.GetInt32(10));
                }
            }
        }

        //==============================================================================================================

        //Prueba
        //Listado del reporte por barrios

        public void ListadoR(DataGridView dgvReporteBarrio)
        {
            string Sql = "SELECT BARRIO, Count (BARRIO) FROM Gimnasio" + "GROUP BY BARRIO ORDER BY Count(BARRIO) DESC";
            Conexion.ConnectionString = Ruta; //Toma la ruta de acceso a la base
            Conexion.Open(); //Abrimos la conexion
            Comando.Connection = Conexion; //Establece la conexion con la BD
            Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
            Comando.CommandText = Sql; //Toma la variable sql antes declarada
            Comando.CommandText = TablaG; //Selecciona la tabla
            OleDbDataReader Lector = Comando.ExecuteReader(); //Lee los datos de la BD             
            dgvReporteBarrio.Rows.Clear(); //Limpia la grilla

            //Llamo las clase para mostrar el nombre del barrio
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";

            if (Lector.HasRows) //Si hay registros ingresa
            {
                while (Lector.Read())
                {
                    NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                }
            }
        }
    }
}
