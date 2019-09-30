using System;

namespace Entidades
{
    public abstract class Persona
    {
        public int Cuil { get; set; }
        public string Nombre { get; set; }
        public Persona(string nombre, int cuil)
        {
            this.Cuil = cuil;
            this.Nombre = nombre;
        }

        public virtual string Mostrar()
        {
            return "nom:"+  this.Nombre + " cuil:" + this.Cuil;
        }
    }
}
