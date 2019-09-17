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
    public partial class frmTempera : Form
    {
        public Tempera t;

        public Tempera frmTempObj { get { return this.t; } }
        public frmTempera()
        {
            InitializeComponent();            
            this.StartPosition = FormStartPosition.CenterParent;
            foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cbColor.Items.Add(c);
            }
            this.cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbColor.SelectedItem = ConsoleColor.Magenta;
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {
            //this.t = new Tempera(ConsoleColor.Black, "asd", 2);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string bffMarca;
            ConsoleColor clrInput;
            int bffCantidad;
            bffMarca = this.txtMarca.Text;
            bffCantidad = int.Parse(this.txtCantidad.Text);
            clrInput = (ConsoleColor)this.cbColor.SelectedItem;
            Tempera buffer = new Tempera(clrInput, bffMarca, bffCantidad);
            this.t = buffer;
            //MessageBox.Show((string)this.t);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
