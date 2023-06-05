using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringBuilder str1 = new StringBuilder("abcd");
            StringBuilder str2 = new StringBuilder("1234567");
            //str1.Equals(str2).ToString();
            textBox1.AppendText(str1.Equals(str2).ToString()+"\r\n");
            //str2.Insert(3, "xyz", 2);
            textBox1.AppendText(str2.Insert(3, "xyz", 2) + "\r\n");
            //str2.Remove(3, 6);
            textBox1.AppendText(str2.Remove(3, 6) + "\r\n");
            str2.Clear(); str2.Append("123abc456abc789abc");
            textBox1.AppendText(str2+ "\r\n");
            str2.Replace("abc", "qqq", 3, 9);
            textBox1.AppendText(str2 + "\r\n");
        }
    }
}
