namespace Brik_breaker_take_2
{
    partial class HighScore
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
            this.button1 = new System.Windows.Forms.Button();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score6 = new System.Windows.Forms.Label();
            this.Score5 = new System.Windows.Forms.Label();
            this.Score4 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 26.25F);
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(652, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 119);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1.ForeColor = System.Drawing.Color.White;
            this.Score1.Location = new System.Drawing.Point(741, 214);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(174, 43);
            this.Score1.TabIndex = 1;
            this.Score1.Text = "None";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.ForeColor = System.Drawing.Color.White;
            this.Score2.Location = new System.Drawing.Point(741, 257);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(174, 43);
            this.Score2.TabIndex = 2;
            this.Score2.Text = "None";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score3.ForeColor = System.Drawing.Color.White;
            this.Score3.Location = new System.Drawing.Point(741, 300);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(174, 43);
            this.Score3.TabIndex = 3;
            this.Score3.Text = "None";
            // 
            // Score6
            // 
            this.Score6.AutoSize = true;
            this.Score6.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score6.ForeColor = System.Drawing.Color.White;
            this.Score6.Location = new System.Drawing.Point(741, 429);
            this.Score6.Name = "Score6";
            this.Score6.Size = new System.Drawing.Size(174, 43);
            this.Score6.TabIndex = 6;
            this.Score6.Text = "None";
            // 
            // Score5
            // 
            this.Score5.AutoSize = true;
            this.Score5.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score5.ForeColor = System.Drawing.Color.White;
            this.Score5.Location = new System.Drawing.Point(741, 386);
            this.Score5.Name = "Score5";
            this.Score5.Size = new System.Drawing.Size(174, 43);
            this.Score5.TabIndex = 5;
            this.Score5.Text = "None";
            // 
            // Score4
            // 
            this.Score4.AutoSize = true;
            this.Score4.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score4.ForeColor = System.Drawing.Color.White;
            this.Score4.Location = new System.Drawing.Point(741, 343);
            this.Score4.Name = "Score4";
            this.Score4.Size = new System.Drawing.Size(174, 43);
            this.Score4.TabIndex = 4;
            this.Score4.Text = "None";
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.Score6);
            this.Controls.Add(this.Score5);
            this.Controls.Add(this.Score4);
            this.Controls.Add(this.Score3);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.button1);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score6;
        private System.Windows.Forms.Label Score5;
        private System.Windows.Forms.Label Score4;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}