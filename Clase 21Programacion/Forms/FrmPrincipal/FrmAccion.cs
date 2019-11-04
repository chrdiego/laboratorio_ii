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
  public delegate void msaje(string mensaje);
  public partial class FrmAccion : Form
  {
    public event msaje enviarMens;
    public FrmAccion()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(enviarMens.GetInvocationList().Length > 0)
      enviarMens.Invoke(this.textBox1.Text); 
    }

  }
}
