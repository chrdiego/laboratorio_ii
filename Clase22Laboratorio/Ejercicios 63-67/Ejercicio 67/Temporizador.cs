using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    
    public sealed class Temporizador
    {
    public delegate void encargadoTiempo(DateTime tiempo);
    public event encargadoTiempo EventoTiempo;

    private int intervalo;
    private Thread hilo;

    public int Intervalo
    {
      get { return this.intervalo;  }
      set { this.intervalo = value;  }
    }

    public bool Activo
    {
      get {  }
    }

    private void Corriendo(EventArgs e)
    {
      while(Activo == true)
      {
        EventoTiempo(DateTime.Now);
      }
    }

    }
}
