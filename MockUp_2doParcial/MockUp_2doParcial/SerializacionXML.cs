using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace MockUp_2doParcial
{
    public class SerializacionXML<T>
    {
        public static void Serializar(T item, string path)
        {
            //El streamWriter se encarga de escribir el archivo.
            StreamWriter writer = new StreamWriter(path);
            //El serializador se encarga de formatear los datos a guardar.
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //El metodo serialize necesita al encargado de escribir el archivo y lo que se necesita guardar.
            serializer.Serialize(writer, item);
        }
        public static void Deserializar(out T item, string path)
        {
            StreamReader reader = new StreamReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            item = (T)serializer.Deserialize(reader);
        }
    }
}
