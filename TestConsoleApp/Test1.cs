using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using TF.BitterMelon.Tool;
using HtmlAgilityPack;

namespace ConsoleApp
{
    public class Test1
    {
        public static void Gooooooo()
        {
            HttpHelper httpHelper = new HttpHelper();
            HttpResult reslut = httpHelper.GetHtml(new HttpItem
            {
                URL = "http://m.tn.ccoo.cn/BBS/GetBBSReplyList",
                Method = "POST",
                Postdata = "curPage=1&pageSize=10&tID=10250819&rusename=&order=0&isDaka=0"
            });
            HtmlDocument document = new HtmlDocument();
            string html = UnicodeToGB(reslut.Html);
            html = html.Replace("\\\"", "\"");
            html = html.Substring(9, html.Length - 11);
            document.LoadHtml(html);
            HtmlNode rotenode = document.DocumentNode;
            string xpathstring = "//div[@class='comment_item']/p";
            HtmlNodeCollection collection = rotenode.SelectNodes(xpathstring);
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    string text = item.InnerText;
                }
            }
        }

        public static string UnicodeToGB(string text)
        {
            MatchCollection mc = Regex.Matches(text, "\\\\u([\\w]{4})");
            if (mc != null && mc.Count > 0)
            {
                foreach (Match m2 in mc)
                {
                    string v = m2.Value;
                    string word = v.Substring(2);
                    byte[] codes = new byte[2];
                    int code = Convert.ToInt32(word.Substring(0, 2), 16);
                    int code2 = Convert.ToInt32(word.Substring(2), 16);
                    codes[0] = (byte)code2;
                    codes[1] = (byte)code;
                    text = text.Replace(v, Encoding.Unicode.GetString(codes));
                }
            }
            else
            {

            }
            return text;
        }
    }
}
