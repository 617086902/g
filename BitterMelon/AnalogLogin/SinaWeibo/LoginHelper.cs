using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TF.BitterMelon.AnalogLogin.SinaWeibo
{
    public class LoginHelper
    {
        /// <summary>
        /// 获取生成密码需要的参数
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetParaFromResult(string result, string regStr = "")
        {
            if (regStr == "") regStr = CommonReg.LikeJsonParam;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Match match = MelonReg.GetMatch(regStr, result);
            while (match.Success)
            {
                if (!dic.ContainsKey(match.Groups["name"].Value))
                    dic.Add(match.Groups["name"].Value, match.Groups["value"].Value.Replace("\"", ""));
                match = match.NextMatch();
            }
            return dic;
        }

        /// <summary>
        /// 用户名编码
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static string EncodeAccount(string account)
        {
            byte[] bytes = Encoding.Default.GetBytes(System.Web.HttpUtility.UrlEncode(account));
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// 生产nonce随机字符串
        /// </summary>
        /// <returns></returns>
        public static string MakeNonce(int length)
        {
            if (length <= 0 || length > 20) return "";
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, length).ToString().ToUpper();
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetServerTime()
        {
            DateTime oldTime = new DateTime(1970);
            TimeSpan span = DateTime.UtcNow.Subtract(oldTime);
            long milliSecondsTime = ((long)span.TotalMilliseconds) / 1000;
            return milliSecondsTime.ToString();
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetFullServerTime()
        {
            return ((long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
        }

    }
}
