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
using System.Media;
using Brik_breaker_take_2;
using System.IO;
using System.Text;



namespace Brik_breaker_take_2
{


   


    public partial class Form1 : Form
    {



        WindowsMediaPlayer jump = new WindowsMediaPlayer();
        WindowsMediaPlayer GameOver = new WindowsMediaPlayer();

        public int speed_left = 4;
        public int speed_top = 4;
        public int speed_count = 4;
        public int speed_count_max;
        public int score = 0;
        public int speed_left1 = 5;
        public int speed_top1 = 5;

        
        

        Main paarent;

        WindowsMediaPlayer music;
       
        public Form1(Main parent, WindowsMediaPlayer musica, int soundEffect_Volume)
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.None; // scoate orice bara
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds; // fullscreen

            // ascundem meniul
            parent.Hide();
            paarent = parent;

            music = musica;


            // volum jump
            jump.settings.volume = soundEffect_Volume;
            GameOver.settings.volume = soundEffect_Volume;



            timer2.Enabled = false;
            timer1.Enabled = true;

            ball2.Enabled = false;
            ball2.Visible = false;



            Cursor.Hide();  // ascude cursorul

            ball.Top = playground.Top - (playground.Top / 10);
            paleta.Top = playground.Bottom - (playground.Bottom / 8); // pune jucatorul in partea de jos a paginii
            groupBox1.Visible =  false;
            groupBox1.Enabled = false;


            speed_count_max = Settings.speedSGL;


        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void GameOVER()
        {
            GameOver.URL = "aww.mp3";
            GameOver.controls.play();
            music.controls.stop();
            timer2.Enabled = false;
            timer1.Enabled = false;
            Cursor.Show();

            // oprm mingea
            speed_top = 0;
            speed_left = 0;
            speed_top1 = 0;
            speed_left1 = 0;

            // apare meniul
            paleta.Enabled = false;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;


            // dispar labelurile

            label1.Visible = false;
            label2.Visible = false;

            // scorul final
            scorExit.Text = "Score: " + score;



            // High Score file
            List<string> lines = File.ReadAllLines("HighScore.txt").ToList();
            lines.Add(Convert.ToString(score));
            File.WriteAllLines("HighScore.txt", lines);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paleta.Left = Cursor.Position.X - (paleta.Width / 2);  // ofera coordonatele paletei playerului 

            ball.Left += speed_left; // forta aplicata mingii
            ball.Top += speed_top;


            if(ball.Bottom >= paleta.Top && ball.Bottom <= paleta.Bottom && ball.Right >= paleta.Left && ball.Left <= paleta.Right)  // Coliziunea mingii cu racheta
            {

                jump.URL = "jump.wav";
               
                jump.controls.play();

                if(speed_count <= speed_count_max)
                {
                speed_top += 2;
                speed_left += 2;
                    speed_count += 2;
                }

                speed_top = -speed_top;     // schimba directia mingii.
                score++;
                label1.Text = "Score: " + score;
                label2.Text = "Speed: " + speed_count;
                if (speed_count >= speed_count_max)
                {
                        score++;
                    label2.ForeColor = Color.Red;
                    label1.ForeColor = Color.Red;
                }    
                
                else
                {
                        label2.ForeColor = Color.Black;
                        label1.ForeColor = Color.Black;
                }

            }


            if (score >= 20)
            {
                ball2.Enabled = true;
                ball2.Visible = true;
                timer2.Enabled = true;
            }
                

                    // se verifica coliziunea cu marginile
            if (ball.Left <= playground.Left)
            {speed_left = -speed_left; }
                
            if (ball.Right >= playground.Right)
            {speed_left = -speed_left; }
                
            if (ball.Top <= playground.Top)
            {speed_top = -speed_top; }
                


                // Daca atinge bara de jos, jocul se opreste

            if(ball.Bottom >= playground.Bottom)
            {
                GameOVER();
            }




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.Exit(); } // inchide jocul;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {

            // functia new game

            music.controls.play();
            

            ball2.Enabled = false;
            ball2.Visible = false;


            // resetam valorile
            score = 0;
            speed_left = 4;
            speed_top = 4;
            speed_left1 = 4;
            speed_top1 = 4;
            speed_count = 4;

            // resetam afisarea scorului si a vitezei


            label1.Visible = true;
            label2.Visible = true;
            label2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.Text = "Score: 0";
            label2.Text = "Speed: 0";

            // repozitionam mingea
            ball.Top = playground.Top - (playground.Top / 10);
            ball2.Top = playground.Top - (playground.Top / 10);

            // pornim din nou framurile
            timer1.Enabled = true;

            // ascundem meniu game over
            groupBox1.Enabled = false;
            groupBox1.Visible = false;

            // ascundem cursorul
            Cursor.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            music.controls.play();
            paarent.Show();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            /*Random r = new Random();

            label1.ForeColor = Color.FromArgb(r.Next(100, 255), r.Next(50, 250), r.Next(50, 250));

       */

            ball2.Left += speed_left1; // forta aplicata mingii
            ball2.Top += speed_top1;


            if (ball2.Bottom >= paleta.Top && ball2.Bottom <= paleta.Bottom && ball2.Right >= paleta.Left && ball2.Left <= paleta.Right)  // Coliziunea mingii cu racheta
            {

                jump.URL = "jump.wav";
                jump.controls.play();
                if (speed_count <= speed_count_max * 0.8f)
                {
                    speed_left1 = speed_left1 + 2;
                    speed_top1 = speed_top1 + 2;
                }

                speed_top1 = -speed_top1;     // schimba directia mingii.
                score++;
                label1.Text = "Score: " + score;
                label2.Text = "Speed: " + speed_count;

            }


            // se verifica coliziunea cu marginile
            if (ball2.Left <= playground.Left)
            { speed_left1 = -speed_left1; }

            if (ball2.Right >= playground.Right)
            { speed_left1 = -speed_left1; }

            if (ball2.Top <= playground.Top)
            { speed_top1 = -speed_top1; }



            // Daca atinge bara de jos, jocul se opreste

            if (ball2.Bottom >= playground.Bottom)
            {
                GameOVER();

            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            bloc1.Visible = true;
            jump.URL = "jump.wav";
            jump.controls.play();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            bloc2.Visible = true;
            jump.URL = "jump.wav";
            jump.controls.play();
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            bloc1.Visible = false;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            bloc2.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
