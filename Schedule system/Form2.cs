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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = aa;
            string sql = "select*from ECourse";
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

        private void button3_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = aa;
            string sql = "select*from PCourse";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = aa;
            string sql = "select*from CCourse";
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
            this.Close();
            LoginForm cc = new LoginForm();
            cc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aa = @"Data Source=127.0.0.1;Initial Catalog=system;Integrated Security=True";
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = aa;
            string sql = "select*from Test";
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
    }
}
