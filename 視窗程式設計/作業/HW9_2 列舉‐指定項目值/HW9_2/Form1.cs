using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW9_2
{
    public partial class Form1 : Form
    {
        enum days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        int[] hour = {4,3,5,7,2,6,8};
        days d;
        int sum_p=0;
        int total_h=0;
        int b;
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked=false;
            checkBox2.Checked=false;
            checkBox3.Checked=false;
            checkBox4.Checked=false;
            checkBox5.Checked=false;
            checkBox6.Checked=false;
            checkBox7.Checked=false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(textBox1.Text);
            } 
            catch(Exception ex) {
            MessageBox.Show("錯誤的格式");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Mon];
            
            if (checkBox1.Checked==true) {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p= total_h*b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Tue];

            if (checkBox2.Checked == true)
            {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p = total_h * b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Wed];

            if (checkBox3.Checked == true)
            {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p = total_h * b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Thu];

            if (checkBox4.Checked == true)
            {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p = total_h * b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Fri];

            if (checkBox5.Checked == true)
            {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p = total_h * b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Sat];

            if (checkBox6.Checked == true)
            {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p = total_h * b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int a = hour[(int)days.Sun];

            if (checkBox7.Checked == true)
            {
                total_h = total_h + a;
            }
            else
            {
                total_h = total_h - a;
            }
            sum_p = total_h * b;
            label2.Text = "本周上班時數=" + total_h.ToString() + ",薪資=" + sum_p.ToString();
        }
    }
}
