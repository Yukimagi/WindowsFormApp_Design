using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class Form1 : Form
    {
        System.DateTime TimeMachine;//機子的現在時間
        System.DateTime TimeNow;//機子的現在時間
        TimeSpan TimeDiff = new TimeSpan();//時間相減
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
            

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                
                TimeNow = DateTime.Now;
                
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeDiff = DateTime.Now - TimeNow;//時間相減
            TimeMachine = DateTime.Now;//現在時間
            textBox1.Text = string.Format("{0:00}", TimeMachine.Hour);//現在時間
            textBox2.Text = string.Format("{0:00}", TimeMachine.Minute);//現在時間
            textBox3.Text = string.Format("{0:00}", TimeMachine.Second);//現在時間
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Start();
            TimeNow = DateTime.Now;
        }
    }
}

