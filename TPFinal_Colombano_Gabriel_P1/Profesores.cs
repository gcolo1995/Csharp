using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_Colombano_Gabriel_P1
{
    public class Profesores
    {
        public Profesores() { }
        public Profesores(string linea)
        {
            string[] datos = linea.Split(',');
            this.Nombre = datos[0];
        }
        public string Nombre { get; set; }
        public string Generar()
        {
            return $"{Nombre}";
        }
    }
}