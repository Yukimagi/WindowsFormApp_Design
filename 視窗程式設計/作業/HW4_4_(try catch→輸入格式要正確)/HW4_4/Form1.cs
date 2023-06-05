using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;//年齡
            try
            {
                age=Convert.ToInt32(textBox1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("輸入錯誤，請重新輸入");
                textBox1.Text = "";
                textBox1.Focus();   
                return;
            }
            if (age <= 18)
            {
                MessageBox.Show("未滿18歲不能買酒", "注意", MessageBoxButtons.OK,MessageBoxIcon.Warning);//內文 標題 彈出視窗按鍵(0k->確定) 彈出視窗符號
            }
            else
            {
                MessageBox.Show("喝酒有害健康", "注意");//內文 標題
            }
        }
    }
}
