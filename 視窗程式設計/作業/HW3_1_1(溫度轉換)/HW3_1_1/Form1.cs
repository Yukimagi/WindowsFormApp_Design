using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float cTemp, fTemp;//攝氏溫度,華氏溫度
            cTemp = Convert.ToSingle(textBox1.Text);//轉浮點數
            fTemp = cTemp * 9 / 5 + 32;
            //fTemp=cTemp*1.8f+32
            label3.Text = Convert.ToString(fTemp);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            float cTemp, fTemp;//攝氏溫度,華氏溫度
            fTemp = Convert.ToSingle(textBox1.Text);//轉浮點數
            cTemp = (fTemp-32) * 5/9;
            //fTemp=cTemp*1.8f+32
            label5.Text = Convert.ToString(cTemp);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
