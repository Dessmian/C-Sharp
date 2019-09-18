using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10.WindowsForm
{
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;

        public FrmCatedra()
        {
            InitializeComponent();            
            this.catedra = new Catedra();
        }

        private void FrmCatedra_Load(object sender, EventArgs e)
        {

        }
    }
}
