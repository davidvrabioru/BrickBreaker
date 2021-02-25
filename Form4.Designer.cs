namespace Brik_breaker_take_2
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Music = new XComponent.SliderBar.MACTrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.jumps = new XComponent.SliderBar.MACTrackBar();
            this.Volume = new XComponent.SliderBar.MACTrackBar();
            this.Song1 = new System.Windows.Forms.Button();
            this.Song2 = new System.Windows.Forms.Button();
            this.Song3 = new System.Windows.Forms.Button();
            this.Song4 = new System.Windows.Forms.Button();
            this.Song5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MusicON = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SpeedSG = new XComponent.SliderBar.MACTrackBar();
            this.Speed1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SpeedML = new XComponent.SliderBar.MACTrackBar();
            this.Multi = new System.Windows.Forms.Label();
            this.sensitivity = new XComponent.SliderBar.MACTrackBar();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Music
            // 
            this.Music.BackColor = System.Drawing.Color.Transparent;
            this.Music.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Music.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.ForeColor = System.Drawing.Color.White;
            this.Music.IndentHeight = 6;
            this.Music.Location = new System.Drawing.Point(72, 571);
            this.Music.Maximum = 25;
            this.Music.Minimum = 0;
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(654, 47);
            this.Music.TabIndex = 1;
            this.Music.TickColor = System.Drawing.Color.Red;
            this.Music.TickHeight = 4;
            this.Music.TrackerColor = System.Drawing.Color.Navy;
            this.Music.TrackerSize = new System.Drawing.Size(16, 16);
            this.Music.TrackLineColor = System.Drawing.Color.Red;
            this.Music.TrackLineHeight = 3;
            this.Music.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.Music.Value = 25;
            this.Music.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Volume_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1385, 770);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // jumps
            // 
            this.jumps.BackColor = System.Drawing.Color.Transparent;
            this.jumps.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jumps.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumps.ForeColor = System.Drawing.Color.White;
            this.jumps.IndentHeight = 6;
            this.jumps.Location = new System.Drawing.Point(72, 669);
            this.jumps.Maximum = 25;
            this.jumps.Minimum = 0;
            this.jumps.Name = "jumps";
            this.jumps.Size = new System.Drawing.Size(654, 47);
            this.jumps.TabIndex = 3;
            this.jumps.TickColor = System.Drawing.Color.Red;
            this.jumps.TickHeight = 4;
            this.jumps.TrackerColor = System.Drawing.Color.Navy;
            this.jumps.TrackerSize = new System.Drawing.Size(16, 16);
            this.jumps.TrackLineColor = System.Drawing.Color.Red;
            this.jumps.TrackLineHeight = 3;
            this.jumps.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.jumps.Value = 25;
            this.jumps.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.jumps_ValueChanged);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Volume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.ForeColor = System.Drawing.Color.White;
            this.Volume.IndentHeight = 6;
            this.Volume.Location = new System.Drawing.Point(72, 468);
            this.Volume.Maximum = 25;
            this.Volume.Minimum = 0;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(655, 47);
            this.Volume.TabIndex = 4;
            this.Volume.TickColor = System.Drawing.Color.Red;
            this.Volume.TickHeight = 4;
            this.Volume.TrackerColor = System.Drawing.Color.Navy;
            this.Volume.TrackerSize = new System.Drawing.Size(16, 16);
            this.Volume.TrackLineColor = System.Drawing.Color.Red;
            this.Volume.TrackLineHeight = 3;
            this.Volume.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.Volume.Value = 25;
            this.Volume.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Volume_ValueChanged_1);
            // 
            // Song1
            // 
            this.Song1.BackColor = System.Drawing.Color.White;
            this.Song1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song1.Location = new System.Drawing.Point(75, 329);
            this.Song1.Name = "Song1";
            this.Song1.Size = new System.Drawing.Size(126, 65);
            this.Song1.TabIndex = 5;
            this.Song1.Text = "Song1";
            this.Song1.UseVisualStyleBackColor = false;
            this.Song1.Click += new System.EventHandler(this.Song1_Click);
            // 
            // Song2
            // 
            this.Song2.BackColor = System.Drawing.Color.White;
            this.Song2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song2.Location = new System.Drawing.Point(207, 329);
            this.Song2.Name = "Song2";
            this.Song2.Size = new System.Drawing.Size(126, 65);
            this.Song2.TabIndex = 6;
            this.Song2.Text = "Song2";
            this.Song2.UseVisualStyleBackColor = false;
            this.Song2.Click += new System.EventHandler(this.Song2_Click);
            // 
            // Song3
            // 
            this.Song3.BackColor = System.Drawing.Color.White;
            this.Song3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song3.Location = new System.Drawing.Point(339, 329);
            this.Song3.Name = "Song3";
            this.Song3.Size = new System.Drawing.Size(126, 65);
            this.Song3.TabIndex = 7;
            this.Song3.Text = "Song3";
            this.Song3.UseVisualStyleBackColor = false;
            this.Song3.Click += new System.EventHandler(this.Song3_Click);
            // 
            // Song4
            // 
            this.Song4.BackColor = System.Drawing.Color.White;
            this.Song4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song4.Location = new System.Drawing.Point(471, 329);
            this.Song4.Name = "Song4";
            this.Song4.Size = new System.Drawing.Size(126, 65);
            this.Song4.TabIndex = 8;
            this.Song4.Text = "Song4";
            this.Song4.UseVisualStyleBackColor = false;
            this.Song4.Click += new System.EventHandler(this.Song4_Click);
            // 
            // Song5
            // 
            this.Song5.BackColor = System.Drawing.Color.White;
            this.Song5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song5.Location = new System.Drawing.Point(603, 329);
            this.Song5.Name = "Song5";
            this.Song5.Size = new System.Drawing.Size(126, 65);
            this.Song5.TabIndex = 9;
            this.Song5.Text = "Song5";
            this.Song5.UseVisualStyleBackColor = false;
            this.Song5.Click += new System.EventHandler(this.Song5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 900);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Music";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Music Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sound Effects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Volume";
            // 
            // MusicON
            // 
            this.MusicON.BackColor = System.Drawing.Color.Lime;
            this.MusicON.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicON.Location = new System.Drawing.Point(245, 303);
            this.MusicON.Name = "MusicON";
            this.MusicON.Size = new System.Drawing.Size(71, 18);
            this.MusicON.TabIndex = 15;
            this.MusicON.UseVisualStyleBackColor = false;
            this.MusicON.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(875, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "Single Player";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(875, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Muliplayer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(876, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = " Sensitivity";
            // 
            // SpeedSG
            // 
            this.SpeedSG.BackColor = System.Drawing.Color.Transparent;
            this.SpeedSG.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpeedSG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedSG.ForeColor = System.Drawing.Color.Black;
            this.SpeedSG.IndentHeight = 10;
            this.SpeedSG.IndentWidth = 1;
            this.SpeedSG.Location = new System.Drawing.Point(881, 315);
            this.SpeedSG.Maximum = 35;
            this.SpeedSG.Minimum = 0;
            this.SpeedSG.Name = "SpeedSG";
            this.SpeedSG.Size = new System.Drawing.Size(527, 55);
            this.SpeedSG.SmallChange = 10;
            this.SpeedSG.TabIndex = 50;
            this.SpeedSG.TickColor = System.Drawing.Color.Black;
            this.SpeedSG.TickHeight = 4;
            this.SpeedSG.TrackerColor = System.Drawing.Color.Navy;
            this.SpeedSG.TrackerSize = new System.Drawing.Size(16, 16);
            this.SpeedSG.TrackLineColor = System.Drawing.Color.Red;
            this.SpeedSG.TrackLineHeight = 3;
            this.SpeedSG.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.SpeedSG.Value = 16;
            this.SpeedSG.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.SpeedSG_ValueChanged);
            // 
            // Speed1
            // 
            this.Speed1.AutoSize = true;
            this.Speed1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed1.ForeColor = System.Drawing.Color.White;
            this.Speed1.Location = new System.Drawing.Point(876, 286);
            this.Speed1.Name = "Speed1";
            this.Speed1.Size = new System.Drawing.Size(225, 26);
            this.Speed1.TabIndex = 51;
            this.Speed1.Text = "Max Speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1459, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 26);
            this.label8.TabIndex = 52;
            this.label8.Text = "16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(876, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 26);
            this.label9.TabIndex = 54;
            this.label9.Text = "Max Speed:";
            // 
            // SpeedML
            // 
            this.SpeedML.BackColor = System.Drawing.Color.Transparent;
            this.SpeedML.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpeedML.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedML.ForeColor = System.Drawing.Color.Black;
            this.SpeedML.IndentHeight = 10;
            this.SpeedML.IndentWidth = 1;
            this.SpeedML.Location = new System.Drawing.Point(881, 501);
            this.SpeedML.Maximum = 35;
            this.SpeedML.Minimum = 5;
            this.SpeedML.Name = "SpeedML";
            this.SpeedML.Size = new System.Drawing.Size(527, 55);
            this.SpeedML.SmallChange = 10;
            this.SpeedML.TabIndex = 53;
            this.SpeedML.TickColor = System.Drawing.Color.Black;
            this.SpeedML.TickHeight = 4;
            this.SpeedML.TrackerColor = System.Drawing.Color.Navy;
            this.SpeedML.TrackerSize = new System.Drawing.Size(16, 16);
            this.SpeedML.TrackLineColor = System.Drawing.Color.Red;
            this.SpeedML.TrackLineHeight = 3;
            this.SpeedML.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.SpeedML.Value = 16;
            this.SpeedML.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.SpeedML_ValueChanged);
            // 
            // Multi
            // 
            this.Multi.AutoSize = true;
            this.Multi.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.ForeColor = System.Drawing.Color.White;
            this.Multi.Location = new System.Drawing.Point(1459, 512);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(58, 26);
            this.Multi.TabIndex = 55;
            this.Multi.Text = "16";
            // 
            // sensitivity
            // 
            this.sensitivity.BackColor = System.Drawing.Color.Transparent;
            this.sensitivity.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sensitivity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensitivity.ForeColor = System.Drawing.Color.Black;
            this.sensitivity.IndentHeight = 10;
            this.sensitivity.IndentWidth = 1;
            this.sensitivity.Location = new System.Drawing.Point(881, 596);
            this.sensitivity.Maximum = 40;
            this.sensitivity.Minimum = 8;
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Size = new System.Drawing.Size(527, 55);
            this.sensitivity.SmallChange = 10;
            this.sensitivity.TabIndex = 56;
            this.sensitivity.TickColor = System.Drawing.Color.Black;
            this.sensitivity.TickHeight = 4;
            this.sensitivity.TrackerColor = System.Drawing.Color.Navy;
            this.sensitivity.TrackerSize = new System.Drawing.Size(16, 16);
            this.sensitivity.TrackLineColor = System.Drawing.Color.Red;
            this.sensitivity.TrackLineHeight = 3;
            this.sensitivity.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.sensitivity.Value = 20;
            this.sensitivity.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.sensitivity_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1459, 605);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 26);
            this.label10.TabIndex = 57;
            this.label10.Text = "16";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1599, 915);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sensitivity);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpeedML);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Speed1);
            this.Controls.Add(this.SpeedSG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MusicON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Song5);
            this.Controls.Add(this.Song4);
            this.Controls.Add(this.Song3);
            this.Controls.Add(this.Song2);
            this.Controls.Add(this.Song1);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.jumps);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XComponent.SliderBar.MACTrackBar Music;
        private System.Windows.Forms.Button button1;
        private XComponent.SliderBar.MACTrackBar jumps;
        private XComponent.SliderBar.MACTrackBar Volume;
        private System.Windows.Forms.Button Song1;
        private System.Windows.Forms.Button Song2;
        private System.Windows.Forms.Button Song3;
        private System.Windows.Forms.Button Song4;
        private System.Windows.Forms.Button Song5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MusicON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private XComponent.SliderBar.MACTrackBar SpeedSG;
        private System.Windows.Forms.Label Speed1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private XComponent.SliderBar.MACTrackBar SpeedML;
        private System.Windows.Forms.Label Multi;
        private XComponent.SliderBar.MACTrackBar sensitivity;
        private System.Windows.Forms.Label label10;
    }
}