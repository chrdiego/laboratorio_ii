using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
  public partial class FrmMensaje : Form
  {
    public FrmMensaje()
    {
      InitializeComponent();
    }

    public void mostrarMensaje(string mensaje)
    {
      textBox1.Text = mensaje;
    }
  }
}
