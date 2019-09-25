using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(Franja miFranja, Llamada unaLlamada)
            :this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion,origen,destino)
        {
            this._franjaHoraria = miFranja;
        }
        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float retFloat = 0;
            switch(this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retFloat =(float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    retFloat = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    retFloat = (float)(this.Duracion * 0.66);
                    break;
                default:
                    break;
            }
            return retFloat;
        }
        #endregion


        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            return this.ToString();
        }
        public override string ToString()
        {
            StringBuilder bldr = new StringBuilder();
            bldr.AppendFormat("{0}", base.Mostrar());
            bldr.AppendFormat("Franja: {0}", this._franjaHoraria.ToString());
            return bldr.ToString();
        }
    }
}
