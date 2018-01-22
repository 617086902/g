using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.QQ
{
    public class CommonApi
    {
        public static QZoneUser GetUserInfo(string token, string appid, string openid)
        {
            try
            {
                string url = "https://graph.qq.com/user/get_user_info";
                RequestParam param = new RequestParam
                {
                    access_token = token,
                    oauth_consumer_key = appid,
                    openid = openid
                };
                HttpHelper hh = new HttpHelper();
                HttpItem item = new HttpItem
                {
                    URL = url + "?access_token=" + token + "&oauth_consumer_key=" + appid + "&openid=" + openid,
                    //Postdata = Newtonsoft.Json.JsonConvert.SerializeObject(param),
                    Method = "get"
                };
                var res = hh.GetHtml(item);
                QZoneUser user = Newtonsoft.Json.JsonConvert.DeserializeObject<QZoneUser>(res.Html);
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

    [Serializable]
    class RequestParam
    {
        public string access_token { get; set; }
        public string oauth_consumer_key { get; set; }
        public string openid { get; set; }
        public string format { get { return "json"; } }
    }

    [Serializable]
    public class QZoneUser
    {
        public string ret { get; set; }
        public string msg { get; set; }
        public string nickname { get; set; }
        public string figureurl { get; set; }
        public string figureurl_1 { get; set; }
        public string figureurl_2 { get; set; }
        public string figureurl_qq_1 { get; set; }
        public string figureurl_qq_2 { get; set; }
        public string gender { get; set; }
        public string is_yellow_vip { get; set; }
        public string vip { get; set; }
        public string yellow_vip_level { get; set; }
        public string level { get; set; }
        public string is_yellow_year_vip { get; set; }
    }
}
