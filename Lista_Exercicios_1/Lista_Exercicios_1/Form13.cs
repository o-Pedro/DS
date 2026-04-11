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
    public partial class Form13 : Form
    {
        double sali, salf, totv;
        string nome;
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sali = Convert.ToDouble(textBox2.Text);
            totv = Convert.ToDouble(textBox3.Text);
            nome = (textBox1.Text);

            totv = sali * (totv / 100);
            salf = sali + totv;


            label5.Text = sali.ToString();
            label7.Text = nome.ToString();
            label10.Text = salf.ToString();

            label5.Text = "R$ " + sali.ToString("F2");
            label10.Text = "R$ " + salf.ToString("F2");
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
            label10.Text = " ";
        }
    }
}
