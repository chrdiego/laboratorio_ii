using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{

    public class Planeta<TAstro> : Astro where TAstro : Astro, IAstro
    {
        private int cantAstros;
        private Tipo tipo;
        private List<TAstro> satelites;

        public Planeta(int durOrb, int duraRot, string nmbr)
            : base(durOrb, duraRot, nmbr)
        {
            this.satelites = new List<TAstro>();
        }

        public Planeta(int durOrb, int durRot, string nmbr, int cantAstr, Tipo tipo)
            : this(durOrb, durRot, nmbr)
        {
            this.cantAstros = cantAstr;
            this.tipo = tipo;
        }

        public List<TAstro> Satelites
        {
            get
            {
                return this.satelites;
            }

            set
            {
                this.satelites = value;
            }
        }

        public int CantAstros
        {
            get
            {
                return this.cantAstros;
            }
            set
            {
                this.cantAstros = value;
            }
        }

        public Tipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public static Planeta<TAstro> operator +(Planeta<TAstro> planeta, TAstro astro)
        {
            bool retorno = false;

            if (planeta == astro)
                retorno = false;
            else
            {
                retorno = true;
                planeta.Satelites.Add(astro);
            }
            return planeta;
        }

        public static bool operator ==(Planeta<TAstro> planeta, TAstro satelite)
        {
            foreach (TAstro astro in planeta.satelites)
            {
                if (astro.Nombre == satelite.Nombre)
                {
                    throw new SateliteException();
                }
            }

            return false;
        }

        public static bool operator !=(Planeta<TAstro> planeta, TAstro astro)
        {
            return !(planeta == astro);
        }

        public string Orbitar()
        {
            return $"Termino de orbitar el planeta {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Termino de rotar el planeta {this.Nombre}";
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Planeta");
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Tipo: {tipo}");
            retorno.AppendLine($"Cantidad de Satelites {cantAstros}");

            foreach (TAstro satelite in this.satelites)
            {
                retorno.AppendLine(satelite.ToString());
            }

            return retorno.ToString();
        }

        public void RunEvntRotar()
        {
            for(int i = 0;  i < DuraRotacion; i++)
            {
                Thread.Sleep(3000);
            }
            InvocarEvento(this.Rotar());
        }

        public void RunEvntOrb()
        {
            for(int i = 0; i < DuraOrbita; i++)
            {
                Thread.Sleep(1000);
            }
            InvocarEvento(this.Orbitar());
        }
    }
}
