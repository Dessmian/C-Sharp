using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public static class CajonExtencion
    {
        public static bool EliminarFruta(this Cajon<Manzana> c, int index)
        {
            return true;
        }
    }
}
