using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
      public class Torneo<T> where T : Equipo
      {
      private List<T> equipos;
      private string nombre;

      public Torneo(string nombre)
      {
        this.nombre = nombre; 
        this.equipos = new List<T>();
      }
      
      public string Nombre
      {
        get
        {
          return this.nombre;
        }
      }

      public List<T> Equipos
      {
        get
       {
        return this.equipos;
        }
      }

      public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
      {
        foreach(Equipo e in torneo.equipos)
        {
          if (e == equipo)
            return torneo;
        else
            torneo.equipos.Add(equipo);
      }
      return torneo;
      }

      private static string CalcularPartido(T equipo1, T equipo2)
      {
        Random random = new Random();
        Random random2 = new Random();
        int numero2 = random.Next();
        int numero = random.Next();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(equipo1 + ": " + numero + " - "+ equipo1 +": " + numero2);
        return sb.ToString();
      }

      public static string JugarPartido(Torneo<T> torneo)
      {
      Random ran1 = new Random();
      Random ran2 = new Random();
      int index1 = ran1.Next(torneo.equipos.Count());
      int index2 = ran2.Next(torneo.equipos.Count());

      return CalcularPartido(torneo.equipos.ElementAt(index1), torneo.equipos.ElementAt(index2));
      }
      public static bool operator ==(Torneo<T> torneo, Equipo equipo)
      {
        foreach(Equipo e in torneo.Equipos)
        {
        if (e.Nombre == equipo.Nombre)
          return true;
        else
          return false;
        }
      return false;
      }

      public static bool operator!=(Torneo<T> torneo, Equipo equipo)
      {
        return !(torneo == equipo);
      }

      public string Mostrar()
      {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("TORNEO: " + this.Nombre + "\nEQUIPOS: ");
      foreach(Equipo e in this.equipos)
      {
        sb.AppendLine(e.Ficha());
      }
      return sb.ToString();
      }
    }
}
