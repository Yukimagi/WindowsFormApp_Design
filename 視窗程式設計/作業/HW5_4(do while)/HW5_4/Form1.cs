using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool fg;
        private void checkBox1_Click(object sender, EventArgs e)
        {
           
            fg=checkBox1.Checked;
            checkBox1.Text = "fg=" + fg.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int i = 1;
            int sum = 0;
            do
            {
                sum = sum + i;
            textBox1.AppendText(sum+"\r\n");
                i++;
            } while (fg&&i<=10);
        }
    }
}
