using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myMoney = 0, myYear = 0;
            double myRate = 0;
            try
            {
                myMoney = int.Parse(textBox1.Text);
                myRate = double.Parse(textBox2.Text) / 100;
                myYear = int.Parse(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的數值資料");
                return;
            }
            Form2 f = new Form2();
            f.ShowDialog();
            label4.Text = myYear + "年後領回本利和: " + f.cal(myMoney, myYear, myRate);
        }
    }
}
