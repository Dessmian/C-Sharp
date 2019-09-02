using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 04";

            Cosa asd = new Cosa();
            Cosa cosa2 = new Cosa();
            Cosa cosa3 = new Cosa(3);
            Cosa cosa4 = new Cosa("Hola");
            Cosa cosa5 = new Cosa("Cosa5", DateTime.Parse("1970/05/10"));
            asd.EstablecerValor(10);
            asd.EstablecerValor("asd");
            asd.EstablecerValor(DateTime.Now);
            Console.WriteLine(cosa2.Mostrar());
            Console.WriteLine(cosa3.Mostrar());
            Console.WriteLine(cosa4.Mostrar());
            Console.WriteLine(cosa5.Mostrar());
            Console.ReadKey();
        }
    }
}
