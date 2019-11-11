using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelotitaForm
{
  public partial class PelotitaControl : UserControl
  {
    public PelotitaControl()
    {
      InitializeComponent();
    }

    public void setImage(Bitmap image)
    {
      this.BackgroundImage = image;
      this.Width = 25;
      this.Height = 25;
    }
  }
}
