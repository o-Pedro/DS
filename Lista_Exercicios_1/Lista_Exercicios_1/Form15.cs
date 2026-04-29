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
    public partial class Form15 : Form
    {
        double val = 0, pre = 0;
        public Form15()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            val = Convert.ToDouble(textBox1.Text);
            pre = val / 5;

            label5.Text = pre.ToString();
            label5.Text = "R$ " + pre.ToString("F2");
        }
    }
}
