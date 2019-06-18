using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            string message = "Welcome,管理員";
            ManagementSysemWinForm.MainForm main = new ManagementSysemWinForm.MainForm(message);
            this.Hide();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}