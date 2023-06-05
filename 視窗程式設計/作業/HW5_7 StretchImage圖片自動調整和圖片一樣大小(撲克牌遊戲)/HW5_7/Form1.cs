using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //StretchImage:圖片自動調整和圖片一樣大小
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox1.image=imagelist1.images["pokerbk.jpg"];
            pictureBox1.Image = imageList1.Images["pokerbk.jpg"];
            pictureBox2.Image = imageList1.Images["pokerbk.jpg"];
            label2.Text = "按洗牌紐遊戲開始...";
            button1.Enabled = true; 
            button2.Enabled = true;
        }
        int num1;
        int num2;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images["pokerbk.jpg"];
            pictureBox2.Image = imageList1.Images["pokerbk.jpg"];
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            Random r=new Random();
            num1=r.Next(2,15);
            num2 = r.Next(2, 15);
            label2.Text = "請在撲克牌上按一下選取...";
            button1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images["Poker" + Convert.ToString(num1) + ".jpg"];
            pictureBox2.Image = imageList1.Images["Poker" + Convert.ToString(num2) + ".jpg"];
            if (num1 > num2)
            {
                label2.Text = "你贏了! 按洗牌紐 重玩 ....";

            }
            else if(num1==num2)
            {
                label2.Text = "平手 ! 按洗牌紐 重玩...";
            }
            else
            {
                label2.Text = "你輸了! 按洗牌紐 重玩...";
            }
            pictureBox1.Enabled = false;
            pictureBox2.Enabled=false;
            button1.Enabled= true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images["Poker" + Convert.ToString(num1) + ".jpg"];
            pictureBox2.Image = imageList1.Images["Poker" + Convert.ToString(num2) + ".jpg"];
            if (num1 < num2)
            {
                label2.Text = "你贏了! 按洗牌紐 重玩 ....";

            }
            else if (num1 == num2)
            {
                label2.Text = "平手 ! 按洗牌紐 重玩...";
            }
            else
            {
                label2.Text = "你輸了! 按洗牌紐 重玩...";
            }
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//遊戲結束(關視窗)
        }
    }
}
