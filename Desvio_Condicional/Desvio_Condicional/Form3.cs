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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro;
            dinheiro = double.Parse(textBox1.Text);

            if (dinheiro > 100.0)
            {
                MessageBox.Show("Você tem muito dinheiro! " + dinheiro, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Você precisa de mais dinheiro... " + dinheiro, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
