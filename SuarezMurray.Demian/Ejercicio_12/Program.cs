using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int input, cumulation = 0;
            ConsoleKeyInfo answer;
            bool cont;
            do
            {
                Console.Clear();                
                Console.Write("Ingrese un numero entero: ");
                input = int.Parse(Console.ReadLine());
                cumulation += input;
                Console.Write("\nDesea continuar?(S/N) ");
                answer = Console.ReadKey();
                cont = ValidarRespuesta.ValidarS_N(answer.KeyChar);
            } while (cont);
            Console.Clear();
            Console.WriteLine("La suma es {0}", cumulation);
            Console.ReadKey();
        }
    }
}
