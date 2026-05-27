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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGray;
            checkBox1.ForeColor = Color.White;
            if (checkBox1.Checked == false)
            {
                panel1.BackColor = Color.Black;
                checkBox1.ForeColor = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Goldenrod;
            checkBox2.ForeColor = Color.White;
            if (checkBox2.Checked == false)
            {
                panel2.BackColor = Color.Black;
                checkBox2.ForeColor = Color.White;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Red;
            checkBox3.ForeColor = Color.White;
            if (checkBox3.Checked == false)
            {
                panel3.BackColor = Color.Black;
                checkBox3.ForeColor = Color.White;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Green;
            checkBox4.ForeColor = Color.White;
            if (checkBox4.Checked == false)
            {
                panel4.BackColor = Color.Black;
                checkBox4.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
