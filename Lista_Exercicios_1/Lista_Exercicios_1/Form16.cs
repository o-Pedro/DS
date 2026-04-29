using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Exercicios_1
{
    public partial class Form16 : Form
    {
        double prod = 0, acre = 0, tota = 0;
        public Form16()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prod = Convert.ToDouble(textBox1.Text);
            acre = Convert.ToDouble(textBox2.Text);

            acre = prod * (acre / 100);
            tota = prod + acre;

            label5.Text = tota.ToString();
            label5.Text = "R$ " + tota.ToString("F2");
        }
    }
}
