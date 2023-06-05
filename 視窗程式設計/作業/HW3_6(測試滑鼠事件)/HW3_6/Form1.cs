using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)//滑鼠按著
        {
            label1.Text = "MouseUp";
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)//滑鼠放開
        {
            label1.Text = "MouseDown";
        }

        private void label2_MouseLeave(object sender, EventArgs e)//滑鼠不在上面
        {
            label2.Text = "MouseLeave";
        }

        private void label2_MouseEnter(object sender, EventArgs e)//滑鼠在上面
        {
            label2.Text = "MouseEnter";
        }

        private void label3_MouseHover(object sender, EventArgs e)//滑鼠在上面一次
        {
            label3.Text = "MouseHover";
            label3.ForeColor = Color.Red;//前景顏色
        }

        private void label4_Click(object sender, EventArgs e)//滑鼠按一次
        {
            label4.Text = "Click";
        }

        private void label4_DoubleClick(object sender, EventArgs e)//滑鼠按兩次
        {
            label4.Text = "DoubleClick";
        }
    }
}
