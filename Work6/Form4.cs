using System;
using System.Windows.Forms;

namespace Work6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] parameters = Form1.GetSqlParameters();
            decimal newmoney;
            bool f = decimal.TryParse(textBox1.Text, out newmoney);
            if (!f)
            {
                MessageBox.Show("请输入正确的金额！");
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                decimal money = decimal.Parse(parameters[2]);
                if(newmoney <= 0)
                {
                    MessageBox.Show("取款应为正数！");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else if (newmoney > money)
                {
                    MessageBox.Show("您的余额不足！\n提取失败！");
                }
                else
                {
                    money -= newmoney;
                    MessageBox.Show("提取成功！");
                    Form1.SetSqlParameters(money);
                    Form2.flag = 0;
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2.flag = 0;
        }
    }
}
