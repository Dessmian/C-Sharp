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

        private Paleta mainPaleta;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.gbPaleta.Visible = false;
            this.lbPaleta.Visible = false;
            this.btnAdd.Visible = false;
            this.btnSubtract.Visible = false;
            mainPaleta = 5;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera actualFrm = new frmTempera();
            //actualFrm.MdiParent = this;
            actualFrm.ShowDialog();
            if (actualFrm.DialogResult == DialogResult.OK)
            {
                //this.lbPaleta.Items.Add((string)actualFrm.frmTempObj);
                //this.lbPaleta.Items.Add("se presiono ok");
            }
            else
            {
                //this.lbPaleta.Items.Add("Se presiono cancelar");
            }
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPaleta = 5;
            this.gbPaleta.Visible = true;            
            this.btnAdd.Visible = true;
            this.btnSubtract.Visible = true;
            this.lbPaleta.Visible = true;
            this.paletaToolStripMenuItem.Click -= paletaToolStripMenuItem_Click;
        }

        private void gbPaleta_Enter(object sender, EventArgs e)
        {
            //this.gbPaleta.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTempera nwTempera = new frmTempera();
            nwTempera.ShowDialog();
            if (nwTempera.DialogResult==DialogResult.OK)
            {
                 /*
                MessageBox.Show((string)this.mainPaleta.colores[0]);
                MessageBox.Show((string)this.mainPaleta.colores[1]);
                MessageBox.Show((string)this.mainPaleta.colores[2]);
                MessageBox.Show((string)this.mainPaleta.colores[3]);
                MessageBox.Show((string)this.mainPaleta.colores[4]);*/
                //this.lbPaleta.Items.Add((string)nwTempera.frmTempObj);
                this.mainPaleta += nwTempera.t;
                MessageBox.Show((string)this.mainPaleta);
            }            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lbPaleta.Items.Remove(lbPaleta.SelectedItem);
        }
    }
}
