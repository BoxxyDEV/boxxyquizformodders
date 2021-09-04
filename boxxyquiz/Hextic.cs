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
    public partial class Hextic : Form
    {
        public Hextic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cool you got it :)", "Hextic");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colbreakzbest();
            MessageBox.Show("Sorry ColBreakz is a artist");
        }

        private void colbreakzbest()
        {
            SoundPlayer brek = new SoundPlayer(Properties.Resources.ColBreakz);
            brek.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thereisaghost();
            pictureBox1.Image = Properties.Resources.ghostimg;
            MessageBox.Show("Good Luck Now", "Ghost");
        }

        private void thereisaghost()
        {
            SoundPlayer ghostplayer = new SoundPlayer(Properties.Resources.ghost);
            ghostplayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry im a base not menu", "FLUX");
        }
    }
}
