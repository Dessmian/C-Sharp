using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Local:Llamada
    {
        protected float _costo;

        public Local (float costo, Llamada unaLlamada)
            :this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {

        }
        public Local (string origen,float duracion, string destino, float costo)
            :base(duracion,origen,destino)
        {
            this._costo = costo;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.Duracion * this._costo;  //Tarifas pendientes
        }        

        public override bool Equals(object obj)
        {
            bool retBool = false;
            if(obj is Local)
            {
                retBool = true;
            }
            return retBool;
        }

        protected new string Mostrar()
        {
            StringBuilder blder = new StringBuilder();
            blder.AppendFormat("{0}", base.Mostrar());
            blder.AppendFormat("Costo: {0}", this.CostoLlamada.ToString());
            return blder.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
