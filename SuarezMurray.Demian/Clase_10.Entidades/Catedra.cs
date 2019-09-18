using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
        }

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retBool = false;
            foreach(Alumno aInstance in c.Alumnos)
            {
                if (aInstance == a)
                {
                    retBool = true;
                }
            }
            return retBool;
        }
        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }
        public static int operator | (Catedra c, Alumno a)
        {
            int i = -1;
            if (c.Alumnos.Count > 0)
            {
                i = 0;
                foreach (Alumno aInstance in c.Alumnos)
                {
                    if (aInstance == a)
                    {
                        break;
                    }
                    i++;
                }
            }            
            return i;
        }
        public static bool operator +(Catedra c, Alumno a)
        {
            bool retBool = false;
            if (c != a)
            {
                c.alumnos.Add(a);
                retBool = true;
            }
            return retBool;
        }
        public static bool operator -(Catedra c, Alumno a)
        {
            bool retBool = false;
            int i = c | a;
            if (i>=0)
            {
                c.alumnos.RemoveAt(i);
            }
            return retBool;
        }
    }
}
