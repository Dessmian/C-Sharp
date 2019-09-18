using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double inNumber)
        {
            string retString;
            retString = Convert.ToString(Convert.ToInt32(inNumber), 2);
            return retString;
        }
        public static double BinarioDecimal(string inString)
        {
            double retDouble = 0;
            int i, j;
            j = inString.Length - 1;
            char actualValue;
            for (i = 0; i < inString.Length; i++)
            {
                actualValue = inString[j];
                j--;
                if (actualValue == '0')
                {
                    continue;
                }
                else if (actualValue == '1')
                {
                    retDouble += (int)Math.Pow(2, i);
                }
                else
                {
                    break;
                }
            }
            return retDouble;
        }
    }
}
