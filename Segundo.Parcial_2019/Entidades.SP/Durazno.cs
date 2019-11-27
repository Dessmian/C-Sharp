using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public Durazno(string color, double peso, int pelusa)
            : base(color, peso)
        {
            this._cantPelusa = pelusa;
        }

        public string Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public override string ToString()
        {
            string durazno = string.Format("{0} Caroso: {1} Pelusa: {2}", base.FrutaToString(),
                this.TieneCarozo.ToString(), this._cantPelusa.ToString());
            return durazno;
        }

    }
}
//Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true