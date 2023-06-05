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
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace HW15_2
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
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立OleDbCommand的cmd物件
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection= cn;
            cmd.CommandText = "Select*From customer";
            OleDbDataReader dr = cmd.ExecuteReader();//執行SQL

            textBox1.Text = "\n\n";
            for (int i = 0; i < dr.FieldCount; i++)
            {
                textBox1.Text += dr.GetName(i) + "\t";//欄位名稱
            }
            textBox1.Text += "\r\n=========================================\r\n";
            while(dr.Read())//一筆一筆讀直到檔案結尾才結束
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    textBox1.Text += dr[i].ToString() + "\t";//select all
                }
                textBox1.Text += "\r\n";
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd=new OleDbCommand();
            cmd.Connection= cn;
            cmd.CommandText = "INSERT INTO customer values" +
                            "('客戶編號0','客戶名稱0','統一編號0'," +
                            "'電話0','傳真0','信箱0','住址0')";
            OleDbDataReader dr= cmd.ExecuteReader();
            MessageBox.Show("新增完成");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd=new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM customer " +
                            "where 客戶編號 = '客戶編號0' ";
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    textBox1.Text += dr[i].ToString() + "\t";
                }
                textBox1.Text += "\r\n";
            }
            else
            {
                textBox1.Text = "找不到這個客戶的資料";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd= new OleDbCommand();
            cmd.Connection= cn;
            cmd.CommandText = "update customer set 客戶編號='客戶編號4'," +
                            "客戶名稱='客戶名稱4',統一編號='統一編號4'," +
                            "電話='電話4',傳真='傳真4',信箱='信箱4',住址='住址4' " +
                            "where 客戶編號 = '客戶編號0' ";
            OleDbDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("修改完成");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from customer where 客戶編號 = '客戶編號4' ";
            OleDbDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("刪除完成");
        }
    }
}
