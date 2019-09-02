using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            Console.ForegroundColor = ConsoleColor.Green;
            /*while (1)
            {
                if (Console.ReadKey=='a')
                {
                    Console.Clear();
                    Console.ForegroundColor = 0;
                    Console.Write('Colores');
                }
            }*/
            string name = "Demian";
            string surname = "Murray";
            Console.WriteLine("Hola mundo C#!");
            Console.WriteLine("\n {0}   -   {1}", name, surname);
            Console.Write("\nIngrese el nuevo nombre: ");
            name = Console.ReadLine();
            if (name.Equals("asd"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\n {0}   -   {1}", name, surname);
            Console.ReadKey();
            
        }
    }
}
