using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;


namespace TPFinal_Colombano_Gabriel_P1
{
    public class GestorMaterias
    {
        string archivo = "Materias.txt";

        public void Alta(string materia)
        {
            if (File.ReadAllLines(archivo).Contains(materia))
            {
                return;
            }
            else
            {
                FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(materia);
                }
                fs.Close();
            }
        }


        public void Baja(string materia)
        {
            string nuevoarchivo = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string mat = linea;
                    if (materia != mat)
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
                    string materia2 = linea;
                    if (datoAnterior != materia2)
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

        public List<Materia> Lista()
        {
            List<Materia> lista = new List<Materia>();
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Materia materia = new Materia(linea);
                    lista.Add(materia);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return lista;
        }
    }
}
