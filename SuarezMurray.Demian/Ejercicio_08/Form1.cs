using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nombre | Antiguedad | Por hora | Bruto | Neto");
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float rateBuffer, hoursBuffer;
            string nameBuffer;
            int tenureBuffer;
            rateBuffer = float.Parse(txtRate.Text);
            hoursBuffer = float.Parse(txtHoras.Text);
            nameBuffer = txtNombre.Text;
            tenureBuffer = int.Parse(txtTenure.Text);
            Employee input = new Employee(rateBuffer, nameBuffer, tenureBuffer, hoursBuffer);
            input.CalculateNetIncome();
            listBox1.Items.Add(input.Show());
        }

       
    }
}
