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
    
    public partial class Multiplayer1 : Form
    {


       
        WindowsMediaPlayer jump = new WindowsMediaPlayer();
        

       // player
            bool goleft;
            bool goright;

            bool goleft_blue;
            bool goright_blue;
            

        // ball
            int speed_left = 5;
            int speed_top = 5;
            int ball_speed = 5;

        // time

        float time = 0.0f;

        Main paarent;
        WindowsMediaPlayer music;

        public Multiplayer1(Main parent, WindowsMediaPlayer musica, int soundEffect_volume)
        {

            InitializeComponent();

            // ichidem meniul principal
            parent.Hide();
            paarent = parent;
            music = musica;

            jump.settings.volume = soundEffect_volume;

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            
           
        }

        private void Multiplayer1_Load(object sender, EventArgs e)
        {
          
            Cursor.Hide();
        }
        int p = 0;
        private void Multiplayer1_KeyDown(object sender, KeyEventArgs e)
        {
      

            // Player rosu

            
            if (e.KeyCode == Keys.Right)
                goright = true;
           
            if (e.KeyCode == Keys.Left)
                goleft = true;



            // Player albastru


            if (e.KeyCode == Keys.D)
                goright_blue = true;

            if (e.KeyCode == Keys.A)
                goleft_blue = true;



        }

        private void Multiplayer1_KeyUp(object sender, KeyEventArgs e)
        {
            // player rosu


            if (e.KeyCode == Keys.Right)
                goright = false;
            if (e.KeyCode == Keys.Left)
                goleft = false;


            // Player albastru


            if (e.KeyCode == Keys.D)
                goright_blue = false;

            if (e.KeyCode == Keys.A)
                goleft_blue = false;

        }



        private void GameOver(int player)
        {
            timer1.Enabled = false;
            speed.Visible = false;
            label1.Visible = false;
            Cursor.Show();
            music.controls.stop();

            gameov.Visible = true;
            gameov.Enabled = true;
            if (player == 1)
                label3.Text = "Player 1 Wins! ";
            if(player == 2)
            {
                label3.ForeColor = Color.Navy;
                label3.Text = "Player 2 Wins! ";
            }
            scorExit.Text = "Time: " + time + "s";
 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Player rosu  
            if (paleta_rosie.Left <= Playground.Left) // verificam sa nu fie pe margine
                goleft = false;
            if (goleft)
                paleta_rosie.Left -= Settings.sensitivityML;
            if (paleta_rosie.Right >= Playground.Right) // verificam sa nu fie pe margine
                goright = false;
                if (goright)
                paleta_rosie.Left += Settings.sensitivityML;

            // Player albastru

            if (paleta_albastra.Left <= Playground.Left)
                goleft_blue = false;
            if (goleft_blue)
                paleta_albastra.Left -= Settings.sensitivityML;

            if (paleta_albastra.Right >= Playground.Right)
                goright_blue = false;
            if (goright_blue)
                paleta_albastra.Left += Settings.sensitivityML;

            


            // Ball

            ball.Left += speed_left;
            ball.Top += speed_top;

            
 


            if (ball.Right >= Playground.Right)
                speed_left = -speed_left;
            if (ball.Left <= Playground.Left)
                speed_left = -speed_left;




            // Ball Colider


            if (ball.Bottom >= paleta_rosie.Top && ball.Bottom <= paleta_rosie.Bottom && ball.Left >= paleta_rosie.Left && ball.Right <= paleta_rosie.Right)
            {
                ball.BackColor = Color.Red;
                jump.URL = "jump.wav";
                jump.controls.play();
                if (ball_speed <= Settings.speedMLT)
                {
                    speed_left += 3 ;
                    speed_top += 3;
                    ball_speed += 3;
                }
                speed_top = -speed_top;         
            }

            if (ball.Top >= paleta_albastra.Top && ball.Top <= paleta_albastra.Bottom && ball.Left >= paleta_albastra.Left && ball.Right <= paleta_albastra.Right)
            {
                jump.URL = "jump.wav";
                jump.controls.play();
                speed_top = -speed_top;
                ball.BackColor = Color.Navy;
            }


            // speed 

            speed.Text = "Speed: " + ball_speed;

           // time 
           
            time += 0.02f;
            label1.Text = "Time: " + time + " s";



            // Ball STOP GamgeOver


            
            if (ball.Top <= Playground.Top)
                GameOver(1);
            if (ball.Bottom >= Playground.Bottom)
                GameOver(2);
            




        }

        private void play_Click(object sender, EventArgs e)
        {
            music.controls.play();
            Multiplayer1 forma = new Multiplayer1(paarent, music, jump.settings.volume);
            this.Close();
            forma.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            music.controls.play();
            paarent.Show();
            this.Close();
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            jump.URL = "jump.wav";
            jump.controls.play();
            bloc1.Visible = true;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            bloc1.Visible = false;

        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            jump.URL = "jump.wav";
            jump.controls.play();
            bloc2.Visible = true;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            bloc2.Visible = false;
        }
    }
}
