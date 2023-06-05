using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int item = 0;
            item=Convert.ToInt32(textBox1.Text);
            int take = 0;
            take= Convert.ToInt32(textBox2.Text);
            int sum = 1;
            int div = 1;
            for(int i = item; i > item - take; i--)
            {
                sum = sum * i;
            }
            for(int i = take; i > 0; i--)
            {
                div= div * i;
            }

            label5.Text = sum / div+"\r\n";
            label5.Visible = true;
        }
    }
}
