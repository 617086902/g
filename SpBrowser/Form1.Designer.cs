namespace SpBrowser
{
    partial class Form1
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
            this.urlText = new System.Windows.Forms.TextBox();
            this.jump = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.cookieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(12, 12);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(499, 21);
            this.urlText.TabIndex = 0;
            // 
            // jump
            // 
            this.jump.Location = new System.Drawing.Point(517, 10);
            this.jump.Name = "jump";
            this.jump.Size = new System.Drawing.Size(75, 23);
            this.jump.TabIndex = 1;
            this.jump.Text = "Go";
            this.jump.UseVisualStyleBackColor = true;
            this.jump.Click += new System.EventHandler(this.jump_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 49);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(668, 719);
            this.webBrowser.TabIndex = 2;
            // 
            // cookieBtn
            // 
            this.cookieBtn.Location = new System.Drawing.Point(599, 9);
            this.cookieBtn.Name = "cookieBtn";
            this.cookieBtn.Size = new System.Drawing.Size(75, 23);
            this.cookieBtn.TabIndex = 3;
            this.cookieBtn.Text = "cookie";
            this.cookieBtn.UseVisualStyleBackColor = true;
            this.cookieBtn.Click += new System.EventHandler(this.cookieBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 795);
            this.Controls.Add(this.cookieBtn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.jump);
            this.Controls.Add(this.urlText);
            this.Name = "Form1";
            this.Text = "浏览窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button jump;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button cookieBtn;
    }
}

