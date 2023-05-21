namespace BalloonGameSection1
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbBallRed = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimerShowCase = new System.Windows.Forms.Label();
            this.txtBallCountDsiplay = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.Label();
            this.txtBalloonCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBoxLife5 = new System.Windows.Forms.PictureBox();
            this.picBoxLife4 = new System.Windows.Forms.PictureBox();
            this.picBoxLife3 = new System.Windows.Forms.PictureBox();
            this.picBoxLife2 = new System.Windows.Forms.PictureBox();
            this.picBoxLife1 = new System.Windows.Forms.PictureBox();
            this.lblNumberLives = new System.Windows.Forms.Label();
            this.timer1Minute = new System.Windows.Forms.Timer(this.components);
            this.timerRandomBalloon = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBallRed)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcbBallRed);
            this.panel1.Location = new System.Drawing.Point(30, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 599);
            this.panel1.TabIndex = 0;
            // 
            // pcbBallRed
            // 
            this.pcbBallRed.Enabled = false;
            this.pcbBallRed.Image = ((System.Drawing.Image)(resources.GetObject("pcbBallRed.Image")));
            this.pcbBallRed.Location = new System.Drawing.Point(531, 429);
            this.pcbBallRed.Margin = new System.Windows.Forms.Padding(2);
            this.pcbBallRed.Name = "pcbBallRed";
            this.pcbBallRed.Size = new System.Drawing.Size(102, 153);
            this.pcbBallRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBallRed.TabIndex = 0;
            this.pcbBallRed.TabStop = false;
            this.pcbBallRed.Visible = false;
            this.pcbBallRed.Click += new System.EventHandler(this.pcbBallRed_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimerShowCase);
            this.panel2.Controls.Add(this.txtBallCountDsiplay);
            this.panel2.Controls.Add(this.txtTimer);
            this.panel2.Controls.Add(this.txtBalloonCount);
            this.panel2.Location = new System.Drawing.Point(699, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 115);
            this.panel2.TabIndex = 1;
            // 
            // txtTimerShowCase
            // 
            this.txtTimerShowCase.AutoSize = true;
            this.txtTimerShowCase.Location = new System.Drawing.Point(106, 57);
            this.txtTimerShowCase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTimerShowCase.Name = "txtTimerShowCase";
            this.txtTimerShowCase.Size = new System.Drawing.Size(0, 13);
            this.txtTimerShowCase.TabIndex = 3;
            // 
            // txtBallCountDsiplay
            // 
            this.txtBallCountDsiplay.AutoSize = true;
            this.txtBallCountDsiplay.Location = new System.Drawing.Point(106, 16);
            this.txtBallCountDsiplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBallCountDsiplay.Name = "txtBallCountDsiplay";
            this.txtBallCountDsiplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBallCountDsiplay.Size = new System.Drawing.Size(13, 13);
            this.txtBallCountDsiplay.TabIndex = 2;
            this.txtBallCountDsiplay.Text = "0";
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Location = new System.Drawing.Point(48, 57);
            this.txtTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(36, 13);
            this.txtTimer.TabIndex = 1;
            this.txtTimer.Text = "Timer:";
            // 
            // txtBalloonCount
            // 
            this.txtBalloonCount.AutoSize = true;
            this.txtBalloonCount.Location = new System.Drawing.Point(10, 16);
            this.txtBalloonCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBalloonCount.Name = "txtBalloonCount";
            this.txtBalloonCount.Size = new System.Drawing.Size(76, 13);
            this.txtBalloonCount.TabIndex = 0;
            this.txtBalloonCount.Text = "Balloon Count:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picBoxLife5);
            this.panel3.Controls.Add(this.picBoxLife4);
            this.panel3.Controls.Add(this.picBoxLife3);
            this.panel3.Controls.Add(this.picBoxLife2);
            this.panel3.Controls.Add(this.picBoxLife1);
            this.panel3.Controls.Add(this.lblNumberLives);
            this.panel3.Location = new System.Drawing.Point(699, 168);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 73);
            this.panel3.TabIndex = 2;
            // 
            // picBoxLife5
            // 
            this.picBoxLife5.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLife5.Image")));
            this.picBoxLife5.Location = new System.Drawing.Point(212, 32);
            this.picBoxLife5.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLife5.Name = "picBoxLife5";
            this.picBoxLife5.Size = new System.Drawing.Size(41, 32);
            this.picBoxLife5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLife5.TabIndex = 5;
            this.picBoxLife5.TabStop = false;
            this.picBoxLife5.Visible = false;
            // 
            // picBoxLife4
            // 
            this.picBoxLife4.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLife4.Image")));
            this.picBoxLife4.Location = new System.Drawing.Point(160, 32);
            this.picBoxLife4.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLife4.Name = "picBoxLife4";
            this.picBoxLife4.Size = new System.Drawing.Size(41, 32);
            this.picBoxLife4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLife4.TabIndex = 4;
            this.picBoxLife4.TabStop = false;
            this.picBoxLife4.Visible = false;
            // 
            // picBoxLife3
            // 
            this.picBoxLife3.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLife3.Image")));
            this.picBoxLife3.Location = new System.Drawing.Point(109, 32);
            this.picBoxLife3.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLife3.Name = "picBoxLife3";
            this.picBoxLife3.Size = new System.Drawing.Size(41, 32);
            this.picBoxLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLife3.TabIndex = 3;
            this.picBoxLife3.TabStop = false;
            this.picBoxLife3.Visible = false;
            // 
            // picBoxLife2
            // 
            this.picBoxLife2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLife2.Image")));
            this.picBoxLife2.Location = new System.Drawing.Point(61, 32);
            this.picBoxLife2.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLife2.Name = "picBoxLife2";
            this.picBoxLife2.Size = new System.Drawing.Size(41, 32);
            this.picBoxLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLife2.TabIndex = 2;
            this.picBoxLife2.TabStop = false;
            this.picBoxLife2.Visible = false;
            // 
            // picBoxLife1
            // 
            this.picBoxLife1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxLife1.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLife1.Image")));
            this.picBoxLife1.Location = new System.Drawing.Point(10, 32);
            this.picBoxLife1.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLife1.Name = "picBoxLife1";
            this.picBoxLife1.Size = new System.Drawing.Size(41, 32);
            this.picBoxLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLife1.TabIndex = 1;
            this.picBoxLife1.TabStop = false;
            this.picBoxLife1.Visible = false;
            // 
            // lblNumberLives
            // 
            this.lblNumberLives.AutoSize = true;
            this.lblNumberLives.Location = new System.Drawing.Point(16, 12);
            this.lblNumberLives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberLives.Name = "lblNumberLives";
            this.lblNumberLives.Size = new System.Drawing.Size(120, 13);
            this.lblNumberLives.TabIndex = 0;
            this.lblNumberLives.Text = "Number Of Used Lives :";
            // 
            // timer1Minute
            // 
            this.timer1Minute.Tick += new System.EventHandler(this.timer1Minute_Tick);
            // 
            // timerRandomBalloon
            // 
            this.timerRandomBalloon.Tick += new System.EventHandler(this.timerRandomBalloon_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(712, 271);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(838, 271);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 34);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 657);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBallRed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLife1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbBallRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Label txtBalloonCount;
        private System.Windows.Forms.Label txtTimerShowCase;
        private System.Windows.Forms.Label txtBallCountDsiplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxLife5;
        private System.Windows.Forms.PictureBox picBoxLife4;
        private System.Windows.Forms.PictureBox picBoxLife3;
        private System.Windows.Forms.PictureBox picBoxLife2;
        private System.Windows.Forms.PictureBox picBoxLife1;
        private System.Windows.Forms.Label lblNumberLives;
        private System.Windows.Forms.Timer timer1Minute;
        private System.Windows.Forms.Timer timerRandomBalloon;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}