using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desvio_Condicional
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro; //declaração de variáveis
            dinheiro = double.Parse(textBox1.Text);

            if (dinheiro > 100.0)
            {
                //MessageBox.Show ("Você tem muito dinheiro!");
                MessageBox.Show ("Você tem muito dinheiro! " + dinheiro, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
