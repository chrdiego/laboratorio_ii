using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("juan", "carlos");
            Persona aux;
            Persona.Guardar(p1);
            aux = Persona.Leer();
            Console.WriteLine(aux.ToString());
            Console.ReadKey();
        }
    }
}
