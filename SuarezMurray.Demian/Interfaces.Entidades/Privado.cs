using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public class Privado : Avion
    {
        protected int _valoracionServicioDeAbordo;

        public Privado(double precio, double velMax, int valoracion)
            : base (precio, velMax)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }

        public override string ToString()
        {
            StringBuilder privado = new StringBuilder();
            privado.AppendLine("AVION PRIVADO");
            privado.AppendFormat("{0}", base.ToString());
            privado.AppendLine("Costo servicio: " + this._valoracionServicioDeAbordo.ToString());
            return privado.ToString();
        }
    }
}
