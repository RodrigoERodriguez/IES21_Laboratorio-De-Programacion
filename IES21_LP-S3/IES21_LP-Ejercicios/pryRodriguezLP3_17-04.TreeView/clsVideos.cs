﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryRodriguezLP_Clase17_04
{
    internal class clsVideos
    {
        //
        private string Cadena = "provider=microsoft.jet.oledb.4.0;data source=YOUTUBE_MIGUEL.mdb";
        private OleDbConnection Conector;
        private OleDbCommand Comando; //Envia el comando a la base de datos
        private OleDbDataAdapter Adaptador; //Da la orden de hacer las acciones del comando
        private DataTable Tabla;

        //Realizo el constructor
        public clsVideos()
        {
            Cadena = clsConfiguration.GetCadena();

            Conector = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Videos";
            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);
        }

        public DataTable GetVideos()
        {
            return Tabla;
        }
    }
}
