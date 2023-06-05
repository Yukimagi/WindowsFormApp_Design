using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible= false;
            label2.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                for(int i = 0,j =255; i <= 255&&j>=0; i++, j--)//同時進行(如果要等某一方跑完的話，要將i或j其中一個包在外面的for)
                {
                    textBox1.BackColor = Color.FromArgb(255, j, i);
                    label1.Text= j.ToString();
                    label2.Text = i.ToString();
                    label1.Visible = true;
                    label2.Visible = true;
                    Refresh();//重繪表單
                    System.Threading.Thread.Sleep(5);//暫停0.005秒

                }
            
        }
    }
}
