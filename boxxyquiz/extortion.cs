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
    public partial class extortion : Form
    {
        public extortion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats you guessed the correct menu", "Exotortion");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kittyplay();
            MessageBox.Show("You have broken bones because we are a label not a mod menu", "Monstercat");
        }

        private void kittyplay()
        {
            SoundPlayer kitten = new SoundPlayer(Properties.Resources.brokenbones);
            kitten.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kidtriple();
            MessageBox.Show("Killed By Oh Baby a Triple Kid");
        }

        private void kidtriple()
        {
            SoundPlayer triple = new SoundPlayer(Properties.Resources.ATriple);
            triple.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("incorrect");
        }
    }
}
