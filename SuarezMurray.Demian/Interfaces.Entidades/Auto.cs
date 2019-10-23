using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }

        public void MostrarPatente()
        {
            Console.WriteLine(this._patente);
        }

        public override string ToString()
        {
            StringBuilder auto = new StringBuilder();
            auto.AppendFormat("{0}",base.ToString());
            auto.AppendLine("Patente: " + this._patente);
            return auto.ToString();
        }
    }
}
