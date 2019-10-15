using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Tipo
    {
        Rocoso, Gaseoso
    }

    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        #region METODOS
        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE: " + this.nombre + "\nDURACION ORBITA: " +this.duracionOrbita+ "\nDURACION ROTACION: " + this.duracionRotacion);
            return sb.ToString();
        }

        public abstract string Orbitar();

        public virtual string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rotando: Tiempo estimado: " + this.duracionRotacion);
            return sb.ToString();
        }
        #endregion
        #region OPERADOR
        public static explicit operator string(Astro astro)
        {
            return astro.nombre;
        }
        #endregion
    }
}
