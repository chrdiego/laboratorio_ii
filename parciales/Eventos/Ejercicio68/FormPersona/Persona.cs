using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersona
{
    public class Persona
    {
        public delegate void DelegadoString(string msj);
        public event DelegadoString EventoString;
        private string apellido;
        private string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if(value != "")
                {
                    this.nombre = value;
                    this.EventoString.Invoke("nuevo apellido " + this.nombre);
                }
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
                if(value != "")
                {
                    this.apellido = value;
                    this.EventoString.Invoke("nuevo apellido: " + this.apellido);
                }
            }
        }

        public Persona()
        {
            this.apellido = "";
            this.nombre = "";
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE: " + this.nombre + "   -   APELLIDO: " + this.apellido);
            return sb.ToString();
        }


    }
}
