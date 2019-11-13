using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22.Entidades
{
    public class Empleado
    {
        public event LimiteSueldoMejorado limiteSueldoMejorado;
        public event LimiteSueldoDelegado limiteSueldo;
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Legajo = legajo;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if(value > 18000)
                {
                    if(this.limiteSueldo != null && this.limiteSueldoMejorado != null)
                    {
                        this.limiteSueldo(value, this);
                        if(value > 30000)
                        {
                            EmpleadoEventArgs args = new EmpleadoEventArgs();
                            args.SualdoAsignar = value;
                            this.limiteSueldoMejorado(this, args);
                        }
                    }
                    else if(this.limiteSueldo != null && this.limiteSueldoMejorado == null)
                    {
                        this.limiteSueldo(value, this);
                    }
                    else if(this.limiteSueldo == null && this.limiteSueldoMejorado != null)
                    {
                        if (value > 30000)
                        {
                            EmpleadoEventArgs args = new EmpleadoEventArgs();
                            args.SualdoAsignar = value;
                            this.limiteSueldoMejorado(this, args);
                        }
                    }
                }
                else
                {
                    this.sueldo = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder empleado = new StringBuilder();
            empleado.AppendFormat("{0} - {1} {2}", this.Legajo.ToString(),
                this.Nombre, this.Apellido);            
            return empleado.ToString();
        }
    }
}
