namespace CentralitaWindowsForms
{
    partial class frmProvincial
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
            this.lblFranja = new System.Windows.Forms.Label();
            this.cboFranja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblFranja
            // 
            this.lblFranja.AutoSize = true;
            this.lblFranja.Location = new System.Drawing.Point(12, 168);
            this.lblFranja.Name = "lblFranja";
            this.lblFranja.Size = new System.Drawing.Size(42, 13);
            this.lblFranja.TabIndex = 8;
            this.lblFranja.Text = "Franja: ";
            // 
            // cboFranja
            // 
            this.cboFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFranja.FormattingEnabled = true;
            this.cboFranja.Location = new System.Drawing.Point(15, 184);
            this.cboFranja.Name = "cboFranja";
            this.cboFranja.Size = new System.Drawing.Size(188, 21);
            this.cboFranja.TabIndex = 9;
            // 
            // frmProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 257);
            this.Controls.Add(this.cboFranja);
            this.Controls.Add(this.lblFranja);
            this.Name = "frmProvincial";
            this.Text = "frmProvincial";
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.txtOrigen, 0);
            this.Controls.SetChildIndex(this.txtDestino, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.lblFranja, 0);
            this.Controls.SetChildIndex(this.cboFranja, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFranja;
        private System.Windows.Forms.ComboBox cboFranja;
    }
}