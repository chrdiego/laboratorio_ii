using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        #region PROPIEDADES
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }

            set
            {
                this.trackingID = value;
            }
        }
        #endregion

        public void MockCicloDeVida()
        {
            while(this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.Estado = this.Estado + 1;
                InformaEstado.Invoke(this, null);
            }
            PaqueteDAO.Insertar(this);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return String.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (p1.TrackingID == p2.TrackingID)
                return true;
            else
                return false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.estado = EEstado.Ingresado;
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

    }
}
