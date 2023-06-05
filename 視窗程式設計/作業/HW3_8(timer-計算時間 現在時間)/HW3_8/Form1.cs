using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_8
{
    public partial class Form1 : Form
    {
        System.DateTime TimeNow;//機子的現在時間
        System.DateTime TimeMachine;//機子的現在時間
        TimeSpan TimeDiff = new TimeSpan();//時間相減
        //DateTime.Now->Hour
        //TimeSpan    ->Hours
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            TimeNow=DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();//大家都會停，如果要個別就要個別用timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeDiff = DateTime.Now - TimeNow;//時間相減
            textBox1.Text=string.Format("{0:00}:{1:00}:{2:00}",TimeDiff.Hours,TimeDiff.Minutes,TimeDiff.Seconds);//計算時間
            //{2:00}={索引值:格式}
            //textBox1.Text=TimeDiff.Hours.Tostring()+":"+TimeDiff.Minutes.Tostring()+":"+TimeDiff.Seconds.Tostring();
            TimeMachine = DateTime.Now;//現在時間
            textBox2.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeMachine.Hour, TimeMachine.Minute, TimeMachine.Second);//現在時間
        }
    }
}
