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
            Local l1 = new Local("Avellaneda",30,"Avellaneda",(float)2.65);
            Provincial l2 = new Provincial("B.A.", Franja.Franja_1, 21, "La Pampa");
            Local l3 = new Local("Avellaneda", 45, "Gerli", (float)1.99);
            Provincial l4 = new Provincial("La Pampa", Franja.Franja_3, 21, "B.A.");

            Console.WriteLine(Telefonica.ToString());
            Telefonica += l1;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += l2;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += l3;
            Console.WriteLine(Telefonica.ToString());
            Telefonica += l4;
            Console.ReadKey();
        }
    }
}
