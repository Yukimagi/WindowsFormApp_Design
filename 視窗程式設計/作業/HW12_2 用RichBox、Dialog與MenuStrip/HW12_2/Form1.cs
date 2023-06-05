using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //豐富文字方塊填滿整個表單
            richTextBox1.Dock = DockStyle.Fill;
        }
        string fs;
        string p;
        bool check = false;
       //FileStream fa;
        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //使用try catch來檢查錯誤
            try
            {
                //將test.rtf檔的內容載入到richTextBox1豐富文字方塊內
                //richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
                //使用openFileDialog開檔
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    fs= openFileDialog1.FileName;
                    // 只取出路徑
                    p= Path.GetDirectoryName(fs);
                    //richTextBox1.Text = p;
                    check = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//點你要的檔案
            }
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check==false)
            {
                MessageBox.Show("請先開檔!");
            }
            else
            {//將richTextBox1文字方塊內容的資料儲存到GOTOP01.rtf
                if (!File.Exists(fs))
                {
                    string test;
                    test= Interaction.InputBox("請輸入檔案名稱", "確定", "test", 50, 50);//50,50視窗座標位置
                    // 將多個字串合併為一個路徑
                    p = Path.Combine(p,test+".rtf");
                    richTextBox1.SaveFile(p, RichTextBoxStreamType.RichText);
                }
                else
                {
                    DialogResult result = MessageBox.Show("檔案已存在，請問是否覆寫檔案?", "檔案檢查", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string test;
                        test = Interaction.InputBox("請輸入檔案名稱", "確定", "test", 50, 50);//50,50視窗座標位置
                        // 將多個字串合併為一個路徑
                        p = Path.Combine(p,test + ".rtf");
                        richTextBox1.SaveFile(p, RichTextBoxStreamType.RichText);
                    }
                }
            }
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();//執行clear()方法
            check = false;
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;//fontDialog1.Font;
        }

        private void 字體顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;//colorDialog1.Color;
        }
        //contextMenuString快顯功能剪下
        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
