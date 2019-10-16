using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoAutos.Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public bool Agregar(Auto a)
        {
            bool retVal = false;
            if (this._capacidadMaxima > this._lista.Count)
            {
                if (this.GetIndice(a) == -1)
                {
                    this._lista.Add(a);
                    retVal = true;
                }
            }
                return retVal;
        }
        private int GetIndice(Auto a)
        {
            int index = -1, count = 0;
            foreach(Auto item in this._lista)
            {
                if (a == item)
                {
                    index = count;
                    break;
                }
                count++;
            }
            return index;
        }
        public bool Remover(Auto a)
        {
            bool retVal = false;
            int index = this.GetIndice(a);
            if (index != -1)
            {
                this._lista.RemoveAt(index);
                retVal = true;
            }
            return retVal;
        }

        public override string ToString()
        {
            StringBuilder exitList = new StringBuilder();
            exitList.AppendFormat("Capacidad maxima: {0}\n", this._capacidadMaxima.ToString());
            exitList.AppendLine("Lista de autos: ");
            foreach(Auto item in this._lista)
            {
                exitList.AppendFormat("{0}\n",item.ToString());
            }
            return exitList.ToString();
        }
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            return d.Agregar(a);
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            return d.Remover(a);
        }
    }
}
