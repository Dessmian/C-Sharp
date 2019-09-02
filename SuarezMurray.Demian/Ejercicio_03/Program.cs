using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int input , i;
            List<int> primeNumbers = new List<int>();
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero (mayor a 0):");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPresione cualquier tecla para continuar...\n");
                Console.ReadKey();
            } while (input<1);
            for (i=1;i<=input;i++)
            {
                if (i.IsPrime())
                {
                    primeNumbers.Add(i);
                }
            }
            if (primeNumbers.Count()>0)
            {
                Console.Clear();
                Console.WriteLine("Numeros primos (menores a):");
                for(i=0;i<primeNumbers.Count();i++)
                {
                    Console.Write("- {0} -",primeNumbers[i]);
                }
                Console.WriteLine("\nPresione cuanlquier tecla para continuar...\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay numeros primos (menores a)...");
                Console.WriteLine("\nPresione cualquier tecla para continiar...\n");
                Console.ReadKey();
            }
        }
    }
}
