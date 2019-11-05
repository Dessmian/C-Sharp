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
        private Persona miPersona;
        private SqlConnection conexion;

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
        public frmPersona(SqlConnection conexion) : this()
        {
            this.Conexion = conexion;
        }
        public frmPersona()
        {
            InitializeComponent();            
        }
        public frmPersona(Persona persona)
            :this()
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
                this.miPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtEdad.Text));
                if (!(this.Conexion.Equals(null)))
                {
                    MessageBox.Show("Tengo conexion!");
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
    }
}
