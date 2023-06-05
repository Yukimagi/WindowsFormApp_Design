using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_3
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        public Form1()
        {
            
            InitializeComponent();
            label2.Visible = false;//讓它初始的時候隱藏
            label3.Visible = false;//讓它初始的時候隱藏
            Random r = new Random();
            num1 = r.Next(1, 6);//產生1~5亂數
            num2 = r.Next(1, 6);//產生1~5亂數
        }
        int test1 = 0;
        int test2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            int b;
            b = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text != ""&& textBox2.Text != "")
            {
                label2.Visible = true;//讓它不隱藏
                label3.Visible = true;//讓它不隱藏
                if (a == num1)
                {
                    label2.Text = "第1個數答對:" + a;
                    test1 = 1;
                }
                else
                {
                    label2.Text = "第1個數答錯，答案是" + num1;
                    test1 = 0;
                }
                if (b == num2)
                {
                    label3.Text = "第2個數答對:" + b;
                    test2 = 1;
                }
                else
                {
                    label3.Text = "第2個數答錯，答案是" + num2;
                    test2 = 0;
                }
            }
            if (test1 == 1 && test2 == 1)
            {
                MessageBox.Show("正確");
            }
            else
            {
                MessageBox.Show("不正確");
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
