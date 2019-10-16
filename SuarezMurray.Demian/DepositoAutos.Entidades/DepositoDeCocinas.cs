using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoAutos.Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public bool Agregar(Cocina c)
        {
            if(this._capacidadMaxima > this._lista.Count())
            {
                if (this.GetIndice(c) == -1)
                {
                    this._lista.Add(c);
                    return true;
                }
            }
            return false;
        }
        public bool Remover(Cocina c)
        {
            int index = this.GetIndice(c);
            if (index != -1)
            {
                this._lista.RemoveAt(index);
                return true;
            }
            return false;
        }
        private int GetIndice(Cocina c)
        {
            int index = -1, counter = 0;
            foreach(Cocina item in this._lista)
            {
                if (item == c)
                {
                    index = counter;
                    break;
                }
                counter++;
            }
            return index;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Capacidad maxima: {0}\n", this._capacidadMaxima.ToString());
            builder.AppendLine("Listado de cocinas");
            foreach(Cocina item in this._lista)
            {
                builder.AppendFormat("{0}\n", item.ToString());
            }
            return builder.ToString();
        }
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            return d.Agregar(c);
        }
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            return d.Remover(c);
        }
    }
}
