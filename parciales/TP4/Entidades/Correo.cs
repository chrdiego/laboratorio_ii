using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.Paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            foreach(Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            Correo correo = (Correo)elementos;
            foreach(Paquete p in correo.Paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return sb.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach(Paquete item in c.Paquetes)
            {
                if (item == p)
                {
                    throw new TracikngIdRepetidoException("Ya existe un paquete con esa Tracking ID");
                }
            }
            c.Paquetes.Add(p);
            Thread t = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(t);
            t.Start();
            return c;
        }
    }
}
