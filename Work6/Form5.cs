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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            string[] parameters = Form1.GetSqlParameters();
            label2.Text = parameters[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.flag = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.flag = 0;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2.flag = 0;
        }
    }
}
