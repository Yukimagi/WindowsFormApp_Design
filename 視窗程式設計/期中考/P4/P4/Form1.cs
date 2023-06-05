using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor= Color.Green;
            pictureBox2.BackColor = Color.Green;
            pictureBox3.BackColor = Color.Green;
            pictureBox4.BackColor = Color.Green;
            pictureBox5.BackColor = Color.Green;
            pictureBox6.BackColor = Color.Green;
            pictureBox7.BackColor = Color.Green;
            pictureBox8.BackColor = Color.Green;
            pictureBox9.BackColor = Color.Green;
            pictureBox1.Enabled= false;
            pictureBox2.Enabled= false;
            pictureBox3.Enabled= false;
            pictureBox4.Enabled= false;
            pictureBox5.Enabled= false;
            pictureBox6.Enabled= false;
            pictureBox7.Enabled= false;
            pictureBox8.Enabled= false;
            pictureBox9.Enabled= false;
        }
        //bool test = true;
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Pink;
            pictureBox2.BackColor = Color.Pink;
            pictureBox3.BackColor = Color.Pink;
            pictureBox4.BackColor = Color.Pink;
            pictureBox5.BackColor = Color.Pink;
            pictureBox6.BackColor = Color.Pink;
            pictureBox7.BackColor = Color.Pink;
            pictureBox8.BackColor = Color.Pink;
            pictureBox9.BackColor = Color.Pink;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            button1.Text = "重玩";
           // int i = 1;
   

        }
        //bool test2=false;
        void test()
        {

            if (pictureBox1.BackColor == Color.Yellow && pictureBox2.BackColor == Color.Yellow && pictureBox3.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox1.BackColor == Color.Blue && pictureBox2.BackColor == Color.Blue && pictureBox3.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox4.BackColor == Color.Yellow && pictureBox5.BackColor == Color.Yellow && pictureBox6.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox4.BackColor == Color.Blue && pictureBox5.BackColor == Color.Blue && pictureBox6.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox7.BackColor == Color.Yellow && pictureBox8.BackColor == Color.Yellow && pictureBox9.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox7.BackColor == Color.Blue && pictureBox8.BackColor == Color.Blue && pictureBox9.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox1.BackColor == Color.Yellow && pictureBox4.BackColor == Color.Yellow && pictureBox7.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox1.BackColor == Color.Blue && pictureBox4.BackColor == Color.Blue && pictureBox7.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox2.BackColor == Color.Yellow && pictureBox5.BackColor == Color.Yellow && pictureBox8.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox2.BackColor == Color.Blue && pictureBox5.BackColor == Color.Blue && pictureBox8.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox3.BackColor == Color.Yellow && pictureBox6.BackColor == Color.Yellow && pictureBox9.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox3.BackColor == Color.Blue && pictureBox6.BackColor == Color.Blue && pictureBox9.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox1.BackColor == Color.Yellow && pictureBox5.BackColor == Color.Yellow && pictureBox9.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else if (pictureBox1.BackColor == Color.Blue && pictureBox5.BackColor == Color.Blue && pictureBox9.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;

            }
            else if (pictureBox3.BackColor == Color.Yellow && pictureBox5.BackColor == Color.Yellow && pictureBox7.BackColor == Color.Yellow)
            {
                MessageBox.Show("黃色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;

            }
            else if (pictureBox3.BackColor == Color.Blue && pictureBox5.BackColor == Color.Blue && pictureBox7.BackColor == Color.Blue)
            {
                MessageBox.Show("藍色贏...");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox1.BackColor= Color.Blue;
                c = 1;
                pictureBox1.Enabled= false;
                test();
            }
            else
            {
                pictureBox1.BackColor = Color.Yellow;
                c = 0;
                pictureBox1.Enabled = false;
                test();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox2.BackColor = Color.Blue;
                c = 1;
                pictureBox2.Enabled = false;
                test();
            }
            else
            {
                pictureBox2.BackColor = Color.Yellow;
                c = 0;
                pictureBox2.Enabled = false;
                test();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox3.BackColor = Color.Blue;
                c = 1;
                pictureBox3.Enabled = false;
                test();
            }
            else
            {
                pictureBox3.BackColor = Color.Yellow;
                c = 0;
                pictureBox3.Enabled = false;
                test();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox4.BackColor = Color.Blue;
                c = 1;
                pictureBox4.Enabled = false;
                test();
            }
            else
            {
                pictureBox4.BackColor = Color.Yellow;
                c = 0;
                pictureBox4.Enabled = false;
                test();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox5.BackColor = Color.Blue;
                c = 1;
                pictureBox5.Enabled = false;
                test();
            }
            else
            {
                pictureBox5.BackColor = Color.Yellow;
                c = 0;
                pictureBox5.Enabled = false;
                test();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox6.BackColor = Color.Blue;
                c = 1;
                pictureBox6.Enabled = false;
                test();
            }
            else
            {
                pictureBox6.BackColor = Color.Yellow;
                c = 0;
                pictureBox6.Enabled = false;
                test();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox7.BackColor = Color.Blue;
                c = 1;
                pictureBox7.Enabled = false;
                test();
            }
            else
            {
                pictureBox7.BackColor = Color.Yellow;
                c = 0;
                pictureBox7.Enabled = false;
                test();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox8.BackColor = Color.Blue;
                c = 1;
                pictureBox8.Enabled = false;
                test();
            }
            else
            {
                pictureBox8.BackColor = Color.Yellow;
                c = 0;
                pictureBox8.Enabled = false;
                test();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                pictureBox9.BackColor = Color.Blue;
                c = 1;
                pictureBox9.Enabled = false;
                test();
            }
            else
            {
                pictureBox9.BackColor = Color.Yellow;
                c = 0;
                pictureBox9.Enabled = false;
                test();
            }
        }
    }
}
