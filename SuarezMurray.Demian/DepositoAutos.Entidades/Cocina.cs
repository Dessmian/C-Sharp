using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoAutos.Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }
        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }
        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Codigo: {0} - ", this.Codigo.ToString());
            builder.AppendFormat("Precio: {0} - ", this.Precio.ToString());
            builder.AppendFormat("Es industrial? {0}", this.EsIndustrial.ToString());
            return builder.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Cocina)
            {
                if (this == (Cocina)obj)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retVal = false;
            if (a.Codigo == b.Codigo)
            {
                retVal = true;
            }
            return retVal;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
    }

}
