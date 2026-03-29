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
    public partial class Form9 : Form
    {
        int n1 = 0, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0, v10 = 0;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
            label3.Text = " ";
            label7.Text = " ";
            label9.Text = " ";
            label11.Text = " ";
            label21.Text = " ";
            label19.Text = " ";
            label17.Text = " ";
            label15.Text = " ";
            label13.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);

            v1 = n1*1;
            v2 = n1 * 2;
            v3 = n1 * 3;
            v4 = n1 * 4;
            v5 = n1 * 5;
            v6 = n1 * 6;
            v7 = n1 * 7;
            v8 = n1 * 8;
            v9 = n1 * 9;
            v10 = n1 * 10;

            label5.Text = v1.ToString();
            label3.Text = v2.ToString();
            label7.Text = v3.ToString();
            label9.Text = v4.ToString();
            label11.Text = v5.ToString();
            label21.Text = v6.ToString();
            label19.Text = v7.ToString();
            label17.Text = v8.ToString();
            label15.Text = v9.ToString();
            label13.Text = v10.ToString();
        }
    }
}
