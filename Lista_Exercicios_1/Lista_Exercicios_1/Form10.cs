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
    public partial class Form10 : Form
    {
        int r = 0, m = 0, equ = 0;
        public Form10()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            m = Convert.ToInt32(textBox1.Text);
            r = Convert.ToInt32(textBox2.Text);
            equ = r * m + 3 + m;        
            label5.Text = equ.ToString();
        }
    }
    }