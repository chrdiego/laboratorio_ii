using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #region METODOS
        public Satelite(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
        {

        }

        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Orbita el planeta: " + this.nombre);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
