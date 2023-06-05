using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HW11_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled= true;
            button2.Enabled= false;
            button3.Enabled= false;
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            path = System.IO.Directory.GetCurrentDirectory();
            textBox1.AppendText(path);
            textBox1.AppendText("\r\n\r\n---------------------\r\n");
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }
        DirectoryInfo din;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            din = new DirectoryInfo(path);
            foreach (var file in din.GetFiles("*.*"))
            {
                textBox1.AppendText(file.Name);
            }
            textBox1.AppendText("\r\n\r\n---------------------\r\n");
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            din = new DirectoryInfo(path);
            bool test = false;
            string search = Interaction.InputBox("請輸入檔案名稱");
            foreach(var file in din.GetFiles(search)) {
                textBox1.AppendText(file.Name);
                test = true;
                break;
            }
            if (test == false)
            {
                textBox1.AppendText("找不到檔案");
            }
            textBox1.AppendText("\r\n\r\n---------------------\r\n");
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }
    }
}
