using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("Pedro");
            negocio.Clientes.Add("Manuel");
            negocio.Clientes.Add("Jeremías");
            negocio.Clientes.Add("Roberto");
            negocio.Clientes.Add("Emanuel");
            negocio.Clientes.Add("Matías");
            negocio.Clientes.Add("Raúl Barila");

            Thread asignacion = new Thread(negocio.AsignarCaja);
            Thread atenCaja1 = new Thread(caja1.AtenderClientes);
            Thread atenCaja2 = new Thread(caja2.AtenderClientes);

            atenCaja1.Name = "Caja 1";
            atenCaja2.Name = "Caja 2";

            asignacion.Start();
            asignacion.Join();
            atenCaja1.Start();
            atenCaja2.Start();
           

            Console.ReadKey();

        }
    }
}
