namespace StudentMS
{
    partial class MainFormStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormStatistic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStudentMS = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbDivideOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxScore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSatistics = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbDivideOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StudentMS.Properties.Resources._9252150_174018365301_2;
            this.panel1.Controls.Add(this.buttonStudentMS);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
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
            this.buttonStudentMS.TabIndex = 12;
            this.buttonStudentMS.Text = "學  生  管  理";
            this.buttonStudentMS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStudentMS.UseVisualStyleBackColor = true;
            this.buttonStudentMS.Click += new System.EventHandler(this.buttonStudentMS_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StudentMS.Properties.Resources._0487;
            this.panel3.Controls.Add(this.gbDivideOptions);
            this.panel3.Controls.Add(this.dataGridViewSatistics);
            this.panel3.Location = new System.Drawing.Point(188, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 446);
            this.panel3.TabIndex = 2;
            // 
            // gbDivideOptions
            // 
            this.gbDivideOptions.Controls.Add(this.comboBoxScore);
            this.gbDivideOptions.Controls.Add(this.label1);
            this.gbDivideOptions.Location = new System.Drawing.Point(24, 22);
            this.gbDivideOptions.Name = "gbDivideOptions";
            this.gbDivideOptions.Size = new System.Drawing.Size(692, 80);
            this.gbDivideOptions.TabIndex = 1;
            this.gbDivideOptions.TabStop = false;
            // 
            // comboBoxScore
            // 
            this.comboBoxScore.FormattingEnabled = true;
            this.comboBoxScore.Items.AddRange(new object[] {
            "各科統計成績",
            "姓名統計成績",
            "各科成績排名",
            "姓名成績排名",
            "班級總人數",
            "科系總人數"});
            this.comboBoxScore.Location = new System.Drawing.Point(375, 35);
            this.comboBoxScore.Name = "comboBoxScore";
            this.comboBoxScore.Size = new System.Drawing.Size(158, 20);
            this.comboBoxScore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗中隸書繁", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(212, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "分組依據：";
            // 
            // dataGridViewSatistics
            // 
            this.dataGridViewSatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatistics.Location = new System.Drawing.Point(24, 127);
            this.dataGridViewSatistics.Name = "dataGridViewSatistics";
            this.dataGridViewSatistics.RowTemplate.Height = 24;
            this.dataGridViewSatistics.Size = new System.Drawing.Size(692, 293);
            this.dataGridViewSatistics.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::StudentMS.Properties.Resources._257623_160G209243590;
            this.panel2.Controls.Add(this.buttonEnter);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 100);
            this.panel2.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Image = global::StudentMS.Properties.Resources.Accept_icon;
            this.buttonEnter.Location = new System.Drawing.Point(675, 10);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(80, 80);
            this.buttonEnter.TabIndex = 15;
            this.buttonEnter.Text = "確      定";
            this.buttonEnter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::StudentMS.Properties.Resources.power_exit_47_2px_1122609_easyicon_net;
            this.buttonExit.Location = new System.Drawing.Point(787, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 80);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "退  出  系  統";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainFormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 576);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormStatistic";
            this.Text = "學生管理  -- 資料統計";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbDivideOptions.ResumeLayout(false);
            this.gbDivideOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewSatistics;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.GroupBox gbDivideOptions;
        private System.Windows.Forms.ComboBox comboBoxScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStudentMS;
    }
}