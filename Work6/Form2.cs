using System;
using System.Windows.Forms;

namespace Work6
{
    public partial class Form2 : Form
    {
        public static int flag = -1;    //标记当前功能窗口

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            flag = 2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            flag = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            flag = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            flag = -1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            flag = -1;
        }
    }
}
