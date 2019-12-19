using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class TestTrackingID
    {
        [TestMethod]
        [ExpectedException(typeof(TracikngIdRepetidoException))]
        public void TestPaqueteRepetido()
        {
            Correo c1 = new Correo();
            Paquete p1 = new Paquete("abc", "123");
            Paquete p2 = new Paquete("abc", "123");

            c1 += p1;
            c1 += p2;
        }
    }
}
