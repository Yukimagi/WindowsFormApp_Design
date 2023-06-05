using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[0];
            pictureBox1.Width = 255;
            pictureBox2.Width = 255;
            timer1.Interval = 30;//計時器週期
            timer1.Enabled=false;//關閉計時器
            pictureBox2.Location = pictureBox1.Location;//將pic2至於pic上
            
        }
        int flag = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                pictureBox1.Image = imageList1.Images[0];//跳來跳去(藍)
                pictureBox2.Image = imageList1.Images[1];//跳來跳去(紅)
            }
            else if (flag == -1)
            {
                pictureBox1.Image= imageList1.Images[2];//另一個的藍
                pictureBox2.Image= imageList1.Images[3];//另一個的紅
            }
            //播放:將picturebox1的寬度每次加2pixels，直到picturebox1寬度=picturebox2寬度換下一組

            if (pictureBox1.Width > 0)
            {
                pictureBox1.Width -= 2;
            }
            else
            {
                pictureBox1.Width = 255;//重設圖的大小
                flag = -flag;//交換字幕
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();//大家都會停，如果要個別就要個別用timer
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
