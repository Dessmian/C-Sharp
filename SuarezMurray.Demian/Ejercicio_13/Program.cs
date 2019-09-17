using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            Console.WriteLine("{0} - {1}", 7, Conversor.DecimalBinario(7.0));
            Console.WriteLine("{0} - {1}", "1010", Conversor.BinarioDecimal("111"));
            Console.ReadKey();
        }
    }
}
