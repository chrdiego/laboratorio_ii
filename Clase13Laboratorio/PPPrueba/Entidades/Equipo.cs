using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #region propiedade
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                    this.directorTecnico = value;
                else
                    this.directorTecnico = null;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            if (e.directorTecnico == null)
                return "\nDT Inválido\n";
            else
            {
                foreach(Jugador j in e.jugadores)
                {
                    sb.AppendLine(j.Mostrar());
                }
            }
            sb.AppendLine("DT: " + e.directorTecnico.Nombre);
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach(Jugador a in e.jugadores)
            {
                if(!object.ReferenceEquals(a,null))
                {
                    if (a == j)
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            int cont = 0;
            if(e != j)
            {
                foreach(Jugador aux in e.jugadores)
                {
                    cont++;
                }
                if (cont < e.cantidadMaximaJugadores && j.ValidarAptitud())
                {
                    e.jugadores.Add(j);
                    return true;
                }
            }
            return false;
        }

        public bool ValidarEquipo(Equipo e)
        {
            int auxArquero = 0;
            int auxDelantero = 0;
            int auxCentral = 0;
            int auxDefensor = 0;
            int contador = 0;
            if(e.directorTecnico != null)
            {
                foreach(Jugador j in e.jugadores)
                {
                    if (j.Posicion == Posicion.Arquero)
                        auxArquero++;
                    if (j.Posicion == Posicion.Defensor)
                        auxDefensor++;
                    if (j.Posicion == Posicion.Central)
                        auxCentral++;
                    if (j.Posicion == Posicion.Delantero)
                        auxDelantero++;
                    contador++;
                }
                if (auxArquero == 1 && auxDelantero >= 1 && auxDefensor >= 1 && auxCentral >= 1 && contador == this.cantidadMaximaJugadores)
                    return true;
                else
                    return false;
            }
            return false;
        }
        
    }
}
