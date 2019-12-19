using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public static bool operator ==(T e, Torneo<T> torneo)
        {
            foreach(Equipo equipo in torneo.equipos)
            {
                if (equipo == e)
                    return true;
            }
            return false;
        }

        public static bool operator !=(T e, Torneo<T> torneo)
        {
            return !(e == torneo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T e)
        {
            if(e != torneo)
            {
                torneo.equipos.Add(e);
                return torneo;
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE DEL EQUIPO: " + this.nombre);
            sb.AppendLine("----EQUIPOS----");
            foreach(Equipo e in this.equipos)
            {
                sb.AppendLine(e.Nombre);
            }
            sb.AppendLine("---------------");
            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            int numero = random.Next(1, 10);
            int numero2 = random.Next(1, 10);
            sb.AppendLine(e1.Nombre + " " + numero + " - " + e2.Nombre + " " + numero2);
            return sb.ToString();
        }

        public string JugarPartido()
        {
            Random random = new Random();
            int cantEquipos = this.equipos.Count();
            int equipo1 = random.Next(1, cantEquipos);
            int equipo2 = random.Next(1, cantEquipos);
            if(cantEquipos >= 2)
            {
                while(equipo1 == equipo2)
                {
                    equipo2 = random.Next(1, cantEquipos);
                }
                return CalcularPartido(this.equipos.ElementAt(equipo1), this.equipos.ElementAt(equipo2));
            }
            return "No se pudo jugar";
        }

    }
}
