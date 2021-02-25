namespace Brik_breaker_take_2
{
    partial class Multiplayer1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.paleta_albastra = new System.Windows.Forms.PictureBox();
            this.paleta_rosie = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Playground = new System.Windows.Forms.Panel();
            this.gameov = new System.Windows.Forms.GroupBox();
            this.bloc2 = new System.Windows.Forms.PictureBox();
            this.bloc1 = new System.Windows.Forms.PictureBox();
            this.scorExit = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paleta_albastra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paleta_rosie)).BeginInit();
            this.Playground.SuspendLayout();
            this.gameov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(0, 539);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 604);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 543);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(1982, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 532);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Navy;
            this.ball.Location = new System.Drawing.Point(744, 207);
            this.ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(31, 28);
            this.ball.TabIndex = 6;
            this.ball.TabStop = false;
            // 
            // paleta_albastra
            // 
            this.paleta_albastra.BackColor = System.Drawing.Color.Navy;
            this.paleta_albastra.Cursor = System.Windows.Forms.Cursors.Default;
            this.paleta_albastra.Location = new System.Drawing.Point(1011, 50);
            this.paleta_albastra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paleta_albastra.Name = "paleta_albastra";
            this.paleta_albastra.Size = new System.Drawing.Size(267, 25);
            this.paleta_albastra.TabIndex = 7;
            this.paleta_albastra.TabStop = false;
            // 
            // paleta_rosie
            // 
            this.paleta_rosie.BackColor = System.Drawing.Color.Red;
            this.paleta_rosie.Cursor = System.Windows.Forms.Cursors.Default;
            this.paleta_rosie.Location = new System.Drawing.Point(1027, 988);
            this.paleta_rosie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paleta_rosie.Name = "paleta_rosie";
            this.paleta_rosie.Size = new System.Drawing.Size(267, 25);
            this.paleta_rosie.TabIndex = 8;
            this.paleta_rosie.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Playground
            // 
            this.Playground.Controls.Add(this.pictureBox3);
            this.Playground.Controls.Add(this.pictureBox4);
            this.Playground.Controls.Add(this.ball);
            this.Playground.Controls.Add(this.gameov);
            this.Playground.Controls.Add(this.label1);
            this.Playground.Controls.Add(this.speed);
            this.Playground.Controls.Add(this.paleta_albastra);
            this.Playground.Location = new System.Drawing.Point(16, 0);
            this.Playground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(2069, 1108);
            this.Playground.TabIndex = 10;
            // 
            // gameov
            // 
            this.gameov.BackColor = System.Drawing.Color.Black;
            this.gameov.Controls.Add(this.bloc2);
            this.gameov.Controls.Add(this.bloc1);
            this.gameov.Controls.Add(this.scorExit);
            this.gameov.Controls.Add(this.Exit);
            this.gameov.Controls.Add(this.play);
            this.gameov.Controls.Add(this.label3);
            this.gameov.Enabled = false;
            this.gameov.Location = new System.Drawing.Point(744, 373);
            this.gameov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameov.Name = "gameov";
            this.gameov.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameov.Size = new System.Drawing.Size(613, 362);
            this.gameov.TabIndex = 8;
            this.gameov.TabStop = false;
            this.gameov.Visible = false;
            // 
            // bloc2
            // 
            this.bloc2.BackColor = System.Drawing.Color.Navy;
            this.bloc2.Location = new System.Drawing.Point(107, 263);
            this.bloc2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bloc2.Name = "bloc2";
            this.bloc2.Size = new System.Drawing.Size(51, 44);
            this.bloc2.TabIndex = 9;
            this.bloc2.TabStop = false;
            this.bloc2.Visible = false;
            // 
            // bloc1
            // 
            this.bloc1.BackColor = System.Drawing.Color.Navy;
            this.bloc1.Location = new System.Drawing.Point(107, 186);
            this.bloc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bloc1.Name = "bloc1";
            this.bloc1.Size = new System.Drawing.Size(51, 44);
            this.bloc1.TabIndex = 8;
            this.bloc1.TabStop = false;
            this.bloc1.Visible = false;
            // 
            // scorExit
            // 
            this.scorExit.AutoSize = true;
            this.scorExit.BackColor = System.Drawing.Color.Black;
            this.scorExit.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorExit.ForeColor = System.Drawing.Color.White;
            this.scorExit.Location = new System.Drawing.Point(177, 100);
            this.scorExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scorExit.Name = "scorExit";
            this.scorExit.Size = new System.Drawing.Size(116, 39);
            this.scorExit.TabIndex = 7;
            this.scorExit.Text = "Score";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(185, 256);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(256, 60);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Main Menu";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.White;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(185, 178);
            this.play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(256, 60);
            this.play.TabIndex = 5;
            this.play.Text = "Play again";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(167, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game Over! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time:  0.0 s";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.ForeColor = System.Drawing.Color.White;
            this.speed.Location = new System.Drawing.Point(24, 11);
            this.speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(95, 24);
            this.speed.TabIndex = 0;
            this.speed.Text = "Speed: 5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(1982, 535);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 574);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Multiplayer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2138, 1327);
            this.Controls.Add(this.paleta_rosie);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Playground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Multiplayer1";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Multiplayer1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Multiplayer1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Multiplayer1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paleta_albastra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paleta_rosie)).EndInit();
            this.Playground.ResumeLayout(false);
            this.Playground.PerformLayout();
            this.gameov.ResumeLayout(false);
            this.gameov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox paleta_albastra;
        private System.Windows.Forms.PictureBox paleta_rosie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gameov;
        private System.Windows.Forms.PictureBox bloc2;
        private System.Windows.Forms.PictureBox bloc1;
        private System.Windows.Forms.Label scorExit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}