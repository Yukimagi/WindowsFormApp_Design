using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();//關掉視窗
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            string no;
            no=comboBox1.Text;
            //也可直接改int
            //no=Convert.ToInt32(comboBox1.SelectedItem.ToString());
            switch (no)
            {
                //也可
                /*
                  case "1":
                  case "12":
                  case "11":
                    label3.Text= "冬季"; 
                    break;
                 */

                case "1":
                    label3.Text= "冬季"; 
                    break;
                case "2":
                    label3.Text = "春季";
                    break;
                case "3":
                    label3.Text = "春季";
                    break;
                case "4":
                    label3.Text = "春季";
                    break;
                case "5":
                    label3.Text = "夏季";
                    break;
                case "6":
                    label3.Text = "夏季";
                    break;
                case "7":
                    label3.Text = "夏季";
                    break;
                case "8":
                    label3.Text = "秋季";
                    break;
                case "9":
                    label3.Text = "秋季";
                    break;
                case "10":
                    label3.Text = "秋季";
                    break;
                case "11":
                    label3.Text = "冬季";
                    break;
                case "12":
                    label3.Text = "冬季";
                    break;
            }
        }
    }
}
