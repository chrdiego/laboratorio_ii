using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base (numero, escuderia)
        {
            this.caballosDeFuerza = 0;
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this (numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

   
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NUMERO: " + this.Numero);
            sb.AppendLine("ESCUDERIA: " + this.Escuderia);
            sb.AppendLine("EN COMPETENCIA: " + this.EnCompetencia.ToString());
            sb.AppendLine("COMBUSTIBLE: " + this.CantidadCombustible);
            sb.AppendLine("VUELTAS RESTANTES: " + this.VueltasRestantes);
            sb.AppendLine("CABALLOS DE FUERZA: " + this.CaballosDeFuerza);
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.Escuderia == a2.Escuderia && a1.Numero == a2.Numero && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
                return true;
            else
                return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
