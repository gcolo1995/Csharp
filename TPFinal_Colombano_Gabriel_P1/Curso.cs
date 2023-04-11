using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_Colombano_Gabriel_P1
{
    public class Curso
    {
        public Curso() { }
        public Curso(string linea)
        {
            string[] datos = linea.Split(',');
            this.Materia = datos[0];
            this.Profesor = datos[1];
            this.Alumno = datos[2];
        }
        public string Materia { get; set; }
        public string Profesor { get; set; }
        public string Alumno { get; set; }
        public string Generar()
        {
            return $"{Materia},{Profesor},{Alumno}";
        }
    }
}