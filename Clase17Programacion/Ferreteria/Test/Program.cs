using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
  public class Program
  {
    static void Main(string[] args)
    {
      Estanteria<Alimenticio> est1 = new Estanteria<Alimenticio>(5);
      Estanteria<Ferreteria> est2 = new Estanteria<Ferreteria>(5);
      Estanteria<Alimenticio> est3 = new Estanteria<Alimenticio>(5);
      DateTime d1 = new DateTime(1);
      DateTime d2 = new DateTime(2);

      Alimenticio alimento1 = new Alimenticio(5, "Verdura", d1);
      Alimenticio alimento2 = new Alimenticio(6, "Bebida", d2);
      Alimenticio alimento3 = new Alimenticio(7, "Snack", d1);
      Alimenticio alimento4 = new Alimenticio(8, "Carne", d1);
      Alimenticio alimento5 = new Alimenticio(9, "Pollo", d2);
      Alimenticio alimento6 = new Alimenticio(8, "AlimentoRepetido", d1);
      Ferreteria ferre1 = new Ferreteria(23, "Martillo", 20);
      Ferreteria ferre2 = new Ferreteria(24, "Destornillador", 25);
      Ferreteria ferre3 = new Ferreteria(25, "Lija", 30);
      Ferreteria ferre4 = new Ferreteria(26, "Tornillo", 5);
      Ferreteria ferre5 = new Ferreteria(27, "Regla", 10);
      Ferreteria ferre6 = new Ferreteria(26, "FerreRepetida", 30);

      Console.WriteLine("ESTANTE 1: ");
      if (est1 + alimento1)
        Console.WriteLine("Alimento 1 ha sido agregado (Verdura)");
      else
        Console.WriteLine("No pudo agregarse");
      if (est1 + alimento1)
        Console.WriteLine("Alimento 1 ha sido agregado (Verdura)");
      else
        Console.WriteLine("No pudo agregarse");
      if (est1 + ferre2)
        Console.WriteLine("Pudo agregarse");
      else
        Console.WriteLine("No pudo agregarse");
      Console.ReadKey();

    }
  }
}
