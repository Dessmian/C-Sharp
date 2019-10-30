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

namespace AdminPersonas
{
    public partial class frmPersona : Form
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
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
