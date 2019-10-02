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
    public partial class frmLocal : frmLlamada
    {
        public frmLocal()
        {
            InitializeComponent();
        }

        private new void btnAceptar_Click(object sender, EventArgs e)
        {
            this.llamadaActual = new Local(
                txtOrigen.Text, float.Parse(txtDuracion.Text), txtDestino.Text, float.Parse(txtCosto.Text));
            base.btnAceptar_Click(sender,e);
        }
    }
}
