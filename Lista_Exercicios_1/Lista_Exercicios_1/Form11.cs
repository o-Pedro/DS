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
    public partial class Form11 : Form
    {
        double porcm = 0, porcf = 0, nm = 0, nf = 0, tot = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = " ";
            label6.Text = " ";
            label8.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nm = Convert.ToDouble(textBox1.Text);
            nf = Convert.ToDouble(textBox2.Text);
            tot = nm + nf;

            porcm = (nm / tot) * 100;
            porcf = (nf / tot) * 100;

            label5.Text = porcm.ToString() + "%";
            label6.Text = porcf.ToString() + "%";
            label8.Text = tot.ToString();
        }
    }
}
