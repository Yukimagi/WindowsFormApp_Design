using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_6app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string str1 = "aBcdefghijk";
            string str2 = "abcdefghijk";
            string str3 = "你好嗎？";
            //str1.Length.ToString()
            textBox1.AppendText(str1.Length.ToString() + "\r\n\n");
            //str1[3].ToString()
            textBox1.AppendText(str1[3].ToString() + "\r\n");
            //String.Compare(str1, str2);
            textBox1.AppendText(String.Compare(str1, str2) + "\r\n");
            string str5 = String.Concat("王小明," + str3);
            textBox1.AppendText(str5 + "\r\n");
            //str1.Contains("cde")
            textBox1.AppendText(str1.Contains("cde") + "\r\n");
            //str1.EndsWith("IJK")
            textBox1.AppendText(str1.EndsWith("IJK") + "\r\n");
            //str3.PadRight(10, 'c')
            textBox1.AppendText(str3.PadRight(10, 'c') + "\r\n");
            //str1.Remove(2, 4)
            textBox1.AppendText(str1.Remove(2, 4) + "\r\n");
            str1 = "This is a book."; str1.Replace('s', '6');
            textBox1.AppendText(str1 + "\r\n");
            //" This is a book. ".Trim()
            textBox1.AppendText(" This is a book. ".Trim() + "\r\n");
            //string[] str6很重要
            string[] str6 = str5.Split(' ');
            //textBox1.AppendText(str6 + "\r\n");
            foreach (var s in str6) textBox1.AppendText(s + "\r\n");
        }
    }
}
