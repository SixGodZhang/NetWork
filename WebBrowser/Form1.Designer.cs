namespace WebBrowser
{
    partial class 自定义浏览器
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.moveBtn = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.preBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(0, 67);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1080, 800);
            this.wb.TabIndex = 1;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(590, 23);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(75, 23);
            this.moveBtn.TabIndex = 3;
            this.moveBtn.Text = "跳转";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtnClick);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(145, 25);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(428, 21);
            this.urlText.TabIndex = 4;
            this.urlText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // preBtn
            // 
            this.preBtn.Location = new System.Drawing.Point(13, 25);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(54, 21);
            this.preBtn.TabIndex = 5;
            this.preBtn.Text = "上一页";
            this.preBtn.UseVisualStyleBackColor = true;
            this.preBtn.Click += new System.EventHandler(this.OnPreBtnClick);
            // 
            // nextBtn
            // 
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(74, 25);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(54, 21);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "下一页";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // 自定义浏览器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 800);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "自定义浏览器";
            this.Text = "自定义浏览器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button preBtn;//上一页
        private System.Windows.Forms.Button nextBtn;//下一页
    }
}

