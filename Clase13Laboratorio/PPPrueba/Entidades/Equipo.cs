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
            bool retorno = false;
            int flagArq = 0;
            int flagDef = 0;
            int flagDel = 0;
            int flagCen = 0;
            int contador = 0;

            if (!(e is null))
            {
                if (!(e.directorTecnico is null))
                {
                    foreach (Jugador j in e.jugadores)
                    {
                        contador++;
                        if (j.Posicion == Posicion.Arquero)
                        {
                            if (flagArq == 1)
                            {
                                flagArq = 0;
                                break;
                            }
                            flagArq = 1;
                        }
                        else if (j.Posicion == Posicion.Defensor)
                        {
                            flagDef = 1;
                        }
                        else if (j.Posicion == Posicion.Central)
                        {
                            flagCen = 1;
                        }
                        else if (j.Posicion == Posicion.Delantero)
                        {
                            flagDel = 1;
                        }
                    }
                }

                if (flagArq == 1 && flagDef == 1 && flagCen == 1 && flagDel == 1 && contador == 6)
                {
                    retorno = true;
                }
            }
            return retorno;
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
