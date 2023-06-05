using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW11_6
{
    public partial class Form1 : Form
    {
        int sum;
        float avg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Student = "student.txt";
            string Score = "score.txt";
            StreamReader stu;
            string str;
            StreamReader scr;
            string str2;

            StreamWriter sw;
            sw = new StreamWriter("fusion.csv");


            textBox1.Clear();
            stu = new StreamReader(Student);
            scr = new StreamReader(Score);
            textBox1.AppendText("Name,Class1,Class2,Class3,Class4,Class5,Class6,Class7,Class8,Class9,Class10,Avg.\r\n");
            sw.Write("Name,Class1,Class2,Class3,Class4,Class5,Class6,Class7,Class8,Class9,Class10,Avg.\r\n");
            while ((str = stu.ReadLine()) != null && (str2 = scr.ReadLine()) != null)
            {
                sum = 0;
                textBox1.AppendText(str);
                sw.Write(str);
                string[] s = str2.Split(' ');
                for (int i = 0; i < 10; i++)
                {
                    textBox1.AppendText("," + s[i]);
                    sw.Write("," + s[i]);
                    sum += Convert.ToInt32(s[i]);
                }
                avg = (float)sum / (float)10;
                textBox1.AppendText("平均: " + avg.ToString());
                sw.Write("," + avg.ToString());
                textBox1.AppendText("\r\n");
                sw.Write("\r\n");
            }
            stu.Close();
            scr.Close();
            sw.Close();
        }
    }
}
