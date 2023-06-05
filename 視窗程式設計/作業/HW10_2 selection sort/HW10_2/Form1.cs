using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void selection(int[] list)
        {
            int temp;
            int n = list.Length;
            int smallest;
            for (int i = 0; i < list.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < list.Length; index++)
                {
                    if (list[index] < list[smallest])
                    {
                        smallest = index;
                    }
                }
                // 內圈迴路結束，取得本回最大值
                // 將本回最大值與未排序區裡最右邊的值對調
                temp = list[i];
                list[i] = list[smallest];
                list[smallest] = temp;
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
                textBox2.AppendText("字串長度:" + num.Length + "\r\n");
                selection(num);
                for (int i = 0; i < num.Length; i++)
                {
                    textBox2.AppendText(num[i] + " ");
                }
                textBox2.AppendText("\r\n");
            }
        }
    }
}
