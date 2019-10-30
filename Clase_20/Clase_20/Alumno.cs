using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20
{
    public class Alumno : Persona
    {
        public int nota;

        public Alumno(string nombre, string apellido, int edad, int nota)
            :base(nombre,apellido,edad)
        {
            this.nota = nota;
        }
    }
}
