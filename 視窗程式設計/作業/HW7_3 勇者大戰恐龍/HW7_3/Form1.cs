using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_3
{
    public partial class Form1 : Form
    {
        int dBlood = 100,hBlood=100;//噴火龍與英雄的血
        int heroState = 0;//唐吉軻德，0放鬆、1:抵擋、2:攻擊
        int dinosaurState = 0;//噴火龍，0放鬆、1:抵擋、2:攻擊
        Random rd=new Random();
       

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images["d0.png"];
            pictureBox2.Image = imageList1.Images["h0.png"];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode= PictureBoxSizeMode.StretchImage;
            label1.Text = "100";
            label2.Text = "100";
            label3.Visible= false;
            timer1.Enabled = true;
            timer1.Interval = 300;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str;//儲存轉成大寫的按鍵字元

            str = (e.KeyChar).ToString();//只允許小寫、大寫不能運作
            //將按鍵字幕轉成大寫，若使用者是小寫也能運作
            str=(e.KeyChar).ToString().ToUpper();
            if (str == "A")//攻擊
            {
                pictureBox2.Image = imageList1.Images[5];
                heroState= 2;
            }
            else
            {
                if (str == "S")
                {
                    pictureBox2.Image = imageList1.Images[4];
                    heroState= 1;
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = imageList1.Images[3];
            heroState = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //以亂數決定顯示哪張噴火龍影像
            dinosaurState = rd.Next(0, 5);
            if (dinosaurState > 2)//以增加噴火龍防守的機會
                dinosaurState = 1;

            pictureBox1.Image = imageList1.Images[dinosaurState];

            //---判斷狀態與分數------
            //若恐龍噴火且騎士沒抵擋、則唐吉軻德失血
            //若騎士揮刀且恐龍休息，則恐龍失血
            pictureBox3.Width = dBlood;
            pictureBox4.Width = hBlood;
            if (hBlood == 0 || dBlood == 0)
            {
                label1.Enabled = false;
                label2.Enabled = false;
            }
            else
            {
                if ((dinosaurState == 2 && heroState == 0) || (dinosaurState == 2 && heroState == 2))
                {

                    pictureBox4.Width = pictureBox4.Width - 10;
                    hBlood = hBlood - 10;
                }
                if (heroState == 2 && dinosaurState == 0)
                {
                    pictureBox3.Width = pictureBox3.Width - 10;
                    dBlood = dBlood - 10;
                }
            }
            label1.Text = dBlood.ToString();//顯示血量
            label2.Text = hBlood.ToString();

            if (dBlood == 0 || hBlood == 0)
            {
                if (dBlood == 0)
                {  
                    label3.Text = "你贏了!";
                }
                else
                {
                    label3.Text = "你輸了!";
                }
                label3.Visible = true;
                timer1.Enabled= false;
            }
        }
    }
}
