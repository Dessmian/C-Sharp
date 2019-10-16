using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoAutos.Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public int GetIndice(T a)
        {
            int index = -1, counter = 0;
            foreach(T item in this._lista)
            {
                if (item.Equals(a))
                {
                    index = counter;
                    break;
                }
                counter++;
            }
            return index;
        }
        public bool Agregar(T a)
        {
            if(this._capacidadMaxima > this._lista.Count())
            {
                if(this.GetIndice(a) == -1)
                {
                    this._lista.Add(a);
                    return true;
                }
            }
            return false;
        }
        public bool Remover(T a)
        {
            int index = this.GetIndice(a);
            if(index != -1)
            {
                this._lista.RemoveAt(index);
                return true;
            }
            return false;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            return d.Agregar(a);
        }
        public static bool operator -(Deposito<T> d, T a)
        {
            return d.Remover(a);
        }
        public override string ToString()
        {
            StringBuilder exitList = new StringBuilder();
            exitList.AppendFormat("Capacidad maxima: {0}\n", this._capacidadMaxima.ToString());
            exitList.AppendFormat("Lista de {0}:\n", typeof(T).Name);
            foreach (T item in this._lista)
            {
                exitList.AppendFormat("{0}\n", item.ToString());
            }
            return exitList.ToString();
        }
    }
}
