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

namespace StudentMS
{
    public partial class MainFormStatistic : Form
    {
        public MainFormStatistic()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            string sqlquery;

            switch (comboBoxScore.SelectedItem.ToString())
            {
                case "姓名統計成績":
                    sqlquery = "SELECT t1.Semester 學期, t3.StudentID 學生編號,t3.StudentName 學生姓名, max(t2.Score) 最高分, min(t2.Score) 最低分, sum(t2.Score)分數加總, CONVERT(decimal(5,1),avg(t2.Score)) 分數平均 FROM Batch t1 join Student t3 on t1.BatchID = t3.BatchID join Score t2 on t3.StudentID = t2.StudentID join Course t4 on t2.CourseID = t4.CourseID GROUP BY t1.BatchID, t1.Semester, t3.StudentName, t3.StudentID ORDER BY t3.StudentID";
                    try
                    {
                        sqlconn.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                        sda.Fill(ds, "Score");
                        dataGridViewSatistics.DataSource = ds.Tables["Score"];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    break;

                case "各科統計成績":
                    sqlquery = "select t1.Semester 學期, t3.ClassID 班級, t4.CourseID 課程編號, t4.CourseName 課程姓名, max(t2.Score) 最高分, min(t2.Score) 最低分, sum(t2.Score) 分數加總 , count(*) 人數總和, CONVERT(decimal(5,1),avg(Score)) 平均分數 FROM Batch t1 join Student t3 on t1.BatchID = t3.BatchID join Score t2 on t3.StudentID = t2.StudentID join Course t4 on t2.CourseID = t4.CourseID GROUP BY t1.Semester, t3.ClassID, t4.CourseName, t4.CourseID ORDER BY t3.ClassID";
                    try
                    {
                        sqlconn.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                        sda.Fill(ds, "Score");
                        dataGridViewSatistics.DataSource = ds.Tables["Score"];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    break;

                case "姓名成績排名":
                    sqlquery = "SELECT a4.Semester 學期, a1.CourseID 課程編號, a1.StudentID 學生編號, a3.StudentName 學生姓名, a2.CourseName 課程名稱, a1.Score 成績, RANK() OVER (PARTITION BY  a1.StudentID ORDER BY a1.Score desc) AS 排名 FROM  Score a1 join Course a2 on a1.CourseID = a2.CourseID join Student a3 on a1.StudentID = a3.StudentID join Batch a4 on a3.BatchID = a4.BatchID";
                    try
                    {
                        sqlconn.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                        sda.Fill(ds, "Score");
                        dataGridViewSatistics.DataSource = ds.Tables["Score"];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    break;

                case "各科成績排名":
                    sqlquery = "SELECT a4.Semester 學期, a1.CourseID 課程編號, a1.StudentID 學生編號, a3.StudentName 學生姓名, a2.CourseName 課程名稱, a1.Score 成績, RANK() OVER (PARTITION BY  a1.CourseID ORDER BY a1.Score desc) AS 排名 FROM  Score a1 join Course a2 on a1.CourseID = a2.CourseID join Student a3 on a1.StudentID = a3.StudentID join Batch a4 on a3.BatchID = a4.BatchID";
                    try
                    {
                        sqlconn.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                        sda.Fill(ds, "Score");
                        dataGridViewSatistics.DataSource = ds.Tables["Score"];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    break;

                case "科系總人數":
                    sqlquery = "SELECT StudentDep, COUNT(StudentDep) 科系總人數 FROM [dbo].[Student] GROUP BY StudentDep";
                    try
                    {
                        sqlconn.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                        sda.Fill(ds, "Student");
                        dataGridViewSatistics.DataSource = ds.Tables["Student"];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    break;

                case "班級總人數":
                    sqlquery = "SELECT ClassID, COUNT(ClassID) 班級總人數 FROM [dbo].[Student] GROUP BY ClassID";
                    try
                    {
                        sqlconn.Open();
                        DataSet ds = new DataSet();
                        SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                        sda.Fill(ds, "Student");
                        dataGridViewSatistics.DataSource = ds.Tables["Student"];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("沒有查到相關訊息，請檢查查詢條件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message, "操作資料庫出错！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconn.Close();
                    }
                    break;
            }
        }

        private void buttonStudentMS_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }
    }
}