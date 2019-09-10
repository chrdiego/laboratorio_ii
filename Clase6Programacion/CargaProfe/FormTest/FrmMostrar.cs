﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            //this.lstPersonas.DataSource = ((FrmCarga)this.Owner).personas;
            for (int i = 0; i < ((FrmCarga)this.Owner).personas.Length; i++)
            {
                this.lstPersonas.Items.Add(((FrmCarga)this.Owner).personas[i].MostrarDatos());
            }

        }
    }
}
