using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Clase_20.Consola_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persona personaUno = new Persona("skdfjsdfg", "juanes", 50);
                Serializadora.Serializar(personaUno);
                Console.Write(personaUno.ToString());
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
/*main 
 crear lista personas
 serializar lista
 observar contenido archivo
 deserializar lista
 magia*/
