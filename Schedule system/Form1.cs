using cn.bmob.exception;
using cn.bmob.io;
using cn.bmob.json;
using cn.bmob.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Schedule_system
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }
        string str = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        SqlDataReader result = null;
        public bool loginus(string un, string pw)
        //登录程序，用户名和密码都正确，返回true
        {
            conn.ConnectionString = str;
            string sql="select*from student where name='"+un+"'and password='"+pw+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            try
            {
                result = cmd.ExecuteReader();

            }
            catch (Exception)
            {
                MessageBox.Show("对不起!查询数据失败!", "提示");
            }
            if(result!=null)
            {
                if(result.Read())
                {return true;};
            }
            result.Close();
            cmd.Connection.Close();
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text.Trim();
            string p = textBox2.Text.Trim();
            if ((textBox1.Text != "") & (textBox2.Text != ""))
            {
                if (loginus(n, p) == false)
                {
                    MessageBox.Show("用户名或密码错误");
                    return;
                }
                DialogResult = DialogResult.OK;
                this.Hide();
                if (comboBox1.Text == "学生")
                {
                    mainform tt = new mainform();
                    tt.Show();
                }
                else
                {
                    manageForm pp = new manageForm();
                    pp.Show();
 
                }
            } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
