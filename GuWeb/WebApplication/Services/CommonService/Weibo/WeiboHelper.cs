using CommonService.Sms;
using CommonService.Stocks;
using Core;
using Core.Entities;
using Core.Utilities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.BitterMelon.AnalogLogin.SinaWeibo;
using TF.BitterMelon.Entities;
using TF.BitterMelon.Tool;

namespace CommonService.Weibo
{
    public class WeiboHelper
    {
        public static void Get(DateTime date = default(DateTime))
        {
            try
            {
                SaveWeiboStockData();
                //当前时间小时
                var hour = DateTime.Now.Hour;
                if (hour < 6) return;
                string[] kws = new[] { "大盘", "股票", "a股" };
                string pathDate = date == default(DateTime) ? DateTime.Now.ToString("yyyy-MM-dd") : date.ToString("yyyy-MM-dd");
                List<WeiboDetails> autoWeiboList = new List<WeiboDetails>();
                //总成功条数
                int totalCount = 0;
                foreach (var k in kws)
                {
                    int pn = 1;
                    int pageCount = 1;
                    string filePath = ConstStr.WeiboContentPath(k, pathDate);
                    bool isGrabed = false;
                    StringBuilder weiboBuilder = new StringBuilder();
                    //当前关键词下成功条数
                    int pcount = 0;
                    for (; pn <= pageCount; pn++)
                    {
                        List<WeiboDetails> dlist = WeiboSearch.GetWeiboContent(k, pn, out pageCount, date);
                        //没有数据时
                        if (dlist == null || !dlist.Any()) { isGrabed = true; break; }
                        //
                        pcount += dlist.Count();
                        totalCount += dlist.Count();
                        List<string> gdlist = FileOperate.Read(filePath);
                        foreach (var weibo in dlist)
                        {
                            isGrabed = gdlist != null && gdlist.Any(w => w.Contains(weibo.AuthorNickName) && w.Contains(weibo.Pubdate));
                            if (isGrabed) break;
                            if (!weiboBuilder.ToString().Contains(weibo.Content))
                            {
                                weiboBuilder.AppendLine(Newtonsoft.Json.JsonConvert.SerializeObject(weibo));
                                autoWeiboList.Add(weibo);
                            }
                        }
                        if (isGrabed) break;
                    }
                    if (pcount > 0)
                        FileOperate.WriteFile(filePath, weiboBuilder.ToString());
                }
                if (totalCount <= 0)
                {
                    Alarm.SendAlarmMsg("13269276932", 1);
                }
                //自动发帖
                //AutoAddPost(autoWeiboList);
            }
            catch (Exception ex)
            {
                var errpath = ConstStr.WeiboExceptionLog;
                FileOperate.WriteFile(errpath, ex.StackTrace);
            }
            Core.Utilities.HttpHelper hh = new Core.Utilities.HttpHelper();
            Core.Utilities.HttpItem item = new Core.Utilities.HttpItem { URL = "http://www.nichaogu.com" };
            hh.GetHtml(item);
        }


        public static void AutoAddPost(List<WeiboDetails> wbList)
        {
            int[] useridList = new[] { 7, 8, 9 };
            Random random = new Random();
            int count = 3;
            List<Post> postList = new List<Post>();
            foreach (var wb in wbList)
            {
                if (count <= 0) break;
                if (wb.Content.Contains("【") || wb.Content.Contains("博文") || wb.Content.Contains("大盘鸡") || wb.Content.Length < 50) continue;
                int by = useridList[random.Next(0, 3)];
                postList.Add(new Post
                {
                    Content = wb.Content,
                    CreatedBy = by,
                    CreatedOn = DateTime.Now,
                    Deleted = false,
                    HotValue = 0,
                    IsTop = false,
                    Title = wb.Content.Substring(0, 30),
                    StockCode = "000000",
                    IsBoutique = false,
                    ModifyBy = by,
                    ModifyOn = DateTime.Now,
                });
                count--;
            }
            var db = AppContext.Current.DbContext;
            db.Post.AddRange(postList);
            db.SaveChanges();
        }

        public static void SaveWeiboStockData()
        {
            var date = DateTime.Now;
            if (date.DayOfWeek == 0 || (int)date.DayOfWeek == 6 || date.Hour != 0 || date.Minute > 5) return;
            string path = ConstStr.WeiboContentPath("Weibo", "Stock");
            var stockDetials = StockHelper.GetCurStockData("000000");
            string[] kws = new[] { "大盘", "股票", "a股" };
            List<string> clist = new List<string>();
            foreach (var k in kws)
            {
                var l = FileOperate.Read(ConstStr.WeiboContentPath(k, date.AddDays(-1).ToString("yyyy-MM-dd")));
                if (l == null || !l.Any()) continue;
                clist.AddRange(l);
            }
            int count = clist.Count();
            string price = stockDetials.currentPrice;
            string str = string.Format("{0}|{1}|{2}", date.AddDays(-1).ToString("yyyy-MM-dd"), count, price.Replace("元", ""));
            FileOperate.WriteFile(path, str);
        }

        public static List<StockWeiboModel> GetWeiboStockData()
        {
            string path = ConstStr.WeiboContentPath("Weibo", "Stock");
            List<string> dataList = FileOperate.Read(path);
            List<StockWeiboModel> hmList = new List<StockWeiboModel>();
            for (int i = 0; i < dataList.Count; i++)
            {
                StockWeiboModel sw = new StockWeiboModel();
                var data = dataList[i];
                if (string.IsNullOrEmpty(data)) break;
                string[] arr = data.Split('|');
                sw.DateStr = arr[0].Substring(arr[0].IndexOf('-') + 1);
                sw.Data = arr[1] + "," + arr[2] + "," + (Convert.ToDecimal(arr[1]) / Convert.ToDecimal(arr[2])).ToString("f2");
                hmList.Add(sw);
            }
            return hmList;
        }
    }
}
