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
    public partial class utp : Form
    {
        public utp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Got it correct mate", "Good Job");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myyoda();
            MessageBox.Show("Yoda says now i will make it tricker");
            pictureBox1.Image = Properties.Resources.yodautp;
            MessageBox.Show("i have put my baby pic for u");
        }

        private void myyoda()
        {
            SoundPlayer da = new SoundPlayer(Properties.Resources.YODA);
            da.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            MessageBox.Show("Sorry my guy im destroying your menu Good Luck :)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect");
        }
    }
}
