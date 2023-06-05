using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            label2.Visible= false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("請選擇餐點");
            }
            if (radioButton1.Checked == true)
            {
                sum = sum + 100;
            }
            if (radioButton2.Checked == true)
            {
                sum = sum + 90;
            }
            if (radioButton3.Checked == true)
            {
                sum = sum + 110;
            }
            if (checkBox1.Checked == true)
            {
                sum = sum + 20;
            }
            if (checkBox2.Checked == true)
            {
                sum = sum + 30;
            }
            if (checkBox3.Checked == true)
            {
                sum = sum + 40;
            }
            label2.Visible = true;
            label2.Text= sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = "0";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }
    }
}
