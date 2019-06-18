namespace StudentMS
{
    partial class FormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lstViewStudent = new System.Windows.Forms.ListView();
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tvwCourse = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MaintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudenttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoursetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoretoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvwClass = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.mnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "各班課程訊息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lstViewStudent);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvScore);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Size = new System.Drawing.Size(512, 561);
            this.splitContainer3.SplitterDistance = 268;
            this.splitContainer3.TabIndex = 0;
            // 
            // lstViewStudent
            // 
            this.lstViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentName,
            this.StudentNo,
            this.Gender,
            this.Birthday,
            this.ClassName,
            this.StudentDep});
            this.lstViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewStudent.FullRowSelect = true;
            this.lstViewStudent.GridLines = true;
            this.lstViewStudent.Location = new System.Drawing.Point(0, 42);
            this.lstViewStudent.MultiSelect = false;
            this.lstViewStudent.Name = "lstViewStudent";
            this.lstViewStudent.Size = new System.Drawing.Size(512, 226);
            this.lstViewStudent.TabIndex = 4;
            this.lstViewStudent.UseCompatibleStateImageBehavior = false;
            this.lstViewStudent.View = System.Windows.Forms.View.Details;
            this.lstViewStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstViewStudent_MouseDoubleClick);
            // 
            // StudentName
            // 
            this.StudentName.Text = "姓名";
            // 
            // StudentNo
            // 
            this.StudentNo.Text = "學號";
            // 
            // Gender
            // 
            this.Gender.Text = "性别";
            // 
            // Birthday
            // 
            this.Birthday.Text = "生日";
            // 
            // ClassName
            // 
            this.ClassName.Text = "班級";
            // 
            // StudentDep
            // 
            this.StudentDep.Text = "科系";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(0, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "各班學生訊息";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "学生信息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScore.Location = new System.Drawing.Point(0, 21);
            this.dgvScore.MultiSelect = false;
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            this.dgvScore.RowHeadersWidth = 4;
            this.dgvScore.RowTemplate.Height = 23;
            this.dgvScore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScore.Size = new System.Drawing.Size(512, 268);
            this.dgvScore.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentName";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ClassName";
            this.Column2.HeaderText = "班級";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CourseName";
            this.Column3.HeaderText = "科目";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Score";
            this.Column4.HeaderText = "成績";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "成績訊息";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvwCourse
            // 
            this.tvwCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwCourse.Location = new System.Drawing.Point(0, 21);
            this.tvwCourse.Name = "tvwCourse";
            this.tvwCourse.Size = new System.Drawing.Size(254, 269);
            this.tvwCourse.TabIndex = 2;
            this.tvwCourse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCourse_AfterSelect);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(770, 24);
            this.mnsMain.TabIndex = 4;
            this.mnsMain.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaintoolStripMenuItem,
            this.StudenttoolStripMenuItem,
            this.CoursetoolStripMenuItem,
            this.ScoretoolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExittoolStripMenuItem});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(43, 20);
            this.tsmFile.Text = "文件";
            // 
            // MaintoolStripMenuItem
            // 
            this.MaintoolStripMenuItem.Name = "MaintoolStripMenuItem";
            this.MaintoolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.MaintoolStripMenuItem.Text = "學生管理系統主畫面(&M)";
            this.MaintoolStripMenuItem.Click += new System.EventHandler(this.MaintoolStripMenuItem_Click);
            // 
            // StudenttoolStripMenuItem
            // 
            this.StudenttoolStripMenuItem.Name = "StudenttoolStripMenuItem";
            this.StudenttoolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.StudenttoolStripMenuItem.Text = "學生管理(&S)";
            this.StudenttoolStripMenuItem.Click += new System.EventHandler(this.StudenttoolStripMenuItem_Click);
            // 
            // CoursetoolStripMenuItem
            // 
            this.CoursetoolStripMenuItem.Name = "CoursetoolStripMenuItem";
            this.CoursetoolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.CoursetoolStripMenuItem.Text = "課程管理(&C)";
            this.CoursetoolStripMenuItem.Click += new System.EventHandler(this.CoursetoolStripMenuItem_Click);
            // 
            // ScoretoolStripMenuItem
            // 
            this.ScoretoolStripMenuItem.Name = "ScoretoolStripMenuItem";
            this.ScoretoolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ScoretoolStripMenuItem.Text = "成績管理(&S)";
            this.ScoretoolStripMenuItem.Click += new System.EventHandler(this.ScoretoolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // ExittoolStripMenuItem
            // 
            this.ExittoolStripMenuItem.Name = "ExittoolStripMenuItem";
            this.ExittoolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ExittoolStripMenuItem.Text = "退出(&E)";
            this.ExittoolStripMenuItem.Click += new System.EventHandler(this.ExittoolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(770, 561);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvwClass);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tvwCourse);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(254, 561);
            this.splitContainer2.SplitterDistance = 267;
            this.splitContainer2.TabIndex = 0;
            // 
            // tvwClass
            // 
            this.tvwClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwClass.Location = new System.Drawing.Point(0, 42);
            this.tvwClass.Name = "tvwClass";
            this.tvwClass.Size = new System.Drawing.Size(254, 225);
            this.tvwClass.TabIndex = 3;
            this.tvwClass.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwClass_AfterSelect);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(0, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "所有班级列表";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 561);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormView";
            this.Text = "資料查看";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormView_FormClosing);
            this.Load += new System.EventHandler(this.FormView_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvwCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem ScoretoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExittoolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem StudenttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CoursetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaintoolStripMenuItem;
        private System.Windows.Forms.ListView lstViewStudent;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader StudentNo;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader ClassName;
        private System.Windows.Forms.ColumnHeader StudentDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.TreeView tvwClass;
        private System.Windows.Forms.Label label5;
    }
}