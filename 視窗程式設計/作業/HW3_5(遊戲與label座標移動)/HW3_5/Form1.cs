using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "定錨";
            label1.Font = new Font("標楷體",12,FontStyle.Bold);//字體
            label1.BackColor = Color.Cyan;//背景顏色
            label1.ForeColor = Color.Blue;//前景顏色
            label1.Location = new Point(100,100);//位置(x,y)
            button3.Enabled = false;//左邊按鈕失效
            button4.Enabled = false;//右邊按鈕失效
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = label1.Location.X;
            y = label1.Location.Y-10;//愈上面數字愈小
            label1.Location=new Point(x,y);
            button3.Enabled = true;//左邊按鈕恢復
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y;
            x = label1.Location.X;
            y = label1.Location.Y + 10;//愈下面數字愈大
            label1.Location = new Point(x, y);
            button4.Enabled = true;//右邊按鈕恢復
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y;
            x = label1.Location.X-10;//愈左數字愈小
            y = label1.Location.Y ;
            label1.Location = new Point(x, y);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y;
            x = label1.Location.X + 10;//愈右數字愈大
            y = label1.Location.Y;
            label1.Location = new Point(x, y);
        }
    }
}
