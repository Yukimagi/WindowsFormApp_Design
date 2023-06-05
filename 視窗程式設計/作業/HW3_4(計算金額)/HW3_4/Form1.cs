using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int noodle, soda;//泡麵，汽水
            int np=25, sp=30;//泡麵價格，汽水價格
            noodle = Convert.ToInt32(textBox1.Text);//轉浮點數
            soda = Convert.ToInt32(textBox2.Text);//轉浮點數
            np = np * noodle;
            sp = sp * soda;
            label3.Text = "總金額: " + (np + sp);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
