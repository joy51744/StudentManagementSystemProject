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

namespace StudentMS.Course
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormCourse main = new MainFormCourse();
            this.Hide();
            main.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FormShow show = new FormShow();
            this.Hide();
            show.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Begin = dateTimePickerBegin.Value.ToString("yyyy-MM-dd");
            string Finish = dateTimePickerFinish.Value.ToString("yyyy-MM-dd");

            if (textBoxName.Text == "" || textBoxID.Text == "" || textBoxTeacher.Text == "")
            {
                MessageBox.Show("您輸入的訊息不夠完整，請重新輸入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
                string sqlquery = String.Format("INSERT INTO [dbo].[Course](CourseName, ClassID, ClassTeacher, SubjectID, BeginDate, FinishDate) VALUES (N'{0}', '{1}', N'{2}','{3}','{4}', '{5}')", textBoxName.Text, textBoxID.Text, textBoxTeacher.Text, comboBoxSubject.Text, Begin, Finish); //SQL语句
                try
                {
                    sqlconn.Open();
                    SqlCommand command = new SqlCommand(sqlquery, sqlconn);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("您成功新增一堂課程", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("課程訊息新增失敗", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormAdd_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            string sqlquery = "Select SubjectID from [dbo].[Subject]";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBoxSubject.DisplayMember = "SubjectID";
            comboBoxSubject.DataSource = dt;
            sqlconn.Close();
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FormShow show = new FormShow();
            this.Hide();
            show.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            this.Hide();
            update.Show();
        }
    }
}