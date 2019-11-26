using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MockUp_2doParcial
{
    public static class SQLMockUp
    {
        private static SqlConnection connection;
        private static SqlCommand comando;

        static SQLMockUp()
        {
            SqlConnection conexion = new SqlConnection("Server=.\\SQLEXPRESS;Database=<Nombre del DB>;Trusted_Connection=True;");
            SQLMockUp.connection = conexion;
        }        
        public static void Conectar()
        {
            try
            {
                SQLMockUp.connection.Open();
                //Hacer algo
            }
            finally
            {
                if(SQLMockUp.connection.State == System.Data.ConnectionState.Open)
                    SQLMockUp.connection.Close();
            }
        }
        public static void CrearComando()
        {
            SqlCommand traer = new SqlCommand("SELECT * FROM <DB>", SQLMockUp.connection);

            SqlCommand insertar = new SqlCommand("INSERT INTO <DB> VALUES (@v1,@v2,@v3)", SQLMockUp.connection);
            insertar.Parameters.AddWithValue("@v1", "Valor 1");
            insertar.Parameters.AddWithValue("@v2", "Valor 2");
            insertar.Parameters.AddWithValue("@v3", "Valor 3");

            SqlCommand actualizar = new SqlCommand("UPDATE <DB> SET campo = @valor WHERE id = @valor", SQLMockUp.connection);

            SqlCommand borrar = new SqlCommand("DELETE FROM <DB> WHERE id = @valor");
        }
    }
}
