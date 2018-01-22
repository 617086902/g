using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuModel;
using Core.Utilities;
using System.Text.RegularExpressions;
using Core;
using BusinessService.Entities;

namespace BusinessService
{
    public class StockService : IStockService
    {
        private GSEntities dbcontext;
        public StockService()
        {
            dbcontext = AppContext.Current.DbContext;
        }

        public int AddCompanyProfile(List<CompanyProfile> profiles)
        {
            dbcontext.CompanyProfile.AddRange(profiles);
            return dbcontext.SaveChanges();
        }

        public int AddStock(List<Stock> stocks)
        {
            var astocks = dbcontext.Stock.ToList();
            foreach (var stock in stocks)
            {
                if (!astocks.Exists(s => s.StockCode.Equals(stock.StockCode)))
                    dbcontext.Stock.Add(stock);
            }
            return dbcontext.SaveChanges();
        }

        public Stock GetStockByCode(string code)
        {
            var stock = dbcontext.Stock.FirstOrDefault(s => s.StockCode == code);
            return stock;
        }

        public IEnumerable<AutoCompleteModel> SearchStock(string kw)
        {
            Regex numreg = new Regex(@"[0-9]");
            Regex pyreg = new Regex(@"[a-zA-Z]");
            Regex hzreg = new Regex(@"[\u4e00-\u9fa5]");
            IQueryable<Stock> list = null;
            if (numreg.Match(kw.Substring(0, 1)).Success)
                list = dbcontext.Stock.Where(s => s.StockCode.StartsWith(kw)).Take(5);
            else if (pyreg.Match(kw.Substring(0, 1)).Success)
                list = dbcontext.Stock.Where(s => s.PyAbbre.StartsWith(kw) || s.PyFullName.StartsWith(kw)).Take(5);
            else if (hzreg.Match(kw.Substring(0, 1)).Success)
                list = dbcontext.Stock.Where(s => s.StockName.StartsWith(kw)).Take(5);
            return list.Select(s => new AutoCompleteModel
            {
                label = s.StockCode + "  " + s.StockName,
                value = s.StockCode
            });
        }

        public IEnumerable<Stock> GetStockList()
        {
            IEnumerable<Stock> slist = dbcontext.Stock.Where(s => s.StockCode.StartsWith("6") || s.StockCode.StartsWith("0") || s.StockCode.StartsWith("3"))
                .OrderBy(o => o.PyAbbre);
            return slist;
        }
    }
}
