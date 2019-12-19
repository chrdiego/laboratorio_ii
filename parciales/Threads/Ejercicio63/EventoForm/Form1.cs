using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EventoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = DateTime.Now.ToString();

        }

        public void AsignarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                   {
                       label1.Text = DateTime.Now.ToString();
                   });
                }
                else
                    label1.Text = DateTime.Now.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread threadHora = new Thread(AsignarHora);
            threadHora.Start();
        }
    }
}
