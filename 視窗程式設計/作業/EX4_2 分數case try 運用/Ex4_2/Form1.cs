using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            int grade=0;
            try//用try來告知輸入格式錯誤
            {
                grade = Convert.ToInt32(textBox1.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("輸入字串格式不正確");
            }
            

            if (grade < 0 || grade > 100)//超過範圍
            {
                label3.Text = "輸入錯誤";
            }
            else
            {
                grade = grade / 10;

                switch (grade)
                {
                    case 10:
                    case 9:
                        label3.Text = "A";
                        break;
                    case 8:
                        label3.Text = "B";
                        break;
                    case 7:
                        label3.Text = "C";
                        break;
                    case 6:
                        label3.Text = "D";
                        break;
                    case 5:
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                    case 0:
                        label3.Text = "E";
                        break;

                    default:
                        label3.Text = "輸入錯誤";
                        break;

                }
            }
        }
    }
}
