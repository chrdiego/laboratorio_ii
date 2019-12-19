using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    [ExpectedException (typeof(AlumnoException))]
    public void TestMethod1()
    {
      Profesor<Alumno> profesor = new Profesor<Alumno>(1, "Juan");
      Alumno a1 = new Alumno(2, "Carlos");
      Alumno a2 = new Alumno(2, "Carlos");

      profesor += a1;
      profesor += a2;
      /*
      profesor.Alumnos.Add(a1);
      profesor.Alumnos.Add(a2);
      */
    }
  }
}
