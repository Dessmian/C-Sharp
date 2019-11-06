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
    public partial class frmVisorPersona : Form
    {
        protected List<Persona> misPersonas;
        protected SqlConnection conexion;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.misPersonas = new List<Persona>();
        }
        public frmVisorPersona(SqlConnection connection)
            :this()
        {
            this.conexion = connection;
        }
        public frmVisorPersona(List<Persona> lista)
            :this()
        {
            this.misPersonas = lista;
            this.ActualizarLista();
        }
        public frmVisorPersona(List<Persona> lista, SqlConnection conection) 
            : this(lista)
        {
            this.conexion = conection;
        }

        public List<Persona> ListaPersonas
        {
            get
            {
                return this.misPersonas;
            }
        }
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

        protected virtual void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach(Persona persona in this.misPersonas)
            {
                this.lstVisor.Items.Add(persona.ToString());
            }
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            if(this.conexion != null)
            {
                frm.Conexion = this.conexion;
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                misPersonas.Add(frm.Persona);
                this.ActualizarLista();
            }
        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;
            frmPersona frm = new frmPersona(this.misPersonas.ElementAt(index));
            frm.Conexion = this.Conexion;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.misPersonas[index] = frm.Persona;
                this.lstVisor.Items[index] = frm.Persona.ToString();
            }
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;
            this.RemoveFromDB(index);
            this.misPersonas.RemoveAt(index);
            this.ActualizarLista();            
        }

        private void RemoveFromDB(int index)
        {
            Persona bufferPersona = this.misPersonas[index];
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM personas WHERE nombre = @nombre, " +
                "apellido = @apellido, edad = @edad");
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = this.conexion;
            sqlCommand.Parameters.AddWithValue("@nombre", bufferPersona.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", bufferPersona.apellido);
            sqlCommand.Parameters.AddWithValue("@edad", bufferPersona.edad.ToString());
            this.conexion.Open();
            sqlCommand.ExecuteNonQuery();
            this.conexion.Close();
        }
    }
}
