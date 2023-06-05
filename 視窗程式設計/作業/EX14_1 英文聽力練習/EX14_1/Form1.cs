using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX14_1
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        int ques;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            label3.Text="請按播放開始";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label3.Visible = true;
            string ans = textBox1.Text;
            if (ques == 1 && String.Equals(ans, "one", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 2 && String.Equals(ans, "two", StringComparison.CurrentCultureIgnoreCase)){
                    label3.Text = "答對了";
            }
            else if (ques == 3 && String.Equals(ans, "three", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 4 && String.Equals(ans, "four", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 5 && String.Equals(ans, "five", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 6 && String.Equals(ans, "six", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 7 && String.Equals(ans, "seven", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 8 && String.Equals(ans, "eight", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 9 && String.Equals(ans, "nine", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else if (ques == 10 && String.Equals(ans, "ten", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = "答對了";
            }
            else {
                    label3.Text = "答錯了";
            }
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            SoundPlayer sp;
            sp = new SoundPlayer();
            sp.SoundLocation = "../../../source/";
            ques = rd.Next(11);
            switch (ques)
            {
                case 1:
                    sp.SoundLocation = "../../../source/1.wav";
                    break;
                case 2:
                    sp.SoundLocation = "../../../source/2.wav";
                    break;
                case 3:
                    sp.SoundLocation = "../../../source/3.wav";
                    break;
                case 4:
                    sp.SoundLocation = "../../../source/4.wav";
                    break;
                case 5:
                    sp.SoundLocation = "../../../source/5.wav";
                    break;
                case 6:
                    sp.SoundLocation = "../../../source/6.wav";
                    break;
                case 7:
                    sp.SoundLocation = "../../../source/7.wav";
                    break;
                case 8:
                    sp.SoundLocation = "../../../source/8.wav";
                    break;
                case 9:
                    sp.SoundLocation = "../../../source/9.wav";
                    break;
                case 10:
                    sp.SoundLocation = "../../../source/10.wav";
                    break;
            }
            sp.Play();
            button1.Enabled= false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp;
            sp = new SoundPlayer();
            sp.SoundLocation = "../../../source/" + ques + ".wav";
            sp.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
