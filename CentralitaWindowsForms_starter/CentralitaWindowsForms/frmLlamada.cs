using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo;

namespace CentralitaWindowsForms
{
    public partial class frmLlamada : Form
    {
        protected Llamada llamadaActual;

        public Llamada MiLlamada
        {
            get
            {
                return this.llamadaActual;
            }
        }

        public frmLlamada()
        {
            InitializeComponent();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.OK;
        }
    }
}
