using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;//初始座標
            int move = 10;//移動量
            int index = 0;//影像編號
            //x+width(圖寬)+(移動寬度)<form寬(可移)，else不可移
            pictureBox1.Left= x;//設定初始的picture
            //----將imagelist1的影像的寬與高設定給picturebox1
            pictureBox1.Width=imageList1.ImageSize.Width;
            pictureBox1.Height=imageList1.ImageSize.Height; 

            while (x+pictureBox1.Width+move<ClientSize.Width)
            {
                if (index == 5) { index = 0; }
                pictureBox1.Image= imageList1.Images[index];
                //重新設定picturebox1的位置
                x = x + move;
                pictureBox1.Left = x;
                //重新設定下一次圖片的編號
                if (index < 5) { index++; }
                
                Refresh();//表單重繪
                System.Threading.Thread.Sleep(100);//暫停0.1秒
            }
        }
    }
}
