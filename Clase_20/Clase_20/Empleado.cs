using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20
{
    public class Empleado : Persona
    {
        public int legajo;
        public float sueldo;

        public Empleado(string nombre, string apellido, int edad, int legajo, float sueldo)
            :base(nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
    }
}
