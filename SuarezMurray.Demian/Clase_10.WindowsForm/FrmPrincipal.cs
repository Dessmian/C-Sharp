using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_10.WindowsForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void catedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatedra nuevaCatedra = new FrmCatedra();
            nuevaCatedra.MdiParent = this;
            //nuevaCatedra.Dock = DockStyle.Left;
            nuevaCatedra.Show();
        }

        private void gbContenedor_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}


/*
 * Completar primeras dos partes
 */