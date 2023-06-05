using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW7_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringBuilder str1; str1 = new StringBuilder(5);
            textBox1.AppendText("str1.Append(\"1234\")" + "\r\n");
            str1.Append("1234");
            //str1.Capacity.ToString(); str1.Length.ToString(); ?
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            textBox1.AppendText("str1.Append(\"5678\")" + "\r\n");
            str1.Append("5678");
            //str1.Capacity.ToString(); str1.Length.ToString(); ?
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            textBox1.AppendText("str1.Length = 15" + "\r\n");
            str1.Length = 15;
            //str1.Capacity.ToString(); str1.Length.ToString(); ?
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            textBox1.AppendText("str1.Clear(); str1.Append(\"123\")" + "\r\n");
            str1.Clear(); str1.Append("123");
            //str1.Capacity.ToString(); str1.Length.ToString(); ?
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
        }
    }
}
