using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bornDate = new DateTime();
            string inputString;
            int days;
            TimeSpan livedTime = new TimeSpan();
            do
            {
                Console.Clear();
                Console.Write("Ingrese su fecha de nacimiento (aaaa/mm/dd): ");
                inputString = Console.ReadLine();
                
            } while ((DateTime.TryParse(inputString,out bornDate)).Equals(false));
            livedTime = DateTime.Now.Subtract(bornDate);
            days = (int)livedTime.TotalDays;
            Console.WriteLine("Usted vivio {0} dias!",days);
            Console.ReadKey();
        }
    }
}
