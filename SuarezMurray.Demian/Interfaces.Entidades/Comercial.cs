using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public class Comercial : Avion , IARBA
    {
        protected int _cantidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros)
            : base(precio, velocidad)
        {
            this._cantidadPasajeros = pasajeros;
        }

        double IARBA.CobrarImpuesto()
        {
            return (this.Precio * 0.25);
        }

        public override string ToString()
        {
            StringBuilder comercial = new StringBuilder();
            comercial.AppendLine("AVION COMERCIAL");
            comercial.AppendFormat("{0}", base.ToString());
            comercial.AppendLine("Cantidad pasajeros: " + this._cantidadPasajeros.ToString());
            return comercial.ToString();
        }
    }
}
