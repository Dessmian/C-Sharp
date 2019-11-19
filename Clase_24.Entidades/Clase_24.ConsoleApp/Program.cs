using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_24.Entidades;
using CExterna = Entidades.Externa;
using CESellada = Entidades.Externa.Sellada;
using System.Data.SqlClient;
using System.Data;

namespace Clase_24.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Juan", "Perez", 12345678);
            PersonaHeredada per2 = new PersonaHeredada("Pedro", "Perez", 45, CExterna.ESexo.Indefinido);
            CESellada.PersonaExternaSellada per3 = new CESellada.PersonaExternaSellada(
                                "Juan", "Perez", 45, CESellada.ESexo.Indefinido);
            List<Persona> lista = new List<Persona>();
            lista.ObtenerListadoBD();

            foreach(Persona item in lista)
            {
                Console.WriteLine(item.ObtenerInfo());
                //Console.WriteLine("asd");
            }

            Console.WriteLine(per1.EsNulo());
            Console.WriteLine(per3.ObtenerInfo());
            Console.WriteLine();
            Console.WriteLine(per1.Nombre + " " + per1.Apellido + " " + per1.DNI.ToString());
            //Console.WriteLine(per2.ObtenerInfo());
            //Console.Write(per1.RepetirInfo());

            Console.ReadLine();
        }
    }
    public static class Extensora
    {
        public static string ObtenerInfo(this CESellada.PersonaExternaSellada externaSellada)
        {
            return (externaSellada.Nombre + " " + externaSellada.Apellido + " " + externaSellada.Edad
                + " " + externaSellada.Sexo);
        }
        public static bool EsNulo(this object o)
        {
            if(o == null)
            {
                return true;
            }
            return false;
        }
        public static List<Persona> ObtenerListadoBD(this List<Persona> lista)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM personas", connection);
                DataTable table = new DataTable();
                connection.Open();
                adapter.Fill(table);
                connection.Close();
                foreach(DataRow row in table.Rows)
                {
                    Persona p = new Persona(row[1].ToString(), row[2].ToString(), int.Parse(row[3].ToString()));
                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
/*
 * Metodos de extension
 *      Son metodos que se agregan a una clase ya existente.
 *      Pueden agregarse a clases selladas.
 *      El metodo de extension tiene que estar dentro de una clase estatica.
 *      Si bien los metodos agregados son estaticos, se utilizan como metodos de instancia.
 *      
 *      [mod] static [Retorno] [IdentificadorMetodo](this [Tipo] [IdentificadorObjeto]){} 
 *      
 */