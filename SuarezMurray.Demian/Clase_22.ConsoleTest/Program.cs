using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_22.Entidades;

namespace Clase_22.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Juan", "Perez", 123);

            //Asignar sueldo
            try
            {
                Program program = new Program();
                //e1.limiteSueldo += program.ManejadorLimiteSueldo;
                //e1.limiteSueldoMejorado += ManejadorLimiteSueldoMejorado;
                e1.limiteSueldoMejorado += program.ManejadorLimiteSueldoMejorado2;
                e1.Sueldo = 33000;
                //e1.Sueldo = 25000;
                //e1.Sueldo = 18000;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Mostrar sueldo
            Console.WriteLine(e1.ToString() + " - " + e1.Sueldo.ToString());



            Console.ReadLine();
        }
        public void ManejadorLimiteSueldo(double sueldo, Empleado emp)
        {
            Console.WriteLine("El empleado es: " + emp.ToString() + ", y el sueldo es: " + sueldo.ToString());
            Console.WriteLine();
        }
        public static void ManejadorLimiteSueldoMejorado(Empleado sender, EmpleadoEventArgs e)
        {
            Console.WriteLine("*****Metodo mejorado*****");
            Console.WriteLine("El empleado es: " + sender.ToString() + ", y el sueldo es: " + e.SualdoAsignar.ToString());
            Console.WriteLine();
            
        }
        public void ManejadorLimiteSueldoMejorado2(Empleado sender, EmpleadoEventArgs e)
        {
            Program.ManejadorLimiteSueldoMejorado(sender, e);
        }
    }
}
