using System;

namespace Entidades
{
    public class AlumnoException : Exception
  {
    public AlumnoException() : base("Alumno repetido") { }
  }
}
