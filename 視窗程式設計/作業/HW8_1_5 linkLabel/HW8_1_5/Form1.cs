using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_1_5
{
    public partial class Form1 : Form
    {
        string str1 = "www.google.com";
        string str2 = "www.youtube.com";
        public Form1()
        {
            InitializeComponent();
            
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;//onMouseHover

            linkLabel1.Text = str1 + " " + str2;
            
            linkLabel1.Links.Add(0, str1.Length, str1); //Links[0]第0位，取str1.Length 個字元，目標
            linkLabel1.Links.Add(str1.Length+1,str2.Length , str2);//Links[1]第str1.Length+1位，取str2.Length 個字元，目標

            //linkLabel1.Text = linkLabel1.Links[0].LinkData.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            //下面是改顏色
            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited= true;
        }
    }
}
