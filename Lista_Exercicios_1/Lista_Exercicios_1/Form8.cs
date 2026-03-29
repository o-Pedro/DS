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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_Exercicios_1
{
    public partial class Form8 : Form
    {
        double n1 = 0, n2 = 0, n3 = 0, med1 = 0, n4 = 0, n5 = 0, n6 = 0, med2 = 0, n7 = 0, n8 = 0, n9 = 0, med3 = 0, n10 = 0, n11 = 0, n12 = 0, med4 = 0, n13 = 0, n14 = 0, n15 = 0, med5 = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox8.Clear();
            textBox7.Clear();
            textBox3.Clear();

            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();

            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();

            textBox20.Clear();
            textBox19.Clear();
            textBox18.Clear();

            label5.Text = " ";
            label4.Text = " ";
            label29.Text = " ";
            label30.Text = " ";
            label31.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox4.Text);
            n3 = Convert.ToDouble(textBox5.Text);

            n4 = Convert.ToDouble(textBox8.Text);
            n5 = Convert.ToDouble(textBox7.Text);
            n6 = Convert.ToDouble(textBox3.Text);

            n7 = Convert.ToDouble(textBox12.Text);
            n8 = Convert.ToDouble(textBox11.Text);
            n9 = Convert.ToDouble(textBox10.Text);

            n10 = Convert.ToDouble(textBox16.Text);
            n11 = Convert.ToDouble(textBox15.Text);
            n12 = Convert.ToDouble(textBox14.Text);

            n13 = Convert.ToDouble(textBox20.Text);
            n14 = Convert.ToDouble(textBox19.Text);
            n15 = Convert.ToDouble(textBox18.Text);

            med1 = (n1 + n2 + n3) / 3;
            med2 = (n4 + n5 + n6) / 3;
            med3 = (n7 + n8 + n9) / 3;
            med4 = (n10 + n11 + n12) / 3;
            med5 = (n13 + n14 + n15) / 3;

            label5.Text = med1.ToString();
            label4.Text = med2.ToString();
            label29.Text = med3.ToString();
            label30.Text = med4.ToString();
            label31.Text = med5.ToString();
        }
    }
}
