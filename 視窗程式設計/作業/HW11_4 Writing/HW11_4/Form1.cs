using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//讀檔要用的標頭檔
using static System.Net.Mime.MediaTypeNames;

namespace HW11_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            StreamWriter sw;
            sw = new StreamWriter("test.txt");
            //sw.WriteLine("This is a test\n");
            //sw.Write("Success");
            //學生練習:(密碼產生器:隨機產生10個英文字母與數字寫入檔案)
            Random rd = new Random();//設定亂數
            int c; //(含a~b - 1)
            int count=0;
            string str = "";
            while (count < 10)
            {
                c = rd.Next(48, 123); //(含a~b - 1)
                if (c >= 58 && c <= 64)
                {
                    
                }
                else if(c >= 91 && c <= 96)
                {
                    
                }
                else
                {
                    str = str + Convert.ToChar(c);
                    count++;
                }
            }
            sw.WriteLine(str);
            sw.Close();

            
            StreamReader sr;
            sr = new StreamReader("test.txt");
            string data;
            data = sr.ReadToEnd();//從目前位置到末端的其餘字串
            textBox2.AppendText(data);
            sr.Close();
            
            //學生練習:讀入檔案
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            char []ch = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            sw = new StreamWriter("test1.txt");
            sw.Write(ch,3,5);
            sw.Close();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            StreamWriter sw;
            string str;
            FileStream fs = new FileStream("test2.txt",FileMode.Append,FileAccess.Write);
            str = textBox1.Text;
            if(str.Length ==0 ) {
                MessageBox.Show("請輸入值");
                fs.Close();
                return;
            }
            sw=new StreamWriter(fs,Encoding.UTF8,512);//編碼方式和緩衝大小
            sw.WriteLine(str);
            sw.Close();
            
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
