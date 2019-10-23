using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidades
{
    public class Carreta : Vehiculo , IARBA
    {
        public Carreta(double precio) : base(precio)
        {
            
        }

        public double CobrarImpuesto()
        {
            return (this.Precio * 0.18);
        }

        public override string ToString()
        {
            StringBuilder carreta = new StringBuilder();
            carreta.AppendLine("CARRETA");
            carreta.AppendFormat("{0}", base.ToString());
            return carreta.ToString();
        }
    }
}
