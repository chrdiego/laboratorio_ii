using System;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Satelite : Astro, IAstro
    {
        public Satelite() { }

        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita, duraRotacion, nombre) { }

        public string Orbitar()
        {
            return $"Orbitar el satelite: {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Rota el satelite: {this.Nombre}";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Satelite");
            stringBuilder.AppendLine(Mostrar());

            return stringBuilder.ToString();
        }

        public void RunEvntRotar()
        {
            for(int i = 0; i < DuraOrbita; i++)
            {
                Thread.Sleep(800);
            }
            InvocarEvento(this.Rotar());
        }

        public void RunEvntOrb()
        {
            for(int i = 0; i < DuraRotacion; i++)
            {
                Thread.Sleep(400);
            }
            InvocarEvento(this.Orbitar());
        }

    }
}
