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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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

                if ((idade >= 15) && (idade <= 25) || (altura >= 1.60))
                {
                    textBox3.AppendText("Sim" + Environment.NewLine + "Pode entrar para a equipe");
                }
                else
                {
                    textBox3.AppendText("Não pode entrar para a equipe de natação");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
