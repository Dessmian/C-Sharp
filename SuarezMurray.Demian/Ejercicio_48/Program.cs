using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> cont = new Contabilidad<Factura, Recibo>();

            Factura f1 = new Factura(10);
            Recibo r1 = new Recibo(10);

            Console.Write(cont.ToString());

            Console.ReadKey();
        }
    }
}
