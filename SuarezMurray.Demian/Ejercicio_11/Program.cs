using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int validInputs = 0, objective = 10, minTolerance = -100, maxTolerance = 100;
            string actualInput;
            ConsoleGets getter = new ConsoleGets("Ingrese un numero entero: ");
            List<int> numberList = new List<int>();
            do
            {
                Console.Clear();
                actualInput = getter.Integer(minTolerance, maxTolerance);
                if (getter.isValid)
                {
                    numberList.Add(int.Parse(actualInput));
                    validInputs++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Datos invalidos ingresados.");
                    Console.ReadKey();
                }
            } while (validInputs.IsLessThan(objective));
            Console.WriteLine("Numero maximo: {0}", numberList.Max());
            Console.WriteLine("Numero minimo: {0}", numberList.Min());
            Console.WriteLine("Promedio: {0}", numberList.Average());           
            Console.ReadKey();
        }
    }
}
