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

namespace Calculo_de_Salario_Bruto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ht, vh, sb, pd, sl, td;

            ht = Convert.ToDouble(this.textBox1.Text);
            vh = Convert.ToDouble(this.textBox2.Text);
            pd = Convert.ToDouble(this.textBox3.Text);

            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - td;

            label5.Text = sb.ToString();
            label7.Text = td.ToString();
            label9.Text = sl.ToString();

            label5.Text = sb.ToString("F2");
            label7.Text = td.ToString("F2");
            label9.Text = sl.ToString("F2");

            //---Tipos de formatação para 2 casas decimais---;

                //label1.Text = Math.Round(SL, 2).ToString();

                //label1.Text = SL.ToString("C");

                //label1.Text = Sl.ToString("0.00");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = " ";
            label7.Text = " ";
            label9.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
