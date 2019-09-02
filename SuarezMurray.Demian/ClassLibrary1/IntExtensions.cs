using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IntExtension
    { 
        public static bool IsGreaterThan(this int i,int value)
        {
            return i > value;
        }
        public static bool IsLessThan(this int i,int value)
        {
            return i < value;
        }
        public static bool IsPrime(this int i)
        {
            bool retVal = false;
            if (i>1)
            {
                if (i<4)
                {
                    retVal = true;
                }
                else
                {
                    float j;
                    for (j=2;j<i;j++)
                    {
                        if ((i%j).Equals(0))
                        {
                            break;
                        }
                    }
                    if (j.Equals(i))
                    {
                        retVal = true;
                    }
                }
            }
            return retVal;
        }
        public static List<int> GetDivisors(this int i)
        {
            List<int> retList = new List<int>();
            float j;
            if (i.IsGreaterThan(0))
            {
                for (j=i;j>0;j--)
                {
                    if ((i%j).Equals(0))
                    {
                        retList.Add((int)j);
                    }
                }
            }            
            return retList;
        }
        public static int GetNumericCentre(this int i)
        {
            int centre = 0;
            if (i.IsGreaterThan(0))
            {
                double target, buffer;
                int j;
                target = i * (i+1);
                for (j=1; j<i; j++)
                {
                    buffer = 2 * (Math.Pow(j, 2));
                    if (buffer.Equals(target))
                    {
                        centre = j;
                        break;
                    }
                }
            }
            return centre;
        }
        
    }
}
