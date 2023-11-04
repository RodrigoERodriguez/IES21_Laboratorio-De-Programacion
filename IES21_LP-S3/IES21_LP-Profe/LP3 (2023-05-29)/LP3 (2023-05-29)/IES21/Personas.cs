using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

using System.Windows.Forms;

namespace IES21
{
    class Personas
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private string sql;
        public Personas()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=IES21.mdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
           
        }

        public void listar(DataGridView dgv, string ojos)
        {
            sql = "SELECT nombre, dni, edad, ojos FROM Personas WHERE ojos='" + ojos + "'";
            comando.CommandText = sql;
            adaptador.Fill(tabla);
            dgv.DataSource = tabla;
        }
    }
}
