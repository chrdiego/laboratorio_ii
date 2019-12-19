using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Consola
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {
            XmlTextWriter writer;
            XmlSerializer ser;

            writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/archivo.xml", Encoding.ASCII);
            ser = new XmlSerializer(typeof(Persona));
            ser.Serialize(writer, p);
            writer.Close();
        }

        public static Persona Leer()
        {
            Persona aux;
            XmlTextReader reader;
            XmlSerializer ser;

            reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/archivo.xml");
            ser = new XmlSerializer(typeof(Persona));
            aux = (Persona)ser.Deserialize(reader);
            reader.Close();
            return aux;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.apellido);
            return sb.ToString();
        }
    }
}
