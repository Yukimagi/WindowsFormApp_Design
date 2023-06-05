using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
            textBox2.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1, b = 1, c;//分別為被除數、除數、商
            bool fgError = true;//表示是否輸入值有出現錯誤的情形
            textBox3.Clear();

            try//讀取使用者輸入的被除數與除數
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                fgError = false;
            }
            catch (FormatException ex)
            {
                //資料型別錯誤
                //textBox3.AppendText(ex.Message+"\r\n");//顯示錯誤訊息
                MessageBox.Show("輸入字串格式不正確");
                textBox1.Text = "1";
                textBox2.Text = "1";

            }
            finally
            {
                //顯示a、b的值(AppendText會附加到現在的文字後)
                textBox3.AppendText("a=" + a.ToString() + "\r\n");
                textBox3.AppendText("b=" + b.ToString() + "\r\n");

                //===============做除法運算================            }
                if (fgError == false)//如果沒有發生輸入錯誤
                {
                    try
                    {
                        c = a / b;
                        float a2, b2, c2;
                        a2 = Convert.ToSingle(textBox1.Text);//浮點數
                        b2 = Convert.ToSingle(textBox2.Text);
                        c2 = a2 / b2;
                        label3.Text = c2.ToString("F2");
                    }
                    catch (DivideByZeroException ex)
                    {
                        textBox3.Clear();
                        //除0錯誤
                        textBox3.AppendText("分母不得為0");
                        //重新設定初始值
                    }

                }
            }

        }
    }
}
