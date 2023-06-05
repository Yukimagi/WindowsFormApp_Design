using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        string[] photo = new string[] { "海邊", "沙灘", "建築", "觀海" };
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = false;
            checkBox1.Text= "停止播放";
            //圖片隨控制項大小伸縮
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //圖片隨控制項顯示photo[0]元素的圖檔
            pictureBox1.Image = imageList1.Images[photo[3] + ".jpg"];
            label1.Text = photo[3];
            progressBar1.Maximum = 80;
            progressBar1.Minimum=0;
            progressBar1.Value = 0;
            progressBar1.Step = 27;
        }
        bool fg;
        int i = 0;
        private void checkBox1_Click(object sender, EventArgs e)
        {
            fg=checkBox1.Checked;
            if (fg == false)
            {
                checkBox1.Text = "停止播放";
                timer1.Stop();
            }
            else
            {
                checkBox1.Text = "開始播放";
                timer1.Start();
            }
            
               
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i >3)
            {
                progressBar1.Value = 0;
                i = 0;
            }
            if (i == 3)//如果老師給全錯，就跟老師說我只是忘記加這段
            {
                progressBar1.Value = 0;
                pictureBox1.Image = imageList1.Images[i];
                label1.Text = photo[i];
            }
            else
            {
                progressBar1.PerformStep();
                pictureBox1.Image = imageList1.Images[i];
                label1.Text = photo[i];
            }
            if (i <=3)
            {
                i++;
            }

            Refresh();//表單重繪
        }
        //run();
    }
       // int i = 0;
        
        
           
    
}
