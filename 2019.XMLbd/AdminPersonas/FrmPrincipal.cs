using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Data.SqlClient;

using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorDeArchivo = new OpenFileDialog();
            selectorDeArchivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            selectorDeArchivo.Title = "Selector de archivo";
            selectorDeArchivo.DefaultExt = ".xml";            
            selectorDeArchivo.FileName = "MisPersonas";            
            selectorDeArchivo.ShowDialog();
            StreamReader streamReader = new StreamReader(selectorDeArchivo.OpenFile());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
            this.lista =(List<Persona>) xmlSerializer.Deserialize(streamReader);
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorDeArchivo = new SaveFileDialog();
            selectorDeArchivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            selectorDeArchivo.Title = "Selector de archivo";
            selectorDeArchivo.DefaultExt = ".xml";
            //selectorDeArchivo.Filter = "Archivos xml (*.xml)";
            selectorDeArchivo.FileName = "MisPersonas";
            selectorDeArchivo.CheckFileExists = false;
            selectorDeArchivo.ShowDialog();
            StreamWriter streamWriter = new StreamWriter(selectorDeArchivo.OpenFile());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
            xmlSerializer.Serialize(streamWriter, this.lista);
            //MessageBox.Show(selectorDeArchivo.FileName);            
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVisorPersona frm = new frmVisorPersona(this.lista);
                frm.StartPosition = FormStartPosition.CenterScreen;                
                frm.Show();
                this.lista = frm.ListaPersonas;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);//Conexion = nombre recurso
                conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conexion;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = ("SELECT TOP 1000 [id] ,[nombre] ,[apellido] ,[edad] FROM[personas_bd].[dbo].[personas]");
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read() != false)
                {
                    Persona buffer = new Persona(
                        (string)sqlDataReader["nombre"], (string)sqlDataReader["apellido"], (int)sqlDataReader["edad"]);
                    this.lista.Add(buffer);
                    MessageBox.Show(buffer.ToString());
                }
                MessageBox.Show("Se creo la conexion!");
                conexion.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
