using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.Page
{
    public class PageHelper
    {
        public static string GetPageHtml(int pageIndex, int pageCount, string host, bool isMobile)
        {
            if (pageCount <= 1) return null;
            var isfirst = pageIndex == 1;
            var islast = pageIndex == pageCount;
            var previousurl = isfirst ? "javascript:;" : host + "?pn=" + (pageIndex - 1);
            var nexturl = islast ? "javascript:;" : host + "?pn=" + (pageIndex + 1);
            var firsturl = host + "?pn=1";
            var lasturl = host + "?pn=" + pageCount;
            StringBuilder pageCode = new StringBuilder();
            pageCode.Append("<nav>");
            if (!isMobile)
            {//大屏/桌面分页
                pageCode.Append("<ul class=\"pagination\">");
                //首页/上一页
                if (pageIndex != 1)
                {
                    pageCode.Append("<li><a href=\"" + firsturl + "\" aria-label=\"Previous\"><span aria-hidden=\"true\">首页</span></a></li>");
                    pageCode.Append("<li><a href=\"" + previousurl + "\" aria-label=\"Previous\"><span aria-hidden=\"true\">上一页</span></a></li>");
                }
                var beginnum = pageIndex <= 5 ? 1 : pageIndex + 5 > pageCount ? pageCount - 9 : pageIndex - 4;
                var endnum = pageIndex <= 5 ? 10 : pageIndex + 5 > pageCount ? pageCount : pageIndex + 5;
                for (var i = beginnum; i <= endnum; i++)
                {
                    if (i <= 0 || i > pageCount) continue;
                    if (i == pageIndex)
                    {
                        pageCode.Append("<li class=\"active\"><a href=\"javascript:;\">" + i + " <span class=\"sr-only\">(current)</span></a></li>");
                        continue;
                    }
                    var url = host + "?pn=" + i;
                    pageCode.Append("<li><a href=\"" + url + "\">" + i + "</a></li>");
                }
                //下一页/尾页
                if (pageIndex != pageCount)
                {
                    pageCode.Append("<li><a href=\"" + nexturl + "\" aria-label=\"Next\"><span aria-hidden=\"true\">下一页</span></a></li>");
                    pageCode.Append("<li><a href=\"" + lasturl + "\" aria-label=\"Next\"><span aria-hidden=\"true\">尾页</span></a></li>");
                }
            }
            else
            {//手机分页
                pageCode.Append("<ul class=\"pager\">");
                pageCode.Append("<li class=\"previous" + (isfirst ? " disabled" : "") + "\"><a href=\"" + previousurl + "\"><span aria-hidden=\"true\">&larr;</span> 上一页</a></li>");
                pageCode.Append("<li class=\"next" + (islast ? " disabled" : "") + "\"><a href=\"" + nexturl + "\">下一页 <span aria-hidden=\"true\">&rarr;</span></a></li>");
            }
            pageCode.Append("</ul></nav>");
            return pageCode.ToString();
        }
    }
}
