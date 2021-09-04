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
    public partial class JamesReborn : Form
    {
        public JamesReborn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect", "FVY7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope incorrect", "FBI4Z");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct Thx", "James Reborn");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do i look like a ghost?", "ModLoader Speaks");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fortnite All Night This One Ain't it Chief", "Fortnite");
        }
    }
}
