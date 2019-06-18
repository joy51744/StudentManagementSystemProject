namespace Project
{
    partial class Picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Picture));
            this.label1 = new System.Windows.Forms.Label();
            this.bttDown = new System.Windows.Forms.Button();
            this.bttStart = new System.Windows.Forms.Button();
            this.bttEnd = new System.Windows.Forms.Button();
            this.bttUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // bttDown
            // 
            this.bttDown.BackColor = System.Drawing.Color.White;
            this.bttDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttDown.Location = new System.Drawing.Point(256, 273);
            this.bttDown.Name = "bttDown";
            this.bttDown.Size = new System.Drawing.Size(65, 23);
            this.bttDown.TabIndex = 43;
            this.bttDown.Text = "下一張";
            this.bttDown.UseVisualStyleBackColor = false;
            this.bttDown.Click += new System.EventHandler(this.bttDown_Click);
            // 
            // bttStart
            // 
            this.bttStart.BackColor = System.Drawing.Color.White;
            this.bttStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttStart.Location = new System.Drawing.Point(112, 273);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(65, 23);
            this.bttStart.TabIndex = 42;
            this.bttStart.Text = "首頁";
            this.bttStart.UseVisualStyleBackColor = false;
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            // 
            // bttEnd
            // 
            this.bttEnd.BackColor = System.Drawing.Color.White;
            this.bttEnd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttEnd.Location = new System.Drawing.Point(328, 273);
            this.bttEnd.Name = "bttEnd";
            this.bttEnd.Size = new System.Drawing.Size(65, 23);
            this.bttEnd.TabIndex = 41;
            this.bttEnd.Text = "末頁";
            this.bttEnd.UseVisualStyleBackColor = false;
            this.bttEnd.Click += new System.EventHandler(this.bttEnd_Click);
            // 
            // bttUp
            // 
            this.bttUp.BackColor = System.Drawing.Color.White;
            this.bttUp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttUp.Location = new System.Drawing.Point(184, 273);
            this.bttUp.Name = "bttUp";
            this.bttUp.Size = new System.Drawing.Size(65, 23);
            this.bttUp.TabIndex = 40;
            this.bttUp.Text = "上一張";
            this.bttUp.UseVisualStyleBackColor = false;
            this.bttUp.Click += new System.EventHandler(this.bttUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(400, 273);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 23);
            this.buttonExit.TabIndex = 45;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(474, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttDown);
            this.Controls.Add(this.bttStart);
            this.Controls.Add(this.bttEnd);
            this.Controls.Add(this.bttUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Picture";
            this.Text = "圖片管理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttDown;
        private System.Windows.Forms.Button bttStart;
        private System.Windows.Forms.Button bttEnd;
        private System.Windows.Forms.Button bttUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
    }
}