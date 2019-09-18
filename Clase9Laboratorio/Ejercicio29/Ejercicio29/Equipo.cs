using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    public class Equipo
    {
    short cantidadDeJugadores;
    List<Jugador> jugadores;
    string nombre;

    private Equipo()
    {
      this.jugadores = new List<Jugador>();
    }

    public Equipo(short cantidad, string nombre)
    {
      this.cantidadDeJugadores = cantidad;
      this.nombre = nombre;
    }

    public static bool operator +(Equipo e, Jugador j)
    {
      foreach(Jugador jug in e.jugadores)
      {
        if(j == jug)
           return false;
      }
      e.jugadores.Add(j);
      return true;
    }
    }
}
