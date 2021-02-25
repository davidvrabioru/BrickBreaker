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
using System.IO;
namespace Brik_breaker_take_2
{
    public partial class HighScore : Form
    {

        Main Parent;
        WindowsMediaPlayer SoundEffects;
        WindowsMediaPlayer hover = new WindowsMediaPlayer();
        public HighScore(Main Parrent, WindowsMediaPlayer efect)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Parent = Parrent;
            SoundEffects = efect;

            Parent.Hide();



        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines("HighScore.txt").ToList();

            string[] score;
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                Score1.Text = entries[0];
                Score2.Text = entries[1];
                Score3.Text = entries[2];
                Score4.Text = entries[3];
                Score5.Text = entries[4];
                Score6.Text = entries[5];
            }

            
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            button1.BackColor = Color.Navy;
            hover.URL = "jump.wav";
            hover.controls.play();

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
