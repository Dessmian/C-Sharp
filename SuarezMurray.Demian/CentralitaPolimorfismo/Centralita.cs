using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonsocial;

        public Centralita() : this("Default") { }
        public Centralita(string nombreEmpresa)
        {
            this._listaDeLlamadas = new List<Llamada>();
            this._razonsocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retFloat = 0;
            foreach(Llamada item in this._listaDeLlamadas)
            {
                switch(tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            retFloat += item.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            retFloat += item.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        retFloat += item.CostoLlamada;
                        break;
                }
            }
            return retFloat;
        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retbool = false;
            int i = central._listaDeLlamadas.Count;
            foreach(Llamada item in central._listaDeLlamadas)
            {
                if (item == nuevaLlamada)
                {
                    break;
                }
                i--;
            }
            if (i==0)
            {
                retbool = true;
            }
            return retbool;
        }
        public static bool operator !=(Centralita central,Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }
        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central!=nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            return central;
        }

        private string Mostrar()
        {
            string retString = this._razonsocial + " Llamadas: \n";
            foreach(Llamada item in this._listaDeLlamadas)
            {
                retString += item.ToString() + "\n";
            }
            return retString;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public void OrdenarLlamadas()
        {
            int i, j, comp;
            Llamada buffer;
            for (i = 0; i < this._listaDeLlamadas.Count -1; i++)
            {
                for (j = i+1; j< this._listaDeLlamadas.Count; j++)
                {
                    comp = Llamada.OrdenarPorDuracion(this._listaDeLlamadas[i], this._listaDeLlamadas[j]);
                    if (comp > 1)
                    {
                        buffer = this._listaDeLlamadas[i];
                        this._listaDeLlamadas[i] = this._listaDeLlamadas[j];
                        this._listaDeLlamadas[j] = buffer;
                    }
                }
            }
        }
    }
}
