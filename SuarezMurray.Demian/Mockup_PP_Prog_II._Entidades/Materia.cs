using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup_PP_Prog_II._Entidades
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        private Materia()
        {
            this._alumnos = new List<Alumno>();
        }
        private Materia(EMateria nombre):this()
        {
            this._nombre = nombre;
        }
        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }


        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
            set
            {
                this._alumnos = value;
            }
        }
        public EMateria Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }


        public void CalificarAlumnos()
        {
            foreach(Alumno a in this.Alumnos)
            {
                a.Nota = Materia._notaParaUnAlumno.Next(1, 10);
            }
        }
        private string Mostrar()
        {
            StringBuilder materia = new StringBuilder();
            materia.AppendFormat("\nMateria: {0}\n", this.Nombre.ToString());
            materia.AppendLine("****************************************");//40 asteriscos
            materia.AppendLine("****************ALUMNOS*****************");
            foreach(Alumno a in this.Alumnos)
            {
                materia.AppendFormat("{0}\n", Alumno.Mostrar(a));
                materia.AppendLine("");
            }
            return materia.ToString();
        }

        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }
        public static implicit operator float(Materia materia)
        {
            float promedio = 0;
            float acumulador = 0;
            foreach (Alumno a in materia.Alumnos)
            {
                acumulador += a.Nota;
            }
            if (materia.Alumnos.Count > 0)
            {
                promedio = acumulador / materia.Alumnos.Count;
            }
            return promedio;
        }
        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);
        }


        public static bool operator ==(Materia m, Alumno a)
        {
            bool retBool = false;
            foreach (Alumno item in m.Alumnos)
            {
                if (item == a)
                {
                    retBool = true;
                    break;
                }
            }
            return retBool;
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }
        public static Materia operator +(Materia m, Alumno a)
        {
            if (m != a)
            {
                m.Alumnos.Add(a);
                Console.WriteLine("Se agrego el alumno a la materia {0}!!!!",m.Nombre.ToString());
            }
            else
            {
                Console.WriteLine("El alumno ya esta en la materia {0}!!!!",m.Nombre.ToString());
            }
            return m;
        }
        public static Materia operator -(Materia m, Alumno a)
        {
            if(m == a)
            {
                m.Alumnos.Remove(a);
                Console.WriteLine("Se quito el alumno de la materia {0}!!!!", m.Nombre.ToString());
            }
            else
            {
                Console.WriteLine("El alumno no esta en la materia {0}!!!!", m.Nombre.ToString());
            }
            return m;
        }
    }
}
