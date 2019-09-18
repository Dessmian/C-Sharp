using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    class AlumnoCalificado : Alumno
    {
        protected double nota;

        public double Nota
        {
            get
            {
                return this.nota;
            }
        }

        public AlumnoCalificado(Alumno a1, double nota):base(a1.Apellido,a1.Nombre,a1.Legajo,a1.Examen)
        {            
            this.nota = nota;            
        }
        public AlumnoCalificado(string apellido, string nombre, int legajo, ETipoExamen examen,double nota)
            :this(new Alumno(apellido,nombre,legajo,examen),nota)
        {

        }
        public string Mostrar()
        {
            return Alumno.Mostrar(this) + ", " + this.nota.ToString();
        }
    }
}
