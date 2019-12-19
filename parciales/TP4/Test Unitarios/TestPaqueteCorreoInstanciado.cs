using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class TestPaqueteCorreoInstanciado
    {
        [TestMethod]
        public void TestPaqueteInstanciado()
        {
            Correo correo = new Correo();
            if (correo.Paquetes.Equals(null))
                Assert.Fail();
        }
    }
}
