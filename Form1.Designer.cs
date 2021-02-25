namespace Brik_breaker_take_2
{
    partial class Form1
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
            this.playground = new System.Windows.Forms.Panel();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bloc2 = new System.Windows.Forms.PictureBox();
            this.bloc1 = new System.Windows.Forms.PictureBox();
            this.scorExit = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paleta = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paleta)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.White;
            this.playground.Controls.Add(this.ball2);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.groupBox1);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.paleta);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1584, 862);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ball2
            // 
            this.ball2.BackColor = System.Drawing.Color.Navy;
            this.ball2.Location = new System.Drawing.Point(1129, 114);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(23, 23);
            this.ball2.TabIndex = 6;
            this.ball2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(192, 114);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(23, 23);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bloc2);
            this.groupBox1.Controls.Add(this.bloc1);
            this.groupBox1.Controls.Add(this.scorExit);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.play);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(562, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 294);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bloc2
            // 
            this.bloc2.BackColor = System.Drawing.Color.Navy;
            this.bloc2.Location = new System.Drawing.Point(80, 209);
            this.bloc2.Name = "bloc2";
            this.bloc2.Size = new System.Drawing.Size(38, 36);
            this.bloc2.TabIndex = 9;
            this.bloc2.TabStop = false;
            this.bloc2.Visible = false;
            // 
            // bloc1
            // 
            this.bloc1.BackColor = System.Drawing.Color.Navy;
            this.bloc1.Location = new System.Drawing.Point(80, 146);
            this.bloc1.Name = "bloc1";
            this.bloc1.Size = new System.Drawing.Size(38, 36);
            this.bloc1.TabIndex = 8;
            this.bloc1.TabStop = false;
            this.bloc1.Visible = false;
            // 
            // scorExit
            // 
            this.scorExit.AutoSize = true;
            this.scorExit.BackColor = System.Drawing.Color.White;
            this.scorExit.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scorExit.Location = new System.Drawing.Point(171, 85);
            this.scorExit.Name = "scorExit";
            this.scorExit.Size = new System.Drawing.Size(0, 31);
            this.scorExit.TabIndex = 7;
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(136, 203);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(192, 49);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Main Menu";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // play
            // 
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(136, 140);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(192, 49);
            this.play.TabIndex = 5;
            this.play.Text = "Play again";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(129, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game Over! ";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1383, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed: 4";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: 0";
            // 
            // paleta
            // 
            this.paleta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paleta.Location = new System.Drawing.Point(303, 233);
            this.paleta.Name = "paleta";
            this.paleta.Size = new System.Drawing.Size(200, 20);
            this.paleta.TabIndex = 0;
            this.paleta.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brick breaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox paleta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label scorExit;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.PictureBox bloc2;
        private System.Windows.Forms.PictureBox bloc1;
    }
}

