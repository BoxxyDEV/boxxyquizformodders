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
    public partial class inimitable : Form
    {
        public inimitable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes the Coolest", "Correct");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            russia();
            MessageBox.Show("Nope this is not amercian not the all mighty russian made mod", "RussiaModz");
        }

        private void russia()
        {
            SoundPlayer ussrplr = new SoundPlayer(Properties.Resources.USSR);
            ussrplr.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rewrite();
            MessageBox.Show("Nope i think you need to rewrite your answer", "FazeModz");
        }

        private void rewrite()
        {
            SoundPlayer faze = new SoundPlayer(Properties.Resources.fazemodz);
            faze.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I maybe helped in some sort of way but i did not make it", "2much4U");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nyan();
            MessageBox.Show("Meow im not a hacker cat", "Nyan Cat");
        }

        private void nyan()
        {
            SoundPlayer ncat = new SoundPlayer(Properties.Resources.meow);
            ncat.Play();
        }
    }
}
