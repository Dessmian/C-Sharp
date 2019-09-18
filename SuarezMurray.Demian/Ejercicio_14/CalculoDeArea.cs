using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double retValue = -1;
            if (lado > 0)
            {
                retValue = lado * lado;
            }                    
            return retValue;
        }
        public static double CalcularTriangulo(double baseTr, double altura)
        {
            double retValue = -1;
            if (baseTr > 0 && altura > 0)
            {
                retValue = (baseTr * altura) / 2;
            }
            return retValue;
        }
        public static double CalcularCirculo(double radio)
        {
            double retVal = -1;
            if (radio > 0)
            {
                retVal = Math.Pow((Math.PI * radio),2);
            }
            return retVal;
        }
    }
}
