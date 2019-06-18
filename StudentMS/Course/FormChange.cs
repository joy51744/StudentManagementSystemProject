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
    public partial class FormChange : Form
    {
        private DataSet ds = new DataSet();
        private SqlConnection sqlconn = new SqlConnection();

        public FormChange()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
        }

        internal void init(int courseID, string courseName, int classID, string classTeacher, int subjectID, DateTime beginDate, DateTime finishDate)
        {
            DateTime begin = Convert.ToDateTime(dateTimePickerBegin.Value);
            DateTime finish = Convert.ToDateTime(dateTimePickerFinish.Value);
            string CourseID = Convert.ToString(courseID);
            string ClassID = Convert.ToString(classID);
            string SubjectID = Convert.ToString(subjectID);

            textBoxCourse.Text = CourseID;
            textBoxName.Text = courseName;
            textBoxClass.Text = ClassID;
            textBoxTeacher.Text = classTeacher;
            textBoxSubject.Text = SubjectID;
            beginDate = begin;
            finishDate = finish;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormCourse course = new MainFormCourse();
            this.Hide();
            course.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string begin = dateTimePickerBegin.Value.ToString("yyyy-MM-dd");
            string finish = dateTimePickerFinish.Value.ToString("yyyy-MM-dd");

            DialogResult dialog = MessageBox.Show("確定要修改課程編號為" + textBoxCourse.Text + "的訊息嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand sqlcmd;
                string sqlquery = String.Format("SELECT COUNT(*) FROM [dbo].[Course] WHERE CourseID = {0}", textBoxCourse.Text);
                try
                {
                    sqlcmd = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    int num = (int)sqlcmd.ExecuteScalar();
                    sqlquery = String.Format("UPDATE [dbo].[Course] SET CourseName= N'{0}', ClassID = '{1}', ClassTeacher = N'{2}', SubjectID = '{3}', BeginDate = '{4}', FinishDate = '{5}' WHERE CourseID = '{6}'", textBoxName.Text, textBoxClass.Text, textBoxTeacher.Text, textBoxSubject.Text, begin, finish, textBoxCourse.Text);
                    sqlconn.Close();
                    sqlconn.Open();
                    sqlcmd = new SqlCommand(sqlquery, sqlconn);
                    int count = sqlcmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("成功修改一名課程訊息", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("課程訊息修改失敗", "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "操作資料庫出錯！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
        }
    }
}