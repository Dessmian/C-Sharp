using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita("Telefonica");
            Llamada l1 = new Local("1111111",30,"222222222",(float)2.65);
            Llamada l2 = new Provincial("3333333333", Franja.Franja_1, 21, "44444444");
            Llamada l3 = new Local("555555555", 45, "66666666666", (float)1.99);
            Llamada l4 = new Provincial("777777777", Franja.Franja_3, 21, "8888888888");

            Telefonica += l1;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += l2;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += l3;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += l4;
            Console.WriteLine(Telefonica.ToString());
            Console.ReadKey();
        }
    }
}
