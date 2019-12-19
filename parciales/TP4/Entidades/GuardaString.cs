using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool flag = false;
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(texto);
                sw.Close();
                flag = true;
            }
            catch(Exception e)
            {
                throw e;
            }
            return flag;
        }
    }
}
