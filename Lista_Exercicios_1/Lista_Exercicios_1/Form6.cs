using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Exercicios_1
{
    public partial class Form6 : Form
    {
        int n1 = 0, som = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            som = n1 + 20;
            label5.Text = som.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            som = n1 * n1;
            label5.Text = som.ToString();
        }
    }
}
