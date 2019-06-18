using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS
{
    public partial class MainFormScore : Form
    {
        public MainFormScore()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Score.FormShow add = new Score.FormShow();
            this.Hide();
            add.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Score.FormAdd add = new Score.FormAdd();
            this.Hide();
            add.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Score.FormSearch search = new Score.FormSearch();
            this.Hide();
            search.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Score.FormUpdate update = new Score.FormUpdate();
            this.Hide();
            update.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("真的要退出嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
        }

        private void buttonStudentMS_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }
    }
}