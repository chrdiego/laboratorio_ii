﻿using System;
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
                    this.directorTecnico = value;
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
            StringBuilder sb = new StringBuilder();
            if (e.directorTecnico == null)
            {
                sb.AppendLine("\tDT INVÁLIDO\n");
                foreach (Jugador j in e.jugadores)
                {
                    sb.AppendLine(j.Mostrar());
                }
            }
            else
            {
                sb.AppendLine("DT: " + e.directorTecnico.Nombre + "\n");
                foreach (Jugador j in e.jugadores)
                {
                    sb.AppendLine(j.Mostrar());
                }
            }
            return sb.ToString();
        }


        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador a in e.jugadores)
            {
                if (!object.ReferenceEquals(a, null))
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


        public static Equipo operator +(Equipo e, Jugador j)
        {
            int cont = 0;
            if (e != j)
            {
                foreach (Jugador aux in e.jugadores)
                {
                    cont++;
                }
                if (cont < e.cantidadMaximaDeJugadores && j.ValidarAptitud())
                {
                    e.jugadores.Add(j);
                    return e;
                }
            }
            return e;
        }
    }
}
