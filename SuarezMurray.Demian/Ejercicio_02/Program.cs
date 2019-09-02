using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";
            double input, square, cube;
            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero: ");
                input = double.Parse(Console.ReadLine());
                if (input.Equals(0))
                    Console.WriteLine("\nError. Numero invalido.");
                Console.Write("\nPresione cualquier tecla para continuar...\n");
                Console.ReadKey();
            } while (input.Equals(0));
            Console.Clear();
            square = Math.Pow(input, 2.0);
            cube = Math.Pow(input, 3.0);
            Console.WriteLine("Numero ingresado: {0}\nCuadrado: {1}\nCubo: {2}",
                               input, square, cube);
            Console.ReadKey();
        }
    }
}
