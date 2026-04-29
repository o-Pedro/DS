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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); //Cria uma instância de objeto para o formulário 2
            form4.FormClosed += (s, args) => this.Show();
            this.Hide();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); //Cria uma instância de objeto para o formulário 2
            form1.FormClosed += (s, args) => this.Show();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //Cria uma instância de objeto para o formulário 2
            form2.FormClosed += (s, args) => this.Show();
            this.Hide();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); //Cria uma instância de objeto para o formulário 2
            form3.FormClosed += (s, args) => this.Show();
            this.Hide();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //Cria uma instância de objeto para o formulário 2
            form5.FormClosed += (s, args) => this.Show();
            this.Hide();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); //Cria uma instância de objeto para o formulário 2
            form6.FormClosed += (s, args) => this.Show();
            this.Hide();
            form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); //Cria uma instância de objeto para o formulário 2
            form7.FormClosed += (s, args) => this.Show();
            this.Hide();
            form7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(); //Cria uma instância de objeto para o formulário 2
            form8.FormClosed += (s, args) => this.Show();
            this.Hide();
            form8.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(); //Cria uma instância de objeto para o formulário 2
            form9.FormClosed += (s, args) => this.Show();
            this.Hide();
            form9.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(); //Cria uma instância de objeto para o formulário 2
            form10.FormClosed += (s, args) => this.Show();
            this.Hide();
            form10.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(); //Cria uma instância de objeto para o formulário 2
            form11.FormClosed += (s, args) => this.Show();
            this.Hide();
            form11.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(); //Cria uma instância de objeto para o formulário 2
            form12.FormClosed += (s, args) => this.Show();
            this.Hide();
            form12.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13(); //Cria uma instância de objeto para o formulário 2
            form13.FormClosed += (s, args) => this.Show();
            this.Hide();
            form13.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14(); //Cria uma instância de objeto para o formulário 2
            form14.FormClosed += (s, args) => this.Show();
            this.Hide();
            form14.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15(); //Cria uma instância de objeto para o formulário 2
            form15.FormClosed += (s, args) => this.Show();
            this.Hide();
            form15.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16(); //Cria uma instância de objeto para o formulário 2
            form16.FormClosed += (s, args) => this.Show();
            this.Hide();
            form16.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
