using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Consola
{
    public class Caja
    {
        private List<string> filaClientes;
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach(string value in filaClientes)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Cliente " + value + " atendido por caja " + Thread.CurrentThread.Name);
            }
        }
    }
}
