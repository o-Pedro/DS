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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.javascript;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.html2;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.css;
            }
        }
    }
}
