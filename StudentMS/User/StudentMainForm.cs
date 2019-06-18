using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMS.User
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStuInfo_Click(object sender, EventArgs e)
        {
            User.MainFormInfo info = new User.MainFormInfo();
            this.Hide();
            info.Show();
        }

        private void buttonStuScore_Click(object sender, EventArgs e)
        {
            User.MainFormScore score = new User.MainFormScore();
            this.Hide();
            score.Show();
        }

        private void buttonStuAttendance_Click(object sender, EventArgs e)
        {
            User.MainFormCourse course = new User.MainFormCourse();
            this.Hide();
            course.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormStatistic statistic = new MainFormStatistic();
            this.Hide();
            statistic.Show();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            FormView view = new FormView();
            this.Hide();
            view.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "現在時間是：" + DateTime.Now.ToString();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}