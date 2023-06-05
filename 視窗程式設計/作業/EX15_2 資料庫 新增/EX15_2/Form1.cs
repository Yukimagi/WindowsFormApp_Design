using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//引用OleDb命名空間
using System.Windows.Forms;

namespace EX15_2
{
    public partial class Form1 : Form
    {
        OleDbConnection cn;
        public Form1()
        {
            InitializeComponent();
            String cnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
            cn = new OleDbConnection(cnStr);
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            if (textBox1.Text == "") { MessageBox.Show("請輸入客戶編號!"); }
            else
            {
                cmd.CommandText = "SELECT * FROM customer " +
                                "where 客戶編號 = '客戶編號" + textBox1.Text + "' ";
                OleDbDataReader dr = cmd.ExecuteReader();//執行SQL
                if (dr.Read())
                {
                    MessageBox.Show("Error:客戶編號已存在!");
                }
                else
                {
                    add();
                }
            }
        }
        void add()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO customer values" +
                                "('客戶編號" + textBox1.Text + "','客戶名稱" + textBox2.Text + "','統一編號" + textBox3.Text + "'," +
                                "'電話" + textBox4.Text + "','傳真" + textBox5.Text + "','信箱" + textBox6.Text + "','住址" + textBox7.Text + "')";
            OleDbDataReader dr = cmd.ExecuteReader();//執行SQL
            MessageBox.Show("新增完成");
        }
    }
}
