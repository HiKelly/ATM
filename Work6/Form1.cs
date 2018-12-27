using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Work6
{
    public partial class Form1 : Form
    {
        private int errorTime = 0;
        private static string[] parameters = new string[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(); //账号
            string pw = textBox2.Text.Trim();   //密码
            string constr = "Server=106.15.90.215;port=3306;DataBase=ATM;user=root;password=root";

            MySqlConnection Conn = new MySqlConnection(constr);
            Conn.Open();

            string sqlStr = "select name,password,balance from users where name='" + username +
                "' and password='" + pw + "'";  //SQL命令            

            var command = Conn.CreateCommand();
            command.CommandText = sqlStr;
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) {
                    MessageBox.Show("欢迎使用");
                    parameters[0] = reader.GetString("name");
                    parameters[1] = reader.GetString("password");
                    parameters[2] = reader.GetString("balance");
                }
                Form2.flag = 0;
                this.Close();
            }
            else
            {
                if(errorTime < 3)
                {
                    MessageBox.Show("用户名或密码有错，请重新输入！\n" + 
                        "还有" + (3 - errorTime).ToString() + "次机会!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    errorTime++;
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误已达三次\n将退出程序！");
                    this.Close();
                }
            }
        }

        public static string[] GetSqlParameters()
        {
            return parameters;
        }

        public static void SetSqlParameters(decimal newmoney)
        {
            parameters[2] = newmoney.ToString();
            string constr = "Server=106.15.90.215;port=3306;DataBase=ATM;user=root;password=root";
            MySqlConnection Conn = new MySqlConnection(constr);
            Conn.Open();

            
            string s1 = "update users set balance=" + newmoney + " where name=\'" + parameters[0] + "\'";  //SQL命令
            MySqlCommand mycom = new MySqlCommand(s1, Conn);
            mycom.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
