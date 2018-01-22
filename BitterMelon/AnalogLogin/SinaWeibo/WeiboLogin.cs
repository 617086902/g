using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using TF.BitterMelon.Entities;
using TF.BitterMelon.Tool;

namespace TF.BitterMelon.AnalogLogin.SinaWeibo
{
    public class WeiboLogin
    {
        private string userCode;
        private string passCode;
        private HttpHelper httpHelper;
        private string userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:46.0) Gecko/20100101 Firefox/46.0";
        private string accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        private string contentType = "application/x-www-form-urlencoded";
        public string cookieFile { get; set; }

        public string LoginCookie
        {
            get
            {
                string jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(cookieDic);
                jsonStr = jsonStr.Substring(1, jsonStr.Length - 2);
                jsonStr = jsonStr.Replace(":", "=");
                jsonStr = jsonStr.Replace("\"", "");
                jsonStr = jsonStr.Replace(",", ";");
                return jsonStr;
            }
        }
        public bool IsLogin
        {
            get
            {
                return cookieDic.Count > 0;
            }
        }
        public string LoginResult { get; set; }
        public WeiboEntities WeiboEntities { get; set; }
        public WeiboUserEntities WeiboUserEntities { get; set; }
        public Dictionary<string, string> cookieDic;
        public WeiboLogin(string u, string p, string _cookieFile = "")
        {
            httpHelper = new HttpHelper();
            userCode = u;
            passCode = p;
            cookieDic = new Dictionary<string, string>();
            WeiboEntities = new WeiboEntities();
            WeiboUserEntities = new WeiboUserEntities();
            cookieFile = string.IsNullOrEmpty(_cookieFile) ? ConstStr.WeiboCookiePath : _cookieFile;
            L(false);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="refresh">是否强制刷新</param>
        public bool L(bool refresh)
        {
            string cookieStr = FileOperate.ReadFile(cookieFile);
            bool loginSucc = false;
            if (refresh || cookieStr == "不存在相应的目录" || cookieStr == "")
            {
                loginSucc = LoginIn();
                if (loginSucc)
                {
                    FileOperate.FileDel(cookieFile);
                    FileOperate.WriteFile(cookieFile, LoginCookie);
                }
            }
            else
            {
                GetCurrentCookie(cookieStr);
            }
            return loginSucc;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public bool LoginIn()
        {
            try
            {
                string su = HttpUtility.UrlEncode(LoginHelper.EncodeAccount(userCode));
                string url = "http://login.sina.com.cn/sso/prelogin.php?entry=account&callback=sinaSSOController.preloginCallBack"
                    + "&su=" + su + "&rsakt=mod&checkpin=1&client=ssologin.js(v1.4.15)&_=" + LoginHelper.GetFullServerTime();

                HttpResult prelogin = httpHelper.GetHtml(new HttpItem
                {
                    URL = url,
                    UserAgent = userAgent,
                    Accept = accept,
                    Referer = "http://login.sina.com.cn/",
                    ContentType = contentType
                });
                Dictionary<string, string> preloginParam = LoginHelper.GetParaFromResult(prelogin.Html);


                string servertime = LoginHelper.GetFullServerTime();//preloginParam["servertime"];
                string pubKey = preloginParam["pubkey"];
                string nonce = LoginHelper.MakeNonce(6);//preloginParam["nonce"];
                string rsakv = preloginParam["rsakv"];

                string password = ScriptHelper.RunJs(Rsa2.getJs(), string.Format("getpass(\"{0}\",\"{1}\",\"{2}\",\"{3}\")",
                    passCode, servertime, nonce, pubKey));

                string postdata = string.Format("entry={0}&gateway={1}&from={2}&savestate={3}&useticket={4}&pagerefer={5}&vsnf={6}&su={7}&service={8}&servertime={9}" +
                    "&nonce={10}&pwencode={11}&rsakv={12}&sp={13}&sr={14}&encoding={15}&prelt={16}&url={17}&returntype={18}",
                    "weibo", 1, "", 0, 1, "http%3A%2F%2Flogin.sina.com.cn%2Fsso%2Flogout.php%3Fentry%3Dminiblog%26r%3Dhttp%253A%252F%252Fweibo.com%252Flogout.php%253Fbackurl%253D%25252F", 1, su, "miniblog", servertime,
                    nonce, "rsa2", rsakv, password, "1366*768", "UTF-8", 100, "http%3A%2F%2Fweibo.com%2Fajaxlogin.php%3Fframelogin%3D1%26callback%3Dparent.sinaSSOController.feedBackUrlCallBack", "META");
                //另一种登录方式的请求参数
                //string postdata = string.Format("entry={0}&gateway={1}&from={2}&savestate={3}&useticket={4}&pagerefer={5}&vsnf={6}&su={7}&service={8}&servertime={9}" +
                //    "&nonce={10}&pwencode={11}&rsakv={12}&sp={13}&sr={14}&encoding={15}&cdult={16}&domain={17}&prelt={18}&returntype={19}",
                //    "account", 1, "", 0, 0, "", 1, su, "sso", servertime,
                //    nonce, "rsa2", rsakv, password, "1366*768", "UTF-8", 3, "sina.com.cn", 20, "TEXT");
                HttpItem loginItem = new HttpItem
                {
                    URL = "http://login.sina.com.cn/sso/login.php?client=ssologin.js(v1.4.18)",
                    Method = "POST",
                    Postdata = postdata,
                    UserAgent = userAgent,
                    Accept = accept,
                    Referer = "http://login.sina.com.cn/",
                    ContentType = contentType,
                };
                HttpResult loginresult = httpHelper.GetHtml(loginItem);
                if (loginresult == null) return false;
                string resStr = loginresult.Html;
                bool isLoginSucess = resStr.Contains("\"retcode\":0");
                LoginResult = resStr;
                //LoginResult = UnicodeHelper.UnicodeToString(resStr);
                //登录成功，确认登录，保存cookie
                if (isLoginSucess)
                {
                    //取得cookie
                    GetCurrentCookie(loginresult.Cookie);
                    //获取微博登录成功属性
                    TakeWeiboEntities();
                    //再次确认登陆
                    EnsureLogin();
                    //获取用户属性
                    GetUserEntities(cookieDic["SUP"]);
                }
                return isLoginSucess;
            }
            catch (Exception ex)
            {
                FileOperate.WriteFile(ConstStr.WeiboContentPath("Err"), ex.StackTrace);
                return false;
            }
        }

        public void GetCurrentCookie(string cookieStr)
        {
            string[] cookieNames = { "tgc", "SUS", "SUE", "SUP", "SUB", "SUBP", "ALC", "ALF", "LT", "sso_info", "SUHB" };
            cookieStr = cookieStr.Replace(" ", "");

            foreach (var s in cookieNames)
            {
                string matchValue = MelonReg.GetMatchValue(CommonReg.CookieRegStr(s), cookieStr);
                if (!cookieDic.ContainsKey(s))
                {
                    cookieDic.Add(s, matchValue);
                }
                else
                {
                    cookieDic[s] = matchValue;
                }
            }

        }

        /// <summary>
        /// 登录成功获取参数
        /// </summary>
        public void TakeWeiboEntities()
        {
            if (LoginResult != null)
            {
                Regex reg = new Regex("(?<=setCrossDomainUrlList)(?<para>[^)]*)");
                Match match = reg.Match(LoginResult);
                if (match.Success)
                {
                    WeiboEntities = Newtonsoft.Json.JsonConvert.DeserializeObject<WeiboEntities>(match.Value.Substring(1));
                }
                Regex urlReg = new Regex(@"(?<=replace).*?'(?<abc>[^']*)");
                Match surlMatch = urlReg.Match(LoginResult);
                WeiboEntities.successURL = surlMatch.Value.Substring(2);
                Regex callbackUrlReg = new Regex(@"(?<=url=)(?<callback>[^&]*)");
                Match callbackUrlMatch = callbackUrlReg.Match(WeiboEntities.successURL);
                WeiboEntities.callbackURL = callbackUrlMatch.Value;
            }
        }
        /// <summary>
        /// 确认登录
        /// </summary>
        /// <returns></returns>
        public bool EnsureLogin()
        {
            bool ensureLogin = false;
            if (WeiboEntities == null || string.IsNullOrEmpty(WeiboEntities.successURL))
                return false;

            HttpItem cItem = new HttpItem
            {
                URL = HttpUtility.UrlDecode(WeiboEntities.successURL),
                Cookie = LoginCookie,
                UserAgent = userAgent,
                Accept = accept,
                Referer = "http://login.sina.com.cn/sso/login.php?client=ssologin.js(v1.4.18)",
            };
            HttpResult res = httpHelper.GetHtml(cItem);
            GetCurrentCookie(res.Cookie);
            ensureLogin = true;
            return ensureLogin;
        }

        public void GetUserEntities(string supStr)
        {
            supStr = HttpUtility.UrlDecode(HttpUtility.UrlDecode(supStr));
            string[] userEntityNames = { "uid", "name", "nick" };
            foreach (var s in userEntityNames)
            {
                string matchValue = MelonReg.GetMatchValue(CommonReg.WeiboUserRegStr(s), supStr);
                switch (s)
                {
                    case "uid": WeiboUserEntities.uid = matchValue; break;
                    case "name": WeiboUserEntities.name = matchValue; break;
                    case "nick": WeiboUserEntities.nick = matchValue; break;
                    default: break;
                }
            }
        }
    }
}
