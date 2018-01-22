using CommonService.Weibo;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TF.BitterMelon.AnalogLogin.SinaWeibo;

namespace WinFormApp.spiderBrowser
{
    public partial class uploadWeiboCookid : Form
    {
        public uploadWeiboCookid()
        {
            InitializeComponent();
            urlText.Text = "https://www.weibo.com/";
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jump_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlText.Text);
            while (webBrowser.ReadyState != WebBrowserReadyState.Complete) Application.DoEvents();
            urlText.Text = webBrowser.Document.Url.ToString();
        }

        private void uploadcookie_Click(object sender, EventArgs e)
        {
            string cookieStr = GetCookies(webBrowser.Url.ToString());
            if (string.IsNullOrEmpty(cookieStr)) return;
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\d\\weiboCookie.txt";
            WeiboLogin l = new WeiboLogin("", "", "");
            l.GetCurrentCookie(HttpUtility.HtmlDecode(HttpUtility.UrlDecode(cookieStr)));
            TxtFile.WriteAllText(path, l.LoginCookie);
            FTPHelper ftp = new FTPHelper("qxw1151970042.my3w.com", "d", "qxw1151970042", "2131402780");
            ftp.Upload("d\\weiboCookie.txt");
            MessageBox.Show("更新cookie成功");
        }


        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref System.UInt32 pcchCookieData, int dwFlags, IntPtr lpReserved);
        private static string GetCookies(string url)
        {
            uint datasize = 1024;
            StringBuilder cookieData = new StringBuilder((int)datasize);
            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x2000, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;

                cookieData = new StringBuilder((int)datasize);
                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, IntPtr.Zero))
                    return null;
            }
            return cookieData.ToString();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            urlText.Text = e.Url.ToString();
        }

        private void urlText_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void urlText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) jump_Click(null, null);
        }
    }
}
