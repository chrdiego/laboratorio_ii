using System;
using System.Text;

namespace Entidades
{
    public abstract class Universitario
    {
        private int legajo;
        private string nombre;

        public int Legajo { get => legajo; set => legajo = value; }

        public Universitario() { }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Universitario(int legajo, string nombre)
        {
            this.legajo = legajo;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            var retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"Nota Parcial: {legajo}");
            return retorno.ToString();
        }
    }
}
