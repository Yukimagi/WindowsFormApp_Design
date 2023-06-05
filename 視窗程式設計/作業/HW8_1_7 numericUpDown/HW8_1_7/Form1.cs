using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=numericUpDown1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 5;
            numericUpDown1.Minimum = 0;
            numericUpDown1.DecimalPlaces = 1;//顯示小數位數，若0位小數，則4捨5入
            numericUpDown1.Increment = (decimal)0.2;//遞增

            numericUpDown1.Enabled = true;
        }
    }
}
