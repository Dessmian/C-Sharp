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
        private SqlConnection conexion;
        private DataTable tablaPersonas;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            this.CargarDataTable();
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
                frm.Conexion = this.conexion;
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
                this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);//Conexion = nombre recurso (seteado en propiedades del proyecto)
                MessageBox.Show("Se creo la conexion!");                
                //conexion.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion))
                //{
                //    conexion.Open();
                //    SqlCommand command = new SqlCommand("INSERT INTO[personas_bd].[dbo].[personas] (nombre, apellido, edad)" +
                //        "VALUES (@nombre, @apellido, @edad)");
                //    command.CommandType = CommandType.Text;
                //    command.Connection = conexion;
                //    //command.Parameters.AddWithValue("@nombre", )
                    
                //}
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.conexion.Open();//abro la conexion
            SqlCommand sqlCommand = new SqlCommand();//instacion sqlcommand - el cual me permite realizar una transaccion sql
            sqlCommand.Connection = this.conexion;//le asigno la conexion a sql command
            sqlCommand.CommandType = CommandType.Text;//le indico que lo que se tranfiere es texto
            sqlCommand.CommandText = ("SELECT TOP 1000 [id] ,[nombre] ,[apellido] ,[edad] FROM[personas_bd].[dbo].[personas]");
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//leo la base de datos y guardo el contenido en sqlDataReader
            while (sqlDataReader.Read() != false)//leo los datos tomados
            {
                Persona buffer = new Persona(
                    (string)sqlDataReader["nombre"], (string)sqlDataReader["apellido"], (int)sqlDataReader["edad"]);
                this.lista.Add(buffer);//creo una nueva persona por cada fila que lei
                                       MessageBox.Show(buffer.ToString());
            }
            this.conexion.Close();
        }

        private void CargarDataTable()
        {
            this.tablaPersonas = new DataTable("personas");            
            this.conexion.Open();//abro la conexion
            SqlCommand sqlCommand = new SqlCommand();//instacion sqlcommand - el cual me permite realizar una transaccion sql
            sqlCommand.Connection = this.conexion;//le asigno la conexion a sql command
            sqlCommand.CommandType = CommandType.Text;//le indico que lo que se tranfiere es texto
            sqlCommand.CommandText = ("SELECT * FROM personas");
            SqlDataReader dataReader = sqlCommand.ExecuteReader();//leo la base de datos y guardo el contenido en sqlDataReader
            this.tablaPersonas.Load(dataReader);
            this.conexion.Close();            
        }

    }
}
