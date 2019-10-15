using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormParcial
{
    public partial class Form1 : Form
    {
        private static List<Astro> planetas;
        public Form1()
        {
            InitializeComponent();
            planetas = new List<Astro>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(Tipo));
        }

        private void BtnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            int tiempoOrb = 0;
            if (txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && int.TryParse(txtOrbitaPlaneta.Text, out tiempoOrb))
            {
                if (tiempoOrb > 0 && (int)numRotacion.Value > 0 && (int)numSatelite.Value >= 0)
                {
                    Planeta planeta = new Planeta(tiempoOrb, (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numSatelite.Value, (Tipo)cmbTipo.SelectedItem);
                    planetas.Add(planeta);
                    cmbPlanetas.Items.Add((string)planeta);
                    MessageBox.Show("Planeta agregado corréctamente");
                }
                else
                {
                    MessageBox.Show("Ingrese valores mayores a 0");
                }
            }
            else
                MessageBox.Show("Ingrese datos corréctamente");
            txtNombrePlaneta.Text = "";
            txtNombreSatelite.Text = "";
            txtOrbitaPlaneta.Text = "";
            numRotacion.Value = 0;
            numRotacionSatelite.Value = 0;
            numOrbitaSatelite.Value = 0;
            numSatelite.Value = 0;
        }

        private void BtnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (txtNombreSatelite.Text != "" && (int)numOrbitaSatelite.Value >= 0 && (int)numRotacionSatelite.Value >= 0 && planetas.Count > 0)
            {
                Satelite satelite = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);
                foreach (Planeta planeta in planetas)
                {
                    if ((string)planeta == (string)cmbPlanetas.SelectedItem && planeta != satelite)
                    {
                        if (planeta + satelite)
                        {
                            MessageBox.Show("Satélite agregado");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No hay mas espacio");
                            break;
                        }
                    }                    
                }
            }
            else
                MessageBox.Show("Ingrese los datos corréctamente");
            txtNombrePlaneta.Text = "";
            txtNombreSatelite.Text = "";
            txtOrbitaPlaneta.Text = "";
            numRotacion.Value = 0;
            numRotacionSatelite.Value = 0;
            numOrbitaSatelite.Value = 0;
            numSatelite.Value = 0;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach(Planeta p in planetas)
            {
                richTextBox1.Text += p.ToString();
            }
        }

        private void BtnMoverAstros_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach(Planeta planeta in planetas)
            {
                richTextBox1.Text += planeta.Orbitar() + "\n" + planeta.Rotar();
                foreach (Satelite satelite in planeta.Satelites)
                    richTextBox1.Text += satelite.Orbitar() + satelite.Rotar();
                richTextBox1.Text += "************\n";
            }
        }
    }
}
