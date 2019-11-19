using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Clase_24.Entidades
{
    public class PersonaHeredada : PersonaExterna
    {
        public PersonaHeredada(string nombre, string apellido, int edad, ESexo sexo)
            : base(nombre, apellido, edad, sexo)
        {

        }

        public string Nombre
        {
            get => this._nombre;
            set => this._nombre = value;
        }
        public string Apellido
        {
            get => this._apellido;
            set => this._apellido = value;
        }
        public int Edad
        {
            get => this._edad;
            set => this._edad = value;
        }
        public ESexo Sexo
        {
            get => this._sexo;
            set => this._sexo = value;
        }

        public string ObtenerInfo()
        {
            return this.Nombre + " " + this.Apellido + " " + this.Edad.ToString() + " " + this.Sexo.ToString();
        }
    }
}
