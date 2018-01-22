using System.Text.RegularExpressions;

namespace TF.BitterMelon
{
    public class MelonReg
    {
        /// <summary>
        /// 根据正则表达式匹配字符串并返回匹配到的第一项的值
        /// </summary>
        /// <param name="regStr"></param>
        /// <param name="str"></param>
        /// <param name="options">用于设置正则表达式的枚举值</param>
        /// <returns></returns>
        public static string GetMatchValue(string regStr, string str, RegexOptions options = RegexOptions.IgnoreCase)
        {
            Regex reg = new Regex(regStr, options);
            var mat = GetMatch(reg, str);
            return mat.Success ? mat.Value : "";
        }
        /// <summary>
        /// 根据正则表达式匹配字符串
        /// </summary>
        /// <param name="regStr"></param>
        /// <param name="str"></param>
        /// <param name="options">用于设置正则表达式的枚举值</param>
        /// <returns></returns>
        public static Match GetMatch(string regStr, string str, RegexOptions options = RegexOptions.IgnoreCase)
        {
            Regex reg = new Regex(regStr, options);
            return GetMatch(reg, str);
        }
        /// <summary>
        /// 匹配字符串
        /// </summary>
        /// <param name="reg">正则</param>
        /// <param name="str">要匹配的字符串</param>
        /// <returns></returns>
        public static Match GetMatch(Regex reg, string str)
        {
            return reg.Match(str);
        }
        /// <summary>
        /// 替换正则字符串
        /// </summary>
        /// <param name="regStr"></param>
        /// <param name="str"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string Replace(string regStr,string str, RegexOptions options = RegexOptions.IgnoreCase)
        {
            Regex reg = new Regex(regStr, options);
            str = reg.Replace(str, "");
            return str;
        }
    }

}
