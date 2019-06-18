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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void buttonMain_Click(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            this.Hide();
            add.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormScore main = new MainFormScore();
            this.Hide();
            main.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
                sqlconn.Open();
                SqlDataAdapter dataSelect = new SqlDataAdapter("SELECT * FROM [dbo].[Score]", sqlconn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            if (textBoxUpdate.Text == "")
            {
                string sqlquery = string.Format("SELECT * FROM [dbo].[Score]");
                try
                {
                    sqlconn.Open();   //打开数据库连接
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, sqlconn);
                    DataSet DS = new DataSet();
                    adapter.Fill(DS, "Score");
                    dataGridView1.DataSource = DS.Tables["Score"];
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

                sqlquery = String.Format("SELECT * FROM [dbo].[Score] WHERE ScoreID = '{0}' ", textBoxUpdate.Text);
                try
                {
                    sqlconn.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, sqlconn);
                    adapter.Fill(ds, "Score");
                    dataGridView1.DataSource = ds.Tables["Score"];
                    if (ds.Tables[0].Rows.Count == 0)  //如果未查詢到任何訊息，給出提示，並顯示全部訊息
                    {
                        MessageBox.Show("沒有查詢到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        sqlconn.Close();
                        sqlquery = String.Format("SELECT * FROM [dbo].[Score]");
                        sqlconn.Open();
                        adapter = new SqlDataAdapter(sqlquery, sqlconn);
                        ds = new DataSet();
                        adapter.Fill(ds, "Score");
                        dataGridView1.DataSource = ds.Tables["Score"];
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
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUpdate.Text == "")
            {
                MessageBox.Show("成績編號不能為空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dia = MessageBox.Show("確實要刪除成績編號為 " + textBoxUpdate.Text + " 的訊息嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  //输出信息的提示
                string sql = String.Format("SELECT COUNT(*) FROM [dbo].[Score] WHERE ScoreID = '{0}'", textBoxUpdate.Text);
                if (dia == DialogResult.Yes)  //如果确定删除
                {
                    string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf; Integrated Security = True; Connect Timeout = 30";
                    SqlConnection connecion = new SqlConnection(connString);
                    try
                    {
                        connecion.Open();  //打开数据库连接
                        SqlCommand command = new SqlCommand(sql, connecion);  //创建command对象
                        sql = String.Format("DELETE FROM [dbo].[Score] WHERE ScoreID = {0}", textBoxUpdate.Text);   //执行删除功能的SQL语句
                        connecion.Close();
                        connecion.Open();
                        command = new SqlCommand(sql, connecion);
                        int count = command.ExecuteNonQuery();  //执行删除命令，返回所删除的所在行数
                        if (count > 0)
                        {
                            scoreTableAdapter.Fill(this.studentScoreManageDataSet.Score);
                            MessageBox.Show("您成功删除一位學生成績！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("成績資訊刪除失敗！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)  //操作数据库出错情况
                    {
                        MessageBox.Show(ex.Message, "操作資料庫出錯！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connecion.Close();  //关闭数据库连接
                    }
                }
            }
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'studentScoreManageDataSet.Score' 資料表。您可以視需要進行移動或移除。
            this.scoreTableAdapter.Fill(this.studentScoreManageDataSet.Score);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormChange change = new FormChange();
            change.textBoxScoreID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            change.textBoxCourse.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            change.textBoxStudent.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            change.comboBoxClass.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            change.textBoxScore.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            change.ShowDialog();
        }
    }
}