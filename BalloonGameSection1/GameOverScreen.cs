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
    public partial class GameOverScreen : Form
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("GoodBye, have a nice day.", "Goodbye", MessageBoxButtons.OK);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
        }
    }
}
