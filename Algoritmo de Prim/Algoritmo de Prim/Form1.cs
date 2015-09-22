using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_de_Prim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Arbol minimo.txt"))
                {
                    String line = sr.ReadToEnd();
                    txt_resultado.Text = line;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Error: " + es,"Error critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

      
    }
}
