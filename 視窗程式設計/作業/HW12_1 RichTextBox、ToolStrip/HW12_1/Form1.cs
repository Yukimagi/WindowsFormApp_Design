using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //豐富文字方塊填滿整個表單
            richTextBox1.Dock= DockStyle.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //使用try catch來檢查錯誤
            try
            {
                //將test.rtf檔的內容載入到richTextBox1豐富文字方塊內
                //richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
                //使用openFileDialog開檔
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//點你要的檔案
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //將richTextBox1文字方塊內容的資料儲存到GOTOP01.rtf
            richTextBox1.SaveFile("GOTOP01.rtf", RichTextBoxStreamType.RichText);
        }
        //===按工具列的清除紐
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();//執行clear()方法
        }
        //===按工具列的結束紐
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op;
            op = toolStripComboBox1.SelectedItem.ToString();
            switch (op)
            {
                case "黑":
                    //richtextbox1文字方塊被選取部分字型色彩設定
                    richTextBox1.SelectionColor = Color.Black;
                    break;
                case "紅":
                    //richtextbox1文字方塊被選取部分字型色彩設定
                    richTextBox1.SelectionColor = Color.Red;
                    break;
            }
        }

        private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //字型不變、粗細不變、只變大小
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily.ToString(), int.Parse(e.ClickedItem.Text), richTextBox1.Font.Style);
        }
    }
}
