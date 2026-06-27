using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Pedro_Counter_Strike
{
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\cs-go-dance.gif");

            player.URL = Application.StartupPath + @"\Counter_Strike_2_Soundtrack_-_Main_Menu_(SkySound.cc).mp3"; // caminho do arquivo
            player.settings.volume = 2;      // volume de 0 a 100
            player.settings.setMode("loop", true); // repetir em loop
            player.controls.play();
        }
        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop(); // para a música do Form3
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        bool mutado = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (mutado)
            {
                player.settings.mute = false;
                mutado = false;
                button3.BackgroundImage = Properties.Resources.ChatGPT_Image_26_de_jun__de_2026__07_59_06;
            }
            else
            {
                player.settings.mute = true;
                mutado = true;
                button3.BackgroundImage = Properties.Resources.ChatGPT_Image_25_de_jun__de_2026__21_30_11;
            }
        }
    }
}
