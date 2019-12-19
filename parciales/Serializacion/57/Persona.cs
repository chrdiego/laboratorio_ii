using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

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

        public static bool Guardar(Persona p)
        {
            bool retorno = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "zipzap.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(p.Nombre);
            sw.WriteLine(p.Apellido);
            return retorno;
        }

        public static Persona Leer(Persona p)
        {

        }

    }
}
