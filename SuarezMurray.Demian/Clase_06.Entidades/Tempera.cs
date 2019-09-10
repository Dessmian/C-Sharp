using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor clr, string brnd, int ammnt)
        {
            this.color = clr;
            this.marca = brnd;
            this.cantidad = ammnt;
        }
        public Tempera MiTempera {
            get { return this; }
        }
        private string Mostrar()
        {
            string retString = "nullObject";
            if (!this.Equals(null))
            {
                retString = this.marca + " - " + this.color.ToString() + " - " + this.cantidad.ToString();
            }
            return retString;
        }
        public static implicit operator string (Tempera inObject)
        {
            return inObject.Mostrar();
        }
        public static bool operator ==(Tempera inOne, Tempera inTwo)
        {
            bool retBool = false;
            if (!inOne.Equals(null))
            {
                if (!inTwo.Equals(null))
                {
                    if (inOne.marca == inTwo.marca)
                    {
                        if (inOne.color == inTwo.color)
                        {
                            retBool = true;
                        }
                    }
                }
            }
            else
            {
                if (inTwo.Equals(null))
                {
                    retBool = true;
                }
            }
            return retBool;
        }
        public static bool operator !=(Tempera inOne, Tempera inTwo)
        {
            return !(inOne == inTwo);
        }
        public static Tempera operator +(Tempera inTemp, int inAmmnt)
        {
            if (!inTemp.Equals(null))
            {
                inTemp.cantidad += inAmmnt;
            }
            return inTemp;
        }
        public static Tempera operator +(Tempera inOne, Tempera inTwo)
        {
            if (inOne == inTwo)
            {
                inOne += inTwo.cantidad;
            }
            return inOne;
        }
    }
}
