namespace TPFinal_Colombano_Gabriel_P1
{
    partial class ListarCurso
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
            this.lblMateria2 = new System.Windows.Forms.Label();
            this.lblProfesor2 = new System.Windows.Forms.Label();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.txtMat2 = new System.Windows.Forms.TextBox();
            this.txtProf2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMateria2
            // 
            this.lblMateria2.AutoSize = true;
            this.lblMateria2.Location = new System.Drawing.Point(12, 19);
            this.lblMateria2.Name = "lblMateria2";
            this.lblMateria2.Size = new System.Drawing.Size(55, 13);
            this.lblMateria2.TabIndex = 2;
            this.lblMateria2.Text = "MATERIA";
            // 
            // lblProfesor2
            // 
            this.lblProfesor2.AutoSize = true;
            this.lblProfesor2.Location = new System.Drawing.Point(12, 59);
            this.lblProfesor2.Name = "lblProfesor2";
            this.lblProfesor2.Size = new System.Drawing.Size(78, 13);
            this.lblProfesor2.TabIndex = 3;
            this.lblProfesor2.Text = "PROFESOR/A";
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Location = new System.Drawing.Point(15, 93);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.ReadOnly = true;
            this.dataGridAlumnos.Size = new System.Drawing.Size(210, 245);
            this.dataGridAlumnos.TabIndex = 4;
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(69, 349);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(97, 36);
            this.btnSalir2.TabIndex = 5;
            this.btnSalir2.Text = "SALIR";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // txtMat2
            // 
            this.txtMat2.Location = new System.Drawing.Point(89, 17);
            this.txtMat2.Name = "txtMat2";
            this.txtMat2.Size = new System.Drawing.Size(131, 20);
            this.txtMat2.TabIndex = 6;
            // 
            // txtProf2
            // 
            this.txtProf2.Location = new System.Drawing.Point(89, 56);
            this.txtProf2.Name = "txtProf2";
            this.txtProf2.Size = new System.Drawing.Size(131, 20);
            this.txtProf2.TabIndex = 7;
            // 
            // FormListarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 397);
            this.Controls.Add(this.txtProf2);
            this.Controls.Add(this.txtMat2);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.dataGridAlumnos);
            this.Controls.Add(this.lblProfesor2);
            this.Controls.Add(this.lblMateria2);
            this.Name = "FormListarCurso";
            this.Text = "Listado Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMateria2;
        private System.Windows.Forms.Label lblProfesor2;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.TextBox txtMat2;
        private System.Windows.Forms.TextBox txtProf2;
    }
}