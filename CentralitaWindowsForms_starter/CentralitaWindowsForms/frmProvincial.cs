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
    public partial class frmProvincial : frmLlamada
    {
        public frmProvincial()
        {
            InitializeComponent();
            foreach(var item in Enum.GetValues(typeof(Franja)))
            {
                this.cboFranja.Items.Add(item.ToString());
            }
                
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Franja franja;
            this.llamadaActual = new Provincial
                (this.txtOrigen.Text,cboFranja.SelectedItem, float.Parse(this.txtDuracion.Text), this.txtDestino.Text);
            base.btnAceptar_Click(sender, e);
        }
    }
}
