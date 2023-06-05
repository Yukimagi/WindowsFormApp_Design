using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW9_3
{
    public partial class Form1 : Form
    {
        struct _STU//定義學生資料的結構
        {
            public int id;      //學號
            public string name; //姓名
            public int age;     //年齡
            public int chin;    //中文
            public int eng;     //英文
            public int math;    //數學
        }
        public const int MAX_NUM = 3;//最多3位學生
        _STU[] stut=new _STU[MAX_NUM];//3位學生
        int stuNum;//目前學生數量
        float[] avg = { 0, 0, 0 };//個人平均

        //----------------清除資料--------------
        void clear()
        {
            textBox5.Clear();
        }
        //----------------新增學生資料--------------
        void add()
        {
            stut[stuNum].id = stuNum + 1;
            stut[stuNum].name = textBox1.Text.ToString();
            stut[stuNum].age = Convert.ToInt32(comboBox1.Text.ToString());
            stut[stuNum].chin = Convert.ToInt32(textBox2.Text.ToString());
            stut[stuNum].eng = Convert.ToInt32(textBox3.Text.ToString());
            stut[stuNum].math = Convert.ToInt32(textBox4.Text.ToString());
            label2.Visible = true;
            label2.Text = stut[stuNum].id+"\r\n";
            showData();
            stuNum++;
        }
        void showData()
        {
            textBox5.AppendText("學號:" + stut[stuNum].id + ",姓名:" + stut[stuNum].name + ",年齡:" + stut[stuNum].age + ",國文:" + stut[stuNum].chin + ",英文:" + stut[stuNum].eng + ",數學:" + stut[stuNum].math+"\r\n");
        }
        public Form1()
        {
            InitializeComponent();
            clear();
            label2.Visible= false;
            stuNum= 0;//剛開始學生人數=0
            for(int i=0;i<MAX_NUM;i++)
            {
                stut[i].id = i + 1;
                stut[i].name = "None";
                stut[i].age = 0;
                stut[i].chin = 0;
                stut[i].eng = 0;
                stut[i].math = 0;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            avg[0] = 0;
            avg[1] = 0;
            avg[2] = 0;
            textBox5.AppendText("\r\n\r\n\r\n----------------------------------\r\n\r\n\r\n");
            textBox5.AppendText("共" + stuNum + "人\r\n");
            textBox5.AppendText("[2人平均]:");
            for(int i = 0; i < stuNum; i++)
            {
                int a;
                a = (stut[i].chin+ stut[i].eng+ stut[i].math)/3;
                textBox5.AppendText(stuNum+".:" + a + " ");
                avg[0] = stut[i].chin + avg[0];
                avg[1] = stut[i].eng + avg[1];
                avg[2] = stut[i].math + avg[2];
            }
            avg[0] = avg[0]/stuNum;
            avg[1] = avg[1] / stuNum;
            avg[2] = avg[2] / stuNum;
            textBox5.AppendText("\r\n[三科平均]: 國文=" + avg[0] + " 英文=" + avg[1] + " 數學=" + avg[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stuNum + 1 > 3)
            {
                MessageBox.Show("人數已滿");
            }
            else
            {
                add();//新增資料
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
