using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

        public void MostrarPrecio()
        {
            Console.WriteLine(this._precio.ToString());
        }

        public override string ToString()
        {
            StringBuilder vehiculo = new StringBuilder();
            vehiculo.AppendLine("Precio: " + this._precio.ToString("C2"));
            return vehiculo.ToString();
        }
    }
}
