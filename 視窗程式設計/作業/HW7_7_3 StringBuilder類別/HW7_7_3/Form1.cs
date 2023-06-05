using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringBuilder str1 = new StringBuilder("123");
            StringBuilder str2 = new StringBuilder();
            char[] c1 = new char[4];
            str1.AppendLine();
            //str1.Length.ToString() ?
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            str1.AppendLine("11111").Append('c', 5);
            //str1.ToString() ?
            textBox1.AppendText(str1.ToString() + "\r\n");
            str2.AppendFormat("我和{0}一同去買了{1}本筆記本", "小明", 3);
            //str1.ToString() ?
            textBox1.AppendText(str1.ToString() + "\r\n");
            str2.CopyTo(1, c1, 0, 4);
            //c1 ?
            textBox1.AppendText(new string(c1) + "\r\n");
        }
    }
}
