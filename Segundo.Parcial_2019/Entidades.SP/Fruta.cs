using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get; }

        protected Fruta()
        {

        }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            string fruta = string.Format("Color: {0} Peso: {1}", this._color, this._peso.ToString());
            return fruta;
        }
    }
}
//Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
//constructor con 2 parametros y FrutaToString():string (protegido y virtual, retorna los valores de la fruta)