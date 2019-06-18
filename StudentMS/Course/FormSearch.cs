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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            if (textBoxSearch.Text == "")
            {
                string sqlquery = "SELECT * FROM [dbo].[Course]";
                try
                {
                    sqlconn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Course");
                    dataGridViewSearch.DataSource = ds.Tables["Course"];
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSearch.Focus();
                }
            }
            else
            {
                string sqlquery;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "課程編號":
                        sqlquery = String.Format("select * from [dbo].[Course] where CourseID = '{0}' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(ds, "Course");
                            dataGridViewSearch.DataSource = ds.Tables["Course"];
                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSearch.Focus();
                        }
                        finally
                        {
                            sqlconn.Close();
                        }
                        break;

                    case "課程名稱":
                        sqlquery = String.Format("select * from [dbo].[Course] where CourseName  LIKE  N'%{0}%' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(ds, "Course");
                            dataGridViewSearch.DataSource = ds.Tables["Course"];
                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSearch.Focus();
                        }
                        finally
                        {
                            sqlconn.Close();
                        }
                        break;

                    case "班級編號":
                        sqlquery = String.Format("select * from [dbo].[Course] where ClassID = '{0}' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(ds, "Course");
                            dataGridViewSearch.DataSource = ds.Tables["Course"];
                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSearch.Focus();
                        }
                        finally
                        {
                            sqlconn.Close();
                        }
                        break;

                    case "教師姓名":
                        sqlquery = String.Format("select * from [dbo].[Course] where ClassTeacher  LIKE  N'%{0}%' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet data = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(data, "Course");
                            dataGridViewSearch.DataSource = data.Tables["Course"];
                            if (data.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSearch.Focus();
                        }
                        finally
                        {
                            sqlconn.Close();
                        }
                        break;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormCourse main = new MainFormCourse();
            this.Hide();
            main.Show();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }
    }
}