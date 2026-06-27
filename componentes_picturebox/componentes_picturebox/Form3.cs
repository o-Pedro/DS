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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            checkBox1.Checked = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.java;

            if (checkBox1.Checked == false)
            {
                this.pictureBox1.Image = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.portugol2;

            if (checkBox2.Checked == false)
            {
                this.pictureBox2.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.fluxograma;

            if (checkBox3.Checked == false)
            {
                this.pictureBox3.Image = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
