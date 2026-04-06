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
    public partial class Form14 : Form
    {
        double rea = 0, dol = 0, cot = 0;
        public Form14()
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
            textBox2.Clear();
            label5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cot = Convert.ToDouble(textBox1.Text);
            dol = Convert.ToDouble(textBox2.Text);

            rea = dol * cot;

            label5.Text = rea.ToString();
            label5.Text = "R$ " + rea.ToString("F2");
        }
    }
}
