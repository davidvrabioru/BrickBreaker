using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;



namespace Brik_breaker_take_2
{

    

    public partial class Main : Form
    {

        WindowsMediaPlayer music = new WindowsMediaPlayer();
        WindowsMediaPlayer hover= new WindowsMediaPlayer();

        public static int speedSingle;

        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            axWindowsMediaPlayer1.settings.setMode("Loop", true);
            music.settings.setMode("Loop", true);

            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            music.URL = "Zelda.mp3";
            music.controls.play();
            music.settings.volume = 100;
            hover.settings.volume = 100;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void play_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1(this, music,hover.settings.volume);
            f1.ShowDialog();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            /*
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName("Brick Breaker");
            string fullPath = Path.Combine(exeDir, "..\\Brik breaker take 2\\bg.mov");
            axWindowsMediaPlayer1.URL = fullPath;*/
            axWindowsMediaPlayer1.URL = "bg.mov";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            hover.URL = "jump.wav";
            bloc1.Visible = true;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            hover.URL = "jump.wav";
            bloc2.Visible = true;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            bloc1.Visible = false;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            bloc2.Visible = false;
        }

        private void multi_MouseEnter(object sender, EventArgs e)
        {
            hover.URL = "jump.wav";
            bloc3.Visible = true;
        }

        private void multi_MouseLeave(object sender, EventArgs e)
        {
            bloc3.Visible = false;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            
            Multiplayer1 p1 = new Multiplayer1(this,music,hover.settings.volume);
            p1.ShowDialog();
            

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            bloc4.Visible = true;
            hover.URL = "jump.wav";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            bloc4.Visible = false;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings setari = new Settings(this, music, hover);
            setari.ShowDialog();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            hover.URL = "jump.wav";
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void HighScore_Click(object sender, EventArgs e)
        {
            HighScore form = new HighScore(this, hover);
            form.ShowDialog();
        }
    }
}
// AxWindowsMediaPlayer1.settings.setMode("Loop", True) Loop!!! 