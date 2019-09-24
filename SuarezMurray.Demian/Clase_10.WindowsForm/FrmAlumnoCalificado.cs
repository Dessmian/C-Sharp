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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado alumnoCalificado;        
        public FrmAlumnoCalificado(Alumno alumnoACalificar)
        {
            InitializeComponent();
            this.Alumno = alumnoACalificar;
            this.DeshabilitarCasillas();
            
        }
        public AlumnoCalificado AlumnoCalificado
        {
            get
            {
                return this.alumnoCalificado;
            }
        }        

        private void FrmAlumnoCalificado_Load(object sender, EventArgs e)
        {

        }

        private void DeshabilitarCasillas()
        {
            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbTipoExamen.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int nota = int.Parse(this.txtNota.Text);
            if (nota > 0 && nota < 11)
            {
                this.alumnoCalificado = new AlumnoCalificado(this.Alumno, nota);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
