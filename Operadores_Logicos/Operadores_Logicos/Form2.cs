using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_Logicos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            double altura;

            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Por favor, insira a idade.");
                return;
            }

            idade = Int32.Parse(textBox1.Text);
            altura = Convert.ToDouble(textBox2.Text);

            if ((idade >= 15) && (idade <= 25) && (altura >= 1.60))
            {
                textBox3.AppendText("Sim" + Environment.NewLine + "Pode entrar para a equipe");
            }
            else
            {
                textBox3.AppendText("Não pode entrar para a equipe de natação");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
