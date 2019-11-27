using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public Banana(string color, double peso, string origen)
            : base (color, peso)
        {
            this._paisOrigen = origen;
        }

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }

        public string Nombre
        {
            get
            {
                return "Banana";
            }
        }

        public override string ToString()
        {
            string banana = string.Format("{0} Carozo: {1} Origen: {2}", base.FrutaToString(),
                this.TieneCarozo.ToString(), this._paisOrigen);
            return banana;
        }
    }
}
//Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false