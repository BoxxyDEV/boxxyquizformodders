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
    public partial class whomadeutp : Form
    {
        public whomadeutp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is correct");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotYourDope Just maintains the mod and updates it");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            telstrathewankers();
            pictureBox1.Image = Properties.Resources.telstraimg;
            MessageBox.Show("We are a aussie telco not a hacker");
        }

        private void telstrathewankers()
        {
            SoundPlayer tel = new SoundPlayer(Properties.Resources.telstra);
            tel.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weirdalaudio();
            MessageBox.Show("How have u never heard of weird al he is legit a god");
        }

        private void weirdalaudio()
        {
            SoundPlayer nerd = new SoundPlayer(Properties.Resources.nerdy);
            nerd.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mummy();
            MessageBox.Show("Tommy's Mummy says tommy is adopted like u");
        }

        private void mummy()
        {
            SoundPlayer adopter = new SoundPlayer(Properties.Resources.Motherinnit);
            adopter.Play();
        }
    }
}
