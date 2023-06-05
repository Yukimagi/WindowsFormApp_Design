using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//header
using System.IO.Compression;//header

namespace HW11_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourcePath;//壓縮目錄
            //設定壓縮目錄
            sourcePath=Application.StartupPath+@"\source";
            if(File.Exists("a.zip")) {//壓縮若已存在先刪除
                File.Delete("a.zip");
            }
            try
            {
                //建立壓縮檔
                ZipFile.CreateFromDirectory(sourcePath,"a.zip");
                textBox1.AppendText("建立壓所檔完成\r\n");
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string extractPath = ".extract";
            //----------解壓縮-----------
            if(Directory.Exists(extractPath))
            {
                Directory.Delete(extractPath, true);
            }
            try
            {
                //解壓縮檔
                ZipFile.ExtractToDirectory("a.zip", extractPath);
                textBox1.AppendText("解壓縮完成\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
