using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoAutos.Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }
        public string Marca
        {
            get
            {
                return this._marca;
            }
        }


        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override bool Equals(object obj)
        {
            bool retVal = false;
            if (obj is Auto)
            {
                retVal = (this == (Auto)obj);
            }
            return retVal;
        }
        public static bool operator ==(Auto a, Auto b)
        {
            bool retVal = false;
            if (a.Color == b.Color && a.Marca == b.Marca)
            {
                retVal = true;
            }
            return retVal;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            StringBuilder auto = new StringBuilder();
            auto.AppendFormat("Marca: {0} - ", this.Marca);
            auto.AppendFormat("Color: {0}", this.Color);
            return auto.ToString();
        }
    }
}
