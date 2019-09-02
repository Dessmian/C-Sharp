using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;
/*
*     2k² == n*(n+1) 
*    k - es el centro numerico 
*    n - es el numero ingresado
*    
*/
namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            int input, i, buffer;
            List<int> centers = new List<int>();
            List<int> limits = new List<int>();
            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero (entero positivo): ");
                input = int.Parse(Console.ReadLine());
            } while (input.IsLessThan(1));
            for (i=1;i<input;i++)
            {
                buffer = i.GetNumericCentre();
                if (buffer.IsGreaterThan(0))
                {
                    centers.Add(buffer);
                    limits.Add(i);
                }
                //Console.WriteLine("Calculando... {0} de {1}", i, input);
            }
            Console.Clear();
            if (centers.Count.IsGreaterThan(0))
            {
                for (i=0;i<(centers.Count);i++)
                {
                    Console.WriteLine("El centro numerico entre 1 y {0} es {1}",
                                       limits[i], centers[i]);
                }
            }
            else
            {
                Console.WriteLine("No hay centros numericos entre 1 y {0}", input);
            }
            Console.ReadKey();
        }
    }
}
