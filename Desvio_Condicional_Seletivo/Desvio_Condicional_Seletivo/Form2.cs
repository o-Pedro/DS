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

namespace Desvio_Condicional_Seletivo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mes;
                mes = textBox1.Text.ToLower();

                if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    MessageBox.Show("Por favor, insira o mês.");
                    return;
                }

                switch (mes)
                {
                    case "janeiro":
                    case "março":
                    case "maio":
                    case "julho":
                    case "agosto":
                    case "outubro":
                    case "dezembro":
                        label3.Text = "Este mês tem 31 dias";
                        break;

                    case "abril":
                    case "junho":
                    case "setembro":
                    case "novembro":
                        label3.Text = "Este mês tem 30 dias";
                        break;

                    case "fevereiro":
                        label3.Text = "Este mês tem 28 ou 29 dias";
                        break;

                    default:
                        MessageBox.Show("Por favor, insira o mês corretamente.");
                        break;
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = " ";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}