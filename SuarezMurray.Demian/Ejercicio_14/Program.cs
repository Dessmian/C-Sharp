using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            Console.WriteLine("El area de un cuadrado de 10m es {0}m2", CalculoDeArea.CalcularCuadrado(10));
            Console.WriteLine("El area de un triangulo de 10m de base y 5m de altura " +
                                "es {0}m2", CalculoDeArea.CalcularTriangulo(10,5));
            Console.WriteLine("El area de un de 10m de radio " +
                                "es {0}m2", CalculoDeArea.CalcularCirculo(10));

            Console.ReadLine();
        }
    }
}
