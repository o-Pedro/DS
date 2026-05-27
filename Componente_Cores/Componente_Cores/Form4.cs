using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Componente_Cores
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
                this.BackColor = Color.DarkGray;
                listBox1.ForeColor = Color.White;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.Goldenrod;
                listBox1.ForeColor = Color.White;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                this.BackColor = Color.Green;
                listBox1.ForeColor = Color.White;
            }
            else if(listBox1.SelectedIndex == 3)
            {
                this.BackColor = Color.Red;
                listBox1.ForeColor = Color.White;
            }
        }
    }
}
