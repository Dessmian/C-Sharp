using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int input, i;
            string line = "*";
            do
            {
                Console.Clear();
                Console.Write("ingrese la altura: ");
                input = int.Parse(Console.ReadLine());
            } while (input.IsLessThan(1));
            for (i = 0; i < input; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                Console.WriteLine(line);
                line = line + "**";
            }
            Console.ReadKey();
        }
    }
}
