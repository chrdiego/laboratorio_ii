using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTest
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string provincia;
        public bool vive;
        public string sexo; 


        public Persona(string nombre, string apellido, int dni, string provincia, bool vive, string sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.sexo = sexo;
            this.vive = vive;
            this.provincia = provincia;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre:{0} - Apellido{1} - Sexo{2} - Provincia{3}", this.nombre, this.apellido, this.sexo, this.provincia);
            return sb.ToString();
        }


    }
}
