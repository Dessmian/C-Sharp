using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(IAFIP bienPinuble)
        {
            return bienPinuble.CobrarImpuesto();
        }
        public static double MostrarImpuestoProvincial(IARBA bienPunible)
        {
            return bienPunible.CobrarImpuesto();
        }
    }
}
