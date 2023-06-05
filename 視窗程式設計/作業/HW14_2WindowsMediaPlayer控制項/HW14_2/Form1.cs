using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW14_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";//隱藏播放控制項
        }
        string file = "vedio.mp4";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog1.FileName;
                    axWindowsMediaPlayer1.URL = file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia == null) return;

            if (button2.Text == "播放影片")
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button2.Text = "暫停影片";
            }
            else if (button2.Text == "暫停影片")
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                button2.Text = "播放影片";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

    }
}
