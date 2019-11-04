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
  public partial class FrmPrincipal : Form
  {
    public FrmPrincipal()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      bool salida = false;

      foreach(Form frm in this.MdiChildren)
      {
        if (frm is FrmMensaje)
          salida = true;
      }
      if(!salida)
      {
        FrmMensaje men = new FrmMensaje();
        men.MdiParent = this;
       foreach(Form frm in this.MdiChildren)
        {
          if (frm is FrmAccion)
            ((FrmAccion)frm).enviarMens += men.mostrarMensaje;
        }
        men.Show();
        men.Focus();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      FrmAccion acc = new FrmAccion();
      acc.MdiParent = this;
      foreach(Form frm in this.MdiChildren)
      {
        if(frm is FrmMensaje)
          acc.enviarMens += ((FrmMensaje)frm).mostrarMensaje;
      }
      acc.Show();
      acc.Focus();
    }
  }
}
