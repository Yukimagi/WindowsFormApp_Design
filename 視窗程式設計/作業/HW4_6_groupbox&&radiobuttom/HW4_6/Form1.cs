using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible= false;
            radioButton1.Checked=false;
            radioButton2.Checked=true;
            radioButton3.Checked = false;
            radioButton4.Checked = true;
            radioButton5.Checked = false;
            radioButton6.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int old=0;
            try//檢查年齡輸入
            {
                
                old= Convert.ToInt32(textBox1.Text);
            }
            catch(FormatException ex) {
                MessageBox.Show("輸入字串格是不正確");
            }
            //---------------開始檢查條件------
            int gender;
            if(radioButton1.Checked == false)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
                groupBox2.Visible = true;
            }
            
            if(gender==0)//女生
            {
                //檢查年齡
                //檢查交通狀況
                if ((old < 20 || old > 34))
                {
                    MessageBox.Show("年齡不符合資格");
                }
                if(radioButton5.Checked == false)
                {
                    MessageBox.Show("沒有自備交通工具，資格不符合");
                }
                else
                {
                    MessageBox.Show("資格符合");
                }
            }
            else//男生
            {
                //檢查役畢情況
                //檢查年齡
                //檢查交通工具狀況
                
                if ((old < 20 || old > 34))
                {
                    MessageBox.Show("年齡不符合資格");
                }
                if (radioButton3.Checked == false)
                {
                    MessageBox.Show("尚未役畢，資格不符合");
                }
                if (radioButton5.Checked == false)
                {
                    MessageBox.Show("沒有自備交通工具，資格不符合");
                }
                else
                {
                    MessageBox.Show("資格符合");
                }
            }
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}
