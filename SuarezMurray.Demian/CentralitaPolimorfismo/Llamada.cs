using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }
        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public Llamada(float duracion, string nroOrigen, string nroDestino)
        {
            this._duracion = duracion;
            this._nroOrigen = nroOrigen;
            this._nroDestino = nroDestino;
        }

        protected virtual string Mostrar()
        {
            StringBuilder retString = new StringBuilder();
            retString.AppendFormat("Duracion: {0}, ", this.Duracion.ToString());
            retString.AppendFormat("Origen: {0}, ", this.NroOrigen);
            retString.AppendFormat("Destino: {0}, ", this.NroDestino);
            return retString.ToString();
        }

        public  static bool operator ==(Llamada uno, Llamada dos)
        {
            bool retBool = false;
            if (uno.Equals(dos))
            {
                if (uno.NroOrigen == dos.NroOrigen)
                {
                    if (uno.NroDestino == dos.NroDestino)
                    {
                        retBool = true;
                    }
                }
            }
            
            return retBool;
        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retInt = 0;
            if (uno.Duracion > dos.Duracion)
            {
                retInt = 1;
            }
            else if (uno.Duracion < dos.Duracion)
            {
                retInt = -1;
            }
            return retInt;
        }
    }
}










