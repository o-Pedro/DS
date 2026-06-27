using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedro_Counter_Strike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Define os limites da ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Loop que simula o carregamento inicial do sistema
            for (int i = 1; i <= 100; i++)
            {
                // Simula uma tarefa (ex: carregando arquivos de configuração)
                System.Threading.Thread.Sleep(30); // 20 milissegundos por passo

                // Atualiza o valor da barra
                progressBar1.Value = i;

                // Força o Windows Forms a pintar a barra atualizada na tela
                progressBar1.Refresh();
            }

            //  Quando a barra chegar a 100%, abre o Form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
