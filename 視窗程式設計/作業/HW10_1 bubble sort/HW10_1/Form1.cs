using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void bubble(int[]list)
        {
            int len = list.Length;
            for (int i = 1; i <= len - 1; i++)//執行的回數
                for (int j = 1; j <= len - i; j++)//執行的次數
                {
                    if (list[j] < list[j - 1])
                    {
                        //二數交換
                        int temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value.Equals(""))
            {
                MessageBox.Show(this, "請先輸入數字串");
            }
            else
            {
                string[] strnum = value.Split(new Char[] { ' ' });
                int[] num = new int[strnum.Length];
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = System.Convert.ToInt32(strnum[i]);
                }
                textBox2.AppendText("字串長度:" +num.Length+"\r\n");
                bubble(num);
                for(int i=0;i<num.Length;i++)
                {
                    textBox2.AppendText(num[i] + " ");
                }
                textBox2.AppendText("\r\n");
            }
           
        }
    }
}
