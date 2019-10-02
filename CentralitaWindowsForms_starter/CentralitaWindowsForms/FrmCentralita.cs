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
    public partial class FrmCentralita : Form
    {
        private Centralita centralTelefonica;

        public FrmCentralita()
        {
            InitializeComponent();
            this.centralTelefonica = new Centralita();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLlamada llamada = new frmLocal();
            llamada.StartPosition = FormStartPosition.CenterScreen;
            llamada.ShowDialog();

            if(llamada.DialogResult == DialogResult.OK)
            {
                this.lstVisor.Items.Add(llamada.MiLlamada.ToString());
            }
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            frmLlamada llamada = new frmProvincial();
            llamada.StartPosition = FormStartPosition.CenterScreen;
            llamada.ShowDialog();

            if (llamada.DialogResult == DialogResult.OK)
            {
                this.lstVisor.Items.Add(llamada.MiLlamada.ToString());
            }
        }
    }
}



/*
 * FRMLlamada
 * (protected) miLlamada Llamada
 * (+) miLlamada Llamada (S / L) //Propiedad
 * 
 * (protected) btnAceptar_Click  //el boton debe ser virtual 
 *      {dialog result ok}
 * (protected) btnCancelar_Click
 * 
 * FRMProvincial
 * //Agregar combo box con franjas
 * btnAceptar_Click override
 *      {reutilizar codigo}
 * 
 * FRMLocal
 * //Agregar text box para el costo
 * 
 * 
 */