namespace WinFormApp.spiderBrowser
{
    partial class uploadWeiboCookid
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
            this.urlText = new System.Windows.Forms.TextBox();
            this.jump = new System.Windows.Forms.Button();
            this.uploadcookie = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(12, 12);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(844, 21);
            this.urlText.TabIndex = 0;
            this.urlText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.urlText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlText_KeyDown);
            this.urlText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlText_KeyPress);
            // 
            // jump
            // 
            this.jump.Location = new System.Drawing.Point(876, 11);
            this.jump.Name = "jump";
            this.jump.Size = new System.Drawing.Size(61, 23);
            this.jump.TabIndex = 1;
            this.jump.Text = "--->";
            this.jump.UseVisualStyleBackColor = true;
            this.jump.Click += new System.EventHandler(this.jump_Click);
            // 
            // uploadcookie
            // 
            this.uploadcookie.Location = new System.Drawing.Point(966, 12);
            this.uploadcookie.Name = "uploadcookie";
            this.uploadcookie.Size = new System.Drawing.Size(98, 23);
            this.uploadcookie.TabIndex = 2;
            this.uploadcookie.Text = "更新cookie";
            this.uploadcookie.UseVisualStyleBackColor = true;
            this.uploadcookie.Click += new System.EventHandler(this.uploadcookie_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(1, 51);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1095, 696);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // uploadWeiboCookid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 748);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.uploadcookie);
            this.Controls.Add(this.jump);
            this.Controls.Add(this.urlText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uploadWeiboCookid";
            this.Text = "微博cookie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button jump;
        private System.Windows.Forms.Button uploadcookie;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}