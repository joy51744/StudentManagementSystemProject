namespace StudentMS
{
    partial class MainFormInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormInfo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStudentMS = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StudentMS.Properties.Resources._9252150_174018365301_2;
            this.panel1.Controls.Add(this.buttonStudentMS);
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 576);
            this.panel1.TabIndex = 0;
            // 
            // buttonStudentMS
            // 
            this.buttonStudentMS.Image = global::StudentMS.Properties.Resources.student_icon;
            this.buttonStudentMS.Location = new System.Drawing.Point(55, 464);
            this.buttonStudentMS.Name = "buttonStudentMS";
            this.buttonStudentMS.Size = new System.Drawing.Size(80, 80);
            this.buttonStudentMS.TabIndex = 10;
            this.buttonStudentMS.Text = "學  生  管  理";
            this.buttonStudentMS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStudentMS.UseVisualStyleBackColor = true;
            this.buttonStudentMS.Click += new System.EventHandler(this.buttonStudentMS_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::StudentMS.Properties.Resources._0487;
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.labelTime);
            this.panelMain.Location = new System.Drawing.Point(188, 118);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(739, 446);
            this.panelMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::StudentMS.Properties.Resources._0487;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 288);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(55, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "退出系統：退出學生系統";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(55, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(538, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "資料修改：依學號查詢到學生訊息進行修改和刪除";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(55, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(586, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "資料查詢：可依學號、姓名、班級、科系查詢學生訊息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(55, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "資料新增：新增學生訊息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "顯示全部：顯示全部學生訊息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗中隸書繁", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "功能介紹：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("源泉圓體 TTF Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTime.Location = new System.Drawing.Point(15, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 31);
            this.labelTime.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentMS.Properties.Resources._2015121415083872506;
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::StudentMS.Properties.Resources._257623_160G209243590;
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.panel5);
            this.panelHeader.Controls.Add(this.panel8);
            this.panelHeader.Controls.Add(this.panel3);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(915, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::StudentMS.Properties.Resources.power_exit_47_2px_1122609_easyicon_net;
            this.buttonExit.Location = new System.Drawing.Point(787, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 80);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "退  出  系  統";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonUpdate);
            this.panel5.Location = new System.Drawing.Point(675, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 80);
            this.panel5.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUpdate.Image = global::StudentMS.Properties.Resources.update_48px_1160368_easyicon_net;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 80);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "資  料  修  改";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonShow);
            this.panel8.Location = new System.Drawing.Point(339, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(80, 80);
            this.panel8.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShow.Image = global::StudentMS.Properties.Resources.dashboard_show_48px_571607_easyicon_net;
            this.buttonShow.Location = new System.Drawing.Point(0, 0);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(80, 80);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "顯  示  全  部";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Location = new System.Drawing.Point(563, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearch.Image = global::StudentMS.Properties.Resources.search_37_8624px_1217956_easyicon_net;
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 80);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "資  料  查  詢";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Location = new System.Drawing.Point(451, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 80);
            this.panel2.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAdd.Image = global::StudentMS.Properties.Resources.add_user_50_007892659826px_1200609_easyicon_net;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 80);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "資  料  新  增";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // MainFormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 576);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormInfo";
            this.Text = "學生資訊主畫面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormInfo_FormClosing);
            this.Load += new System.EventHandler(this.MainFormInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStudentMS;
    }
}