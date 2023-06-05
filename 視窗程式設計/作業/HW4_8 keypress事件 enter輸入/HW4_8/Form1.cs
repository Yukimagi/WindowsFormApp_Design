using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible= false;
            label2.Visible = false;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string No;
            if (e.KeyChar == 13)//按了enter
            {
                label3.Visible = true;
                label2.Visible = true;
                No = textBox1.Text;
                switch (No)
                {

                    case "1":
                        label3.Text = "炸雞餐，109元";
                        break;
                    case "2":
                        label3.Text = "漢堡餐，109元";
                        break;
                    case "3":
                        label3.Text = "起司堡餐，99元";
                        break;
                    case "4":
                        label3.Text = "薯條餐，69元";
                        break;
                    default:    //使用default使非1 2 3 4都顯示錯誤
                        label3.Text = "輸入錯誤";
                        break;

                }
            }
        }
    }
}
