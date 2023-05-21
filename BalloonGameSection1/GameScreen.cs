using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BalloonGameSection1
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
            this.KeyDown += GameScreen_KeyDown;
            this.KeyPreview = true;
            timer1Minute.Interval = 1000;
        }

        //variables go here:
        private Random random = new Random(); //for image position

        public int balloons = 0;
        public int seconds = 60;
        public int lives = 0;
        //public bool ballcolour = false;
        public bool escTriggered = false;

        private bool loadNextBalloons()
        {
            int randBall = random.Next(1, 6);
            pcbBallRed.Image = Image.FromFile($@"Resources\img{randBall}.png");
            pcbBallRed.Location = new Point(random.Next(240, 370), random.Next(0, 530));
            return randBall == 5 ? true : false;
        }

        private void timerRandomBalloon_Tick(object sender, EventArgs e)
        {
            escTriggered = loadNextBalloons();
            timerRandomBalloon.Stop();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            pcbBallRed.Visible=true;
            pcbBallRed.Enabled = true;
            timerRandomBalloon.Enabled = true;
            timer1Minute.Enabled = true;
            timer1Minute.Start();
            this.Focus();
            
        }

        private void pcbBallRed_Click(object sender, EventArgs e)
        {
            if (escTriggered == false && seconds != 0)
            {
                timerRandomBalloon.Start();

                balloons++;
                txtBallCountDsiplay.Text = balloons.ToString();
                if (balloons == 10)
                {
                    
                    timer1Minute.Stop();
                    DialogResult res = MessageBox.Show("You Won!  You caught 10 balloons in less than 1 minute!", "", MessageBoxButtons.OK);
                    Hide();
                    WinningScreen winsrc = new WinningScreen();
                    winsrc.Show();
                }
            }
            
            else
            {
                AddStars();
                timerRandomBalloon.Start();
            }
        }

        private void AddStars()
        {
            lives++;
            foreach (PictureBox pictureBox in panel3.Controls.OfType<PictureBox>())
                if (pictureBox.Name.Last().ToString() == lives.ToString())
                    pictureBox.Visible = true;
            if (lives == 5)
            {
                MessageBox.Show("You Lose");
                GameOverScreen gmovercreen = new GameOverScreen();
                gmovercreen.Show();
                this.Close();
            }
        }


        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && escTriggered == true)
            {
                escTriggered = true;
                loadNextBalloons();
                escTriggered = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1Minute.Stop();
            timerRandomBalloon.Stop();
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Stop", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Hide();
                WinningScreen winscreen = new WinningScreen();
                winscreen.Show();
            }
            if (result == DialogResult.No)
            {
                timer1Minute.Start();
            }
        }

        private void timer1Minute_Tick(object sender, EventArgs e)
        {
            seconds--;
            txtTimerShowCase.Text = seconds.ToString();
            if (seconds <= 0)
            {
                timer1Minute.Stop();
                DialogResult res = MessageBox.Show("Time Up! Do you want to try again?", "Game Over", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    balloons = 0;
                    seconds = 60;
                    timer1Minute.Start();
                    timerRandomBalloon.Start();
                }
                if (res == DialogResult.No)
                {
                    Hide();
                    GameOverScreen gameOver = new GameOverScreen();
                    gameOver.Show();
                }
            }
        }
    }
}

