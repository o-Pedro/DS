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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            //this.BackColor = Color.FromArgb(0, 0, 0)
            radioButton1.ForeColor = Color.DarkGray;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
            //this.BackColor = Color.FromArgb(0, 0, 0)
            radioButton2.ForeColor = Color.Goldenrod;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //this.BackColor = Color.FromArgb(0, 0, 0)
            radioButton3.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb (0, 0, 0);
            //this.BackColor = Color.FromArgb (0, 0, 0)
            radioButton4.ForeColor = Color.FromArgb (0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
