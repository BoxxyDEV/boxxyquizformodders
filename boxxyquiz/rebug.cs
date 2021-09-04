using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BoxxyQuiz
{
    public partial class rebug : Form
    {
        public rebug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes Rebug");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("that is a scorpion not a cobra");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope the other CFW", "Ferrox");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playmuta();
            MessageBox.Show("Muta Laugh's at you saying i do not have CFW", "Mutahar");
        }

        private void playmuta()
        {
            SoundPlayer audio = new SoundPlayer(BoxxyQuiz.Properties.Resources.laugh);
            audio.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playfindthis();
            MessageBox.Show("damm son Where did you find this because it is wrong");
        }

        private void playfindthis()
        {
            SoundPlayer find = new SoundPlayer(Properties.Resources.incorrectfind);
            find.Play();
        }
    }
}
