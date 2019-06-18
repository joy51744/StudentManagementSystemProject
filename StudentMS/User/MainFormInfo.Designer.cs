namespace StudentMS.User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StudentMS.Properties.Resources._9252150_174018365301_2;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 576);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(70, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 80);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            //this.button1.Image = global::StudentMS.Properties.Resources.home_49_798270893372px_1191631_easyicon_net;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "回  主  畫  面";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentMS.Properties.Resources._2015121415083872506;
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StudentMS.Properties.Resources._0487;
            this.panel3.Controls.Add(this.dataGridViewShow);
            this.panel3.Location = new System.Drawing.Point(218, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 446);
            this.panel3.TabIndex = 1;
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(35, 25);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowTemplate.Height = 24;
            this.dataGridViewShow.Size = new System.Drawing.Size(675, 391);
            this.dataGridViewShow.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StudentMS.Properties.Resources._257623_160G209243590;
            this.panel2.Controls.Add(this.panelExit);
            this.panel2.Controls.Add(this.panelShow);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.buttonBack);
            this.panelExit.Location = new System.Drawing.Point(735, 10);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(80, 80);
            this.panelExit.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::StudentMS.Properties.Resources.home_48px_29945_easyicon_net;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 80);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "回  主  畫  面";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.buttonShow);
            this.panelShow.Location = new System.Drawing.Point(615, 10);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(80, 80);
            this.panelShow.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Image = global::StudentMS.Properties.Resources.dashboard_show_48px_571607_easyicon_net;
            this.buttonShow.Location = new System.Drawing.Point(0, 0);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(80, 80);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "顯  示  全  部";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // MainFormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 576);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormInfo";
            this.Text = "學生資訊";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button buttonShow;
    }
}