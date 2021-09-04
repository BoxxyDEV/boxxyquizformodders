using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoxxyQuiz
{
    public partial class Boxxy : Form
    {
        public Boxxy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yay you got me i am also creator of this lol", "Boxxy");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("where tf u get ghost i said SONIC NOT GHOST", "YouTuber - Incorrect");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I know im close to new zealand but it doesnt rain like that", "YouTuber - Incorrect");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maybe i should pacific and say Australia", "YouTuber - Incorrect");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("He is anime girl not sonic", "YouTuber - Incorrect");
        }
    }
}
