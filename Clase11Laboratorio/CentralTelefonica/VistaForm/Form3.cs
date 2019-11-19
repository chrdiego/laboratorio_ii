using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace VistaForm
{
    public partial class Form3 : Form
    {
        public Centralita centralita;
        public Llamada.TipoLlamada tipo;
        public Form3(Centralita centralita, Llamada.TipoLlamada tipo)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.tipo = tipo;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(tipo == Llamada.TipoLlamada.Todas)
            {
                foreach(Llamada llamada in centralita.Llamadas)
                {
                    richTextBox1.Text += llamada.ToString();
                }
                richTextBox1.Text += $"Ganancia total (TODAS): {centralita.GananciaPorTotal}";
            }
            else if(tipo == Llamada.TipoLlamada.Local)
            {
                foreach (Llamada llamada in centralita.Llamadas)
                {
                    if (llamada is Local)
                    {
                        richTextBox1.Text += llamada.ToString();
                    }
                }
                richTextBox1.Text += $"Ganancia Total (Local): {centralita.GananciaPorLocal}";
            }
            else if(tipo == Llamada.TipoLlamada.Provincial)
            {
                foreach(Llamada llamada in centralita.Llamadas)
                {
                    if(llamada is Provincial)
                    {
                        richTextBox1.Text += llamada.ToString();
                    }
                }
                richTextBox1.Text += $"Ganancia Total (Provincial): {centralita.GananciaPorProvincial}";
            }
        }
    }
}
