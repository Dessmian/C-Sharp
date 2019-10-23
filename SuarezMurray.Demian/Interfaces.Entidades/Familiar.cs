using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public class Familiar : Auto
    {
        protected int _cantidadAsientos;

        public Familiar (double precio, string patente, int cantidadAsientos)
            : base(precio, patente)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public override string ToString()
        {
            StringBuilder familiar = new StringBuilder();
            familiar.AppendLine("AUTO FAMILIAR");
            familiar.AppendFormat("{0}", base.ToString());
            familiar.AppendLine("Asientos: " + this._cantidadAsientos.ToString());
            return familiar.ToString();
        }
    }
}
