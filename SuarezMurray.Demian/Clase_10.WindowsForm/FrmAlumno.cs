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
    public partial class FrmAlumno : Form
    {
        private Alumno bufferAlumno;

        public Alumno Alumno
        {
            get
            {
                return this.bufferAlumno;
            }
            set
            {
                this.bufferAlumno = value;
                this.txtApellido.Text = bufferAlumno.Apellido;
                this.txtNombre.Text = bufferAlumno.Nombre;
                this.txtLegajo.Text = bufferAlumno.Legajo.ToString();
                this.cmbTipoExamen.SelectedItem = bufferAlumno.Examen;
                this.txtLegajo.Enabled = false;
            }
        }

        public FrmAlumno()
        {
            InitializeComponent();
            foreach (ETipoExamen ex in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.cmbTipoExamen.SelectedItem = ETipoExamen.Primero;
            string bufferApellido, bufferNombre, bufferStringLegajo;
            int bufferLegajo;
            ETipoExamen bufferExamen;
            bufferNombre = this.txtNombre.Text;
            bufferApellido = this.txtApellido.Text;
            bufferStringLegajo = this.txtLegajo.Text;
            bufferExamen = (ETipoExamen)cmbTipoExamen.SelectedItem;
            if (int.TryParse(bufferStringLegajo, out bufferLegajo))
            {
                this.bufferAlumno = new Alumno(bufferApellido, bufferNombre, bufferLegajo, bufferExamen);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
