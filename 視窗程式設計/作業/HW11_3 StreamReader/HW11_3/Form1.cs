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

namespace HW11_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "test1.txt";
            StreamReader sr;
            string data;
            textBox1.Clear();
            textBox1.AppendText("ReadToEnd:\r\n");
            textBox1.AppendText("-----------\r\n");
            sr= new StreamReader(fileName);
            data= sr.ReadToEnd();//從目前位置到末端的其餘字串
            textBox1.AppendText(data);
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "test1.txt";
            StreamReader sr;
            string data;
            textBox1.Clear();
            textBox1.AppendText("Peak&ReadLine():\r\n");
            textBox1.AppendText("-----------\r\n");
            sr= new StreamReader(fileName);//使用檔案名稱建檔

            while(sr.Peek() >= 0) {//使用Peek控制繞讀檔停止
                char k=Convert.ToChar(sr.Peek());//peek()
                textBox1.AppendText("P:" + k + "\r\n");
                data= sr.ReadToEnd();
                textBox1.AppendText(data+"\r\n==================\r\n");
            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            string fileName = "test.txt";
            StreamReader sr;
            string data;
            textBox1.Clear();
            textBox1.AppendText("ReadLine():\r\n");
            textBox1.AppendText("-----------\r\n");
            sr = new StreamReader(fileName);//使用檔案名稱建檔
            while((str=sr.ReadLine())!=null) {
                textBox1.AppendText(str + "\r\n");
            }
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("FileStream:\r\n");
            textBox1.AppendText("-----------\r\n");
            FileStream fsFile=new FileStream("test.txt",FileMode.Open);//開檔
            StreamReader sr= new StreamReader(fsFile);
            int iChar;
            iChar=sr.Read();
            while(iChar!=-1) {
                textBox1.Text += (Convert.ToChar(iChar));
                iChar = sr.Read();
            }
            sr.Close();
        }
    }
}
