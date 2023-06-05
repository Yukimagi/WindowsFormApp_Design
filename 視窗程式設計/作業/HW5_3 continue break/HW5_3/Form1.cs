using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int sum=0;
            for(int i=1;i<=5;i++)
            {
                if (radioButton1.Checked==true&&i == Convert.ToInt32(textBox1.Text))
                {
                    continue;
                }
                if (radioButton2.Checked == true && i == Convert.ToInt32(textBox2.Text))
                {
                    break;
                }
                sum = sum + i;
                textBox3.AppendText("i=" + i + ",sum=" + sum + "\r\n");
            }
            
        }
    }
}
