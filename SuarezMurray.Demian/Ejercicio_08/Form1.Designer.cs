namespace Ejercicio_08
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblPorHora = new System.Windows.Forms.Label();
            this.lblAntig = new System.Windows.Forms.Label();
            this.txtTenure = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(74, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(74, 142);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(328, 20);
            this.txtRate.TabIndex = 3;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(74, 87);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(328, 20);
            this.txtHoras.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(12, 90);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(57, 13);
            this.lblHoras.TabIndex = 7;
            this.lblHoras.Text = "Horas Tra.";
            // 
            // lblPorHora
            // 
            this.lblPorHora.AutoSize = true;
            this.lblPorHora.Location = new System.Drawing.Point(12, 145);
            this.lblPorHora.Name = "lblPorHora";
            this.lblPorHora.Size = new System.Drawing.Size(34, 13);
            this.lblPorHora.TabIndex = 8;
            this.lblPorHora.Text = "Tarifa";
            // 
            // lblAntig
            // 
            this.lblAntig.AutoSize = true;
            this.lblAntig.Location = new System.Drawing.Point(12, 195);
            this.lblAntig.Name = "lblAntig";
            this.lblAntig.Size = new System.Drawing.Size(61, 13);
            this.lblAntig.TabIndex = 9;
            this.lblAntig.Text = "Antiguedad";
            // 
            // txtTenure
            // 
            this.txtTenure.Location = new System.Drawing.Point(74, 192);
            this.txtTenure.Name = "txtTenure";
            this.txtTenure.Size = new System.Drawing.Size(328, 20);
            this.txtTenure.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(429, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 381);
            this.listBox1.TabIndex = 11;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTenure);
            this.Controls.Add(this.lblAntig);
            this.Controls.Add(this.lblPorHora);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblPorHora;
        private System.Windows.Forms.Label lblAntig;
        private System.Windows.Forms.TextBox txtTenure;
        private System.Windows.Forms.ListBox listBox1;
    }
}

