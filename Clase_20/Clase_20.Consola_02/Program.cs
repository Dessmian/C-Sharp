using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using InterfazXML;

namespace Clase_20.Consola_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Persona personaUno = new Persona("skdfjsdfg", "juanes", 50);
            //    Persona personaLeida = new Persona();
            //    object buffer = new object();
            //    Serializadora.Serializar(personaUno);
            //    Console.Write(personaUno.ToString());
            //    Serializadora.Deserializar(personaLeida, out buffer);
            //    personaLeida = (Persona)buffer;
            //    Console.WriteLine(personaLeida.ToString());
            //    Console.ReadLine();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadLine();
            //}
            //try
            //{
            //    Persona persona1 = new Persona("uno", "UNO", 10);
            //    Persona persona2 = new Persona("dos", "DOS", 20);
            //    Persona persona3 = new Persona("tres", "TRES", 30);
            //    Persona persona4 = new Persona("cuatro", "CUATRO", 40);
            //    List<Persona> listaPersonas = new List<Persona>();
            //    listaPersonas.Add(persona1);
            //    listaPersonas.Add(persona2);
            //    listaPersonas.Add(persona3);
            //    listaPersonas.Add(persona4);
            //    foreach(Persona persona in listaPersonas)
            //    {
            //        Serializadora.Serializar(persona);
            //    }

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadLine();
            //}
            try
            {
                Persona per1 = new Persona("persona", "uno", 10);
                Alumno alum1 = new Alumno("alumno", "uno", 20, 8);
                Empleado emp1 = new Empleado("empleado", "uno", 30, 100, 200);
                List<Persona> listaPersonas = new List<Persona>();
                listaPersonas.Add(per1);
                listaPersonas.Add(alum1);
                listaPersonas.Add(emp1);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
                StreamWriter streamWriter = new StreamWriter(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaPersonas.xml");
                xmlSerializer.Serialize(streamWriter, listaPersonas);
                streamWriter.Close();
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
