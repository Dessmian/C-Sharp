using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtEntero.Text);
            string cadena = txtCadena.Text;
            DateTime fecha = DateTime.Parse(txtFecha.Text);
            //List<Cosa> lista1 = new List<Cosa>();
            Cosa input = new Cosa(numero,cadena,fecha);
            lstCosas.Items.Add(input.Mostrar());
            //lstCosas.Items.Add("");
            MessageBox.Show("Los datos de la cosa son: " + input.Mostrar());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Text = "";
            txtEntero.Text = "";
            txtFecha.Text = "";
            lstCosas.Items.Clear();
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.ForeColor = Color.White;
            //btnAzul.BackColor = Color.Red;
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            this.ForeColor = Color.Black;
        }
    }
}
