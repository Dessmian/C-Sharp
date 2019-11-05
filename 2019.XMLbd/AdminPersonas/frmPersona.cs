using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmPersona : Form
    {
        public enum Modo
        {
            Nuevo,
            Modificar
        }

        private Persona miPersona;
        private SqlConnection conexion;
        private Modo modo;

        public SqlConnection Conexion
        {
            get
            {
                return this.conexion;
            }
            set
            {
                this.conexion = value;
            }
        }

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }
        public frmPersona()
        {
            InitializeComponent();
        }
        private frmPersona(Modo modo) : this()
        {
            this.modo = modo;
        }
        public frmPersona(SqlConnection conexion) : this(Modo.Nuevo)
        {
            this.Conexion = conexion;
        }
        public frmPersona(Persona persona)
            :this(Modo.Modificar)
        {            
            this.miPersona = persona;
            this.txtNombre.Text = miPersona.nombre;
            this.txtApellido.Text = miPersona.apellido;
            this.txtEdad.Text = miPersona.edad.ToString();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.modo == Modo.Nuevo)
                {
                    this.miPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtEdad.Text));
                    this.NewPersona();
                }
                else if (this.modo == Modo.Modificar)
                {
                    this.ModPersona();
                }
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception exc)
            {
                this.DialogResult = DialogResult.Retry;
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NewPersona()
        {
            if (!(this.Conexion.Equals(null)))
            {
                //MessageBox.Show("Tengo conexion!");
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO[personas_bd].[dbo].[personas] (nombre, apellido, edad)" +
                        "VALUES (@nombre, @apellido, @edad)");
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = this.Conexion;
                sqlCommand.Parameters.AddWithValue("@nombre", this.miPersona.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", this.miPersona.apellido);
                sqlCommand.Parameters.AddWithValue("@edad", this.miPersona.edad.ToString());
                this.Conexion.Open();
                sqlCommand.ExecuteNonQuery();
                this.Conexion.Close();
            }
        }
        private void ModPersona()
        {
            Persona bufferPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text,
                int.Parse(this.txtEdad.Text));
            if (!(this.Conexion.Equals(null)))
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Personas SET nombre = @newNombre, apellido = @newApellido, "
                    + " edad = @newEdad WHERE nombre = @oldNombre AND apellido = @oldApellido "
                    + "AND edad = @oldEdad");
                sqlCommand.Connection = this.conexion;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@newNombre", bufferPersona.nombre);
                sqlCommand.Parameters.AddWithValue("@newApellido", bufferPersona.apellido);
                sqlCommand.Parameters.AddWithValue("@newEdad", bufferPersona.edad.ToString());
                sqlCommand.Parameters.AddWithValue("@oldNombre", this.miPersona.nombre);
                sqlCommand.Parameters.AddWithValue("@oldApellido", this.miPersona.apellido);
                sqlCommand.Parameters.AddWithValue("@oldEdad", this.miPersona.edad.ToString());
                this.conexion.Open();
                sqlCommand.ExecuteNonQuery();
                this.conexion.Close();
            }
            this.miPersona = bufferPersona;
        }
    }
}
