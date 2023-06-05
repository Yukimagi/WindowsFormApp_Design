using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Collections;

namespace EX_CH11
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] now = new int[5];

            for (int i = 0; i < 5; i++)
            {
                now[i] = 0;
            }
            for (int i = 0; i < 25; i++)
            {
                maxIndex = 0;
                maxPri = 0;
                for (int j = 0; j < 5; j++)
                {
                    textBox1.AppendText("itm:" + nums[j, now[j]] + ", priority:" + pri[nums[j, now[j]]] + "\r\n");
                    if (nums[j, now[j]] == 0)
                    {
                        continue;
                    }
                    if (pri[nums[j, now[j]]] > maxPri)
                    {
                        maxIndex = j;
                        maxPri = pri[nums[maxIndex, now[maxIndex]]];
                    }
                }
                Qlist.Enqueue(nums[maxIndex, now[maxIndex]]);
                Ans += nums[maxIndex, now[maxIndex]].ToString() + " ";
                textBox1.AppendText("Q:");
                foreach (int obj in Qlist)
                    textBox1.AppendText(obj.ToString() + ", ");
                textBox1.AppendText("\r\n-----\r\n");

                if (Qlist.Count >= QueueSize - 1)
                {
                    textBox1.AppendText("full\r\nExecute & Delete item" +Qlist.Dequeue() + "from Q\r\n\r\n");
                    textBox1.AppendText("Q:");
                    foreach (int obj in Qlist)
                        textBox1.AppendText(obj.ToString() + ", ");
                    textBox1.AppendText("\r\n-----\r\n");
                    Thread.Sleep(500);
                }
                nums[maxIndex, now[maxIndex]] = 0;
                if (now[maxIndex] < 4)
                {
                    now[maxIndex]++;
                }
            }
            textBox1.AppendText("Execute & Delete item" + Qlist.Dequeue() + "from Q\r\n\r\n");
            textBox1.AppendText("EMPTY");
            StreamWriter sw = new StreamWriter("log.txt");
            sw.WriteLine(Ans);
            sw.Close();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
        }
        int QueueSize = 3;          //每回查最大size
        Queue Qlist = new Queue();
        string fileName;
        int maxIndex = 0;
        int maxPri = 0;
        int[,] nums = new int[5, 5];//tasks
        int[] pri = new int[26];//存priority
        String Ans = "";
        private void button1_Click(object sender, EventArgs e)
        {
            fileName = "tasks.txt";
            StreamReader tasks = new StreamReader(fileName);
            string str = "";
            string[] temp = new string[5];
            for (int i = 0; i < 5; i++)
            {
                str = tasks.ReadLine();
                temp = str.Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    nums[i, j] = Convert.ToInt32(temp[j]);
                }
                textBox1.AppendText(str + "\r\n");
            }
            tasks.Close();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileName = "priority.txt";
            StreamReader sr = new StreamReader(fileName);
            string str2 = "";
            string[] temp2 = new string[25];
            pri[0] = 0;
            str2 = sr.ReadLine();
            temp2 = str2.Split(' ');
            for (int j = 0; j < temp2.Length - 1; j++)
            {
                pri[j + 1] = Convert.ToInt32(temp2[j]);
            }
            for (int j = 1; j < temp2.Length; j++)
            {
                textBox1.AppendText(pri[j] + " ");
            }
            textBox1.AppendText("\r\n\r\n");
            sr.Close();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        
    }
}