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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormScore main = new MainFormScore();
            this.Hide();
            main.Show();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            this.Hide();
            add.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            this.Hide();
            update.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
            if (textBoxSearch.Text == "")
            {
                string sqlquery = "SELECT * FROM [dbo].[Score]";
                try
                {
                    sqlconn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Score");
                    dataGridViewSearch.DataSource = ds.Tables["Score"];
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
                        sqlquery = String.Format("select * from [dbo].[Score] where CourseID = '{0}' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(ds, "Score");
                            dataGridViewSearch.DataSource = ds.Tables["Score"];
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

                    case "學生編號":
                        sqlquery = String.Format("select * from [dbo].[Score] where StudentID = '{0}' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(ds, "Score");
                            dataGridViewSearch.DataSource = ds.Tables["Score"];
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
                        sqlquery = String.Format("select * from [dbo].[Score] where ClassID = '{0}' ", textBoxSearch.Text);
                        try
                        {
                            sqlconn.Open();
                            DataSet ds = new DataSet();
                            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
                            sda.Fill(ds, "Score");
                            dataGridViewSearch.DataSource = ds.Tables["Score"];
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
                }
            }
        }
    }
}