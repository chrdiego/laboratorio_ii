using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException (typeof(SateliteException))]
        public void SateliteRepetido()
        {
            Planeta<Satelite> jupiter = new Planeta<Satelite>(100, 30, "Jupiter", 2, Tipo.Rocoso);
            Satelite satelite1 = new Satelite(10, 10, "Luna");
            Satelite satelite2 = new Satelite(10, 10, "Luna");

            bool aux = jupiter + satelite1;
            bool aux2 = jupiter + satelite2;
        }

        [TestMethod]
        public void GuardarSateliteXml()
        {
            Satelite satelite = new Satelite(10, 10, "Luna");

            Assert.IsTrue(satelite.GuardarXML());
        }

        [TestMethod]
        public void GuardarPllaneta()
        {
            Planeta<Satelite> jupiter = new Planeta<Satelite>(100, 30, "Júpiter", 2, Tipo.Rocoso);

            Assert.IsTrue(AstroExtension.GuardarPlanTxt(jupiter));
        }

        [TestMethod]
        public void SateliteDB_Guardar()
        {
            SateliteDB database = new SateliteDB();
            Satelite satelite = new Satelite(200, 100, "Luna");

            Assert.IsTrue(database.Guardar(satelite));
        }

        [TestMethod]
        public void SateliteDB_Leer()
        {
            SateliteDB database = new SateliteDB();

            List<Satelite> listaSatelites = new List<Satelite>();

            listaSatelites = database.Leer();
            Assert.IsNotNull(listaSatelites);
            foreach(Satelite s in listaSatelites)
            {
                Assert.IsTrue(s.GuardarXML());
            }

        }
    }
}
