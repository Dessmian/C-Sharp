using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining, end, i, j;
            List<int> leapYears = new List<int>();
            Console.Write("Ingrese un año de inicio: ");
            begining = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese un año de finalizacion: ");
            end = int.Parse(Console.ReadLine());
            if (end.IsLessThan(begining))
            {
                i = end;
                j = begining;
            }
            else
            {
                i = begining;
                j = end;
            }
            for (;i<j;i++)
            {
                if (i.Equals(0))
                {
                    continue;
                }
                if ((i % 4).Equals(0))
                {
                    leapYears.Add(i);
                }
            }
            Console.Clear();
            for (i=0;i<(leapYears.Count());i++)
            {
                Console.Write("-\t{0}\t-", leapYears[i]);
                if ((i%5).Equals(0)&&i!=0)
                {
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
