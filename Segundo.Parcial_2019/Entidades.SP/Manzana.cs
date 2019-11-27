using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.SP
{
    [XmlInclude(typeof(Manzana))]
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string _provinciaOrigen;

        public Manzana(string color, double peso, string origen)
            : base(color, peso)
        {
            this._provinciaOrigen = origen;
        }

        public Manzana()
            :base()
        {

        }

        public string Nombre
        {
            get
            {
                return "Manzana";
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
            string manzana = string.Format("{0} Carozo: {1} Origen: {2}", base.FrutaToString(),
                this.TieneCarozo.ToString(), this._provinciaOrigen);
            return manzana;
        }

        public bool Xml(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                     + "\\" + path);
                serializer.Serialize(writer, this);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool IDeserializar.Xml(string path, out Fruta frut)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                TextReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                     + @"\" + path);
                frut = (Manzana)serializer.Deserialize(reader);
                reader.Close();
                return true;
            }
            catch(Exception)
            {                
                frut = null;
                return false;
            }
        }
    }
}
//Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true