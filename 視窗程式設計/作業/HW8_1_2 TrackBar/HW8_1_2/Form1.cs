using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_1_2
{
    public partial class Form1 : Form
    {
        string[] photo = new string[] { "企鵝", "沙漠", "無尾熊", "菊花", "鬱金香" };
        public Form1()
        {
            InitializeComponent();
            //圖片隨控制項大小伸縮
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //圖片隨控制項顯示photo[0]元素的圖檔
            pictureBox1.Image = imageList1.Images[photo[0]+".jpg"];
            label1.Text = "圖片名稱:" + photo[0];
            //指定滑桿的最小值，剛好為陣列索引下限
            trackBar1.Minimum=photo.GetLowerBound(0);//陣列中指定之維度0的第一個項
            //指定滑桿的最大值，剛好為陣列索引上限
            trackBar1.Maximum=photo.GetUpperBound(0);//陣列中指定之維度0的最後一個項
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //取得滑桿的位置值，用來當陣列索引
            int index = trackBar1.Value;
            //顯示photo陣列中的index張圖片
            pictureBox1.Image = imageList1.Images[photo[index] + ".jpg"];
            label1.Text = "圖片名稱:" + photo[index];
        }
    }
}
