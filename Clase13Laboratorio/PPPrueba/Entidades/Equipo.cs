using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        protected int cantidadMaximaDeJugadores = 6;
        protected DirectorTecnico directorTecnico;
        protected List<Jugador> jugadores;
        protected string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }


        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud() == true)
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }


        public static bool ValidarEquipo(Equipo e)
        {
            int auxArquero = 0;
            int auxDelantero = 0;
            int auxCentral = 0;
            int auxDefensor = 0;
            int contador = 0;
            if (e.directorTecnico != null)
            {
                foreach (Jugador j in e.jugadores)
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
                if (auxArquero == 1 && auxDelantero >= 1 && auxDefensor >= 1 && auxCentral >= 1 && contador == 6)
                    return true;
                else
                    return false;
            }
            return false;
        }


        public static explicit operator string(Equipo e)
        {
            string retorno = "";
            if (!(e is null))
            {
                retorno = e.Mostrar();
            }
            return retorno;
        }


        public static bool operator ==(Equipo e1, Jugador j)
        {
            bool retorno = false;
            if (!(e1 is null) && !(j is null))
            {
                foreach (Jugador d in e1.jugadores)
                {
                    if (d.Dni == j.Dni)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e1, Jugador j)
        {
            return !(e1 == j);
        }


        public static Equipo operator +(Equipo e1, Jugador j)
        {
            Equipo retorno = e1;
            bool flag = false;
            int contador = 0;

            if (!(e1 is null) && !(j is null))
            {
                flag = true;
                foreach (Jugador m in e1.jugadores)
                {
                    contador++;
                    if (m == j)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true && e1.cantidadMaximaDeJugadores > contador && j.ValidarAptitud() == true)
                {
                    e1.jugadores.Add(j);
                }
            }

            return retorno;
        }


        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            if (directorTecnico is null)
            {
                retorno.AppendLine("Equipo sin DT");
            }
            else
            {
                retorno.AppendLine("DT: " + this.directorTecnico.Nombre);
            }


            foreach (Jugador j in this.jugadores)
            {
                retorno.AppendLine(j.Mostrar());
            }

            return retorno.ToString();
        }
    }
}
