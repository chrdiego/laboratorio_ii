using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelotitaForm
{
  public partial class PelotitaForm : Form
  {
    public PelotitaForm()
    {
      InitializeComponent();
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      PelotitaControl pelotita = new PelotitaControl();
      pelotita.setImage(Properties.Resources.pelotacuadrada);
      Controls.Add(pelotita);
      pelotita.Show();
    }
  }
}
