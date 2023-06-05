using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_3_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            string picPath;//存放圖示路徑
            Image img;
            picPath = Application.ExecutablePath;
            MessageBox.Show("目前目錄Source: " + picPath);
            for(int i = 0; i < 4; i++)
            {
                picPath=System.IO.Directory.GetParent(picPath).ToString();
                MessageBox.Show("目前目錄Source: " + picPath);
            }
            //picPath += @"\pic\";//與下一行一樣，加總:單斜線
            picPath += "\\pic\\";
            MessageBox.Show("目前目錄Source: " + picPath);

            img = Image.FromFile(picPath + "icon3.png");
            imageList1.Images.Add(img);
            img = Image.FromFile(picPath + "icon4.png");
            imageList1.Images.Add(img);
            listView1.SmallImageList = imageList1;

            img = Image.FromFile(picPath + "icon7.png");
            imageList2.Images.Add(img);
            img = Image.FromFile(picPath + "icon8.png");
            imageList2.Images.Add(img);
            listView1.StateImageList= imageList2;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("姓名", 120);
            listView1.Columns.Add("住址", 150);
            listView1.Columns.Add("電話", 100);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] name = { "張三郎", "真美麗", "王小明" };
            string[] address = { "民生路255號", "愛國西路1號", "中央路120號" };
            string[] phone = { "22576267", "22661878", "0938123456" };

            listView1.CheckBoxes = true;//使用核取方塊

            for(int i = 0; i < 3; i++)
            {
                listView1.Items.Add(name[i]);
                listView1.Items[i].SubItems.Add(address[i]);
                listView1.Items[i].SubItems.Add(phone[i]);
                listView1.Items[i].StateImageIndex = 0;
            }
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach(ListViewItem item in listView1.CheckedItems) {
                foreach(ListViewItem.ListViewSubItem str in item.SubItems)
                {
                    textBox1.AppendText(str.Text.ToString()+" ");
                }
                textBox1.AppendText("\r\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                if (listView1.CheckedItems.Count > 0)
                {
                    foreach (int no in listView1.CheckedIndices)
                    {
                        listView1.Items[no].Remove();
                    }
                }
                else
                {
                    MessageBox.Show("請選取刪除的項目");
                }
            }
            else
            {
                MessageBox.Show("目前已無可選取的項目","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
