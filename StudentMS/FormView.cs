using StudentMS.Design_Model;
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
    public partial class FormView : Form
    {
        private DataTable dtClass = null;
        private DataTable dtStudent = null;
        private DataTable dtCourse = null;
        private BLLClass bllclass = null;
        private BLLStudent bllstudent = null;
        private BLLCourse bllcourse = null;
        private ModelStudent modelstudent = null;
        private ListViewItem listview = null;

        public FormView()
        {
            InitializeComponent();
        }

        private void ExittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudenttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFormInfo info = new MainFormInfo();
            this.Hide();
            info.Show();
        }

        private void CoursetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFormCourse course = new MainFormCourse();
            this.Hide();
            course.Show();
        }

        private void ScoretoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFormScore score = new MainFormScore();
            this.Hide();
            score.Show();
        }

        private void MaintoolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentMainForm main = new StudentMainForm();
            this.Hide();
            main.Show();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            ShowClassName();
        }

        private void ShowClassName()
        {
            tvwClass.Nodes.Clear();
            bllclass = new BLLClass();
            dtClass = bllclass.GetClassName();
            for (int i = 0; i < dtClass.Rows.Count; i++)
            {
                TreeNode reenode = new TreeNode(dtClass.Rows[i]["ClassName"].ToString());
                tvwClass.Nodes.Add(reenode);
            }
        }

        private void tvwClass_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            string className = this.tvwClass.SelectedNode.Text;//获取选中节点的名称（班级名称）
            DataView dataview = new DataView(dtClass);//通过班级表new一个DataView
            dataview.RowFilter = "className = '" + className + "'";//根据班级名称筛选数据
            DataTable dt = dataview.ToTable(); //获取筛选后的班级表
            int classID = int.Parse(dt.Rows[0][0].ToString());

            lstViewStudent.Items.Clear();
            bllstudent = new BLLStudent();
            dtStudent = bllstudent.GetStudentInfoClassID(classID);//查询所在班级的学生信息
            if (dtStudent == null)
            {
                MessageBox.Show("該班級才剛剛建立，還沒有學生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < dtStudent.Rows.Count; i++)
                {
                    listview = new ListViewItem();
                    listview.Text = dtStudent.Rows[i][2].ToString();
                    listview.SubItems.Add(dtStudent.Rows[i][1].ToString());
                    listview.SubItems.Add(dtStudent.Rows[i][3].ToString());
                    listview.SubItems.Add(dtStudent.Rows[i][4].ToString());
                    listview.SubItems.Add(className);
                    listview.SubItems.Add(dtStudent.Rows[i][5].ToString());
                    lstViewStudent.Items.Add(listview);
                }
            }

            tvwCourse.Nodes.Clear();
            dtCourse = new DataTable();
            bllcourse = new BLLCourse();
            dtCourse = bllcourse.GetCourseInfoClassID(classID);//點擊班级列表時顯示課程訊息
            if (dtStudent == null)
            {
                MessageBox.Show("該班級才剛剛建立，還沒有學生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < dtCourse.Rows.Count; i++)
                {
                    TreeNode tn = new TreeNode(className + "-" + dtCourse.Rows[i]["CourseName"].ToString());
                    tvwCourse.Nodes.Add(tn);
                }
                tvwCourse.SelectedNode = tvwCourse.Nodes[0];
            }
        }

        private void tvwCourse_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string classCourse = e.Node.Text;
            string[] str = classCourse.Split('-');
            string className = str[0];
            string courseName = str[1];

            BLLCourse bco = new BLLCourse();
            DataTable dtScore = bco.GetCourseAll();
            DataView dvScore = new DataView(dtScore);
            dvScore.RowFilter = "className='" + className + "' and courseName = '" + courseName + "'";
            dgvScore.DataSource = dvScore;
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("真的要退出嗎？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
        }

        private void lstViewStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string stuName = lstViewStudent.SelectedItems[0].Text;
            string stuNo = lstViewStudent.SelectedItems[0].SubItems[1].Text;
            string stuSex = lstViewStudent.SelectedItems[0].SubItems[2].Text;
            DateTime birthday = Convert.ToDateTime(lstViewStudent.SelectedItems[0].SubItems[3].Text);
            string stuClsName = lstViewStudent.SelectedItems[0].SubItems[4].Text;
            int ClassID = bllclass.GetClassIDClassName(stuClsName);
            string stuDep = lstViewStudent.SelectedItems[0].SubItems[5].Text;
            modelstudent = new ModelStudent();
            modelstudent.StudentName = stuName;
            modelstudent.StudentNo = stuNo;
            modelstudent.Gender = stuSex;
            modelstudent.Birthday = birthday;
            modelstudent.ClassID = ClassID;
            modelstudent.StudentDep = stuDep;
        }
    }
}