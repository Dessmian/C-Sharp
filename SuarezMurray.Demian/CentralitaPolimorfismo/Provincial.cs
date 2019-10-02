using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(Franja miFranja, Llamada unaLlamada)
            :this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {
            
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,origen,destino)
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
            bool retBool = false;
            if (obj is Provincial)
            {
                retBool = true;
            }
            return retBool;
        }

        protected override string Mostrar()
        {
            StringBuilder llamadaProvincialString = new StringBuilder();
            llamadaProvincialString.AppendFormat("{0}", base.Mostrar());
            llamadaProvincialString.AppendFormat("Costo: {0} ", this.CalcularCosto().ToString());
            llamadaProvincialString.AppendFormat("Franja: {0}", this._franjaHoraria.ToString());
            return llamadaProvincialString.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
