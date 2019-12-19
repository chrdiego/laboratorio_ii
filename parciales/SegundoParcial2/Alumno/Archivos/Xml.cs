using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> 
    {
        public void Guardar(string archivo, T datos)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(!string.IsNullOrEmpty(archivo) && datos != null)
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                try
                {
                    XmlTextWriter xw = new XmlTextWriter(Path.Combine(desktop, archivo), Encoding.ASCII);
                    xs.Serialize(xw, datos);
                    xw.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        public void Leer(string archivo, out T datos)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
            T obj = default(T);
            try
            {
                XmlTextReader xr = new XmlTextReader(path);
                XmlSerializer xs = new XmlSerializer(typeof(T));

                datos = (T)xs.Deserialize(xr);
                xr.Close();
            }
            catch(Exception ex)
            {
                datos = default(T);
                throw ex;
            }
            datos = obj;
        }
    }
}
