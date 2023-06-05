using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX15_3
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
            button1.Enabled= false;
            label2.Visible= false;
            label3.Visible= false;
            label4.Visible= false;
            label5.Visible= false;
            label6.Visible= false;
            label7.Visible= false;
            textBox2.Visible= false;
            textBox3.Visible= false;
            textBox4.Visible= false;
            textBox5.Visible= false;
            textBox6.Visible= false;
            textBox7.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("請問是否刪除", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                delete();
                button1.Enabled = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                button2.Visible = true;
                textBox1.ReadOnly = false;
            }
        }
        void delete()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from customer where 客戶編號 = '"+s+"' ";
            OleDbDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("刪除完成");
        }
        String s;
        private void button2_Click(object sender, EventArgs e)
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
                    s = "客戶編號" + textBox1.Text;
                    button1.Enabled = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    textBox2.Visible = true;
                    textBox2.Text = dr[1].ToString();

                    textBox3.Visible = true;
                    textBox3.Text = dr[2].ToString();

                    textBox4.Visible = true;
                    textBox4.Text = dr[3].ToString();

                    textBox5.Visible = true;
                    textBox5.Text = dr[4].ToString();

                    textBox6.Visible = true;
                    textBox6.Text = dr[5].ToString();

                    textBox7.Visible = true;
                    textBox7.Text = dr[6].ToString();
                    textBox1.ReadOnly= true;

                    button2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error:客戶編號不存在!");
                }
            }
        }
    }
}
