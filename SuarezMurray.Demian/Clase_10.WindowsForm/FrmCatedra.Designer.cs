namespace Clase_10.WindowsForm
{
    partial class FrmCatedra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAlumnos = new System.Windows.Forms.GroupBox();
            this.cmbOrdenamientos = new System.Windows.Forms.ComboBox();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.grbAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.lbAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.grbAlumnos.SuspendLayout();
            this.grbAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAlumnos
            // 
            this.grbAlumnos.AutoSize = true;
            this.grbAlumnos.Controls.Add(this.cmbOrdenamientos);
            this.grbAlumnos.Controls.Add(this.lbAlumnos);
            this.grbAlumnos.Controls.Add(this.btnCalificar);
            this.grbAlumnos.Controls.Add(this.btnModificar);
            this.grbAlumnos.Controls.Add(this.btnAgragar);
            this.grbAlumnos.Location = new System.Drawing.Point(12, 12);
            this.grbAlumnos.Name = "grbAlumnos";
            this.grbAlumnos.Size = new System.Drawing.Size(776, 359);
            this.grbAlumnos.TabIndex = 0;
            this.grbAlumnos.TabStop = false;
            this.grbAlumnos.Text = "Alumnos";
            // 
            // cmbOrdenamientos
            // 
            this.cmbOrdenamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamientos.FormattingEnabled = true;
            this.cmbOrdenamientos.Location = new System.Drawing.Point(12, 319);
            this.cmbOrdenamientos.Name = "cmbOrdenamientos";
            this.cmbOrdenamientos.Size = new System.Drawing.Size(744, 21);
            this.cmbOrdenamientos.TabIndex = 4;
            this.cmbOrdenamientos.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenamientos_SelectedIndexChanged);
            this.cmbOrdenamientos.Click += new System.EventHandler(this.cmbOrdenamientos_Click);
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.HorizontalScrollbar = true;
            this.lbAlumnos.Location = new System.Drawing.Point(12, 55);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(744, 238);
            this.lbAlumnos.TabIndex = 3;
            this.lbAlumnos.SelectedIndexChanged += new System.EventHandler(this.lbAlumnos_SelectedIndexChanged);
            this.lbAlumnos.Resize += new System.EventHandler(this.lbAlumnos_Resize);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(680, 20);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(346, 20);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgragar
            // 
            this.btnAgragar.Location = new System.Drawing.Point(12, 20);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(75, 23);
            this.btnAgragar.TabIndex = 0;
            this.btnAgragar.Text = "Agregar";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // grbAlumnosCalificados
            // 
            this.grbAlumnosCalificados.AutoSize = true;
            this.grbAlumnosCalificados.Controls.Add(this.lbAlumnosCalificados);
            this.grbAlumnosCalificados.Location = new System.Drawing.Point(12, 374);
            this.grbAlumnosCalificados.Name = "grbAlumnosCalificados";
            this.grbAlumnosCalificados.Size = new System.Drawing.Size(776, 274);
            this.grbAlumnosCalificados.TabIndex = 5;
            this.grbAlumnosCalificados.TabStop = false;
            this.grbAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // lbAlumnosCalificados
            // 
            this.lbAlumnosCalificados.FormattingEnabled = true;
            this.lbAlumnosCalificados.Location = new System.Drawing.Point(21, 37);
            this.lbAlumnosCalificados.Name = "lbAlumnosCalificados";
            this.lbAlumnosCalificados.Size = new System.Drawing.Size(735, 199);
            this.lbAlumnosCalificados.TabIndex = 4;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.grbAlumnosCalificados);
            this.Controls.Add(this.grbAlumnos);
            this.Name = "FrmCatedra";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmCatedra_Load);
            this.grbAlumnos.ResumeLayout(false);
            this.grbAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAlumnos;
        private System.Windows.Forms.ComboBox cmbOrdenamientos;
        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.GroupBox grbAlumnosCalificados;
        private System.Windows.Forms.ListBox lbAlumnosCalificados;
    }
}