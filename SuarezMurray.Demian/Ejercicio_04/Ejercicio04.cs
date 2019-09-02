using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_04
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            int input, i, acumulator = 0;
            List<int> divisors = new List<int>();
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero (mayor a 0):");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPresione cualquier tecla para continuar...\n");
                Console.ReadKey();
            } while (input < 1);
            divisors = input.GetDivisors();
            for (i=0;i<divisors.Count();i++)
            {
                acumulator += divisors[i];
            }
            acumulator -= input;
            if (acumulator.Equals(input))
            {
                Console.Clear();
                Console.WriteLine("Es un numero perfecto!");
                Console.WriteLine("\nPresione cualquier tecla para continuar...\n");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No es un numero perfecto. :(");
                Console.WriteLine("\nPresione cualquier tecla para continuar...\n");
                Console.ReadKey();
            }
        }
    }
}
