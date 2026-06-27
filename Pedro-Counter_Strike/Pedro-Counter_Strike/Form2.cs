using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Pedro_Counter_Strike
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player.URL = Application.StartupPath + @"\Counter_Strike_2_Soundtrack_-_Main_Menu_(SkySound.cc).mp3"; // caminho do arquivo
            player.settings.volume = 2;      // volume de 0 a 100
            player.settings.setMode("loop", true); // repetir em loop
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("DESEJA IR PARA A TELA DE ENCERRAMENTO?", "AVISO!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                player.controls.stop(); // para a música do Form2
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
            else
            {

            }
        }

        bool mutado = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (mutado)
            {
                player.settings.mute = false;
                mutado = false;
                button2.BackgroundImage = Properties.Resources.ChatGPT_Image_26_de_jun__de_2026__07_59_03;
            }
            else
            {
                player.settings.mute = true;
                mutado = true;
                button2.BackgroundImage = Properties.Resources.ChatGPT_Image_25_de_jun__de_2026__20_24_34;
            }
        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
