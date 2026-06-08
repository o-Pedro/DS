using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes_picturebox
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
                pictureBox1.Image = Properties.Resources.thomas;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.pica;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.tomj;
            }
        }
    }
}
