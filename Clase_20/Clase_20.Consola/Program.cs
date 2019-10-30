using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_20;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Clase_20.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase_20";
            string apodo = "apodo";
            Random ran = new Random();
            List<string> apodos = new List<string>();
            for (int i = 0; i<ran.Next(1000,10000); i++)
            {
                apodos.Add(apodo + i.ToString());
            }
            
            Persona pUno = new Persona("Juan", "JUAN", 100);
            Persona pDos = new Persona("Perez", "PEREZ", 98);
            Console.Write(pUno.ToString());
            Console.Write(pDos.ToString());
            Console.WriteLine();

            List<Persona> personas = new List<Persona>();
            personas.Add(pUno);
            personas.Add(pDos);

            #region xmlSerializer
            /*try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                StreamWriter streamWriter = new StreamWriter(
                    @"C:\Users\alumno\Desktop\streamWriter.xml");
                xmlSerializer.Serialize(streamWriter, pUno);
                streamWriter.Close();
                StreamReader streamReader = new StreamReader(
                    @"C:\Users\alumno\Desktop\streamWriter.xml");
                
                //xmlSerializer.Serialize(streamWriter, pDos);

                Persona juan = (Persona)xmlSerializer.Deserialize(streamReader);
                Console.Write(juan.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            #endregion

            try
            {
                XmlSerializer serializerLista = new XmlSerializer(typeof(List<Persona>));
                //string path = Environment.SpecialFolder.Desktop.ToString() + "listaPersonas.xml";
                StreamWriter writerLista = new StreamWriter
                    (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\sdfjsdjf.xml");
                serializerLista.Serialize(writerLista, personas);
                writerLista.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #region XmlTextWriter
            /*
            try
            {

                TextWriter textWriter;
                XmlTextWriter xmlWriter = new XmlTextWriter();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion

            Console.ReadLine();
        }
    }
}
