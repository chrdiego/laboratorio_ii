using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public static FileInfo file = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if(open.CheckFileExists && open.FileName != "")
            {
                file = new FileInfo(open.FileName);

                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    richTextBox1.Text += reader.ReadToEnd();
                }
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} carácteres";
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file is null)
                GuardarComoToolStripMenuItem_Click(sender, e);
            else
                this.Escribir(file.FullName);
        }

        private void Escribir(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            string[] arr = richTextBox1.Text.Split('\n');
            foreach(string s in arr)
            {
                sw.WriteLine(s);
            }
            sw.Close();
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
            if(s.CheckPathExists && s.FileName != "")
            {
                file = new FileInfo(s.FileName);
                this.Escribir(file.FullName);
            }
        }
    }
}
