using Core;
using Core.Utilities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonService.Stocks
{
    public class StockHelper
    {
        public static List<Stock> Get()
        {
            List<Stock> stocks = new List<Stock>();
            HttpHelper httphelper = new HttpHelper();
            HttpItem item = new HttpItem
            {
                URL = "http://quote.eastmoney.com/stocklist.html",
            };
            HttpResult result = httphelper.GetHtml(item);
            Regex reg = new Regex(@".html"">([^<]*)");
            var mr = reg.Match(result.Html);
            while (mr.Success)
            {
                string stock = mr.Value.Replace(@".html"">", "");
                mr = mr.NextMatch();
                string[] ss = stock.Split('(');
                if (ss.Count() < 2) continue;
                ss[1] = ss[1].Replace(")", "");
                if (!stocks.Exists(e => e.StockCode.Equals(ss[1])))
                {
                    stocks.Add(new Stock
                    {
                        StockCode = ss[1],
                        StockName = ss[0],
                        PyFullName = PyHelper.Get(ss[0]),
                        PyAbbre = PyHelper.GetFirst(ss[0]),
                    });
                }
            }
            return stocks;
        }


        public static List<CompanyProfile> SaveCompanyProfile()
        {
            GSEntities dbcontext = AppContext.Current.DbContext;
            var stocks = dbcontext.Stock.Where(t => t.Id > 3838).Select(s => s.StockCode).ToList();
            var cf = dbcontext.CompanyProfile.ToList();
            var list = new List<CompanyProfile>();
            foreach (var s in stocks)
            {
                if (!cf.Exists(c => c.StockCode.Equals(s)))
                {
                    var res = GetDetials(s);
                    if (res != null)
                    {
                        dbcontext.CompanyProfile.Add(res);
                        dbcontext.SaveChanges();
                    };
                }
            }
            return list;
        }

        public static CompanyProfile GetDetials(string stockCode)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(stockCode)) return null;
                HttpHelper httphelper = new HttpHelper();
                HttpItem item = new HttpItem
                {
                    URL = "http://stock.finance.qq.com/corp1/profile.php?zqdm=" + stockCode,
                };
                HttpResult result = httphelper.GetHtml(item);
                Regex tdReg = new Regex(@"<td.*?>(.*?)</td>");
                var mr = tdReg.Match(result.Html);
                CompanyProfile cp = new CompanyProfile();
                cp.StockCode = stockCode;
                Regex valreg = new Regex(@"(?<=<a.*?>)([^<]*)");
                Regex valreg2 = new Regex(@"(?<=<td.*?>)(.*)(?=</td>)");
                string[] vals = new[] { "法定名称", "英文名称", "成立日期", "上市市场", "所属行业",
                "注册资本", "职工总数", "法人代表", "公司电话", "公司电子邮箱", "公司网址",
                "办公地址", "上市日期", "经营范围", "公司简介", "发行价格", };
                while (mr.Success)
                {
                    if (mr.Value.Contains("公司简介变动")) return cp;
                    if (mr.Value.Contains("收入构成"))
                    {
                        mr = mr.NextMatch();
                        continue;
                    }
                    foreach (var v in vals)
                    {
                        if (!mr.Value.Contains(v)) continue;
                        mr = mr.NextMatch();//获取值
                        if (!mr.Success) continue;
                        var valmat = valreg.Match(mr.Value);
                        var valmat2 = valreg2.Match(mr.Value);
                        if (valmat.Value.Contains("公司简介变动")) return cp;
                        if (!valmat.Success && !valmat2.Success) continue;
                        string val = valmat.Success ? valmat.Value : valmat2.Value;
                        switch (v)
                        {
                            case "法定名称": if (string.IsNullOrWhiteSpace(val)) return null; cp.LegalName = val; break;
                            case "英文名称": cp.EnglishName = string.IsNullOrWhiteSpace(cp.EnglishName) ? val : cp.EnglishName; break;
                            case "成立日期": cp.EstablishDate = Convert.ToDateTime(val == "" ? "1900-01-01" : val); break;
                            case "上市市场": cp.ListedMarket = val; break;
                            case "所属行业": cp.OwnedIndustry = val; break;
                            case "注册资本": cp.RegisteredCapital = Convert.ToDecimal(val.Replace(",", "")); break;
                            case "职工总数": cp.EmployeesCount = Convert.ToInt32(val); break;
                            case "法人代表": cp.LegalPerson = val; break;
                            case "公司电话": cp.Telephone = val; break;
                            case "公司电子邮箱": cp.Email = val; break;
                            case "公司网址": cp.Website = val; break;
                            case "办公地址": cp.OfficeAddress = val; break;
                            case "上市日期": cp.ListingDate = Convert.ToDateTime(val == "" ? "1900-01-01" : val); break;
                            case "经营范围": cp.BusinessScope = val; break;
                            case "公司简介": cp.Profile = val; break;
                            case "发行价格": cp.IssuePrice = val.Contains("-") ? 0 : Convert.ToDecimal(val); break;
                            default: break;
                        }
                    }
                    mr = mr.NextMatch();
                }
                return cp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取股票实时数据
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static StockData GetCurrentStockData(string stockId)
        {
            HttpHelper hh = new HttpHelper();
            string url = "http://apis.baidu.com/apistore/stockservice/stock";
            System.Net.WebHeaderCollection header = new System.Net.WebHeaderCollection();
            header.Add("apikey", "69ba7303c5e959acc8f407a247030e42");
            HttpItem item = new HttpItem
            {
                URL = url + "?stockid=sz" + stockId + "&list=" + stockId.Split(',').Length,
                Method = "get",
                Header = header,
            };
            HttpResult result = hh.GetHtml(item);
            var resData = Newtonsoft.Json.JsonConvert.DeserializeObject<StockData>(result.Html);
            return resData;
        }

        /// <summary>
        /// 获取股票实时数据
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static SinaStockData GetCurStockData(string stockCode)
        {
            HttpHelper hh = new HttpHelper();
            string url = "http://hq.sinajs.cn";
            string curCode = stockCode == "000000" ? "sh000001" : stockCode == "000001" ? "sz000001" : "sh" + stockCode;
            HttpItem item = new HttpItem
            {
                URL = url + "?list=" + curCode,
                Method = "get",
            };
            HttpResult result = hh.GetHtml(item);
            if (result.Html.Contains("FAILED") || result.Html.Contains("\"\""))
            {
                curCode = "sz" + stockCode;
                item.URL = url + "?list=" + curCode;
                result = hh.GetHtml(item);
                if (result.Html.Contains("FAILED") || result.Html.Contains("\"\"")) return null;
            }
            Regex conreg = new Regex(@"(?<="")([^""]*)");
            string curStr = conreg.Match(result.Html).Value;
            if (curStr == "") return null;
            string[] arr = curStr.Split(',');
            if (!arr.Any()) return null;
            SinaStockData ssd = new SinaStockData();
            ssd.name = arr[0];
            ssd.openningPrice = Convert.ToDecimal(arr[1]).ToString("f2") + "元";
            ssd.closingPrice = Convert.ToDecimal(arr[2]).ToString("f2") + "元";
            ssd.currentPrice = Convert.ToDecimal(arr[3]).ToString("f2") + "元";
            ssd.hPrice = Convert.ToDecimal(arr[4]).ToString("f2") + "元";
            ssd.lPrice = Convert.ToDecimal(arr[5]).ToString("f2") + "元";
            int tnum = Convert.ToInt32(arr[8]) / 100;
            ssd.increase = ((Convert.ToDecimal(arr[3]) - Convert.ToDecimal(arr[2])) * 100 / Convert.ToDecimal(arr[2])).ToString("f2") + "%";
            ssd.totalNumber = tnum > 10000 ? tnum / 10000 + "万手" : tnum + "手";
            ssd.turnover = (Convert.ToDecimal(arr[9]) / 10000).ToString("f2") + "万元";
            ssd.date = arr[30] + " " + arr[31];
            ssd.chatMin = "http://image.sinajs.cn/newchart/min/n/" + curCode + ".gif";
            return ssd;
        }
    }
}
