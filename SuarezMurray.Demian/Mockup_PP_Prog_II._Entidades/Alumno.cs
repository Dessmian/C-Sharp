using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup_PP_Prog_II._Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        public Alumno (int legajo, string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._legajo = legajo;
        }
        public Alumno(string apellido, string nombre, int legajo) : this(legajo,nombre,apellido)
        {

        }
        public Alumno(string apellido, int legajo, string nombre) : this(legajo, nombre, apellido)
        {

        }
        public Alumno(int legajo, string nombre,  string apellido, float nota) : this(legajo, nombre, apellido)
        {
            this._nota = nota;
        }        
        public Alumno(float nota, int legajo, string nombre, string apellido) : this(legajo, nombre, apellido, nota)
        {

        }


        #region Propiedades
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }
        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public float Nota
        {
            get
            {
                return this._nota;
            }
            set
            {
                this._nota = value;
            }
        }
#endregion

        private string Mostrar()
        {
            StringBuilder alumno = new StringBuilder();
            alumno.AppendFormat("{0}, ", this.Apellido);
            alumno.AppendFormat("{0} - ", this.Nombre);
            alumno.AppendFormat("Legajo: {0} - ", this.Legajo);
            alumno.AppendFormat("Nota: {0}\r\n", this.Nota);

            return alumno.ToString();
        }
        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        { 
            return (a1.Legajo == a2.Legajo);
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
    }
}













