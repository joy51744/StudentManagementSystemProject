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
            MainFormScore main = new MainFormScore();
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
            FormUpdate update = new FormUpdate();
            this.Hide();
            update.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("確定要修改學生編號為" + textBoxStudent.Text + "的訊息嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand sqlcmd;
                string sqlquery = String.Format("SELECT COUNT(*) FROM [dbo].[Score] WHERE StudentID = {0}", textBoxStudent.Text);
                try
                {
                    sqlcmd = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    int num = (int)sqlcmd.ExecuteScalar();
                    sqlquery = String.Format("UPDATE [dbo].[Score] SET CourseID = '{0}', StudentID = '{1}',ClassID = '{2}',Score = '{3}' WHERE ScoreID = '{4}'", textBoxCourse.Text, textBoxStudent.Text, comboBoxClass.Text, textBoxScore.Text, textBoxScoreID.Text);
                    sqlconn.Close();
                    sqlconn.Open();
                    sqlcmd = new SqlCommand(sqlquery, sqlconn);
                    int count = sqlcmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("成功修改一名學生成績", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("學生成績修改失敗", "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormChange_Load(object sender, EventArgs e)
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