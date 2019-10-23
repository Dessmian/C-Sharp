using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public class Deportivo : Auto , IAFIP , IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int caballosFuerza)
            : base(precio, patente)
        {
            this._caballosFuerza = caballosFuerza;
        }

        double IAFIP.CobrarImpuesto()
        {
            return (this.Precio * 0.28);
        }
        double IARBA.CobrarImpuesto()
        {
            return (this.Precio * 0.23);
        }

        public override string ToString()
        {
            StringBuilder deportivo = new StringBuilder();
            deportivo.AppendLine("AUTO DEPORTIVO");
            deportivo.AppendFormat("{0}", base.ToString());
            deportivo.AppendLine("Caballos: " + this._caballosFuerza.ToString());
            return deportivo.ToString();
        }
    }
}
