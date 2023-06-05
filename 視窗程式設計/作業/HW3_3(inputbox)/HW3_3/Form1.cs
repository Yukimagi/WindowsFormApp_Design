using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//1.到“專案” → “加入參考(visualbasic” → “參考管理員”
//2.並最後using就可使用input box

namespace HW3_3
{
    public partial class Form1 : Form
    {
        string account, password;
        private void Form1_Activated(object sender, EventArgs e)
        {
            //4.要用activated事件進行到form1
            label1.Text = "帳號: " + account;
            label2.Text = "密碼: " + password;
        }
        public Form1()
        {
            InitializeComponent();
            //3.inputbox要先執行程式最前面我寫的提示步驟
            account = Interaction.InputBox("輸入帳號", "登入", "Sherk", 50, 50);//50,50視窗座標位置
            password= Interaction.InputBox("輸入密碼", "登入", "", -1, -1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
