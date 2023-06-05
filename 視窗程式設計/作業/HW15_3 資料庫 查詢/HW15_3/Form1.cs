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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW15_3
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
            button1.Visible= false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select*From customer";
            OleDbDataReader dr = cmd.ExecuteReader();//執行SQL

            textBox1.Text = "\n\n";
            for (int i = 0; i < dr.FieldCount; i++)
            {
                textBox1.Text += dr.GetName(i) + "\t";//欄位名稱
            }
            textBox1.Text += "\r\n=========================================\r\n";
            while (dr.Read())//一筆一筆讀直到檔案結尾才結束
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    textBox1.Text += dr[i].ToString() + "\t";//select all
                }
                textBox1.Text += "\r\n";

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            textBox1.Multiline = false;
            textBox1.Width = 200;
        }
        String s;
        private void button1_Click(object sender, EventArgs e)
        {
            s=textBox1.Text;
            OleDbCommand cmd0 = new OleDbCommand();
            cmd0.Connection = cn;
            textBox1.Multiline = true;
            textBox1.Width = 735;
            textBox1.Text = "";

            cmd0.CommandText = "Select*From customer";
            OleDbDataReader dr0 = cmd0.ExecuteReader();//執行SQL

            textBox1.Text = "\n\n";
            for (int i = 0; i < dr0.FieldCount; i++)
            {
                textBox1.Text += dr0.GetName(i) + "\t";//欄位名稱
            }
            textBox1.Text += "\r\n======================================================================================================\r\n";

            button1.Visible=false;

            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = cn;
            cmd2.CommandText = "SELECT * FROM customer " +
                            "where 客戶編號 = '" + s + "' ";
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {

                for (int i = 0; i < dr2.FieldCount; i++)
                {
                    textBox1.Text += dr2[i].ToString() + "\t";
                }
                textBox1.Text += "\r\n";
            }
            else
            {
                textBox1.Text = "找不到這個客戶的資料";
            }
        }

    }
}
