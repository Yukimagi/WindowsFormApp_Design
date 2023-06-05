using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv;
            lv=(ListView)sender;//將sender轉型為ListView
            textBox1.Clear();
            //從所有被選取的項目集合中，逐一取出來並指定給item
            foreach(ListViewItem item in lv.SelectedItems) {
                //將item中所有的欄位裡的資料串在一起顯示
                foreach(ListViewItem.ListViewSubItem str in item.SubItems)
                {
                    textBox1.AppendText(str.Text.ToString()+" ");
                }
                textBox1.AppendText("\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //取得選取數量
            textBox1.AppendText("選取數:"+listView1.SelectedItems.Count.ToString()+"\r\n");
            textBox1.AppendText("欄位數:"+listView1.Columns.Count.ToString()+"\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                //刪除所有選擇的項目
                foreach (int no in listView1.SelectedIndices)
                {
                    listView1.Items[no].Remove();
                }
            }
            else
            {
                MessageBox.Show("請選取刪除的項目");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count>0)
            {
                //移除第一項目
                listView1.Items.Remove(listView1.Items[0]);
            }
            else
            {
                MessageBox.Show("目前已無可刪除的項目");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
