using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazXML
{
    public interface IXML
    {
        bool Guardar(string path);
        bool Leer(string path);
    }
}
