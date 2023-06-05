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

namespace HW11_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs;
        private void button1_Click(object sender, EventArgs e)
        {
            string strFileName = "test1.txt";
            string str = "File.Open";
            textBox1.Clear();

            fs = File.Open(strFileName,FileMode.Create,FileAccess.Write);

            //來源、起點、擷取長度
            //例如:fs.Write(Encoding.UTF8,GetBytes(str,1,2);
            fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
            textBox1.Text = "File.Open建立新檔案test1.txt並寫入資料成功";
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            string str = "File.Create";
            textBox1.Clear();
            //使用Create方法建立檔案並寫入資料
            //建立或覆寫指定路徑中的檔案，並指緩衝區大小，以及描述如何建立檔案
            fs = File.Create("test2.txt", 256, FileOptions.SequentialScan);
            fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
            fs.Close();
            textBox1.Text = "File.Create建立新檔案test2.txt並寫入資料成功";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSource = "test1.txt";
            string strTarget = "copy.txt";
            textBox1.Clear();
            
            /*if (!File.Exists(strSource))
            {
                textBox1.Text = "檔案不存在，無法進行拷貝";
                return;
            }*/

            try
            {
                File.Copy(strSource, strTarget);
                if (File.Exists(strTarget))//檢查拷貝的檔案是否存在
                {
                    textBox1.Text = "File.Copy檔案test1.txt拷貝成功";
                    //MessageBox.Show("File.Copy檔案test1.txt拷貝成功");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("發生錯誤");
                return;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strDelete = "copy.txt";
            textBox1.Clear();
            if (!File.Exists(strDelete))
            {
                textBox1.Text = "檔案不存在，無法進行刪除";
            }
            else
            {
                File.Delete(strDelete);
                if (!File.Exists(strDelete))
                {
                    textBox1.Text = "File.Delete檔案copy.txt刪除成功";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strSource = "test1.txt";
            string strTarget = "..\\move.txt";
            textBox1.Clear();
            if (!File.Exists(strSource))
            {
                textBox1.Text = "檔案不存在。";
            }
            else
            {
                if (!File.Exists(strTarget))
                {
                    File.Move(strSource, strTarget);
                    if (File.Exists(strTarget))
                    {
                        textBox1.Text = "File.Move移動成功";
                    }
                }
                else
                {
                    DialogResult result=MessageBox.Show("檔案已存在，請問是否覆寫檔案?", "檔案檢查", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(strTarget);
                        File.Move(strSource, strTarget);
                        if (File.Exists(strTarget))
                        {
                            textBox1.Text = "File.Move移動成功";
                        }
                    }
                }
            }
        }
    }
}
