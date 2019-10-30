using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using InterfazXML;

namespace Clase_20
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]
    public class Persona : IXML
    {
        public string nombre;
        public string apellido;
        private int edad;        

        public Persona()
        {
            
        }
        public Persona(string nom, string apel)
            :this()
        {
            this.nombre = nom;
            this.apellido = apel;
        }
        public Persona(string nombre, string apellido, int edad)
            :this(nombre, apellido)
        {
            this.edad = edad;
        }
        //public Persona(string nombre, string apellido, int edad)
        //    :this(nombre,apellido,edad)
        //{
            
        //}

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
        //public List<string> Apodos
        //{
        //    get
        //    {
        //        return this.apodos;
        //    }
        //    set
        //    {
        //        this.apodos = value;
        //    }
        //}

        public bool Guardar(string path)
        {
            try
            {                
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                StreamWriter streamWriter = new StreamWriter(path);
                xmlSerializer.Serialize(streamWriter, this);
                streamWriter.Close();
                return true;                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Leer(string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                StreamReader streamReader = new StreamReader(path);
                Persona buffer = (Persona)xmlSerializer.Deserialize(streamReader);
                this.nombre = buffer.nombre;
                this.apellido = buffer.apellido;
                this.edad = buffer.edad;
                streamReader.Close();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public override string ToString()
        {
            StringBuilder persona = new StringBuilder();
            persona.AppendFormat("\nNombre completo: {0}, {1}\n"
                , this.apellido, this.nombre);
            return persona.ToString();
        }

        
    }
}
