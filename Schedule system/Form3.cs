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
    public partial class manageForm : Form
    {
        public manageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = aa;
            string sql = "select*from CCourse where 学分=2";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection1);
            DataSet ds = new DataSet();
            try
            {
                sqlConnection1.Open();
                da.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败", "提示");

            }
            finally
            {
                sqlConnection1.Close();
            }
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            LoginForm rr = new LoginForm();
            rr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = aa;
            string cmdText = @"insert into AddData values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                qingkong();
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败", "提示");
            }
            finally
            {
                con.Close();
            }
            shuaxin();
        }
        void shuaxin()
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = aa;
            string cmdText = "select*FROM AddData";
            SqlDataAdapter da = new SqlDataAdapter(cmdText, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                da.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("打开数据库失败", "提示");
            }
            finally
            {
                con.Close();
            }
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        void qingkong()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = aa;
            MessageBox.Show("删除前请先查询");
            if (comboBox1.Text == "")
                MessageBox.Show("请先选择查询条件");
            else
            {
                string cmdText = "DELECT AddData where" + comboBox1.Text + "='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    qingkong();
                }
                catch (Exception)
                {
                    MessageBox.Show("删除数据失败", "提示");

                }
                finally
                {
                    con.Close();
                }
                shuaxin();
            }

        }
    }
}
