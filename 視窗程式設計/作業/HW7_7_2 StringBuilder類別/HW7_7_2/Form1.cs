using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StringBuilder str1; str1 = new StringBuilder();
            //str1.Capacity.ToString(); str1.Length.ToString(); ?
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");

            str1.Append("12345678901234567"); str1.Length = 10;
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            //str1.Capacity.ToString(); str1.Length.ToString(); ?
        }
    }
}
