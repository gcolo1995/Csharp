using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TPFinal_Colombano_Gabriel_P1
{
    public class GestorProfesores
    {
        string archivo = "Profesores.txt";

        public void Alta(string profesor)
        {
            if (File.ReadAllLines(archivo).Contains(profesor))
            {
                return;
            }
            else
            {
                FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(profesor);
                }
                fs.Close();
            }

        }


        public void Baja(string profesor)
        {
            string nuevoarchivo = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string profe = linea;
                    if (profesor != profe)
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
                    string profesor2 = linea;
                    if (datoAnterior != profesor2)
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

        public List<Profesores> Lista()
        {
            List<Profesores> lista = new List<Profesores>();
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Profesores profesores = new Profesores(linea);
                    lista.Add(profesores);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return lista;
        }
    }
}