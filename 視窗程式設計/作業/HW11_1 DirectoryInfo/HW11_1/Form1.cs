using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //會在debug資料夾內建立目錄
            string strPath = "MyDir\\SubDir";
            if(Directory.Exists(strPath) )
            {
                MessageBox.Show("目錄已存在");
                return;
            }
            Directory.CreateDirectory(strPath);
            MessageBox.Show("建立目錄完成");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string strPath = @"..\";//回到上一層
            List<string> dirs;
            //搜尋所有目錄、子目錄、存到dirs
            dirs = new List<string>(Directory.EnumerateDirectories(strPath,"*.*",SearchOption.AllDirectories));
            foreach(var item in dirs)
            {
                textBox1.AppendText(item.ToString()+"\r\n");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strPath = "MyDir\\SubDir";
            if (!Directory.Exists(strPath))
            {
                MessageBox.Show("目錄不存在");
                return;
            }
            Directory.Delete(strPath);
            MessageBox.Show("完成刪除目錄");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strPath = "MyDir";
            if (Directory.Exists(strPath))
            {
                DirectoryInfo di = new DirectoryInfo("MyDir");
                MessageBox.Show("目錄Source: " + di.FullName);
                if (Directory.Exists("MyDir\\SubDir")){
                    if (Directory.Exists("..\\TempDir\\SubDir") == false)
                    {
                        Directory.Delete("TempDir");
                        di.MoveTo("..\\TempDir");
                        MessageBox.Show("移動SubDir目錄成功");
                    }
                    else
                    {
                        Directory.Delete("MyDir\\SubDir");
                        Directory.Delete("MyDir");
                        MessageBox.Show("..\\TempDir\\SubDir目錄已存在");
                    }
                }
                else
                {
                    if (Directory.Exists("..\\TempDir") == false)
                    {
                        di.MoveTo("..\\TempDir");
                        di.CreateSubdirectory("SubDir");
                        MessageBox.Show("移動SubDir目錄成功");
                    }
                    else
                    {
                        MessageBox.Show("..\\TempDir\\SubDir目錄已存在");
                    }
                }
            }
            else
            {
                MessageBox.Show("MyDir不存在");
            }
        }
    }
}
