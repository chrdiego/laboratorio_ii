using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;

        public List<Astro> Satelites
        {
            get
            {
                return this.satelites;
            }
        }
        #region METODOS
        public Planeta(int duraOrbita, int duraRotacion, string nombre) : base(duraOrbita, duraRotacion, nombre)
        {
            this.satelites = new List<Astro>();
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantSatelites, Tipo tipo) : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }

        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Orbita el planeta: " + this.nombre);
            return sb.ToString();
        }

        public new string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rota el planeta: " + this.nombre);
            sb.AppendLine(base.Rotar());
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Orbitar());
            sb.AppendLine(this.Mostrar());
            sb.AppendLine("Cantidad de satelites: " + this.cantSatelites);
            sb.AppendLine("Tipo: " + this.tipo);
            sb.AppendLine("---------------\nSatelites:");
            foreach (Satelite s in this.Satelites)
            {
                sb.AppendLine(s.ToString());
                sb.AppendLine("\n");
            }
            sb.AppendLine("***********");
            return sb.ToString();
        }
        #endregion
        #region OPERADORES
        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite s in planeta.Satelites)
            {
                if (s.Nombre == satelite.Nombre)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }

        public static bool operator ==(Planeta planeta1, Planeta planeta2)
        {
            if ((string)planeta1 == (string)planeta2)
                return true;
            else
                return false;
        }

        public static bool operator !=(Planeta planeta1, Planeta planeta2)
        {
            return !(planeta1 == planeta2);
        }

        public static bool operator +(Planeta planeta, Astro astro)
        {
            if (astro is Satelite && planeta.Satelites.Count < planeta.cantSatelites)
            {
                planeta.Satelites.Add(astro);
                return true;
            }
            else
                return false;
        }
#endregion
    }
}