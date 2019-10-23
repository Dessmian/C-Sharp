using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public class Avion : Vehiculo , IAFIP , IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double IAFIP.CobrarImpuesto()
        {
            return (this.Precio * 0.33);
        }
        double IARBA.CobrarImpuesto()
        {
            return (this.Precio * 0.27);
        }

        public override string ToString()
        {
            StringBuilder avion = new StringBuilder();
            avion.AppendFormat("{0}", base.ToString());
            avion.AppendFormat("Velocidad maxima: {0} km/h\n", this._velocidadMaxima.ToString());
            return avion.ToString();
        }
    }
}
