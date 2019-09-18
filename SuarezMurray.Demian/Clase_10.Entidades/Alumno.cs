using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected string nombre;
        protected int legajo;
        protected ETipoExamen examen;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
        }
        public ETipoExamen Examen
        {
            get
            {
                return this.examen;
            }
        }
        public Alumno(string apell, string nomb, int leg, ETipoExamen exam)
        {
            this.apellido = apell;
            this.nombre = nomb;
            this.legajo = leg;
            this.examen = exam;
        }
        public static string Mostrar(Alumno inAlumno)
        {
            string al = "";
            al += inAlumno.apellido + ", ";
            al += inAlumno.nombre + ", ";
            al += inAlumno.legajo.ToString() + ", ";
            al += inAlumno.examen.ToString();
            return al;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            bool retBool = false;
            if (a1.legajo == a2.legajo)
            {
                retBool = true;
            }
            return retBool;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        public static int OrdenarPorLegajoAsc(Alumno a1, Alumno a2)
        {
            int retInt = 0, comparison = 0;
            comparison = a1.Legajo - a1.Legajo;
            if (comparison > 0)
            {
                retInt = 1;
            }
            else if(comparison < 0)
            {
                retInt = -1;
            }
            return retInt;
        }
        public static int OrdenarPorLegajoDesc(Alumno a1, Alumno a2)
        {
            return Alumno.OrdenarPorLegajoAsc(a2, a1);
        }
        public static int OrdenarPorApellidoAsc(Alumno a1, Alumno a2)
        {
            int retInt = 0, comparison = 0;
            comparison = string.Compare(a1.Apellido, a2.Apellido);
            if (comparison > 0)
            {
                retInt = 1;
            }
            return retInt;
        }
        public static int OrdenarPorApellidoDesc(Alumno a1, Alumno a2)
        {
            return Alumno.OrdenarPorApellidoAsc(a2, a1);
        }

    }
}


/*
 * clase alumno
 * clase alumnoCalificado
 * clase catedra
 */