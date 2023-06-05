using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult result;//MessageBox回傳值
            string text="";
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (j > i) { text = text + "\n"; break; }
                    else
                    {
                        text = text + i + "*" + j + "=" + i * j+" ";
                    }
                }
            }
            MessageBox.Show(text);
        }
    }
}
