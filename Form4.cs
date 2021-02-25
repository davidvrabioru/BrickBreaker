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
namespace Brik_breaker_take_2
{


    public partial class Settings : Form
    {


        Main parentt;
        WindowsMediaPlayer musica;
        WindowsMediaPlayer jump;

        // single
        public static int speedSGL = 16;

        // multi
        public static int speedMLT = 16;
        public static int sensitivityML = 20;


        public Settings(Main parent, WindowsMediaPlayer music, WindowsMediaPlayer jumps)
        {
            parentt = parent;
            parent.Hide();
            musica = music;
            jump = jumps;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Music.Value = musica.settings.volume / 4;
            jumps.Value = jump.settings.volume / 4;

            SpeedSG.Value = speedSGL;
            SpeedML.Value = speedMLT;
            sensitivity.Value = sensitivityML;

            if (Music.Value == 0)
                MusicON.BackColor = Color.Red;
            else
                MusicON.BackColor = Color.Lime;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            parentt.Show();
            Close();
        }

        private void Volume_ValueChanged(object sender, decimal value)
        {
            
            musica.settings.volume = Music.Value * 4;
        }

        private void jumps_ValueChanged(object sender, decimal value)
        {
            jump.settings.volume = jumps.Value * 4;
        }

        private void Volume_ValueChanged_1(object sender, decimal value)
        {
            if(MusicON.BackColor == Color.Lime)
            Music.Value = Volume.Value;
            jumps.Value = Volume.Value;
        }


        private void Color_off()
        {
            
            foreach (Control b in this.Controls)
            {
                if(b is Button)
                {
                    if (musica.URL != "Zelda.mp3")
                        if (b.ForeColor == Color.Red && musica.URL != b.Text + ".mp3")
                            b.ForeColor = Color.Black;
                        else
                              if (b.Text != "Song1")
                            b.ForeColor = Color.Black;
                }
            }
        }

        private void Song1_Click(object sender, EventArgs e)
        {
            Song1.ForeColor = Color.Red;
            musica.URL = "Zelda.mp3";
            Color_off();
        }

        private void Song2_Click(object sender, EventArgs e)
        {
            Song2.ForeColor = Color.Red;
            musica.URL = "Song 2.mp3";
            Color_off();
        }

        private void Song3_Click(object sender, EventArgs e)
        {
            Song3.ForeColor = Color.Red;
            musica.URL = "Song 3.mp3";
            Color_off();
        }

        private void Song4_Click(object sender, EventArgs e)
        {
            Song4.ForeColor = Color.Red;
            musica.URL = "Song 4.mp3";
            Color_off();
        }

        private void Song5_Click(object sender, EventArgs e)
        {
            Song5.ForeColor = Color.Red;
            musica.URL = "Song 5.mp3";
            Color_off();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            jump.controls.play();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int ok = 0;
            if(ok==0)
            if (MusicON.BackColor == Color.Red)
            {
                Song1.Enabled = true;
                Song2.Enabled = true;
                Song3.Enabled = true;
                Song4.Enabled = true;
                Song5.Enabled = true;
                Music.Enabled = true;
                musica.controls.play();
                Music.Value = jumps.Value;
                Volume.Value = jumps.Value;
                MusicON.BackColor = Color.Lime;
                    ok++;
            }
            if(ok==0)
            if (MusicON.BackColor == Color.Lime)
            {
                Song1.Enabled = false;
                Song2.Enabled = false;
                Song3.Enabled = false;
                Song4.Enabled = false;
                Song5.Enabled = false;
                musica.controls.stop();
                Music.Value = 0;
                Music.Enabled = false;
                MusicON.BackColor = Color.Red;
            }
        }

        private void SpeedSG_ValueChanged(object sender, decimal value)
        {
            speedSGL = SpeedSG.Value;

            label8.Text = Convert.ToString(SpeedSG.Value);
            if (SpeedSG.Value > 25)
                label8.ForeColor = Color.Red;
            if (SpeedSG.Value < 10)
                label8.ForeColor = Color.Navy;
            if (SpeedSG.Value >= 10 && SpeedSG.Value <= 25)
                label8.ForeColor = Color.White;
        }

        private void SpeedML_ValueChanged(object sender, decimal value)
        {
            speedMLT = SpeedML.Value;

            Multi.Text = Convert.ToString(SpeedML.Value);
            if (SpeedML.Value > 25)
                Multi.ForeColor = Color.Red;
            if (SpeedML.Value < 10)
                Multi.ForeColor = Color.Navy;
            if (SpeedML.Value >= 10 && SpeedML.Value <= 25)
                Multi.ForeColor = Color.White;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void sensitivity_ValueChanged(object sender, decimal value)
        {
            sensitivityML = sensitivity.Value;
            label10.Text = Convert.ToString(sensitivity.Value);
        }
    }
}
