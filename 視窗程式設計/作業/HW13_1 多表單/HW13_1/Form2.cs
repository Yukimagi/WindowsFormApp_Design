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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int cal(int vMoney, int vYear, double vRate)
        {   
            if (radioButton1.Checked)
            {
                //每年計息一次
                return (int)(vMoney * Math.Pow(1 + vRate, vYear));
            }
            else
            {
                //每月計息一次
                return (int)(vMoney * Math.Pow(1 + vRate / 12, vYear * 12));
            }
        }
    }
}
