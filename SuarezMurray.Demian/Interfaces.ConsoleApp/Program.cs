using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Entidades;

namespace Interfaces.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta carr1 = new Carreta(10000);
            Familiar fam1 = new Familiar(200000, "aaa", 4);
            Deportivo dep1 = new Deportivo(500000, "bbb", 500);
            Comercial com1 = new Comercial(100000000, 800, 300);
            Privado priv1 = new Privado(50000000, 900, 10000);

            Console.Write(carr1.ToString());
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)carr1).ToString("C2"));
            Console.WriteLine();
            Console.Write(fam1.ToString());
            //Console.WriteLine("Impuestos: " + Gestion.MostrarImpuestoNacional((IAFIP)fam1).ToString("C2"));
            Console.WriteLine();
            Console.Write(dep1.ToString());
            Console.WriteLine("Impuestos AFIP: " + Gestion.MostrarImpuestoNacional((IAFIP)dep1).ToString("C2"));
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)dep1).ToString("C2"));
            Console.WriteLine();
            Console.Write(com1.ToString());
            Console.WriteLine("Impuestos AFIP: " + Gestion.MostrarImpuestoNacional((IAFIP)com1).ToString("C2"));
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)com1).ToString("C2"));
            Console.WriteLine();
            Console.Write(priv1.ToString());
            Console.WriteLine("Impuestos AFIP:" + Gestion.MostrarImpuestoNacional((IAFIP)priv1).ToString("C2"));
            Console.WriteLine("Impuestos ARBA: " + Gestion.MostrarImpuestoProvincial((IARBA)priv1).ToString("C2"));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
