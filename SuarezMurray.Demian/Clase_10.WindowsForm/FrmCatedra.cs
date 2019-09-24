using Clase_10.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clase_10.WindowsForm
{
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;
        private List<AlumnoCalificado> alumnosCalificados;

        public FrmCatedra()
        {
            InitializeComponent();
            this.btnModificar.Enabled = false;
            this.btnCalificar.Enabled = false;
            this.catedra = new Catedra();
            this.alumnosCalificados = new List<AlumnoCalificado>();
            foreach (ETipoOrdenamiento ord in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenamientos.Items.Add(ord);
            }
        }

        private void FrmCatedra_Load(object sender, EventArgs e)
        {

        }

        private void lbAlumnos_Resize(object sender, EventArgs e)
        {
            
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            FrmAlumno nwFrmAlumno = new FrmAlumno();
            nwFrmAlumno.ShowDialog();
            if (nwFrmAlumno.DialogResult == DialogResult.OK)
            {
                if(this.catedra + nwFrmAlumno.Alumno)
                {
                    this.ActualizarListaAlumnos();
                }
            }
        }
        private void ActualizarListaAlumnos()
        {
            this.lbAlumnos.Items.Clear();                
            foreach(Alumno almn in this.catedra.Alumnos)
            {
                this.lbAlumnos.Items.Add(almn.ToString());            //(Alumno.Mostrar(almn));
            }
        }

        private void cmbOrdenamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Se hizo click");
            string bufferOrdenamiento = this.cmbOrdenamientos.Text;
            List<Alumno> bufferCatedra = this.catedra.Alumnos;
            switch(bufferOrdenamiento)
            {
                case "LegajoAscendiente":
                    //bufferCatedra = this.catedra.Alumnos;             //no me gusta como quedo pero no encuentro
                    bufferCatedra.Sort(Alumno.OrdenarPorLegajoAsc);     //manera de operar directamente sobre la
                    //this.catedra.Alumnos = bufferCatedra;             //lista dado que el atributo alumnos es
                    //this.ActualizarListaAlumnos();                               //privado
                    break;                                              
                case "LegajoDescendiente":
                    bufferCatedra.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                case "ApellidoAscendiente":
                    bufferCatedra.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case "ApellidoDescendiente":
                    bufferCatedra.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
                default:
                    break;
            }
            this.catedra.Alumnos = bufferCatedra;
            this.ActualizarListaAlumnos();                                 
        }

        private void cmbOrdenamientos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se hizo click");
        }

        private void lbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lbAlumnos.SelectedIndex;
            if (index == -1)
            {
                this.btnModificar.Enabled = false;
                this.btnCalificar.Enabled = false;
            }
            else
            {
                this.btnModificar.Enabled = true;
                this.btnCalificar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lbAlumnos.SelectedIndex;
            if(index != -1)
            {
                FrmAlumno mdFrmAlumno = new FrmAlumno();
                List<Alumno> bufferAlumnos;
                bufferAlumnos = this.catedra.Alumnos;
                mdFrmAlumno.Alumno = bufferAlumnos.ElementAt(index);
                mdFrmAlumno.ShowDialog();
                if (mdFrmAlumno.DialogResult == DialogResult.OK)
                {
                    bufferAlumnos[index] = mdFrmAlumno.Alumno;
                    this.catedra.Alumnos = bufferAlumnos;
                    this.ActualizarListaAlumnos();
                }
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            int index = this.lbAlumnos.SelectedIndex;
            if (index != -1)
            {
                FrmAlumnoCalificado frmCalificar = new FrmAlumnoCalificado(this.catedra.Alumnos[index]);
                frmCalificar.ShowDialog();
                if (frmCalificar.DialogResult == DialogResult.OK)
                {
                    this.catedra.Alumnos.RemoveAt(index);
                    this.alumnosCalificados.Add(frmCalificar.AlumnoCalificado);
                    this.ActualizarListaAlumnos();
                    this.ActualizarListaAlumnosCalificados();
                }
            }
        }
        
        private void ActualizarListaAlumnosCalificados()
        {
            this.lbAlumnosCalificados.Items.Clear();
            foreach (AlumnoCalificado almn in this.alumnosCalificados)
            {
                this.lbAlumnosCalificados.Items.Add(almn.ToString());
            }
        }
    }
}
