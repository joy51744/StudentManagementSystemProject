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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
                sqlconn.Open();
                SqlDataAdapter dataSelect = new SqlDataAdapter("SELECT * FROM [dbo].[Course]", sqlconn);
                DataTable dt = new DataTable();
                dataSelect.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                this.dataGridView1.RowHeadersVisible = true;
                sqlconn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("警告！", error.Message.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            if (textBoxUpdate.Text == "")
            {
                string sqlquery = string.Format("SELECT * FROM [dbo].[Course]");
                try
                {
                    sqlconn.Open();   //打开数据库连接
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, sqlconn);
                    DataSet DS = new DataSet();
                    adapter.Fill(DS, "Course");
                    dataGridView1.DataSource = DS.Tables["Course"];
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message, "操作資料庫出錯！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
            else
            {
                string sqlquery;

                sqlquery = String.Format("SELECT * FROM [dbo].[Course] WHERE CourseID = '{0}' ", textBoxUpdate.Text);
                try
                {
                    sqlconn.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, sqlconn);
                    adapter.Fill(ds, "Course");
                    dataGridView1.DataSource = ds.Tables["Course"];
                    if (ds.Tables[0].Rows.Count == 0)  //如果未查詢到任何訊息，給出提示，並顯示全部訊息
                    {
                        MessageBox.Show("沒有查詢到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        sqlconn.Close();
                        sqlquery = String.Format("SELECT * FROM [dbo].[Course]");
                        sqlconn.Open();
                        adapter = new SqlDataAdapter(sqlquery, sqlconn);
                        ds = new DataSet();
                        adapter.Fill(ds, "Course");
                        dataGridView1.DataSource = ds.Tables["Course"];
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message, "操作資料庫出錯！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int CourseID = (int)(this.dataGridView1.CurrentRow.Cells[0].Value);
            string CourseName = (string)(this.dataGridView1.CurrentRow.Cells[1].Value);
            int ClassID = (int)(this.dataGridView1.CurrentRow.Cells[2].Value);
            string ClassTeacher = (string)(this.dataGridView1.CurrentRow.Cells[3].Value);
            int SubjectID = (int)(this.dataGridView1.CurrentRow.Cells[4].Value);
            DateTime BeginDate = (DateTime)(this.dataGridView1.CurrentRow.Cells[5].Value);
            DateTime FinishDate = (DateTime)(this.dataGridView1.CurrentRow.Cells[6].Value);

            FormChange change = new FormChange();
            change.init(CourseID, CourseName, ClassID, ClassTeacher, SubjectID, BeginDate, FinishDate);
            change.ShowDialog();  //顯示修改視窗
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormCourse course = new MainFormCourse();
            this.Hide();
            course.Show();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'studentStuCourseManageDataSet.Course' 資料表。您可以視需要進行移動或移除。
            this.courseTableAdapter.Fill(this.studentStuCourseManageDataSet.Course);
            this.courseTableAdapter.Update(this.studentStuCourseManageDataSet.Course);
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }
    }
}