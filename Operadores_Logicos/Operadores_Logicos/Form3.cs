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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string curso;
                curso = textBox1.Text.ToUpper(); //Converte todas letras para maiúscula
                //try catch não trata espaços vazios para string

                if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    MessageBox.Show("Por favor, insira o curso.");
                    return;
                }

                if (curso == "DS" || curso == "ADM")
                {
                    textBox3.AppendText("Curso escolhido!" + Environment.NewLine + curso + " Curso válido");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tente novamente");
            }
        }
    }
}
