using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TPFinal_Colombano_Gabriel_P1

{
    public class GestorCurso
    {
        string archivo = "Cursos.txt";
        
        public void Inscribir(Curso linea)
        {
            bool registroExiste = false; 
            using (StreamReader sr = new StreamReader(archivo))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == linea.Generar())
                    {
                        registroExiste = true;
                        break;
                    }
                }
            }
            if (!registroExiste) 
            {
                FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(linea.Generar());
                }
                fs.Close();
            }
        }

        public void Desinscribir(Curso curso)
        {
            string nuevoarchivo = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string nuevocurso = linea;
                    if (curso.Generar() != nuevocurso)
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

        public void Actualizar(string datoViejo, string datoNuevo, int indice)
        {
            string nuevoarchivo = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length > indice && campos[indice] == datoViejo)
                    {
                        if (datoViejo == datoNuevo) 
                        {
                        }
                        else
                        {
                            campos[indice] = datoNuevo;
                            linea = string.Join(",", campos);
                        }
                    }

                    if (campos.Length <= indice || campos[indice] != datoViejo)
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

        public string[] alumnosCurso(string mat, string prof)
        {
            List<string> alumnosEncontrados = new List<string>();

            using (StreamReader sr = new StreamReader(archivo))
            {
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] campos = linea.Split(',');

                    if (campos[0] == mat && campos[1] == prof)
                    {
                        alumnosEncontrados.Add(campos[2]);
                    }
                }
            }
            return alumnosEncontrados.ToArray();
        }


        public List<Curso> Lista()
        {
            List<Curso> lista = new List<Curso>();
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Curso curso = new Curso(linea);
                    lista.Add(curso);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return lista;
        }
    }
}
