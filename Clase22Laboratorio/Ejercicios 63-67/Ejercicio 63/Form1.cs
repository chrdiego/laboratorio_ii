using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_67;

namespace Ejercicio_63
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      lblHora.Text = DateTime.Now.ToString();
      Timer timer = new Timer();
      timer.Interval = 1000;
      timer.Tick += AsignarHora;
      timer.Start();
    }

    public void AsignarHora(object sender, EventArgs e)
    {
      lblHora.Text = DateTime.Now.ToString();
    }
  }
}
