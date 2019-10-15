using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;


        public List<Astro> Planetas
        {
            get
            {
                return this.planetas;
            }
        }
        #region METODOS
        private SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Planeta p in this.Planetas)
            {
                sb.AppendLine(p.ToString());
                foreach(Satelite s in p.Satelites)
                {
                    sb.AppendLine(s.ToString());
                }
            }
            return sb.ToString();
        }
    #endregion
    }
}
