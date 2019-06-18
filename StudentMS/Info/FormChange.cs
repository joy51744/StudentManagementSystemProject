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
using System.Configuration;

namespace StudentMS.Info
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
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
            FormModify update = new FormModify();
            this.Hide();
            update.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string dob = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
            string sex = "";
            if (comboBox1.Text == "男")
                sex = "男";
            else
                sex = "女";

            DialogResult dialog = MessageBox.Show("確定要修改學號為" + textBoxStudentNo.Text + "的訊息嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand sqlcmd;
                string sqlquery = String.Format("SELECT COUNT(*) FROM [dbo].[Student] WHERE StudentNo = {0}", textBoxStudentNo.Text);
                try
                {
                    sqlcmd = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    int num = (int)sqlcmd.ExecuteScalar();
                    sqlquery = String.Format("UPDATE [dbo].[Student] SET StudentNo='{0}',StudentName = N'{1}',Gender = N'{2}',Birthday = '{3}',ClassID = '{4}',StudentDep = N'{5}' WHERE studentID = '{6}'", textBoxStudentNo.Text, textBoxName.Text, sex, dob, textBoxClass.Text, textBoxDep.Text, textBoxStudentID.Text);
                    sqlconn.Close();
                    sqlconn.Open();
                    sqlcmd = new SqlCommand(sqlquery, sqlconn);
                    int count = sqlcmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("成功修改一名學生訊息", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("學生訊息修改失敗", "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        internal void init(int studentID, string studentNo, string studentName, string gender, DateTime birthday, int classID, string studentDep)
        {
            DateTime dob = Convert.ToDateTime(dateTimePickerDOB.Value);
            // string birth = dateTimePickerDOB.Value.ToShortDateString();
            string ClassID = Convert.ToString(classID);
            string ID = Convert.ToString(studentID);
            textBoxStudentID.Text = ID;
            textBoxStudentNo.Text = studentNo;
            textBoxName.Text = studentName;
            if (comboBox1.Text == "男")
                gender = "男";
            else
                gender = "女";
            dob = birthday;
            textBoxClass.Text = ClassID;
            textBoxDep.Text = studentDep;
        }

        private void FormChange_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}