using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPFinal_Colombano_Gabriel_P1
{
    public partial class FormCursos : Form
    {
        GestorAlumnos alumnos = new GestorAlumnos();
        GestorMaterias materias = new GestorMaterias();
        GestorProfesores profesores = new GestorProfesores();
        GestorCurso cursos = new GestorCurso();


        public FormCursos()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompletarTodosLosDatos();
        }

        #region Salir_LimpiarCajas
        private void btnSalir_Click(object sender, EventArgs e)
        {
            dataGridView1 = null;
            this.Close();
        }

        private void bntLimpiarCajas_Click(object sender, EventArgs e)
        {
            comboBoxMat.Text = string.Empty;
            comboBoxProf.Text = string.Empty;
            comboBoxAlumno.Text = string.Empty;
        }
        #endregion#region Salir_LimpiarCajas

        #region Alta_Baja_Modificacion
        private void btnAltaMat_Click(object sender, EventArgs e)
        {
            string nuevaMat = comboBoxMat.Text;
            if (comboBoxMat.FindString(nuevaMat) == -1)
            {
                materias.Alta(nuevaMat);
                CompletarMaterias();
            }
            comboBoxMat.Text = string.Empty;

        }

        private void btnBajaMat_Click(object sender, EventArgs e)
        {
            string bajaMat = comboBoxMat.Text;
            int i = comboBoxMat.FindString(bajaMat);
            if (i != -1)
            {
                materias.Baja(bajaMat);
                cursos.Actualizar(bajaMat, bajaMat, 0);
                CompletarMaterias();
                CompletarDatagrid();
            }
            comboBoxMat.Text = string.Empty;

        }

        private void btnModificarMat_Click(object sender, EventArgs e)
        {
            string materiaAModificar = comboBoxMat.Text;
            FormModifica formModifica = new FormModifica(materiaAModificar);

            if (formModifica.ShowDialog() == DialogResult.OK)
            {
                string datoActualizado = formModifica.datoModificado;
                materias.Modificar(materiaAModificar, datoActualizado);
                cursos.Actualizar(materiaAModificar, datoActualizado, 0);
                CompletarMaterias();
                CompletarDatagrid();

            }
            comboBoxMat.Text = string.Empty;

        }

        private void btnAltaProf_Click(object sender, EventArgs e)
        {
            string nuevoProf = comboBoxProf.Text;
            if (comboBoxProf.FindString(nuevoProf) == -1)
            {
                profesores.Alta(nuevoProf);
                CompletarProf();
            }
            comboBoxProf.Text = string.Empty;

        }

        private void btnBajaProf_Click(object sender, EventArgs e)
        {
            string bajaProf = comboBoxProf.Text;
            int i = comboBoxProf.FindString(bajaProf);
            if (i != -1)
            {
                profesores.Baja(bajaProf);
                CompletarProf();
                cursos.Actualizar(bajaProf, bajaProf, 1);
                CompletarDatagrid();
            }
            comboBoxProf.Text = string.Empty;
        }

        private void btnModificarProf_Click(object sender, EventArgs e)
        {
            string profesorAModificar = comboBoxProf.Text;
            FormModifica formModifica = new FormModifica(profesorAModificar);
            if (formModifica.ShowDialog() == DialogResult.OK)
            {
                string datoActualizado = formModifica.datoModificado;
                profesores.Modificar(profesorAModificar, datoActualizado);
                CompletarProf();
                cursos.Actualizar(profesorAModificar, datoActualizado, 1);
                CompletarDatagrid();
            }
            comboBoxProf.Text = string.Empty;

        }

        private void btnAltaAlumno_Click(object sender, EventArgs e)
        {
            string nuevoAlumno = comboBoxAlumno.Text;
            if (comboBoxAlumno.FindString(nuevoAlumno) == -1)
            {
                alumnos.Alta(nuevoAlumno);
                CompletarAlumnos();
            }
            comboBoxAlumno.Text = string.Empty;

        }

        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            string bajaAlumno = comboBoxAlumno.Text;
            int i = comboBoxAlumno.FindString(bajaAlumno);
            if (i != -1)
            {
                alumnos.Baja(bajaAlumno);
                CompletarAlumnos();
                cursos.Actualizar(bajaAlumno, bajaAlumno, 2);
                CompletarDatagrid();
            }
            comboBoxAlumno.Text = string.Empty;
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            string alumnoAModificar = comboBoxAlumno.Text;
            FormModifica formModifica = new FormModifica(alumnoAModificar);
            if (formModifica.ShowDialog() == DialogResult.OK)
            {
                string datoActualizado = formModifica.datoModificado;
                alumnos.Modificar(alumnoAModificar, datoActualizado);
                CompletarAlumnos();
                cursos.Actualizar(alumnoAModificar, datoActualizado, 2);
                CompletarDatagrid();
            }
            comboBoxAlumno.Text = string.Empty;
        }

        #endregion Alta_Baja_Modificacion

        #region Inscribir_Desinscribir
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if(comboBoxAlumno.Text == string.Empty || comboBoxMat.Text == string.Empty || comboBoxProf.Text == string.Empty)
            {
            }
            else
            {
                string Materia = comboBoxMat.Text;
                materias.Alta(Materia);
                string Profesor = comboBoxProf.Text;
                profesores.Alta(Profesor);
                string Alumno = comboBoxAlumno.Text;
                alumnos.Alta(Alumno);

                Curso curso = new Curso
                {
                    Materia = comboBoxMat.Text,
                    Profesor = comboBoxProf.Text,
                    Alumno = comboBoxAlumno.Text,
                };
                cursos.Inscribir(curso);
                CompletarTodosLosDatos();
                comboBoxMat.Text = Materia;
                comboBoxProf.Text = Profesor;
                comboBoxAlumno.Text = string.Empty;
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            Curso seleccionado = (Curso)this.dataGridView1.SelectedRows[0].DataBoundItem;
            cursos.Desinscribir(seleccionado);
            CompletarDatagrid();
            comboBoxAlumno.Text = string.Empty;            
        }
        #endregion Inscribir_Desinscribir

        #region Actualizar_Datos_en_Tablas
        private void CompletarTodosLosDatos()
        {
            CompletarDatagrid();
            CompletarMaterias();
            CompletarProf();
            CompletarAlumnos();
        }

        private void CompletarDatagrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = cursos.Lista();
        }

        private void CompletarMaterias()
        {
            this.comboBoxMat.DataSource = null;
            this.comboBoxMat.DataSource = materias.Lista();
            this.comboBoxMat.DisplayMember = "Nombre";

            this.cmbMat2.DataSource = null;
            this.cmbMat2.DataSource = materias.Lista();
            this.cmbMat2.DisplayMember = "Nombre";
        }

        private void CompletarProf()
        {
            this.comboBoxProf.DataSource = null;
            this.comboBoxProf.DataSource = profesores.Lista();
            this.comboBoxProf.DisplayMember = "Nombre";

            this.cmbProf2.DataSource = null;
            this.cmbProf2.DataSource = profesores.Lista();
            this.cmbProf2.DisplayMember = "Nombre";
        }

        private void CompletarAlumnos()
        {
            this.comboBoxAlumno.DataSource = null;
            this.comboBoxAlumno.DataSource = alumnos.Lista();
            this.comboBoxAlumno.DisplayMember = "Nombre";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxMat.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxProf.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxAlumno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        #endregion Actualizar_Datos_en_Tablas

        private void btnListarCurso_Click(object sender, EventArgs e)
        {
            string materiaAListar = cmbMat2.Text;
            string profesorAListar = cmbProf2.Text;
            ListarCurso formListarCurso = new ListarCurso(materiaAListar, profesorAListar,
                cursos.alumnosCurso(materiaAListar, profesorAListar));
            formListarCurso.Show();
        }
    }
}
