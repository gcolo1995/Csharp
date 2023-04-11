using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal_Colombano_Gabriel_P1
{
    public partial class ListarCurso : Form
    {
        
        public ListarCurso(string MateriasList, string ProfesoresList, string[] AlumnosList)
        {
            InitializeComponent();
            txtMat2.Text = MateriasList;
            txtProf2.Text = ProfesoresList;
            var alumnos = AlumnosList.Select(a => new { Nombre = a }).ToList();
            dataGridAlumnos.DataSource = alumnos;
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
