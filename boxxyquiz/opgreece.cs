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
    public partial class opgreece : Form
    {
        public opgreece()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct", "OpGreece");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            risethelava();
            pictureBox1.Image = Properties.Resources.risethelavagreece;
            MessageBox.Show("Watch out the lava is rising because you got it wrong", "Incorrect");
        }

        private void risethelava()
        {
            SoundPlayer riselava = new SoundPlayer(Properties.Resources.lava);
            riselava.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oddfurry();
            MessageBox.Show("i believe you are a FURRY!", "TheOdd1sOut");
        }

        private void oddfurry()
        {
            SoundPlayer mon = new SoundPlayer(Properties.Resources.furry);
            mon.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry that menu has been cracked by cane", "James Reborn");
        }
    }
}
