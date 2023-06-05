using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            input=Convert.ToInt32(textBox1.Text);
            if ((input >= 30 && input < 50) || input < 10)
            {
                MessageBox.Show("正確");
            }
            else
            {
                MessageBox.Show("不正確");
            }
        }
    }
}
