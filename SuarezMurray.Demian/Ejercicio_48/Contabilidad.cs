using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new() 
    {
        private List<T> Egresos;
        private List<U> Ingresos;

        public Contabilidad()
        {
            this.Egresos = new List<T>();
            this.Ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.Egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T,U> operator -(Contabilidad<T,U> c, U ingreso)
        {
            c.Ingresos.Add(ingreso);
            return c;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Egresos: ");
            foreach(T item in this.Egresos)
            {
                str.AppendFormat("{0}\n", item.ToString());
            }
            str.AppendLine("Ingresos: ");
            foreach(U item in this.Ingresos)
            {
                str.AppendFormat("{0}\n", item.ToString());
            }
            return str.ToString();
        }
    }
}
