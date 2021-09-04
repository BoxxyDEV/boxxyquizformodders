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
    public partial class paradise : Form
    {
        public paradise()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect: i feel a rick roll coming", "Rick Astley Creator of Paradise?");
            rickroll();
        }

        private void rickroll()
        {
            SoundPlayer rroll = new SoundPlayer(Properties.Resources.rickroll);
            rroll.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Time is not now it is incorrect", "Incorrect By John Cena");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're Answer is Copy And Paste so you're incorrect", "James Reborn The Leech Detective");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Job Thumb's Up", "gopro_2027");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry thats not pog - Incorrect", "Lush Modz");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tothemoon();
            MessageBox.Show("Let's Send Doge Coin To The Moon Not You - Incorrect", "Elon Musk");
        }

        private void tothemoon()
        {
            SoundPlayer doge = new SoundPlayer(Properties.Resources.wow);
            doge.Play();
        }
    }
}
