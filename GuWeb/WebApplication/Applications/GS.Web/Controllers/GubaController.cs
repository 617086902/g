using BusinessService;
using CommonService.Page;
using Core.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace GS.Web.Controllers
{
    public class GubaController : Controller
    {

        private IStockService stockService;
        private IPostService postService;
        public GubaController()
        {
            stockService = new StockService();
            postService = new PostService();
        }

        [Description("股吧")]
        public ActionResult Index(string code, int pn = 1, int pageSize = 20)
        {
            Stock stock = stockService.GetStockByCode(code);
            if (stock == null) return Redirect("/Assist/Error?errType=404");
            ViewBag.StockData = CommonService.Stocks.StockHelper.GetCurStockData(code);
            ViewBag.Stock = stock;
            //帖子数据列表
            var postList = postService.GetPostByStockCode(code, pn, pageSize);
            //分页，后台生成是为了让搜索引擎抓取
            bool ismobile = Core.Utilities.MobileHelper.IsMoblie(Request);
            string host = "/guba/" + code;
            ViewBag.Pager = PageHelper.GetPageHtml(postList.PageIndex, postList.PageCount, host, ismobile);
            return View(postList);
        }

        [HttpPost]
        [Description("发帖")]
        public JsonResult Add(string kw, string title, string content)
        {
            if (string.IsNullOrWhiteSpace(kw) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
                return Json(new ResultData { code = ResultCode.error, msg = "不允许为空" }, JsonRequestBehavior.AllowGet);
            if (title.Length > 35)
                return Json(new ResultData { code = ResultCode.error, msg = "标题过长" }, JsonRequestBehavior.AllowGet);
            if (Core.AppContext.Current.CurrentUser == null)
                return Json(new ResultData { code = ResultCode.fail, msg = "请登录" }, JsonRequestBehavior.AllowGet);
            Post post = new Post
            {
                StockCode = kw,
                Title = title,
                Content = Server.UrlDecode(content),
                CreatedOn = DateTime.Now,
                CreatedBy = Core.AppContext.Current.CurrentUser.User.Id,
                ModifyOn = DateTime.Now,
                ModifyBy = Core.AppContext.Current.CurrentUser.User.Id,
                HotValue = 0,
                IsBoutique = false,
                IsTop = false,
                Deleted = false
            };
            bool isSuccess = postService.Add(post);
            return Json(new ResultData { code = isSuccess ? ResultCode.ok : ResultCode.error }, JsonRequestBehavior.AllowGet);
        }

        [Description("查询帖子")]
        public JsonResult Get(string kw, int pageIndex = 1, int pageSize = 20)
        {
            var postList = postService.GetPostData(kw, pageIndex, pageSize);
            return Json(new ResultData { code = ResultCode.ok, data = postList }, JsonRequestBehavior.AllowGet);
        }

        [Description("帖子详情")]
        public ActionResult PostDetials(int postId)
        {
            int pageindex = Request.QueryString["pn"] == null ? 1 : Convert.ToInt32(Request.QueryString["pn"]);
            var post = postService.GetPostDetialsById(postId);
            if (post == null)
                return Redirect("/Assist/Error?errType=404");
            ViewBag.IsFirst = pageindex == 1;
            ViewBag.StockData = CommonService.Stocks.StockHelper.GetCurStockData(post.Post.StockCode);
            return View(post);
        }

        [Description("发表评论")]
        public JsonResult AddComment(int postId, string content, int parentCommentId = 0, string toUserName = "")
        {
            if (postId == default(int))
                return Json(new ResultData { code = ResultCode.fail, msg = "发帖失败" }, JsonRequestBehavior.AllowGet);
            if (string.IsNullOrWhiteSpace(content))
                return Json(new ResultData { code = ResultCode.fail, msg = "请输入评论内容" }, JsonRequestBehavior.AllowGet);
            content = Server.UrlDecode(content);
            if (parentCommentId != 0)
            {
                Regex reg = new Regex(@"<([^>]*)>");
                content = reg.Replace(content, "");
            }
            var comment = new Comment
            {
                PostId = postId,
                Content = content,
                ParentCommentId = parentCommentId,
                ToUserName = toUserName,
                CreatedOn = DateTime.Now,
                CreatedBy = Core.AppContext.Current.CurrentUser.User.Id,
                Deleted = false
            };
            bool isSuccess = postService.AddComment(comment);
            return Json(new ResultData { code = isSuccess ? ResultCode.ok : ResultCode.fail }, JsonRequestBehavior.AllowGet);
        }

        [Description("获取评论")]
        public JsonResult GetComment(int pid, int pageIndex = 1, int pageSize = 20)
        {
            var res = postService.GetCommentByPostId(pid, pageIndex, pageSize);
            return Json(new ResultData { code = ResultCode.ok, data = res }, JsonRequestBehavior.AllowGet);
        }

        [Description("获取热门帖子")]
        public JsonResult GetHotPost(int topN, string stockCode = "")
        {
            var res = postService.GetHotPost(topN, stockCode);
            return Json(new ResultData { code = ResultCode.ok, data = res }, JsonRequestBehavior.AllowGet);
        }

    }
}