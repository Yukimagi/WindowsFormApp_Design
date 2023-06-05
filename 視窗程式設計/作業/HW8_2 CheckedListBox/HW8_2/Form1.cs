using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_2
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "State";
            //預設勾選第一個項目
            //checkedListBox1.SetItemChecked(0, true);
        }


        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label1.Text = "第" + (e.Index + 1) + "項的狀態:" + e.NewValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除
            if (checkedListBox1.Items.Count > 0)
            {
                string str = checkedListBox1.Items[checkedListBox1.Items.Count-1].ToString();
                string[] after = str.Split(' ');
                int j = (Convert.ToInt32(after[1])) + 1;
                checkedListBox1.Items.Add("Item" +' '+ (j).ToString());
            }
            else
            {
                checkedListBox1.Items.Add("Item"+' ' + (i).ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除
            string str;
            textBox1.Clear();
            textBox1.AppendText("--列出被勾選的項目，方法1---\r\n");
            //-----逐一檢查每個項目的勾選狀態-----
            for(int i = 0; i < (checkedListBox1.Items.Count); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    str = "第" + (i + 1).ToString() + "項:" + checkedListBox1.Items[i] + "\r\n";
                    textBox1.AppendText(str);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除
            string str;
            //-----直接使用checkedListBox1.CheckedItems-----
            foreach (string item in checkedListBox1.CheckedItems) { 
                str=item+"\r\n";
                textBox1.AppendText(str);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除
            textBox1.AppendText("--列出被勾選的項目，方法3--\r\n");
            foreach (int item in checkedListBox1.CheckedIndices)//索引
            {
                textBox1.AppendText("第" + (item + 1).ToString() + "項被勾選。\r\n");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除
            int i;
            i=checkedListBox1.SelectedIndex;//索引
            textBox1.AppendText("--判斷哪個項目被點選--\r\n");
            textBox1.AppendText("第" + (i + 1).ToString() + "項目被點選\r\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//清除
            textBox1.AppendText("----列出每項的勾選狀態----\r\n");
            for(int i=0;i<checkedListBox1.Items.Count;i++)
            {
                textBox1.AppendText("第" + (i + 1).ToString() + "項狀態:" + checkedListBox1.GetItemCheckState(i).ToString() + "\r\n");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int j=-1;
            if (checkedListBox1.Items.Count < 1&& j==-1)
            {
                textBox1.AppendText("");
            }
            else
            {
                textBox1.Clear();//清除
                
                j = checkedListBox1.SelectedIndex;//索引
                textBox1.AppendText(checkedListBox1.Items[j].ToString() + " 被刪除" + "\r\n");
                checkedListBox1.Items.Remove(checkedListBox1.Items[j]);
            }
            j = -1;

        }
    }
}
