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
    public partial class Semjases : Form
    {
        public Semjases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i would be sad if you got it wrong", "Semjases");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Those are some dank minecraft hax but sadly its gta so ur wrong", "Minecraft");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Whole other menu mate", "Mod");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry im paid", "The Questioned Mod");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry im a modloader", "Modloader");
        }
    }
}
