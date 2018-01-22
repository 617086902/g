using BusinessService;
using CommonService.Stocks;
using CommonService.Weibo;
using Core.Entities;
using Core.Utilities;
using GS.Web.Attribute;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Web.Controllers
{
    public class StockController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AdminFilter]
        public ActionResult AddStocks()
        {
            var stocks = StockHelper.Get();
            IStockService stockService = new StockService();
            int successCount = stockService.AddStock(stocks);
            ViewBag.tip = "成功添加" + successCount + "条记录";
            return View();
        }

        [AdminFilter]
        public ActionResult AddCompanyProfile()
        {
            var list = StockHelper.SaveCompanyProfile();
            ViewBag.tip = "成功添加" + list.Count() + "条记录";
            return View();
        }

        public JsonResult Search(string kw)
        {
            IStockService stockService = new StockService();
            var res = stockService.SearchStock(kw);
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Forecast(string stockCode)
        {
            return null;
        }


        public ActionResult StockList()
        {
            IStockService stockService = new StockService();
            IList<Stock> slist = stockService.GetStockList().ToList();
            ViewBag.StockList = slist;
            return View();
        }


        public ActionResult StockSpline()
        {
            return View();
        }


        public JsonResult GetStockSpLineData()
        {
            return Json(new ResultData { code = ResultCode.ok, data = WeiboHelper.GetWeiboStockData() }, JsonRequestBehavior.AllowGet);
        }
    }
}