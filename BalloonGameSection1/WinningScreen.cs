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
    public partial class WinningScreen : Form
    {
        public WinningScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            //UserProfile().Show;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want exit?", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Goodbye","Goodbye, have a nice day.");
                Close();
            }
        }
    }
}
