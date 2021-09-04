using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoxxyQuiz.Resources
{
    public partial class PS3 : Form
    {
        public PS3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 10";
            Form op = new opgreece();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 1";
            Form p1 = new paradise();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 2";
            Form JR = new JamesReborn();
            JR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 3";
            Form box = new Boxxy();
            box.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 4";
            Form sem = new Semjases();
            sem.Show();
            // finished on the 15/07/2021
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 5";
            Form bug = new rebug();
            bug.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 6";
            Form nyd = new inimitable();
            nyd.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 7";
            Form lush = new lushmodz();
            lush.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 8";
            Form e69 = new extortion();
            e69.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 9";
            Form hectic = new Hextic();
            hectic.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 11";
            Form ut = new utp();
            ut.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "Level 12";
            Form who = new whomadeutp();
            who.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
            //label2.Text = "Level 13";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 14";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 15";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 16";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 17";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 18";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 19";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //label2.Text = "Level 20";
            MessageBox.Show("Sorry Level Not Currently Implemented if you want more levels suggest some in our discord");
        }
    }
}
