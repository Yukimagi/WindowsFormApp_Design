using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class Form1 : Form
    {
        string[] photo = new string[] { "Beach", "Car", "Flower", "Castle" };
        public Form1()
        {
            InitializeComponent();
            //圖片隨控制項大小伸縮
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //圖片隨控制項顯示photo[0]元素的圖檔
            pictureBox1.Image = imageList1.Images[photo[0] + ".jpg"];
            label2.Text = photo[0];

            //圖片方塊寬度指定給水平卷軸最大值
            hScrollBar1.Maximum = pictureBox1.Width;
            //圖片方塊寬度指定給水平卷軸的值
            hScrollBar1.Value = pictureBox1.Width;
            //圖片方塊高度指定給垂直卷軸最大值
            vScrollBar1.Maximum = pictureBox1.Height;
            //圖片方塊高度指定給垂直卷軸的值
            vScrollBar1.Value = pictureBox1.Height;
            //label1顯示目前水平卷軸與垂直卷軸的值
            label3.Text = $"寬:{hScrollBar1.Value}"+" " + $"高:{vScrollBar1.Value}";
            //指定水平卷軸的寬=圖片方塊寬
            hScrollBar1.Width = pictureBox1.Width;
            //指定垂直卷軸的高=圖片方塊高
            vScrollBar1.Height = pictureBox1.Height;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //圖片高度依目前垂直捲軸的值調整
            pictureBox1.Height = vScrollBar1.Value;
            label3.Text = $"寬:{hScrollBar1.Value}" + " "+$"高:{vScrollBar1.Value}";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //圖片寬度依目前水平捲軸的值調整
            pictureBox1.Width = hScrollBar1.Value;
            label3.Text = $"寬:{hScrollBar1.Value}" + " " + $"高:{vScrollBar1.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            label2.Text = photo[0];
            numericUpDown1.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[3];
            label2.Text = photo[3];
            numericUpDown1.Value = 3;
        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (i - 1 < 0)
            {
                i = 3;
            }
            else
            {
                i = i - 1;
            }
            pictureBox1.Image = imageList1.Images[i];
            label2.Text = photo[i];
            numericUpDown1.Value = i;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i + 1 > 3)
            {
                i = 0;
            }
            else
            {
                i = i + 1;
            }
            pictureBox1.Image = imageList1.Images[i];
            label2.Text = photo[i];
            numericUpDown1.Value = i;
        }
    }
}
