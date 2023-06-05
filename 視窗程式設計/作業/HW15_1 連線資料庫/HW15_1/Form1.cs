using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//引用OleDb命名空間
namespace HW15_1
{
    
    public partial class Form1 : Form
    {
        OleDbConnection cn;
        bool test = false;
        public Form1()
        {
            InitializeComponent();
            String cnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
            cn = new OleDbConnection(cnStr);
            textBox1.Text += $"逾時秒數:{cn.ConnectionTimeout}\r\n";
            textBox1.Text += $"連線成功，資料來源:{cn.DataSource}\r\n";
            button1.Text = "開啟";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (test == false)
            {
                cn.Open();
                textBox1.Text += "\r\n目前狀態:資料庫開啟\r\n";
                button1.Text = "關閉";
                test = true;
            }
            else
            {
                cn.Close();
                textBox1.Text += "\r\n目前狀態:資料庫關閉\r\n";
                button1.Text = "開啟";
                test = false;
            }

        }
    }
}
