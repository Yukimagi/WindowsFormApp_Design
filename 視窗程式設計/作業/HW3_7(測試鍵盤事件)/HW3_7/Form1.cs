using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//於form1操作
        {
            label3.Text=e.KeyCode.ToString();//會顯示那個鍵相對應的code
            label5.Text = e.KeyValue.ToString();//會顯示那個鍵相對應的value
            label7.Text = e.KeyData.ToString();//會顯示那個鍵相對應的data
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label10.Text = Convert.ToString(e.KeyChar);//會顯示那個鍵相對應的char
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label12.Text = Convert.ToString(e.KeyData);//會顯示那個鍵相對應的data
        }
    }
}
