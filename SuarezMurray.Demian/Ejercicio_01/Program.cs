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
            int input, min = 0, max = 0, counter = 0;
            float average = 0;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                input = int.Parse(Console.ReadLine());
                if(counter==0)
                {
                    min = input;
                    max = input;
                    average = input;
                }
                else
                {
                    average = average + input;
                    if (input>max)
                    {
                        max = input;
                    }
                    if (input<min)
                    {
                        min = input;
                    }
                }
                counter++;
            } while (counter < 5);
            average = average / counter;
            Console.WriteLine("Minimo: {0}\nMaximo: {1}\nPromedio: {2}",min,max,average);
            Console.ReadKey();
        }
    }
}
