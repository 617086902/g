using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using TF.BitterMelon.Entities;
using TF.BitterMelon.Tool;

namespace TF.BitterMelon.AnalogLogin.SinaWeibo
{
    public class WeiboSearch
    {
        /// <summary>
        /// 获取微博搜索内容
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public static List<WeiboDetails> GetWeiboContent(string keyword, int pageIndex, out int count, DateTime date = default(DateTime))
        {
            count = 0;
            string whtml = GetWeiboHtml(keyword, pageIndex, date);
            if (whtml == "") return null;
            string html = MelonReg.GetMatchValue(CommonReg.WeiboBody, whtml);
            html = html.Replace("\\n", "");
            html = html.Replace("\\r", "");
            html = html.Replace("\\t", "");
            html = HttpUtility.HtmlDecode(HttpUtility.UrlDecode(html));
            html = UnicodeHelper.UnicodeToString(html);
            html = html.Replace("\\", "");
            Match pageLinkMatch = MelonReg.GetMatch(CommonReg.PageCount, html);
            while (pageLinkMatch.Success) { count++; pageLinkMatch = pageLinkMatch.NextMatch(); }

            Match match = MelonReg.GetMatch(CommonReg.WeiboDetials, html);
            List<string> list = new List<string>();
            List<WeiboDetails> dlist = new List<WeiboDetails>();
            while (match.Success)
            {
                list.Add(match.Value);
                match = match.NextMatch();
            }
            foreach (var l in list)
            {
                string headimgstr = MelonReg.GetMatchValue(CommonReg.WeiboFace, l);
                string img = MelonReg.GetMatchValue(CommonReg.Img, headimgstr);
                string content = MelonReg.GetMatchValue(CommonReg.WeiboContentHtml, l);
                string nick = MelonReg.GetMatchValue(CommonReg.WeiboNickName, content);
                string url = MelonReg.GetMatchValue(CommonReg.WeiboAuthorUrl, content);
                content = MelonReg.Replace(CommonReg.RemoveLink, content);
                content = MelonReg.Replace(CommonReg.RemoveTag, content);
                string footer = MelonReg.GetMatchValue(CommonReg.WeiboFooterHtml, l);
                string pubdate = MelonReg.GetMatchValue(CommonReg.WeiboPubData, footer);
                string devicetype = MelonReg.GetMatchValue(CommonReg.DeviceType, footer);
                dlist.Add(new WeiboDetails { FaceImg = img, Content = content, AuthorNickName = nick, Pubdate = pubdate, DeviceType = devicetype, AuthorUrl = url });
            }
            return dlist;
        }

        public static string GetWeiboHtml(string keyword, int pageIndex, DateTime date = default(DateTime))
        {
            string cookieFile = ConstStr.WeiboCookiePath;
            string html = "";
            string cookieStr = FileOperate.ReadFile(cookieFile);
            if (cookieStr != "不存在相应的目录" && cookieStr != "")
            {
                string dt = date == default(DateTime) ? DateTime.Now.ToString("yyyy-MM-dd") : date.ToString("yyyy-MM-dd");
                string target = "http://s.weibo.com/weibo/" + keyword + "&scope=ori&timescope=custom:" + dt + ":" + dt + ":&page=" + pageIndex;
                HttpItem item = new HttpItem
                {
                    URL = target,
                    Cookie = cookieStr,
                    UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:46.0) Gecko/20100101 Firefox/46.0",
                    Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
                };
                HttpResult res = new HttpHelper().GetHtml(item);
                html = res.Html;
            }
            return html;
        }
    }
}
