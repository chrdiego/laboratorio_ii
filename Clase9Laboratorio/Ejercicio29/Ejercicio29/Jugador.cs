using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
  public class Jugador
  {
    int dni;
    string nombre;
    int partidosJugados;
    float promedioGoles;
    int totalGoles;

    private Jugador()
    {
      this.partidosJugados = 0;
      this.promedioGoles = 0;
      this.totalGoles = 0;
    }

    public float GetPromedioGoles()
    {
      return this.totalGoles / this.partidosJugados;
    }

    public Jugador(int dni, string nombre)
    {
      this.dni = dni;
      this.nombre = nombre;
    }

    public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
    {
      this.totalGoles = totalGoles;
      this.partidosJugados = totalPartidos;
    }

    public string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      return sb.AppendFormat("DNI: {0}\nNOMBRE: {1}\nPARTIDOS JUGADOS: {2}\nPROMEDIO GOLES: {3}\nTOTAL GOLES: {4}",this.dni, this.nombre, this.partidosJugados, this.promedioGoles, this.totalGoles).ToString();
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
      if (j1.dni == j2.dni)
        return true;
      else
        return false;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
      return !(j1 == j2);
    }
  }
}
