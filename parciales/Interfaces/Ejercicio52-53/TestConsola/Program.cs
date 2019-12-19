using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            // Lápiz está implementada de manera explícita.
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            // Bolígrafo no, por eso casteo.
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.ReadKey();
        }
    }
}
