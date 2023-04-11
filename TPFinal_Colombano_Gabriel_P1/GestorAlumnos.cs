using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace TPFinal_Colombano_Gabriel_P1
{
    public class GestorAlumnos
    {
        string archivo = "Alumnos.txt";

        public void Alta(string alumno)
        {
            if (File.ReadAllLines(archivo).Contains(alumno))
            {
                return;
            }
            else
            {
                FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(alumno);
                }
                fs.Close();
            }
        }


        public void Baja(string alumno)
        {
            string nuevoarchivo = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string alumno2 = linea;
                    if (alumno != alumno2)
                    {
                        nuevoarchivo += linea + Environment.NewLine;
                    }
                    linea = sr.ReadLine();
                }
            }
            fs.Close();
            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter wr = new StreamWriter(fs))
            {
                wr.Write(nuevoarchivo);
            }
        }


        public void Modificar(string datoAnterior, string datoNuevo)
        {
            string nuevoarchivo = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string alumno2 = linea;
                    if (datoAnterior != alumno2)
                    {
                        nuevoarchivo += linea + Environment.NewLine;
                    }
                    else
                    {
                        nuevoarchivo += datoNuevo + Environment.NewLine;
                    }
                    linea = sr.ReadLine();
                }
            }
            fs.Close();
            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter wr = new StreamWriter(fs))
            {
                wr.Write(nuevoarchivo);
            }
        }

        public List<Alumnos> Lista()
        {
            List<Alumnos> lista = new List<Alumnos>();
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumnos alumnos = new Alumnos(linea);
                    lista.Add(alumnos);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return lista;
        }

    }
}