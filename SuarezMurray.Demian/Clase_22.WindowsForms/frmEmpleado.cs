using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_22.Entidades;

namespace Clase_22.WindowsForms
{
    public partial class frmEmpleado : Form
    {
        private Empleado empleado;

        public frmEmpleado()
        {
            InitializeComponent();
            foreach(var item in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(item);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text,
                    int.Parse(txtLegajo.Text));
                switch (this.cmbManejador.Text)
                {
                    case "LimiteSueldo":
                        this.empleado.limiteSueldo += ManejadorLimiteSueldo;
                        break;
                    case "LimiteSueldoMejorado":
                        this.empleado.limiteSueldoMejorado += ManejadorLimiteSueldoMejorado;
                        break;
                    case "Todos":
                        this.empleado.limiteSueldo += ManejadorLimiteSueldo;
                        this.empleado.limiteSueldoMejorado += ManejadorLimiteSueldoMejorado2;
                        break;
                    default:
                        break;
                }
                this.empleado.Sueldo = double.Parse(txtSueldo.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtLegajo.Clear();
            this.txtSueldo.Clear();            
        }

        private void ManejadorLimiteSueldo(double sueldo, Empleado emp)
        {            
            MessageBox.Show(emp.ToString() + "\nIntento ingresar un sueldo de " +
                sueldo.ToString() + "\nDetectado por ManejadorLimiteSueldo");
        }
        private static void ManejadorLimiteSueldoMejorado(Empleado sender, EmpleadoEventArgs e)
        {
            MessageBox.Show(sender.ToString() + "\nIntento ingresar un sueldo de " +
                 e.SualdoAsignar.ToString() + "\nDetectado por ManejadorLimiteSueldoMejorado");
        }
        private void ManejadorLimiteSueldoMejorado2(Empleado sender, EmpleadoEventArgs e)
        {
            frmEmpleado.ManejadorLimiteSueldoMejorado(sender, e);
        }
    }
}
