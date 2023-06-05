using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pictureBox1顯示"無尾熊.jpg"
            pictureBox1.Image = imageList1.Images["無尾熊.jpg"];
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            //pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            //圖片方塊寬度指定給水平卷軸最大值
            hScrollBar1.Maximum = pictureBox1.Width;
            //圖片方塊寬度指定給水平卷軸的值
            hScrollBar1.Value = pictureBox1.Width;
            //圖片方塊高度指定給垂直卷軸最大值
            vScrollBar1.Maximum= pictureBox1.Height;
            //圖片方塊高度指定給垂直卷軸的值
            vScrollBar1.Value = pictureBox1.Height;
            //label1顯示目前水平卷軸與垂直卷軸的值
            label1.Text=$"寬:{hScrollBar1.Value}"+$"高:{vScrollBar1.Value}";
            //指定水平卷軸的寬=圖片方塊寬
            hScrollBar1.Width = pictureBox1.Width;
            //指定垂直卷軸的高=圖片方塊高
            vScrollBar1.Height= pictureBox1.Height;

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //圖片高度依目前垂直捲軸的值調整
            pictureBox1.Height = vScrollBar1.Value;
            label1.Text = $"寬:{hScrollBar1.Value}" + $"高:{vScrollBar1.Value}";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //圖片寬度依目前水平捲軸的值調整
            
            pictureBox1.Width = hScrollBar1.Value;
            label1.Text = $"寬:{hScrollBar1.Value}" + $"高:{vScrollBar1.Value}";
        }
    }
}
