namespace TPFinal_Colombano_Gabriel_P1
{
    partial class FormCursos
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
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnAltaMat = new System.Windows.Forms.Button();
            this.btnAltaProf = new System.Windows.Forms.Button();
            this.btnAltaAlumno = new System.Windows.Forms.Button();
            this.btnBajaMat = new System.Windows.Forms.Button();
            this.btnBajaProf = new System.Windows.Forms.Button();
            this.btnBajaAlumno = new System.Windows.Forms.Button();
            this.btnModificarMat = new System.Windows.Forms.Button();
            this.btnModificarProf = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntLimpiarCajas = new System.Windows.Forms.Button();
            this.comboBoxMat = new System.Windows.Forms.ComboBox();
            this.comboBoxProf = new System.Windows.Forms.ComboBox();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.btnListarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMat2 = new System.Windows.Forms.ComboBox();
            this.cmbProf2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(12, 26);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(61, 13);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "MATERIA: ";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(12, 114);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(84, 13);
            this.lblProf.TabIndex = 1;
            this.lblProf.Text = "PROFESOR/A: ";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(12, 201);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(68, 13);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "ALUMNO/A:";
            // 
            // btnAltaMat
            // 
            this.btnAltaMat.Location = new System.Drawing.Point(14, 57);
            this.btnAltaMat.Name = "btnAltaMat";
            this.btnAltaMat.Size = new System.Drawing.Size(65, 24);
            this.btnAltaMat.TabIndex = 6;
            this.btnAltaMat.Text = "Alta";
            this.btnAltaMat.UseVisualStyleBackColor = true;
            this.btnAltaMat.Click += new System.EventHandler(this.btnAltaMat_Click);
            // 
            // btnAltaProf
            // 
            this.btnAltaProf.Location = new System.Drawing.Point(15, 147);
            this.btnAltaProf.Name = "btnAltaProf";
            this.btnAltaProf.Size = new System.Drawing.Size(65, 24);
            this.btnAltaProf.TabIndex = 7;
            this.btnAltaProf.Text = "Alta";
            this.btnAltaProf.UseVisualStyleBackColor = true;
            this.btnAltaProf.Click += new System.EventHandler(this.btnAltaProf_Click);
            // 
            // btnAltaAlumno
            // 
            this.btnAltaAlumno.Location = new System.Drawing.Point(15, 233);
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(65, 24);
            this.btnAltaAlumno.TabIndex = 8;
            this.btnAltaAlumno.Text = "Alta";
            this.btnAltaAlumno.UseVisualStyleBackColor = true;
            this.btnAltaAlumno.Click += new System.EventHandler(this.btnAltaAlumno_Click);
            // 
            // btnBajaMat
            // 
            this.btnBajaMat.Location = new System.Drawing.Point(95, 57);
            this.btnBajaMat.Name = "btnBajaMat";
            this.btnBajaMat.Size = new System.Drawing.Size(65, 24);
            this.btnBajaMat.TabIndex = 9;
            this.btnBajaMat.Text = "Baja";
            this.btnBajaMat.UseVisualStyleBackColor = true;
            this.btnBajaMat.Click += new System.EventHandler(this.btnBajaMat_Click);
            // 
            // btnBajaProf
            // 
            this.btnBajaProf.Location = new System.Drawing.Point(95, 147);
            this.btnBajaProf.Name = "btnBajaProf";
            this.btnBajaProf.Size = new System.Drawing.Size(65, 24);
            this.btnBajaProf.TabIndex = 10;
            this.btnBajaProf.Text = "Baja";
            this.btnBajaProf.UseVisualStyleBackColor = true;
            this.btnBajaProf.Click += new System.EventHandler(this.btnBajaProf_Click);
            // 
            // btnBajaAlumno
            // 
            this.btnBajaAlumno.Location = new System.Drawing.Point(95, 233);
            this.btnBajaAlumno.Name = "btnBajaAlumno";
            this.btnBajaAlumno.Size = new System.Drawing.Size(65, 24);
            this.btnBajaAlumno.TabIndex = 11;
            this.btnBajaAlumno.Text = "Baja";
            this.btnBajaAlumno.UseVisualStyleBackColor = true;
            this.btnBajaAlumno.Click += new System.EventHandler(this.btnBajaAlumno_Click);
            // 
            // btnModificarMat
            // 
            this.btnModificarMat.Location = new System.Drawing.Point(179, 57);
            this.btnModificarMat.Name = "btnModificarMat";
            this.btnModificarMat.Size = new System.Drawing.Size(65, 24);
            this.btnModificarMat.TabIndex = 12;
            this.btnModificarMat.Text = "Modificar";
            this.btnModificarMat.UseVisualStyleBackColor = true;
            this.btnModificarMat.Click += new System.EventHandler(this.btnModificarMat_Click);
            // 
            // btnModificarProf
            // 
            this.btnModificarProf.Location = new System.Drawing.Point(179, 147);
            this.btnModificarProf.Name = "btnModificarProf";
            this.btnModificarProf.Size = new System.Drawing.Size(65, 24);
            this.btnModificarProf.TabIndex = 13;
            this.btnModificarProf.Text = "Modificar";
            this.btnModificarProf.UseVisualStyleBackColor = true;
            this.btnModificarProf.Click += new System.EventHandler(this.btnModificarProf_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(179, 233);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(65, 24);
            this.btnModificarAlumno.TabIndex = 14;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(15, 272);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(103, 36);
            this.btnInscribir.TabIndex = 15;
            this.btnInscribir.Text = "INSCRIBIR";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarBaja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDarBaja.Location = new System.Drawing.Point(141, 272);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(103, 36);
            this.btnDarBaja.TabIndex = 16;
            this.btnDarBaja.Text = "DESINSCRIBIR";
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(141, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 76);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 332);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bntLimpiarCajas
            // 
            this.bntLimpiarCajas.Location = new System.Drawing.Point(15, 324);
            this.bntLimpiarCajas.Name = "bntLimpiarCajas";
            this.bntLimpiarCajas.Size = new System.Drawing.Size(103, 45);
            this.bntLimpiarCajas.TabIndex = 25;
            this.bntLimpiarCajas.Text = "LIMPIAR CAJAS";
            this.bntLimpiarCajas.UseVisualStyleBackColor = true;
            this.bntLimpiarCajas.Click += new System.EventHandler(this.bntLimpiarCajas_Click);
            // 
            // comboBoxMat
            // 
            this.comboBoxMat.FormattingEnabled = true;
            this.comboBoxMat.Location = new System.Drawing.Point(97, 18);
            this.comboBoxMat.Name = "comboBoxMat";
            this.comboBoxMat.Size = new System.Drawing.Size(147, 21);
            this.comboBoxMat.TabIndex = 28;
            // 
            // comboBoxProf
            // 
            this.comboBoxProf.FormattingEnabled = true;
            this.comboBoxProf.Location = new System.Drawing.Point(97, 106);
            this.comboBoxProf.Name = "comboBoxProf";
            this.comboBoxProf.Size = new System.Drawing.Size(147, 21);
            this.comboBoxProf.TabIndex = 29;
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(97, 193);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(147, 21);
            this.comboBoxAlumno.TabIndex = 30;
            // 
            // btnListarCurso
            // 
            this.btnListarCurso.Location = new System.Drawing.Point(545, 18);
            this.btnListarCurso.Name = "btnListarCurso";
            this.btnListarCurso.Size = new System.Drawing.Size(114, 48);
            this.btnListarCurso.TabIndex = 31;
            this.btnListarCurso.Text = "LISTAR \r\nCURSO";
            this.btnListarCurso.UseVisualStyleBackColor = true;
            this.btnListarCurso.Click += new System.EventHandler(this.btnListarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "MATERIA: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "PROFESOR/A: ";
            // 
            // cmbMat2
            // 
            this.cmbMat2.FormattingEnabled = true;
            this.cmbMat2.Location = new System.Drawing.Point(391, 18);
            this.cmbMat2.Name = "cmbMat2";
            this.cmbMat2.Size = new System.Drawing.Size(147, 21);
            this.cmbMat2.TabIndex = 34;
            // 
            // cmbProf2
            // 
            this.cmbProf2.FormattingEnabled = true;
            this.cmbProf2.Location = new System.Drawing.Point(391, 45);
            this.cmbProf2.Name = "cmbProf2";
            this.cmbProf2.Size = new System.Drawing.Size(147, 21);
            this.cmbProf2.TabIndex = 35;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 417);
            this.Controls.Add(this.cmbProf2);
            this.Controls.Add(this.cmbMat2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarCurso);
            this.Controls.Add(this.comboBoxAlumno);
            this.Controls.Add(this.comboBoxProf);
            this.Controls.Add(this.comboBoxMat);
            this.Controls.Add(this.bntLimpiarCajas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.btnModificarProf);
            this.Controls.Add(this.btnModificarMat);
            this.Controls.Add(this.btnBajaAlumno);
            this.Controls.Add(this.btnBajaProf);
            this.Controls.Add(this.btnBajaMat);
            this.Controls.Add(this.btnAltaAlumno);
            this.Controls.Add(this.btnAltaProf);
            this.Controls.Add(this.btnAltaMat);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblMateria);
            this.Name = "FormCursos";
            this.Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnAltaMat;
        private System.Windows.Forms.Button btnAltaProf;
        private System.Windows.Forms.Button btnAltaAlumno;
        private System.Windows.Forms.Button btnBajaMat;
        private System.Windows.Forms.Button btnBajaProf;
        private System.Windows.Forms.Button btnBajaAlumno;
        private System.Windows.Forms.Button btnModificarMat;
        private System.Windows.Forms.Button btnModificarProf;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntLimpiarCajas;
        private System.Windows.Forms.ComboBox comboBoxMat;
        private System.Windows.Forms.ComboBox comboBoxProf;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.Button btnListarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMat2;
        private System.Windows.Forms.ComboBox cmbProf2;
    }
}

