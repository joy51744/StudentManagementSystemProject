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

namespace StudentMS.User
{
    public partial class MainFormScore : Form
    {
        public MainFormScore()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
                sqlconn.Open();
                SqlDataAdapter dataSelect = new SqlDataAdapter("SELECT * FROM [dbo].[Score]", sqlconn);
                DataTable dt = new DataTable();
                dataSelect.Fill(dt);
                dataGridViewShow.DataSource = dt.DefaultView;
                this.dataGridViewShow.RowHeadersVisible = true;
                sqlconn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("警告！", error.Message.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            User.StudentMainForm main = new User.StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }
    }
}