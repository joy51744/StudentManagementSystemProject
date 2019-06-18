namespace Project
{
    partial class PictureMS
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureMS));
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDeletePP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttDown = new System.Windows.Forms.Button();
            this.bttStart = new System.Windows.Forms.Button();
            this.bttEnd = new System.Windows.Forms.Button();
            this.bttUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttShowPP = new System.Windows.Forms.Button();
            this.bttInsertPP = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.White;
            this.bttUpdate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttUpdate.Location = new System.Drawing.Point(256, 11);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(78, 27);
            this.bttUpdate.TabIndex = 37;
            this.bttUpdate.Text = "修改圖片";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDeletePP
            // 
            this.bttDeletePP.BackColor = System.Drawing.Color.White;
            this.bttDeletePP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttDeletePP.Location = new System.Drawing.Point(131, 11);
            this.bttDeletePP.Name = "bttDeletePP";
            this.bttDeletePP.Size = new System.Drawing.Size(78, 27);
            this.bttDeletePP.TabIndex = 36;
            this.bttDeletePP.Text = "刪除圖片";
            this.bttDeletePP.UseVisualStyleBackColor = false;
            this.bttDeletePP.Click += new System.EventHandler(this.bttDeletePP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // bttDown
            // 
            this.bttDown.BackColor = System.Drawing.Color.White;
            this.bttDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttDown.Location = new System.Drawing.Point(312, 253);
            this.bttDown.Name = "bttDown";
            this.bttDown.Size = new System.Drawing.Size(65, 23);
            this.bttDown.TabIndex = 34;
            this.bttDown.Text = "下一張";
            this.bttDown.UseVisualStyleBackColor = false;
            this.bttDown.Click += new System.EventHandler(this.bttDown_Click);
            // 
            // bttStart
            // 
            this.bttStart.BackColor = System.Drawing.Color.White;
            this.bttStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttStart.Location = new System.Drawing.Point(168, 253);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(65, 23);
            this.bttStart.TabIndex = 33;
            this.bttStart.Text = "首頁";
            this.bttStart.UseVisualStyleBackColor = false;
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            // 
            // bttEnd
            // 
            this.bttEnd.BackColor = System.Drawing.Color.White;
            this.bttEnd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttEnd.Location = new System.Drawing.Point(384, 253);
            this.bttEnd.Name = "bttEnd";
            this.bttEnd.Size = new System.Drawing.Size(65, 23);
            this.bttEnd.TabIndex = 32;
            this.bttEnd.Text = "末頁";
            this.bttEnd.UseVisualStyleBackColor = false;
            this.bttEnd.Click += new System.EventHandler(this.bttEnd_Click);
            // 
            // bttUp
            // 
            this.bttUp.BackColor = System.Drawing.Color.White;
            this.bttUp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttUp.Location = new System.Drawing.Point(240, 253);
            this.bttUp.Name = "bttUp";
            this.bttUp.Size = new System.Drawing.Size(65, 23);
            this.bttUp.TabIndex = 31;
            this.bttUp.Text = "上一張";
            this.bttUp.UseVisualStyleBackColor = false;
            this.bttUp.Click += new System.EventHandler(this.bttUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttShowPP
            // 
            this.bttShowPP.BackColor = System.Drawing.Color.White;
            this.bttShowPP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttShowPP.Location = new System.Drawing.Point(381, 11);
            this.bttShowPP.Name = "bttShowPP";
            this.bttShowPP.Size = new System.Drawing.Size(78, 27);
            this.bttShowPP.TabIndex = 29;
            this.bttShowPP.Text = "顯示圖片";
            this.bttShowPP.UseVisualStyleBackColor = false;
            this.bttShowPP.Click += new System.EventHandler(this.bttShowPP_Click);
            // 
            // bttInsertPP
            // 
            this.bttInsertPP.BackColor = System.Drawing.Color.White;
            this.bttInsertPP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bttInsertPP.Location = new System.Drawing.Point(6, 11);
            this.bttInsertPP.Name = "bttInsertPP";
            this.bttInsertPP.Size = new System.Drawing.Size(78, 27);
            this.bttInsertPP.TabIndex = 28;
            this.bttInsertPP.Text = "上傳圖片";
            this.bttInsertPP.UseVisualStyleBackColor = false;
            this.bttInsertPP.Click += new System.EventHandler(this.bttInsertPP_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(384, 282);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 23);
            this.buttonExit.TabIndex = 38;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // PictureMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(465, 316);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttDeletePP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttDown);
            this.Controls.Add(this.bttStart);
            this.Controls.Add(this.bttEnd);
            this.Controls.Add(this.bttUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttShowPP);
            this.Controls.Add(this.bttInsertPP);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureMS";
            this.Text = "圖片管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureMS_FormClosing);
            this.Load += new System.EventHandler(this.PictureMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDeletePP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttDown;
        private System.Windows.Forms.Button bttStart;
        private System.Windows.Forms.Button bttEnd;
        private System.Windows.Forms.Button bttUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttShowPP;
        private System.Windows.Forms.Button bttInsertPP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonExit;
    }
}

