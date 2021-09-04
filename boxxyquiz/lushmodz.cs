using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BoxxyQuiz
{
    public partial class lushmodz : Form
    {
        public lushmodz()
        {
            InitializeComponent();
        }

        private void lushmodz_Load(object sender, EventArgs e)
        {
            SoundPlayer whosthatyoutuber = new SoundPlayer(Properties.Resources.youtuberwho);
            whosthatyoutuber.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it's lush modz");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rapcream();
            MessageBox.Show("I know people think i cheat but i don't cheat at gta 5 on ps3 lol", "McCreamy");
        }

        private void rapcream()
        {
            SoundPlayer ice = new SoundPlayer(Properties.Resources.mccreamy);
            ice.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pinkboi();
            MessageBox.Show("fuck you im not no gamer boi");
        }

        private void pinkboi()
        {
            SoundPlayer teriyaki = new SoundPlayer(Properties.Resources.pinkguy);
            teriyaki.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("theres a diffrence puriefied uses sub bot", "YouTuber");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That boi american im from europe", "omar ghost");
        }
    }
}
