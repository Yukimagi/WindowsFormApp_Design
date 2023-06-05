using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW9_1
{
    public partial class Form1 : Form
    {
        enum days { Mon,Tue,Wed,Thu,Fri,Sat,Sun};
        string[] week = {"星期一","星期二", "星期三", 
            "星期四", "星期五","星期六","星期日"};
        days d;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            switch(comboBox1.SelectedIndex)
            {
                case (int)days.Mon:
                    d=days.Mon;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Mon];
                    break;

                case (int)days.Tue:
                    d = days.Tue;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Tue];
                    break;

                case (int)days.Wed:
                    d = days.Wed;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Wed];
                    break;

                case (int)days.Thu:
                    d = days.Thu;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Tue];
                    break;

                case (int)days.Fri:
                    d = days.Fri;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Fri];
                    break;

                case (int)days.Sat:
                    d = days.Sat;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Sat];
                    break;

                case (int)days.Sun:
                    d = days.Sun;
                    textBox1.Text = "";
                    textBox1.AppendText(d.ToString() + " ");
                    textBox1.AppendText(Convert.ToInt32(d).ToString() + "\r\n");
                    str = week[(int)days.Sun];
                    break;
            }
            label2.Text = "您選擇了:" + " " + str;
        }
    }
}
