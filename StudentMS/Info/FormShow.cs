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
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormInfo main = new MainFormInfo();
            this.Hide();
            main.Show();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection();
                sqlconn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\ManagementSystemSolution\StudentMS\DatabaseStudent.mdf;Integrated Security=True;Connect Timeout=30";
                sqlconn.Open();
                SqlDataAdapter dataSelect = new SqlDataAdapter("SELECT * FROM [dbo].[Student]", sqlconn);
                DataTable dt = new DataTable();
                dataSelect.Fill(dt);
                dataGridViewShow.DataSource = dt.DefaultView;
                this.dataGridViewShow.RowHeadersVisible = true;
                sqlconn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("警告！", error.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Info.FormAdd add = new FormAdd();
            this.Hide();
            add.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Info.FormSearch search = new FormSearch();
            this.Hide();
            search.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Info.FormModify update = new FormModify();
            this.Hide();
            update.Show();
        }

        private void FormShow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}