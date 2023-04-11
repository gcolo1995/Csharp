namespace TPFinal_Colombano_Gabriel_P1

{
    partial class FormModifica
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
            this.lblDatoAnterior = new System.Windows.Forms.Label();
            this.lblDatoNuevo = new System.Windows.Forms.Label();
            this.txtDatoAnterior = new System.Windows.Forms.TextBox();
            this.txtDatoNuevo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatoAnterior
            // 
            this.lblDatoAnterior.AutoSize = true;
            this.lblDatoAnterior.Location = new System.Drawing.Point(21, 20);
            this.lblDatoAnterior.Name = "lblDatoAnterior";
            this.lblDatoAnterior.Size = new System.Drawing.Size(69, 13);
            this.lblDatoAnterior.TabIndex = 0;
            this.lblDatoAnterior.Text = "Dato Anterior";
            // 
            // lblDatoNuevo
            // 
            this.lblDatoNuevo.AutoSize = true;
            this.lblDatoNuevo.Location = new System.Drawing.Point(21, 46);
            this.lblDatoNuevo.Name = "lblDatoNuevo";
            this.lblDatoNuevo.Size = new System.Drawing.Size(85, 13);
            this.lblDatoNuevo.TabIndex = 1;
            this.lblDatoNuevo.Text = "Dato Modificado";
            // 
            // txtDatoAnterior
            // 
            this.txtDatoAnterior.Location = new System.Drawing.Point(112, 17);
            this.txtDatoAnterior.Name = "txtDatoAnterior";
            this.txtDatoAnterior.Size = new System.Drawing.Size(136, 20);
            this.txtDatoAnterior.TabIndex = 2;
            // 
            // txtDatoNuevo
            // 
            this.txtDatoNuevo.Location = new System.Drawing.Point(112, 43);
            this.txtDatoNuevo.Name = "txtDatoNuevo";
            this.txtDatoNuevo.Size = new System.Drawing.Size(136, 20);
            this.txtDatoNuevo.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 78);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 29);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(138, 78);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 124);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDatoNuevo);
            this.Controls.Add(this.txtDatoAnterior);
            this.Controls.Add(this.lblDatoNuevo);
            this.Controls.Add(this.lblDatoAnterior);
            this.Name = "FormModifica";
            this.Text = "Modificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatoAnterior;
        private System.Windows.Forms.Label lblDatoNuevo;
        private System.Windows.Forms.TextBox txtDatoAnterior;
        private System.Windows.Forms.TextBox txtDatoNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}