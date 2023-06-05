using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no=Convert.ToInt32(textBox3.Text);
            int differ = Convert.ToInt32(textBox2.Text);//公差
            int sum = 0;
            int first= Convert.ToInt32(textBox1.Text);//起始
            sum = sum + first;
            int a=first;//先設目前數字為first
            for (int i = 1; i < no; i++)
            {
                a = a + differ;//要加前一數字+等差
                textBox4.AppendText("第" + i + "次:" + sum+"+"+a+"=");
                sum = sum+a;
                textBox4.AppendText ( sum+"\r\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
