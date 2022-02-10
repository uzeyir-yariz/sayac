using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayaç
{
    public partial class Form1 : Form
    {
        int s1;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 arttır

            if (s1 < 10)
            {
                s1++;
                textBox1.Text = s1.ToString();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 eksilt

            if (s1 > 0)
            {
                s1--;
                textBox1.Text = s1.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int top = 0;

            for (int i = 0; i <= 10; i++)
            {
                top = i * s1;
                listBox1.Items.Add(i.ToString() + " X " + s1.ToString() + " = " + top.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
