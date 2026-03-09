using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_SIMPLES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0, res = 0; //Declaração das variáveis
            n1 = int.Parse(textBox1.Text); //Converte conteúdo vindo da string
            n2 = Convert.ToInt32(textBox2.Text); //Também converte contéudo vindo da String, mas é recomendável utilizar este método
            res = n1 + n2;
            label5.Text = res.ToString(); //Converte as variáveis em uma string

            //---Outras Conversões---

            //  double V = double.Parse(textbox1.text); //Conversão de string para double
            //  ou double V = Convert.ToDouble(textbox1.text)

            //  bool R = bool.Parse(textbox1.text); //Conversão de string para boolean
            //  ou bool R = Convert.ToBoolean(textbox1.text)

            //  char L = char.Parse(textbox1.text); //Conversão de string para carácter
            //  ou char L = Convert.ToChar(textbox1.text)

            //---Operadores Aritiméticos---

            //  (+) - Adição
            //  (-) - Subtração
            //  (*) - Multiplicação
            //  (/) - Divisão
            //  (%) - Resto da divisão

            //---Operadores Relacionais---

            //  (>) - Maior que
            //  (<) - Menor que
            //  (>=) - Maior ou igual a
            //  (<=) - Menor ou igual a
            //  (==) - Igual a
            //  (!=) - Diferente de
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //Limpa os campos de texto
            textBox2.Clear();
            label5.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
