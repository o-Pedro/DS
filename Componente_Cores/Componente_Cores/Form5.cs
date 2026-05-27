using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Cores
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.BackColor = Color.DarkGray;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.Green;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                this.BackColor = Color.Goldenrod;
            }
        }
    }
}
