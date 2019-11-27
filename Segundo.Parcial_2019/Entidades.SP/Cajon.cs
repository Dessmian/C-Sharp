using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.SP
{
    //[XmlInclude(typeof(Cajon<typeof(T)>))]
    public class Cajon<T> : ISerializar
    {
        public delegate void EventoPrecio(double precio, EventArgs e);

        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        public event EventoPrecio eventoPrecio;

        public string Elementos
        {
            get
            {
                string elem = "";
                foreach(T item in this._elementos)
                {
                    elem += item.ToString() + "\n";
                }
                return elem;
            }
        }
        public double PrecioTotal
        {
            get
            {
                return (this._precioUnitario * this._elementos.Count);
            }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
            this.eventoPrecio += CajonEventArgs.EscrbirEnArchivo;
        }
        public Cajon(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }
        public Cajon( double precio,int capacidad)
            :this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public override string ToString()
        {
            string cajon = string.Format("Capacidad: {0}\nElementos: {1}\nPrecio: {2}",
                this._capacidad, this._elementos.Count, this.PrecioTotal);
            cajon += "\n" + this.Elementos;
            return cajon;
        }

        public bool Xml(string path)
        {
            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                + @"\" + path);
            XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
            serializer.Serialize(writer, this);
            writer.Close();
            return true;
        }

        public static Cajon<T> operator +(Cajon<T> c, T elemento)
        {
            if(c._capacidad > c._elementos.Count)
            {
                c._elementos.Add(elemento);
                if(c.PrecioTotal > 55)
                {
                    c.eventoPrecio(c.PrecioTotal, EventArgs.Empty);
                }
            }
            else
            {
                throw new CajonLlenoException();
            }
            return c;
        }
    }
}
//Crear la clase Cajon<T>
//atributos: _capacidad:int, _elementos:List<T> y _precioUnitario:double (todos protegidos)        
//Propiedades
//Elementos:(sólo lectura) expone al atributo de tipo List<T>.
//PrecioTotal:(sólo lectura) retorna el precio total del cajón (precio * cantidad de elementos).
//Constructor
//Cajon(), Cajon(int), Cajon(double, int); 
//El por default: es el único que se encargará de inicializar la lista.
//Métodos
//ToString: Mostrará en formato de tipo string, la capacidad, la cantidad total de elementos, el precio total 
//y el listado de todos los elementos contenidos en el cajón. Reutilizar código.
//Sobrecarga de operador
//(+) Será el encargado de agregar elementos al cajón, siempre y cuando no supere la capacidad del mismo.