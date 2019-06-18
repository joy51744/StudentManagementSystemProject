using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSysemWinForm
{
    public partial class UserMainForm : Form
    {
        public UserMainForm(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StudentMS.User.StudentMainForm main = new StudentMS.User.StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Project.Picture main = new Project.Picture();
            this.Hide();
            main.Show();
        }
    }
}