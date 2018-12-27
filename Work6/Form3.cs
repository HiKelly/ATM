using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal money;
            string[] parameter = Form1.GetSqlParameters();
            bool f = decimal.TryParse(textBox1.Text, out money);
            if (!f)
            {
                MessageBox.Show("输入金额错误！请重新输入！");
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                decimal newmoney = decimal.Parse(parameter[2]);
                if(money <= 0)
                {
                    MessageBox.Show("存款应为正数！");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else if(money > 1000000000000)
                {
                    MessageBox.Show("存款金额过大！");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    newmoney += money;
                    Form1.SetSqlParameters(newmoney);
                    MessageBox.Show("存款成功！");
                    Form2.flag = 0;
                    this.Close();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2.flag = 0;
        }
    }
}
