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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "admin" && textBoxUserPassword.Text == "admin")
            {
                string message = "Welcome,管理員";
                MainForm main = new MainForm(message);
                this.Hide();
                main.Show();
            }
            else if (textBoxUserName.Text == "User" && textBoxUserPassword.Text == "User")
            {
                string message = "Welcome,使用者";
                UserMainForm user = new UserMainForm(message);
                this.Hide();
                user.Show();
            }
            else
            {
                MessageBox.Show("登入失敗，請重新輸入！");
                textBoxUserName.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUserPassword.Clear();
            textBoxUserName.Clear();
        }
    }
}