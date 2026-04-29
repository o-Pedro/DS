using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Exercicios_1
{
    public partial class Form12 : Form
    {
        double ve = 0, np = 0, tx = 0, valp = 0, valt = 0;
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = " ";
            label7.Text = " ";
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ve = Convert.ToDouble(textBox1.Text);
            np = Convert.ToDouble(textBox2.Text);
            tx = Convert.ToDouble(textBox3.Text);

            tx = ve * (tx / 100) * np;
            valt = ve + tx;
            valp = valt / np;

            label5.Text = valt.ToString();
            label7.Text = valp.ToString();

            label5.Text = "R$ " + valt.ToString("F2");
            label7.Text = "R$ " + valp.ToString("F2");
        }
    }
}
