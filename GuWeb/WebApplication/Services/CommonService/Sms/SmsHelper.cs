using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonService.Sms {
    public class SmsHelper {

        //登陆网址：http://www.smschinese.cn/
        //用户名：“携行天下”
        //密码：“2131...”
        public static bool Send(string mobile, string content) {
            HttpHelper hh = new HttpHelper();
            string smsServerUrl = string.Format("{0}/?Uid={1}&Key={2}&smsMob={3}&smsText={4}",
                "http://utf8.sms.webchinese.cn", "携行天下", "5a96c7b9e48c925ec354", mobile, content);
            HttpItem item = new HttpItem {
                URL = smsServerUrl,
                Method = "get",
            };
            HttpResult result = hh.GetHtml(item);
            return result.Html == "1";
        }
    }
}
