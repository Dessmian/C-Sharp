using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.SP
{
    public class CajonEventArgs : EventArgs
    {
        public static void EscrbirEnArchivo(double precio, EventArgs e)
        {
            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                + @"\" + "cajones.txt");
            writer.Write(string.Format("[{0}] \n {1} \n", DateTime.Now.ToString(), precio.ToString(), true));
            writer.Close();
        }
    }
}
