using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24.Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = dni;
        }

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public string Apellido
        {
            get => this.apellido;
            set => this.apellido = value;
        }
        public int DNI
        {
            get => this.edad;
            set => this.edad = value;
        }

        public string ObtenerInfo()
        {
            StringBuilder persona = new StringBuilder();            
            persona.AppendFormat("{0} {1} {2}", this.Nombre, this.Apellido, this.DNI);            
            return persona.ToString();
        }
    }
}
