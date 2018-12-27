using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            form1.ShowDialog();
            while (Form2.flag != -1)
            {
                if (Form2.flag == 0)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
                if (Form2.flag == 1)
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                if (Form2.flag == 2)
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                }
                if (Form2.flag == 3)
                {
                    Form5 form5 = new Form5();
                    form5.ShowDialog();
                }
            }
        }
    }
}
