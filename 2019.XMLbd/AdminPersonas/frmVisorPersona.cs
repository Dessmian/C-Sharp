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
    public partial class frmVisorPersona : Form
    {
        private List<Persona> misPersonas;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.misPersonas = new List<Persona>();
        }
        public frmVisorPersona(List<Persona> lista)
            :this()
        {
            this.misPersonas = lista;
            this.ActualizarLista();
        }

        public List<Persona> ListaPersonas
        {
            get
            {
                return this.misPersonas;
            }
        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach(Persona persona in this.misPersonas)
            {
                this.lstVisor.Items.Add(persona.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                misPersonas.Add(frm.Persona);
                this.ActualizarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;
            frmPersona frm = new frmPersona(this.misPersonas.ElementAt(index));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.misPersonas[index] = frm.Persona;
                this.lstVisor.Items[index] = frm.Persona.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;
            //frmPersona frm = new frmPersona();
            //frm.StartPosition = FormStartPosition.CenterScreen;
            this.misPersonas.RemoveAt(index);
            this.ActualizarLista();            
        }
    }
}
