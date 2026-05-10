using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desvio_Condicional_Seletivo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int day;
                day = Convert.ToInt32(textBox1.Text);

                if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    MessageBox.Show("Por favor, insira um número.");
                    return;
                }

                switch (day)
                {
                    case 1:
                        label3.Text = ("Monday");
                        break;
                    case 2:
                        label3.Text = ("Tuesday");
                        break;
                    case 3:
                        label3.Text = ("Wednesday");
                        break;
                    case 4:
                        label3.Text = ("Thursday");
                        break;
                    case 5:
                        label3.Text = ("Friday");
                        break;
                    case 6:
                        label3.Text = ("Satursday");
                        break;
                    case 7:
                        label3.Text = ("Sunday");
                        break;
                    default:
                        MessageBox.Show("Insira um número de 1 até 7.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
