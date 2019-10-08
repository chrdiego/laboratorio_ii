using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this ()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            int cont = 0;
            foreach(Vehiculo v in e.vehiculos)
            {
                cont++;
            }
            sb.AppendLine("****************************************************************");
            sb.AppendLine("Espacio disponible: " + (e.espacioDisponible - cont) + " Nombre: " + e.nombre);
            foreach(Vehiculo a in e.vehiculos)
            {
                sb.AppendLine(a.ConsultarDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo a in estacionamiento.vehiculos)
            {
                if (a == vehiculo)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool flag = false;
            int contador = 0;
            if(estacionamiento != null && vehiculo != null)
            {
                foreach(Vehiculo a in estacionamiento.vehiculos)
                {
                    if (a == vehiculo)
                        flag = true;
                    contador++;
                }
                if (flag == false && contador < estacionamiento.espacioDisponible && !(vehiculo.Patente.Equals("inválida")))
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                    return estacionamiento;
                }
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            int i = 0;
            bool flag = false;
            foreach(Vehiculo a in estacionamiento.vehiculos)
            {
                if (a == vehiculo)
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag == true)
            {
                estacionamiento.vehiculos.RemoveAt(i);
                return vehiculo.ImprimirTicket(); 
            }
            else
                return "El vehiculo no es parte del estacionamiento";
        }
    }
}
