using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDO
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
