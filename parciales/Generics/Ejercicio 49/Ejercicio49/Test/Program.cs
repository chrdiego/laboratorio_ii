using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio competencia
            Competencia competencia = new Competencia(10, 3);

            //Instancio Competidores
            AutoF1 auto1 = new AutoF1((short)3322, "Ford");
            AutoF1 auto2 = new AutoF1((short)3322, "Renault");
            AutoF1 auto3 = new AutoF1((short)3322, "Fiat");
            AutoF1 auto4 = new AutoF1((short)3322, "Chevrolet");


            //Agrego competidores
            if (competencia + auto1)
                Console.WriteLine("Se agrego Ford");
            else
                Console.WriteLine("No se agrego Ford");
            if (competencia + auto2)
                Console.WriteLine("Se agrego Renault");
            else
                Console.WriteLine("No se agrego Renault");
            if (competencia + auto3)
                Console.WriteLine("Se agrego Fiat");
            else
                Console.WriteLine("No se agrego Fiat");
            if (competencia + auto4)
                Console.WriteLine("Se agrego Chevrolet");
            else
                Console.WriteLine("No se agrego Chevrolet");

            Console.WriteLine("");

            //Quito competidor
            if (competencia - auto3)
                Console.WriteLine("Se quito Fiat");
            else
                Console.WriteLine("No se quito Fiat");

            Console.WriteLine("");

            Console.WriteLine("Informacion de competidores");
            Console.WriteLine("");
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
