using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalloonGameSection1
{
    public partial class WelcomeScreen : Form
    {
        private int progress = 0;
        
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            progressLabel.Visible = true;
            progressBar1.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress < 100)
            {
                progress++;
                progressBar1.Value = progress;
                progressLabel.Text = progress.ToString() + "%";
            }
            if (progress == 100)
            {
                timer1.Stop();
                GameScreen gameScrn = new GameScreen();
                gameScrn.Show();
                this.Hide();
            }
            
        }
    }
}
