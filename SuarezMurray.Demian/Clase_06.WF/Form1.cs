using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_06.WF
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera actualFrm = new frmTempera();
            //actualFrm.MdiParent = this;
            actualFrm.ShowDialog();
            if (actualFrm.DialogResult == DialogResult.OK)
            {
                this.listBox1.Items.Add((string)actualFrm.MiTempera);
            }
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paleta nPaleta;
            this.gbPaleta.Visible = true;
            this.paletaToolStripMenuItem.Click -= paletaToolStripMenuItem_Click;
        }

        private void gbPaleta_Enter(object sender, EventArgs e)
        {
            this.gbPaleta.Visible = false;
        }
    }
}
