using System;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            player.settings.volume = 100;      // volume de 0 a 100
            player.settings.setMode("loop", true); // repetir em loop
            player.controls.play();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            groupBox2.Visible = false;

            listBox1.Visible = false;
            groupBox1.Visible = false;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Visible = false;
            label4.Visible = false;
            label6.Visible = false;

            if (comboBox1.SelectedIndex == 0)
            {
                radioButton1.Text = "g3nerationX";
                radioButton2.Text = "NIP";
                radioButton3.Text = "Fnatic";
                radioButton4.Text = "mTw";
                radioButton5.Text = "MIBR";
                radioButton6.Text = "Natus Vincere";

                checkBox1.Text = "fNx";
                checkBox2.Text = "f0rest";
                checkBox3.Text = "markeloff";
                checkBox4.Text = "TaZ";
                checkBox5.Text = "SpawN";
                checkBox6.Text = "HeatoN";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                radioButton1.Text = "Evil Genius";
                radioButton2.Text = "3DMAX";
                radioButton3.Text = "Team Dignitas";
                radioButton4.Text = "Very Games";
                radioButton5.Text = "Epsilon eSports";
                radioButton6.Text = "Reason Gaming";

                checkBox1.Text = "shox";
                checkBox2.Text = "RpK";
                checkBox3.Text = "kennyS";
                checkBox4.Text = "Skadoodle";
                checkBox5.Text = "Scream";
                checkBox6.Text = "Ex6TenZ";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                radioButton1.Text = "FaZe Clan";
                radioButton2.Text = "Astralis";
                radioButton3.Text = "SK Gaming";
                radioButton4.Text = "G2 eSports";
                radioButton5.Text = "Virtus.Pro";
                radioButton6.Text = "Mouz";

                checkBox1.Text = "FalleN";
                checkBox2.Text = "s1mple";
                checkBox3.Text = "karrigan";
                checkBox4.Text = "NiKo";
                checkBox5.Text = "GeT_RiGhT";
                checkBox6.Text = "Boombl4";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                radioButton1.Text = "Vitality";
                radioButton2.Text = "Spirit";
                radioButton3.Text = "Furia";
                radioButton4.Text = "The Mongolz";
                radioButton5.Text = "Aurora";
                radioButton6.Text = "Falcons";

                checkBox1.Text = "ZywOo";
                checkBox2.Text = "donk";
                checkBox3.Text = "m0NESY";
                checkBox4.Text = "ropz";
                checkBox5.Text = "molodoy";
                checkBox6.Text = "XANTARES";
            }

            //Times
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            
            groupBox2.Visible = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

            label7.Visible = false;
            label8.Visible = false;

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label5.Visible = false;

            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox2.Image = Properties.Resources.cc4ec90b270b9f1de8dc2d8864425252;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;

                label2.Text = "LANÇADO COMO UMA MODIFICAÇÃO DE HALF-LIFE, COUNTER-STRIKE 1.6 TORNOU-SE UM DOS MAIORES CLÁSSICOS DOS JOGOS DE TIRO. SUA JOGABILIDADE COMPETITIVA, ALIADA À ESTRATÉGIA E COOPERAÇÃO ENTRE JOGADORES, CONQUISTOU MILHÕES DE FÃS E INFLUENCIOU O CRESCIMENTO DOS ESPORTS, DANDO INÍCIO A UMA DAS FRANQUIAS MAIS POPULARES DOS GAMES.";

                listBox1.Items.Add("RIO");
                listBox1.Items.Add("DUST");
                listBox1.Items.Add("POOL PARTY");
                listBox1.Items.Add("TUSCAN");
                listBox1.Items.Add("INFERNO");
                listBox1.Visible = true;

                groupBox1.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox2.Image = Properties.Resources.source2;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;

                label2.Text = "LANÇADO EM 2004, COUNTER-STRIKE SOURCE MOSTROU UMA GRANDE EVOLUÇÃO DA FRANQUIA. O JOGO TROUXE GRÁFICOS MELHORES E AMBIENTES MAIS DETALHADOS. SEM ABANDONAR O ESTILO COMPETITIVO QUE CONSAGROU O CS 1.6, O SOURCE MODERNIZOU A EXPERIÊNCIA DOS JOGADORES E AJUDOU NO CAMINHO PARA AS PRÓXIMAS GERAÇÕES DA SÉRIE.";

                listBox1.Items.Add("AZTEC");
                listBox1.Items.Add("NUKE");
                listBox1.Items.Add("OFFICE");
                listBox1.Items.Add("ASSAULT");
                listBox1.Items.Add("MILITIA");
                listBox1.Visible = true;

                groupBox1.Visible = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox2.Image = Properties.Resources.csgo;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;

                label2.Text = "EM 2012, COUNTER-STRIKE: GLOBAL OFFENSIVE LEVOU A FRANQUIA A OUTRO NÍVEL. COM VISUAIS MELHORADOS, NOVO MAPAS, ARMAS E MODOS DE JOGO, O CS:GO EXPANDIU A EXPERIÊNCIA COMPETITIVA DA SÉRIE. MANTENDO A JOGABILIDADE QUE CONSAGROU SEUS ANTECESSORES, O JOGO SE TORNOU O MAIOR E-SPORTS DO MUNDO E MARCOU UMA NOVA ERA PARA O ESTILO DE JOGO FPS.";

                listBox1.Items.Add("CACHE");
                listBox1.Items.Add("DUST 2");
                listBox1.Items.Add("COBBLESTONE");
                listBox1.Items.Add("VERTIGO");
                listBox1.Items.Add("ITALY");
                listBox1.Visible = true;

                groupBox1.Visible = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox2.Image = Properties.Resources.cs2;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;

                label2.Text = "LANÇADO NO FINAL DE 2023, O COUNTER-STRIKE 2 É A VERSÃO ATUAL DA FRANQUIA E REPRESENTA SUA MAIOR EVOLUÇÃO TÉCNICA. DESENVOLVIDO COM A SOURCE 2 ENGINE, O JOGO TROUXE MELHORIAS EM VÁRIOS ASPÉCTOS, GRÁFICOS, FUMAÇAS DINÂMICAS E JOGABILIDADE. MANTENDO A ESSÊNCIA DE SEMPRE DA FRANQUIA, O CS2 SEGUE UM DOS PRINCÍPAIS JOGOS DO MUNDO.";

                listBox1.Items.Add("OVERPASS");
                listBox1.Items.Add("ANUBIS");
                listBox1.Items.Add("ANCIENT");
                listBox1.Items.Add("MIRAGE");
                listBox1.Items.Add("BAGGAGE");
                listBox1.Visible = true;

                groupBox1.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = true;

            if (comboBox1.SelectedIndex == 0)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.rio;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.dust;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.pool;
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.tuscan;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.inferno;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.aztec;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.nuke;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.office;
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.assault;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.militia;
                }

            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.cache;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.dust2;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.cobblestone;
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.vertigo;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.italy;
                }

            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.overpass;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.anubis;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.ancient;
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.mirage;
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.baggage;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO UCRANIANA QUE MARCOU ÉPOCA NO CS 1.6 COM UMA EQUIPE HISTÓRICA, CONQUISTANDO TÍTULOS IMPORTANTES E INFLUENCIANDO GERAÇÕES DE JOGADORES.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.navi_time;
                pictureBox4.Image = Properties.Resources.navi_logo;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO BRITÂNICA QUE MANTEVE EQUIPES COMPETITIVAS NO CENÁRIO DE COUNTER-STRIKE: SOURCE, PARTICIPANDO DE IMPORTANTOS TORNEIOS EUROPEUS E REVELANDO JOGADORES DE DESTAQUE.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.reason_time__1_;
                pictureBox4.Image = Properties.Resources.reason_logo;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO ALEMÃ QUE SE DESTACOU NO CS:GO POR DESENVOLVER JOVENS TALENTOS E FORMAR EQUIPES COMPETITIVAS. AO LONGO DOS ANOS, A MOUZ PARTICIPOU DE GRANDES TORNEIOS E REVELOU JOGADORES QUE SE TORNARAM DESTAQUES INTERNACIONAIS.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.mouz_time;
                pictureBox4.Image = Properties.Resources.mouz_logo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO QUE GANHOU ESPAÇO NO CENÁRIO COMPETITIVO DO CS2 AO INVESTIR EM GRANDES JOGADORES E ELENCOS COMPETITIVOS. A EQUIPE PASSOU A PARTICIPAR DE IMPORTANTES TORNEIOS INTERNACIONAIS E BUSCAR SEU ESPAÇO ENTRE AS GRANDES FORÇAS DO CENÁRIO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.falcons_time2;
                pictureBox4.Image = Properties.Resources.falcons_logo2;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO BRASILEIRA QUE SE DESTACOU NO CENÁRIO DO CS 1.6, REVELANDO TALENTOS E PARTICIPANDO DE IMPORTANTES COMPETIÇÕES NACIONAIS DURANTE O CRESCIMENTO DOS ESPORTS.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.g3x_time;
                pictureBox4.Image = Properties.Resources.g3x_logo;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO NORTE-AMERICANA QUE MANTEVE EQUIPES COMPETITIVAS NO CENÁRIO DE COUNTER-STRIKE: SOURCE, PARTICIPANDO DE IMPORTANTES TORNEIOS NORTE-AMERICANOS E REVELANDO JOGADORES DE DESTAQUE.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.evil_g_time;
                pictureBox4.Image = Properties.Resources.evil_g_logo;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO INTERNACIONAL QUE SE DESTACOU NO CS:GO POR REUNIR GRANDES JOGADORES DE DIFERENTES PAÍSES. A EQUIPE PARTICIPOU DE DIVERSOS GRANDES TORNEIOS E SE TORNOU UMA DAS MAIS POPULARES E RECONHECIDAS DO CENÁRIO COMPETITIVO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.faze_time;
                pictureBox4.Image = Properties.Resources.faze_logo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO FRANCESA QUE SE TORNOU UMA DAS PRINCIPAIS FORÇAS DO CS2, REUNINDO GRANDES JOGADORES E CONQUISTANDO IMPORTANTES TORNEIOS INTERNACIONAIS. A EQUIPE SE DESTACOU POR SUA CONSISTÊNCIA E PELO ALTO NÍVEL APRESENTADO NAS GRANDES COMPETIÇÕES.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.vitality_time;
                pictureBox4.Image = Properties.Resources.vitality_logo;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "EQUIPE SUECA QUE SE TORNOU UMA DAS MAIS TRADICIONAIS DO CS 1.6, REUNINDO GRANDES JOGADORES E CONQUISTANDO RESULTADOS MARCANTES NO CENÁRIO INTERNACIONAL.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.nip_time;
                pictureBox4.Image = Properties.Resources.nip_logo;
            }
            if (comboBox1.SelectedIndex == 1) {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO FRANCESA QUE MANTEVE EQUIPES COMPETITIVAS NO CENÁRIO DE COUNTER-STRIKE: SOURCE, PARTICIPANDO DE IMPORTANTES TORNEIOS EUROPEUS E REVELANDO JOGADORES DE DESTAQUE.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources._3d_time;
                pictureBox4.Image = Properties.Resources._3d_logo;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO DINAMARQUESA QUE DOMINOU O CENÁRIO COMPETITIVO DO CS:GO, CONQUISTANDO GRANDES TORNEIOS E FORMANDO UM DOS ELENCOS MAIS VITORIOSOS DA HISTÓRIA. SUA CONSISTÊNCIA, ESTRATÉGIA E DESEMPENHO EM GRANDES CAMPEONATOS MARCARAM UMA ERA DO JOGO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.astralis_time;
                pictureBox4.Image = Properties.Resources.astralis_logo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO RUSSA QUE GANHOU GRANDE DESTAQUE NO CS2 COM UMA EQUIPE JOVEM E EXTREMAMENTE COMPETITIVA. O TIME CONQUISTOU GRANDES TÍTULOS E SE TORNOU UMA DAS PRINCIPAIS FORÇAS DO CENÁRIO INTERNACIONAL, DESTACANDO-SE POR SEU ESTILO AGRESSIVO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.spirit_time;
                pictureBox4.Image = Properties.Resources.spirit_logo;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO SUECA QUE CONSTRUIU UMA HISTÓRIA VITORIOSA NO CS 1.6, ACUMULANDO TÍTULOS E CONSOLIDANDO SUA POSIÇÃO ENTRE AS MAIORES EQUIPES DA MODALIDADE.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.fnatic_time;
                pictureBox4.Image = Properties.Resources.fnatic_logo;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO BRITÂNICA QUE MANTEVE EQUIPES COMPETITIVAS NO CENÁRIO DE COUNTER-STRIKE: SOURCE, CONQUISTANDO TORNEIOS REGIONAIS E REVELANDO JOGADORES DE DESTAQUE.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.dignitas_time;
                pictureBox4.Image = Properties.Resources.dignitas_logo;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO QUE TEVE UMA DAS FASES MAIS MARCANTES DO BRASIL NO CS:GO, ESPECIALMENTE COM SEU ELENCO BRASILEIRO. CONQUISTANDO GRANDES TORNEIOS INTERNACIONAIS, A EQUIPE LEVOU O NOME DO BRASIL AO TOPO DO CENÁRIO COMPETITIVO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.sk_time;
                pictureBox4.Image = Properties.Resources.sk_logo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO BRASILEIRA QUE SE MANTEVE ENTRE AS PRINCIPAIS EQUIPES DO CS2, REPRESENTANDO O BRASIL EM GRANDES COMPETIÇÕES INTERNACIONAIS. CONHECIDA POR SEU ESTILO AGRESSIVO, A FURIA CONTINUOU REVELANDO JOGADORES E MARCANDO PRESENÇA NO CENÁRIO MUNDIAL.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.furia_time;
                pictureBox4.Image = Properties.Resources.furia_logo;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "EQUIPE DINAMARQUESA QUE GANHOU DESTAQUE NO CS 1.6 POR SUA CONSISTÊNCIA, ELENCO DE ALTO NÍVEL E PARTICIPAÇÃO EM GRANDES TORNEIOS INTERNACIONAIS.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.mtw_time;
                pictureBox4.Image = Properties.Resources.mtw_logo;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "EQUIPE FRANCESA QUE SE DESTACOU NO CS: SOURCE POR SEU DOMÍNIO COMPETITIVO, ELENCO DE ALTO NÍVEL E CONQUISTAS EM GRANDES TORNEIOS INTERNACIONAIS.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.very_time;
                pictureBox4.Image = Properties.Resources.very_logo;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO EUROPEIA QUE SE CONSOLIDOU COMO UMA DAS GRANDES FORÇAS DO CS:GO, REUNINDO JOGADORES DE ALTO NÍVEL E PARTICIPANDO DE IMPORTANTES CAMPEONATOS. A EQUIPE MARCOU PRESENÇA EM GRANDES DISPUTAS DO CENÁRIO INTERNACIONAL.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.g2_time;
                pictureBox4.Image = Properties.Resources.g2_logo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO MONGOL QUE SE TORNOU UM DOS GRANDES DESTAQUES DO CS2, REPRESENTANDO A ÁSIA NO CENÁRIO INTERNACIONAL. COM UM ELENCO JOVEM E TALENTOSO, A EQUIPE CONQUISTOU RESULTADOS IMPORTANTES E PASSOU A COMPETIR DE IGUAL PARA IGUAL COM GRANDES TIMES.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.molgo_time;
                pictureBox4.Image = Properties.Resources.molgo_logo;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO BRASILEIRA QUE SE TORNOU UM DOS MAIORES SÍMBOLOS DO CS 1.6, CONQUISTANDO TÍTULOS MUNDIAIS E ELEVANDO O NOME DO BRASIL NOS ESPORTS.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.mibr_time;
                pictureBox4.Image = Properties.Resources.mibr_logo;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "EQUIPE EUROPEIA QUE GANHOU DESTAQUE NO CS: SOURCE POR SUA FORÇA COMPETITIVA, ELENCO DE ALTO NÍVEL E PARTICIPAÇÃO EM GRANDES TORNEIOS INTERNACIONAIS.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.epsilon_time;
                pictureBox4.Image = Properties.Resources.epsilon_logo;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO POLONESA QUE CONSTRUIU UMA HISTÓRIA MARCANTE NO CS:GO, PRINCIPALMENTE COM SEU FAMOSO ELENCO POLONÊS. A EQUIPE CONQUISTOU IMPORTANTES TORNEIOS E SE TORNOU UMA DAS MAIS TRADICIONAIS DA ERA COMPETITIVA DO JOGO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.virtus_time;
                pictureBox4.Image = Properties.Resources.virtus_logo;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label5.Text = "ORGANIZAÇÃO QUE GANHOU DESTAQUE NO CENÁRIO COMPETITIVO DO CS2 COM UM ELENCO JOVEM E PROMISSOR. A EQUIPE PASSOU A DISPUTAR GRANDES TORNEIOS INTERNACIONAIS, MOSTRANDO EVOLUÇÃO E BUSCANDO SE CONSOLIDAR ENTRE OS PRINCIPAIS TIMES DO CENÁRIO.";

                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Image = Properties.Resources.aurora_time;
                pictureBox4.Image = Properties.Resources.aurora_logo2;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label9.Visible = true;
                    label9.Text = "fNx";
                    pictureBox5.Visible = true;
                    pictureBox5.Image = Properties.Resources.fnx;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label9.Visible = true;
                    label9.Text = "shox";
                    pictureBox5.Visible = true;
                    pictureBox5.Image = Properties.Resources.shox;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label9.Visible = true;
                    label9.Text = "FalleN";
                    pictureBox5.Visible = true;
                    pictureBox5.Image = Properties.Resources.fallen;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label9.Visible = true;
                    label9.Text = "ZywOo";
                    pictureBox5.Visible = true;
                    pictureBox5.Image = Properties.Resources.zywoo;
                }
            }
            else
            {
                pictureBox5.Visible = false;
                label9.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label10.Visible = true;
                    label10.Text = "f0rest";
                    pictureBox6.Visible = true;
                    pictureBox6.Image = Properties.Resources.forest;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label10.Visible = true;
                    label10.Text = "RpK";
                    pictureBox6.Visible = true;
                    pictureBox6.Image = Properties.Resources.rpk;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label10.Visible = true;
                    label10.Text = "s1mple";
                    pictureBox6.Visible = true;
                    pictureBox6.Image = Properties.Resources.s1mple;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label10.Visible = true;
                    label10.Text = "donk";
                    pictureBox6.Visible = true;
                    pictureBox6.Image = Properties.Resources.donk;
                }
            }
            else
            {
                pictureBox6.Visible = false;
                label10.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label11.Visible = true;
                    label11.Text = "markeloff";
                    pictureBox8.Visible = true;
                    pictureBox8.Image = Properties.Resources.markeloff;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label11.Visible = true;
                    label11.Text = "kennyS";
                    pictureBox8.Visible = true;
                    pictureBox8.Image = Properties.Resources.kenny;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label11.Visible = true;
                    label11.Text = "karrigan";
                    pictureBox8.Visible = true;
                    pictureBox8.Image = Properties.Resources.karrigan;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label11.Visible = true;
                    label11.Text = "m0NESY";
                    pictureBox8.Visible = true;
                    pictureBox8.Image = Properties.Resources.m0nesy;
                }
            }
            else
            {
                pictureBox8.Visible = false;
                label11.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label13.Visible = true;
                    label13.Text = "TaZ";
                    pictureBox7.Visible = true;
                    pictureBox7.Image = Properties.Resources.taz;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label13.Visible = true;
                    label13.Text = "Skadoodle";
                    pictureBox7.Visible = true;
                    pictureBox7.Image = Properties.Resources.skadoodle;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label13.Visible = true;
                    label13.Text = "NiKo";
                    pictureBox7.Visible = true;
                    pictureBox7.Image = Properties.Resources.niko;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label13.Visible = true;
                    label13.Text = "ropz";
                    pictureBox7.Visible = true;
                    pictureBox7.Image = Properties.Resources.ropz;
                }
            }
            else
            {
                label13.Visible = false;
                pictureBox7.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label12.Visible = true;
                    label12.Text = "SpawN";
                    pictureBox10.Visible = true;
                    pictureBox10.Image = Properties.Resources.spawn;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label12.Visible = true;
                    label12.Text = "ScreaM";
                    pictureBox10.Visible = true;
                    pictureBox10.Image = Properties.Resources.scream;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label12.Visible = true;
                    label12.Text = "GeT_RiGhT";
                    pictureBox10.Visible = true;
                    pictureBox10.Image = Properties.Resources.get_right;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label12.Visible = true;
                    label12.Text = "molodoy";
                    pictureBox10.Visible = true;
                    pictureBox10.Image = Properties.Resources.molodoy;
                }
            }
            else
            {
                label12.Visible = false;
                pictureBox10.Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label14.Visible = true;
                    label14.Text = "HeatoN";
                    pictureBox9.Visible = true;
                    pictureBox9.Image = Properties.Resources.heaton;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label14.Visible = true;
                    label14.Text = "Ex6TenZ";
                    pictureBox9.Visible = true;
                    pictureBox9.Image = Properties.Resources.ex6tenz;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label14.Visible = true;
                    label14.Text = "Boombl4";
                    pictureBox9.Visible = true;
                    pictureBox9.Image = Properties.Resources.boombl4;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label14.Visible = true;
                    label14.Text = "XANTARES";
                    pictureBox9.Visible = true;
                    pictureBox9.Image = Properties.Resources.xantares;
                }
            }
            else
            {
                label14.Visible = false;
                pictureBox9.Visible = false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }

}
