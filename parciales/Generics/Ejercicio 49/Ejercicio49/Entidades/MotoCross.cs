using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia) : base (numero, escuderia)
        {
            this.cilindrada = 0;
        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1.Escuderia == a2.Escuderia && a1.Numero == a2.Numero && a1.Cilindrada == a2.Cilindrada)
                return true;
            else
                return false;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NUMERO: " + this.Numero);
            sb.AppendLine("ESCUDERIA: " + this.Escuderia);
            sb.AppendLine("EN COMPETENCIA: " + this.EnCompetencia.ToString());
            sb.AppendLine("COMBUSTIBLE: " + this.CantidadCombustible);
            sb.AppendLine("VUELTAS RESTANTES: " + this.VueltasRestantes);
            sb.AppendLine("CILINDRADA: " + this.Cilindrada);
            return sb.ToString();
        }
    }
}
