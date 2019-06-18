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

namespace StudentMS.Score
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FormShow show = new FormShow();
            this.Hide();
            show.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxStudent.Text == "" || textBoxCourse.Text == "" || textBoxScore.Text == "")
            {
                MessageBox.Show("您輸入的訊息不夠完整，請重新輸入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
                string sqlquery = String.Format("INSERT INTO [dbo].[Score](CourseID, StudentID, ClassID, Score) VALUES ('{0}', '{1}', N'{2}','{3}')", textBoxCourse.Text, textBoxStudent.Text, comboBoxClass.Text, textBoxScore.Text); //SQL语句
                try
                {
                    sqlconn.Open();
                    SqlCommand command = new SqlCommand(sqlquery, sqlconn);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("您成功新增一位學生成績", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("學生成績新增失敗", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "操作資料庫出錯！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    sqlconn.Close();// 关闭数据库连接
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormScore main = new MainFormScore();
            this.Hide();
            main.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch search = new FormSearch();
            this.Hide();
            search.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            this.Hide();
            update.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            string sqlquery = "Select ClassID from [dbo].[Class]";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBoxClass.DisplayMember = "ClassID";
            comboBoxClass.DataSource = dt;
            sqlconn.Close();
        }
    }
}