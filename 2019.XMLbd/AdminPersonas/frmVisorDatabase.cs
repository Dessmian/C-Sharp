﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Entidades;

namespace AdminPersonas
{
    class frmVisorDatabase : frmVisorPersona
    {
        private DataTable tabla;

        public frmVisorDatabase(DataTable tabla)
            : base ()
        {
            this.tabla = tabla;
            this.ActualizarLista();
            foreach(DataRow fila in this.Tabla.Rows)
            {
                this.misPersonas.Add(new Persona(fila[1].ToString(), fila[2].ToString(), 
                    int.Parse(fila[3].ToString())));
            }
        }

        public DataTable Tabla
        {
            get
            {
                return this.tabla;
            }
            set
            {
                this.tabla = value;
            }
        }        

        protected override void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            try
            {                
                StringBuilder stringPersona = new StringBuilder();
                foreach(DataRow dataRow in this.Tabla.Rows)
                {
                    if(dataRow.RowState != DataRowState.Deleted)
                    {
                        stringPersona.Clear();    
                        stringPersona.AppendFormat("{0} - ", dataRow[0]);
                        stringPersona.AppendFormat("{0} {1}, {2}", dataRow[1], dataRow[2], dataRow[3]);
                        this.lstVisor.Items.Add(stringPersona.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }            
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersona formPersona = new frmPersona();
                formPersona.ShowDialog();
                if(formPersona.DialogResult == DialogResult.OK)
                {
                    this.misPersonas.Add(formPersona.Persona);
                    DataRow fila = this.Tabla.NewRow();
                    fila[1] = formPersona.Persona.nombre;
                    fila[2] = formPersona.Persona.apellido;
                    fila[3] = formPersona.Persona.edad.ToString();
                    this.tabla.Rows.Add(fila);
                    this.ActualizarLista();
                    //MessageBox.Show(formPersona.Persona.ToString());
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message + "\nEn metodo btnAgregar_Click");
            }
        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int personaListIndex = this.lstVisor.SelectedIndex;
                int dataRowIndex = this.GetPersonRowIndex(personaListIndex);
                DataRow fila = this.tabla.Rows[dataRowIndex];
                frmPersona frmPersona = new frmPersona(this.misPersonas[personaListIndex]);
                frmPersona.ShowDialog();
                if(frmPersona.DialogResult == DialogResult.OK)
                {
                    fila[1] = frmPersona.Persona.nombre;
                    fila[2] = frmPersona.Persona.apellido;
                    fila[3] = frmPersona.Persona.edad.ToString();
                    this.misPersonas[personaListIndex].nombre = frmPersona.Persona.nombre;
                    this.misPersonas[personaListIndex].apellido = frmPersona.Persona.apellido;
                    this.misPersonas[personaListIndex].edad = frmPersona.Persona.edad;
                    this.ActualizarLista();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message + "\nEn metodo btnModificar_Click.");
            }
        }
        private int GetPersonRowIndex(int selectedIndex)
        {
            string item = this.lstVisor.Items[this.lstVisor.SelectedIndex].ToString();
            string indexPersona;
            int indexRow = 0;
            foreach (DataRow fila in this.tabla.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    indexPersona = "";
                    for (int i = 0; item[i].ToString() != " "; i++)
                    {
                        indexPersona += item[i];
                        if (i > 5)
                        {
                            break;
                        }
                    }
                    if (fila[0].ToString() == indexPersona)
                    {
                        return indexRow;                       
                    }
                }
                indexRow++;
            }
            return -1;
        }
        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string item = this.lstVisor.Items[this.lstVisor.SelectedIndex].ToString();
                this.misPersonas.RemoveAt(this.lstVisor.SelectedIndex);
                string index;
                foreach(DataRow fila in this.tabla.Rows)
                {
                    if (fila.RowState != DataRowState.Deleted)
                    {
                        index = "";
                        for (int i = 0; item[i].ToString() != " "; i++)
                        {
                            index += item[i];
                            if (i > 10)
                            {
                                break;
                            }
                        }
                        if (fila[0].ToString() == index)
                        {
                            fila.Delete();
                            break;
                        }
                    }
                }
                this.ActualizarLista();                
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message + "\nEn metodo btnEliminar_Click.");
            }
        }

        
    }
}
