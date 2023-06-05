using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showPic();
        }
        int num = 0;
        string[] photo = new string[] { "企鵝", "沙漠", "無尾熊", "菊花", "鬱金香" };
        //===showPic方法
        //在toolStripeStatusLabel顯示目前圖片名稱
        void showPic()
        {
            //在pictureBox1上顯示photo[num]陣列元素的圖檔
            pictureBox1.Image = imageList1.Images[photo[num]+".jpg"];
            toolStripStatusLabel1.Text = $"圖片名稱:{photo[num]}";
        }
        private void 第一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num = 0;
            showPic();
        }

        private void 上一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (num != 0) num--;
            if (num == 0) num = 4;
            showPic();
        }

        private void 下一張toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (num != 4) num++;
            if (num == 4) num = 0;
            showPic();
        }

        private void 最後一張toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            num = 4;
            showPic();
        }
    }
}
