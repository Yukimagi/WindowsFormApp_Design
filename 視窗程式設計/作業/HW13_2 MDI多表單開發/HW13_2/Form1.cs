using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW13_2
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
            pictureBox1.Image = imageList1.Images["q.png"];
            pictureBox2.Image = imageList1.Images["q.png"];
            label2.Text = "按重來遊戲鍵開始...";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        int num1;
        int num2;
        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = imageList1.Images["s.png"];
            if (num2 == 1)
            {
                label2.Text = "你贏了! 按紐 重玩....";
            }
            else if (num2 == 2)
            {
                label2.Text = "平手! 按紐 重玩....";
            }
            else
            {
                label2.Text = "你輸了! 按紐 重玩....";
            }
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            Random r = new Random();

            num2 = r.Next(1, 3);

            if (num2 == 1)
            {
                pictureBox2.Image = imageList1.Images["p.png"];
            }
            else if (num2 == 2)
            {
                pictureBox2.Image = imageList1.Images["s.png"];
            }
            else
            {
                pictureBox2.Image = imageList1.Images["t.png"];
            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label2.Text = "請按剪刀、石頭、布 按鈕繼續";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = imageList1.Images["t.png"];
            if (num2 == 1)
            {
                label2.Text = "你輸了! 按紐 重玩....";
            }
            else if (num2 == 2)
            {
                label2.Text = "你贏了! 按紐 重玩....";
            }
            else
            {
                label2.Text = "平手! 按紐 重玩....";
            }
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images["p.png"];
            if (num2 == 1)
            {
                label2.Text = "平手! 按紐 重玩....";
            }
            else if (num2 == 2)
            {
                label2.Text = "你輸了! 按紐 重玩....";
            }
            else
            {
                label2.Text = "你贏了! 按紐 重玩....";
            }
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
