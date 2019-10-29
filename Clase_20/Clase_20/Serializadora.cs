using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using InterfazXML;

namespace Clase_20
{
    public static class Serializadora
    {
        public static bool Serializar(IXML item)
        {
            try
            {
                item.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + 
                    @"\DatosClase20\textoXML.xml");
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public static bool Deserializar(IXML item, out object obj)
        {
            try
            {
                obj = item.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                     @"\DatosClase20\textoXML.xml");
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
