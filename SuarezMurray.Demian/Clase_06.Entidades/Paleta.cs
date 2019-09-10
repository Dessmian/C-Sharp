using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;


namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        private Paleta():this(5){}
        private Paleta(int ammnt)
        {
            this.cantidadMaximaColores = ammnt;
            this.colores = new Tempera[this.cantidadMaximaColores];
        }
        public static implicit operator Paleta(int ammnt)
        {
            return new Paleta(ammnt);
        }
        private string Mostrar()
        {
            string retString = "nullObject";
            if (!this.Equals(null))
            {
                int i, j;
                j = this.colores.Count();
                retString = "Cantidad maxima: " + this.cantidadMaximaColores.ToString();
                if (this.colores.Count().IsGreaterThan(0))
                {
                    retString += " Temperas: ";
                    for (i=0; i<j;i++)
                    {
                        retString += " - ";
                        retString += this.colores[i];
                    }
                }
            }
            return retString;
        }
        private int ObtenerLugarLibre()
        {
            int retIndex = -1;
            if (!this.Equals(null))
            {
                int i;
                for (i=0;i<this.cantidadMaximaColores;i++)
                {
                    if (this.colores[i].Equals(null))
                    {
                        retIndex = i;
                        break;
                    }
                }
            }
            return retIndex;
        }
        public static explicit operator string (Paleta palet)
        {
            return palet.Mostrar();
        }
        public static bool operator ==(Paleta inPalet, Tempera inTemp)
        {
            bool retBool = false;
            if (!inPalet.Equals(null))
            {
                int i;
                for (i=0;i<inPalet.cantidadMaximaColores;i++)
                {
                    if (inPalet.colores[i]==inTemp)
                    {
                        retBool = true;
                        break;
                    }
                }
            }
            return retBool;
        }
        public static bool operator !=(Paleta inPalet, Tempera inTemp)
        {
            return !(inPalet == inTemp);
        }
        public static Paleta operator +(Paleta inPalet, Tempera inTemp)
        {
            if (inPalet == inTemp)
            {
                int i;
                for (i=0;i<inPalet.cantidadMaximaColores;i++)
                {
                    if (inPalet.colores[i] == inTemp)
                    {
                        inPalet.colores[i] += inTemp;
                        break;
                    }
                }
            }
            else
            {
                int index;
                index = inPalet.ObtenerLugarLibre();
                if (index>=0)
                {
                    inPalet.colores[index] = inTemp;
                }
            }
            return inPalet;
        }
        public static int operator |(Paleta inPalet, Tempera inTemp)
        {
            int retInt = -1;
            if (!inPalet.Equals(null))
            {
                int i;
                for (i=0;i<inPalet.cantidadMaximaColores;i++)
                {
                    if (inPalet.colores[i] == inTemp)
                    {
                        retInt = i;
                        break;
                    }
                }
            }
            return retInt;
        }
    }
}
