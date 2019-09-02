using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int number) : this ()
        {
            this.entero = number;
            //this.cadena = "Sin Valor";
            //this.fecha = DateTime.Now;
        }
        public Cosa(string str) : this()
        {
            //this.entero = -1;
            this.cadena = str;
            //this.fecha = DateTime.Now;
        }
        public Cosa(string str, DateTime dat) : this(str)
        {
            //this.entero = -1;
            //this.cadena = str;
            this.fecha = dat;
        }
        public Cosa(int number, string str, DateTime dat) : this(str,dat)
        {
            this.entero = number;
            //this.cadena = str;
            //this.fecha = dat;
        }
        public string Mostrar()
        {
            return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToString() + "\n";
        }
        public void EstablecerValor(int entr)
        {
            this.entero = entr;
        }
        public void EstablecerValor(string str)
        {
            this.cadena = str;
        }
        public void EstablecerValor(DateTime dat)
        {
            this.fecha = dat;
        }
    }
}
