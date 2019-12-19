using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(!string.IsNullOrEmpty(archivo) && !(datos is null))
            {
                bool append = File.Exists(Path.Combine(desktop, archivo));
                StreamWriter sw = new StreamWriter(Path.Combine(desktop, archivo), append);
                try
                {
                    foreach(Patente item in datos)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
            Queue<Patente> queue = new Queue<Patente>();

            try
            {
                if (File.Exists(path))
                {
                    var arr = File.ReadAllLines(path);

                    foreach (string s in arr)
                    {
                        queue.Enqueue(s.ValidarPatente());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            datos = queue;
        }
    }
}
