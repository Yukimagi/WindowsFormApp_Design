using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd=new Random();//設定亂數
            int num1;
            int num2;
            int c;
            try
            {
                
                num1=Convert.ToInt32(textBox1.Text);
                num2= Convert.ToInt32(textBox2.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show("輸入錯誤，請重新輸入");
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            if (num2 <= num1)
            {
                MessageBox.Show("輸入錯誤，請重新輸入");
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                
                c = rd.Next() % (num2+1);
                while (c < num1)
                {
                    c = rd.Next() % (num2 + 1);
                }
                label4.Text = c.ToString();
                label4.Visible= true;
            }
           

        }
    }
}
