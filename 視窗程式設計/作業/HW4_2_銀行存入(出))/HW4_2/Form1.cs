using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;//讓它初始的時候隱藏
            textBox2.Visible = false;
            button2.Visible = false;
        }
        int choose;
        int account=1000;//要記得定義帳戶值於全域
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                choose = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("輸入字串格式不正確");
            }
            if (textBox1.Text != "")
            {
                //choose = Convert.ToInt32(textBox1.Text);
                if (choose == 1||choose==2)
                {
                    label2.Visible = true;//讓它有輸入後不隱藏
                    textBox2.Visible = true;
                    button2.Visible= true;
                }
                else
                {
                    label2.Visible = false;//讓它隱藏
                    textBox2.Visible = false;
                    button2.Visible = false;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money=0;
            try
            {
                money = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("輸入字串格式不正確");
            }
            if (textBox1.Text != "")
            {
                if (choose == 2)
                {
                    if (account<money)
                    {
                        MessageBox.Show("您目前的餘額為" + account + "元，餘額不足!");

                    }
                    else
                    {
                        account = account - money;
                        MessageBox.Show("餘額:" + (account));
                        label2.Visible = false;//讓它隱藏
                        textBox2.Visible = false;
                        button2.Visible = false;
                    }
                }
                else
                {
                    account = account + money;
                    MessageBox.Show("餘額:" + (account));
                    label2.Visible = false;//讓它隱藏
                    textBox2.Visible = false;
                    button2.Visible = false;
                }
            }
        }
    }
}
